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
            string strSQL = "Select law_id From UserAccount Where userName = '"+taikhoan.UserName+"' and law_id in(Select law_id from law)";
            string infor = null;
            DataTableReader dr = modify.GetDataTable(strSQL).CreateDataReader();
            if(dr.HasRows)
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
                mo.Command("Insert into UserAccount values( '" + user.UserName + "' , '" + user.Pass + "', '" + user.Email + "', NULL)");
            }catch (Exception ex)
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
            if(reader.HasRows)
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
            string strSQL = "Update UserAccount set pass = '" + user.Pass + "', email = '" + user.Email + "' where userName = '"+user.UserName+"'";
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
        public static DataTable GetListUserDAO()
        {
            Modify modify = new Modify();   
            string strSQL = "select us.userName, us.Email, l.law_name From UserAccount us, law l Where us.law_id = l.law_id";
            return modify.GetDataTable(strSQL);
            
        }
    }
}
