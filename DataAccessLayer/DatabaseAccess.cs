using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ValueObject;

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
    public class DatabaseAccess
    {
        public static string CheckLogicDTO(UserAccount taikhoan)
        {
            string user = null;
            // Hàm connect tới CSDL
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            string strSQL = "Select * From UserAccount Where userName = '" + taikhoan.UserName + "' and pass = '" + taikhoan.Pass + "'";
            SqlCommand command = new SqlCommand(strSQL, conn);
            // Kiểm tra quyền các bạn thêm 1 cái parameter...
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
    }
}
