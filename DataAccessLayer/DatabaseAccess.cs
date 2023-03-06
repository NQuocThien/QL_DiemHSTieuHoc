using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ValueObject;
using System.Data.Common;
using System.Reflection.Metadata.Ecma335;
using System.Linq.Expressions;

namespace DataAccessLayer
{
    public class SqlConnectionData
    {
        // Tạo chuỗi kết nối cơ sở dữ liệu
        public static SqlConnection Connect()
        {
            string strcon = @"Data Source=QTHIEN\MSSQLSERVER01;Initial Catalog=QLTieuHoc;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strcon); // khởi tạo connect
            return conn;
        }
    }
    /// <summary>
    /// modifi
    class Modify
    {
        public Modify()
        {
        }
        SqlCommand sqlCommand;
        SqlConnection connection;
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        SqlDataReader dataReader; // doc dL tron

        public DataTableReader DataTableReader { get; private set; }

        public void Command(string squery) // thêm xóa sửa
        {
            using (SqlConnection sqlConnection = SqlConnectionData.Connect())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(squery, sqlConnection);
                sqlCommand.ExecuteNonQuery(); // thực thi câu truy vấn
                sqlConnection.Close();
            }
        }
        public DataTable GetDataTable(string squery) // 
        {
            using (SqlConnection sqlConnection = SqlConnectionData.Connect())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(squery, sqlConnection);
                DataTable dt = new DataTable();
                dt.Load(sqlCommand.ExecuteReader());
                return dt;
            }
        }
        public SqlDataReader GetDataAdapter(string squery) // 
        {
            using (SqlConnection sqlConnection = SqlConnectionData.Connect())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(squery, sqlConnection);
                return sqlCommand.ExecuteReader();
            }
        }


    }
    /// </summary>
    public class DatabaseAccess
    {
        public static string CheackAccessAcountDAO(UserAccount taikhoan)
        {
            Modify modify = new Modify();
            string strSQL = "Select law_id From UserAccount Where userName = '" + taikhoan.UserName + "' and law_id in(Select law_id from law)";
            string infor = null;
            DataTableReader dr = modify.GetDataTable(strSQL).CreateDataReader();
            if (dr.HasRows)
            {
                return "susccess";
            }
            return "user_not_accepted";
        }
        public static string CheckLogicDTO(UserAccount taikhoan)
        {
            string user = null;
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            string strSQL = "Select * From UserAccount Where userName = '" + taikhoan.UserName + "' and pass = '" + taikhoan.Pass + "'";
            SqlCommand command = new SqlCommand(strSQL, conn);
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    user = reader.GetString(1);
                }
                reader.Close();
                conn.Close();
            }
            else
            {
                return "Tài khoản hoặc mật khẩu không chính xác!";
            }
            return user;
        }
        public static string CheckEmailDAO(string email)
        {
            string pass = null;
            string strSQL = "Select * From UserAccount Where email = '" + email + "'";
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand(strSQL, conn);
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    pass = reader.GetString(1);
                }
                reader.Close();
            }
            else
            {
                return null;
            }
            return pass;
        }
        public static string CreateAccoutDAO(UserAccount user)
        {
            Modify mo = new Modify();
            try
            {
                mo.Command("Insert into UserAccount values( '" + user.UserName + "' , '" + user.Pass + "', '" + user.Email + "', '0')");
            }
            catch (Exception ex)
            {
                return "exist_username_email";
            }
            return "success";
        }

        public static UserAccount GetUserDAO(string userName)
        {
            Modify mo = new Modify();
            UserAccount user = new UserAccount();
            string strSQL = "Select * from UserAccount Where userName = '" + userName + "'";
            DataTableReader reader = mo.GetDataTable(strSQL).CreateDataReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {

                    user.UserName = reader.GetString(0);
                    user.Pass = reader.GetString(1);
                    user.Email = reader.GetString(2);
                    user.law_id = reader.GetInt32(3);
                }
            }
            else
            {
                return null;
            }
            return user;
        }
        public static DataTable GetLawDataTBDAO()
        {
            return new Modify().GetDataTable("select * from law");
        }
        public static Law GetLawDAO(string userName)
        {
            Modify mo = new Modify();
            Law l = new Law();
            string strSQL = "Select l.law_id,l.law_name from UserAccount us, law l Where us.userName = '" + userName + "' and us.law_id = l.law_id";
            DataTableReader reader = mo.GetDataTable(strSQL).CreateDataReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    l.law_id = reader.GetInt32(0);
                    l.law_name = reader.GetString(1);
                }
            }
            else
            {
                return null;
            }
            return l;
        }
        public static string UpdateUserDAO(UserAccount user)
        {
            Modify mo = new Modify();
            string strSQL = "Update UserAccount set pass = '" + user.Pass + "', email = '" + user.Email + "' where userName = '" + user.UserName + "'";
            try
            {
                mo.Command(strSQL);
                return "success";
            }
            catch
            {
                return "exist_username_email";
            }
        }
        public static string ProvideLawUserDAO(UserAccount user, string law_name)
        {
            Modify mo = new Modify();
            int law_id1 = 0;
            // get id
            string strSQL = "select * from law where law_name = '" + law_name + "'";
            try
            {

                DataTableReader re = mo.GetDataTable(strSQL).CreateDataReader();
                if (re.HasRows)
                {
                    while (re.Read())
                    {
                        law_id1 = re.GetInt32(0);
                    }
                }
                else
                {
                    return "fail";
                }

                strSQL = "Update UserAccount set law_id = '" + law_id1 + "' where userName = '" + user.UserName + "'";
                mo.Command(strSQL);
                return "success";
            }
            catch
            {
                return "fail";
            }
        }
        public static DataTable GetListUserAccessDAO()
        {
            Modify modify = new Modify();
            string strSQL = "select us.userName, us.Email, l.law_name From UserAccount us, law l Where us.law_id = l.law_id ";
            return modify.GetDataTable(strSQL);
        }
        public static string DeleteUserDAO(string userName)
        {
            Modify modify = new Modify();
            string strSQL = "Delete From UserAccount Where userName = '" + userName + "'";
            try
            {
                modify.Command(strSQL);
                return "success";
            }
            catch
            {
                return "fail";

            }
        }

        public static DataTable BlockClassDAO()
        {
            Modify modify = new Modify();
            string strSQL = "select * from BlockClass ";
            return modify.GetDataTable(strSQL);
        }
        public static DataTable GetClassDAO()
        {
            Modify modify = new Modify();
            string strSQL = "select c.class_id, c.nameClass, b.block_name, c.schoolYear, c.block_id from Class c, BlockClass b where c.block_id = b.block_id";
            return modify.GetDataTable(strSQL);
        }
        public static DataTable GetClasscbDAO()
        {
            Modify modify = new Modify();
            string strSQL = "select* from Class ";
            return modify.GetDataTable(strSQL);
        }
        public static DataTable GetClassDAO(string search)
        {
            Modify modify = new Modify();
            string strSQL = "select c.class_id, c.nameClass, b.block_name, c.schoolYear, c.block_id from Class c, BlockClass b where c.block_id = b.block_id and nameClass like  '%" + search + "%' ";
            return modify.GetDataTable(strSQL);
        }
        public static string CreateBlockDAO(Block block)
        {
            Modify mo = new Modify();
            try
            {
                mo.Command("Insert into BlockClass values(  '" + block.block_name + "')");
            }
            catch (Exception ex)
            {
                return "exist_block_name";
            }
            return "success";
        }

        public static string UpdateBlockDAO(Block block)
        {
            Modify mo = new Modify();
            string strSQL = "Update BlockClass set block_name = '" + block.block_name + "' where block_id = '" + block.block_id + "'";
            try
            {
                mo.Command(strSQL);
                return "success";
            }
            catch
            {
                return "exist_block_name";
            }

        }
        public static string DeleteBlockDAO(Block block)
        {
            Modify mo = new Modify();
            string strSQL = "Delete BlockClass where block_id = '" + block.block_id + "'";
            try
            {
                mo.Command(strSQL);
                return "success";
            }
            catch
            {
                return "fail";
            }
        }
        public static string CreateClassDAO(Class cl)
        {
            Modify mo = new Modify();
            try
            {
                mo.Command("Insert into Class values( '" + cl.block_id + "','" + cl.nameClass + "','" + cl.schoolYear + "' )");
            }
            catch (Exception ex)
            {
                return "exist_class_name";
            }
            return "success";
        }
        public static string UpdateClassDAO(Class cl)
        {
            Modify mo = new Modify();
            string strSQL = "Update Class set block_id = '" + cl.block_id + "', nameClass = '" + cl.nameClass + "', schoolYear = '" + cl.schoolYear + "' where class_id = '" + cl.class_id + "'";
            try
            {
                mo.Command(strSQL);
                return "success";
            }
            catch
            {
                return "exist_block_name";
            }
        }
        public static string DeleteClassDAO(Class cl)
        {
            Modify mo = new Modify();
            string strSQL = "Delete Class where class_id = '" + cl.class_id + "'";
            try
            {
                mo.Command(strSQL);
                return "success";
            }
            catch
            {
                return "fail";
            }
        }

        public static DataTable GetStudentDAO(int class_id)
        {
            try
            {
                return new Modify().GetDataTable("select sudentName, numberphone, dateOfBirth,sex, adress, student_id from Student where class_id = '" + class_id + "'");

            }
            catch
            {
                return null;
            }
        }
        public static DataTable GetStudentDAO(string name)
        {
            try
            {
                return new Modify().GetDataTable("select sudentName, numberphone, dateOfBirth,sex, adress, student_id from Student where sudentName  like N'%" + name + "%'");

            }
            catch
            {
                return null;
            }
        }
        public static string CreateStudentDAO(StudentObject st)
        {
            try
            {
                new Modify().Command("insert into Student values (N'" + st.studentName + "','" + st.numberPhone + "','" + st.dateOfBirth + "',N'" + st.sex + "',N'" + st.adress + "','" + st.class_id + "')");
                return "success";
            }
            catch { return null; }
        }
        public static string UpdateStudentDAO(StudentObject st)
        {
           new Modify().Command("Update Student set sudentName = N'" + st.studentName + "' , numberphone = N'" + st.numberPhone + "' ,dateOfBirth = '" + st.dateOfBirth + "' , sex = N'" + st.sex + "', adress = N'" + st.adress + "', class_id = '"+st.class_id+"' where student_id = '"+st.student_id+"'");
            
            return "success";

        }
        public static string DeleteStudentDAO(StudentObject st)
        {
            Modify mo = new Modify();
            string strSQL = "Delete Student where class_id = '" + st.student_id + "'";
            try
            {
                mo.Command(strSQL);
                return "success";
            }
            catch
            {
                return "fail";
            }
        }
        public static DataTable GetTeacherDAO()
        {
            try
            {
                return new Modify().GetDataTable("Select * From Teacher");
            }catch
            {
                return null;
            }
        }
        public static DataTable GetClassOfTeacherDAO(int techer_id)
        {
                return new Modify().GetDataTable("Select * From Class where class_id in(select class_id from TeacherAndClass where teacher_id = '" + techer_id+"')"); 

        }
        public static DataTable GetClassNonOfTeacherDAO(int techer_id)
        {
            return new Modify().GetDataTable("Select * From Class where class_id not in(select class_id from TeacherAndClass where teacher_id = '" + techer_id + "')");
        }
        public static DataTable GetSubjectOfTeacherDAO(int teacher_id)
        {
            try
            {
                return new Modify().GetDataTable("Select * From Subjectt where subject_id in(select subject_id from Undertake where teacher_id = '"+teacher_id+"')");
            }
            catch
            {
                return null;
            }
        }
        public static DataTable GetSubjectNonOfTeacherDAO(int teacher_id)
        {
            try
            {
                return new Modify().GetDataTable("Select * From Subjectt where subject_id not in(select subject_id from Undertake where teacher_id = '" + teacher_id + "')");
            }
            catch
            {
                return null;
            }
        }
        public static string CreateTeacherDAO(TeacherObject tc)
        {
            try
            {
                new Modify().Command("insert into Teacher values (N'" + tc.name_teacher + "','" + tc.numberPhone + "','" + tc.dateOfBirth + "',N'" + tc.sex + "',N'" + tc.adress + "')");
                return "success";
            }
            catch { return null; }
        }
        public static string UpdateTeacherDAO(TeacherObject tc)
        {
            try
            {
                new Modify().Command("Update Teacher set  name_teacher = N'"+tc.name_teacher+"',numberphone = '"+tc.numberPhone+"', dateOfBirth = '"+tc.dateOfBirth+"', sex=N'"+tc.sex+"', adress=N'"+tc.adress+"' where teacher_id ='"+tc.teacher_id+"'");
               // new Modify().Command("Update Teacher set  name_teacher = N'asdas',numberphone = '0123456789', dateOfBirth = '2002-03-03', sex=N'Nam', adress='An Giang' where teacher_id ='1'");

                return "success";
            }
            catch(Exception e) { return e.Message; }
        }
        public static string DeleteTeacherDAO(TeacherObject tc)
        {
            Modify mo = new Modify();
            string strSQL = "Delete Teacher where teacher_id = '" + tc.teacher_id + "'";
            try
            {
                mo.Command(strSQL);
                return "success";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public static string AddClassForTeacherDAO(int class_id, int teacher_id)
        {
            try
            {
                new Modify().Command("Insert into TeacherAndClass values('" + class_id + "','" + teacher_id + "')");
                return "success";
            }catch(Exception e)
            {
                return e.Message;
            }
        }
        public static string RemoveClassForTeacherDAO(int class_id, int teacher_id)
        {
            try
            {
                new Modify().Command("Delete TeacherAndClass where class_id = '"+class_id+"' and teacher_id = '"+teacher_id+"'");
                return "success";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public static string AddSubjectForTeacherDAO(int subject_id, int teacher_id)
        {
            try
            {
                new Modify().Command("Insert into Undertake values('" + subject_id + "','" + teacher_id + "')");
                return "success";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public static string RemoveSubjectForTeacherDAO(int subject_id, int teacher_id)
        {
            try
            {
                new Modify().Command("Delete Undertake where subject_id = '" + subject_id + "' and teacher_id = '" + teacher_id + "'");
                return "success";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public static DataTable GetFamilyForStudentDAO(StudentObject st)
        {
            try
            {
                return new Modify().GetDataTable("Select * From Farmily Where farmily_id in (select farmily_id from SutdentAndFarmily where student_id = '" + st.student_id + "')");
            }catch(Exception e)
            {
                return null;
            }
        }
        public static DataTable GetFamilyDAO()
        {
            try
            {
                return new Modify().GetDataTable("Select * From Farmily ");
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public static string CreateFamilyDAO(Family f)
        {
            try
            {
                new Modify().Command("insert into Farmily values (N'" + f.nameRelationShip + "','" + f.numberPhone + "','" + f.yearOfBirth + "',N'" + f.parent_name + "')");
                return "success";
            }
            catch(Exception e) { return e.Message; }
        }
        public static string UpdateFamilyDAO(Family f)
        {
            try
            {
                new Modify().Command("update Farmily set nameRelationship = N'" + f.nameRelationShip + "',numberphone = '" + f.numberPhone + "', yearOfBirth = '" + f.yearOfBirth + "',parent_name =  N'" + f.parent_name + "' Where farmily_id = '"+f.family_id+"'");
                return "success";
            }
            catch (Exception e) { return e.Message; }
        }
        public static string DeleteFamilyDAO(Family f)
        {
            try
            {
                new Modify().Command("Delete Farmily Where farmily_id = '" + f.family_id + "'");
                return "success";
            }
            catch (Exception e) { return e.Message; }
        }
        public static string AddStudentForFamilyDAO(int student_id, int family_id)
        {
            try
            {
                new Modify().Command("insert into SutdentAndFarmily values('"+family_id+"','"+student_id+"')");
                return "success";
            }
            catch (Exception e) { return e.Message; }
        }
        public static string RemoveStudentForFamilyDAO(int student_id, int family_id)
        {
            try
            {
                new Modify().Command("Delete SutdentAndFarmily where farmily_id =  '" + family_id + "'and student_id =  '" + student_id + "'");
                return "success";
            }
            catch (Exception e) { return e.Message; }
        }
        public static DataTable GetStudentOfFamilyDAO(int family_id)
        {
            try
            {
               return new Modify().GetDataTable("Select  sudentName, numberphone, dateOfBirth,sex, adress, student_id From Student where student_id in (select student_id From SutdentAndFarmily where farmily_id = '"+family_id+"')");
                
            }
            catch (Exception e) { return null; }
        }
        public static DataTable GetStudentNonOfFamilyDAO(int family_id, int class_id)
        {
            try
            {
                return new Modify().GetDataTable("Select  sudentName, numberphone, dateOfBirth,sex, adress, student_id From Student where class_id = '"+class_id+"' and  student_id not in (select student_id From SutdentAndFarmily where farmily_id = '" + family_id + "')");

            }
            catch (Exception e) { return null; }
        }
        public static DataTable GetStudentNonOfFamilyDAO(int family_id, string name)
        {
            try
            {
                return new Modify().GetDataTable("Select  sudentName, numberphone, dateOfBirth,sex, adress, student_id From Student where sudentName like '%"+name+"%' and student_id not in (select student_id From SutdentAndFarmily where farmily_id = '" + family_id + "')");

            }
            catch (Exception e) { return null; }
        }
    }
}
