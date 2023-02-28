using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ValueObject;
using System.Data.Common;

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
       
        public static string CheckLogicDTO(UserAccount taikhoan)
        {
            Modify modify = new Modify();
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
                    pass = reader.GetString(2);
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
                mo.Command("Insert into UserAccount values( '" + user.UserName + "' , '" + user.Pass + "', '" + user.Email + "' )");
            }catch (Exception ex)
            {
                return "exist_username_email";
            }
            return "success";
        }
    }
}
