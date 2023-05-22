using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ValueObject;

namespace BusinessLogicLayer
{
    public class UserBLL
    {
        UserAccess tkAccess = new UserAccess();
        static string GetMd5Hash(MD5 md5Hash, string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
        public string DecryptMD5(string input)
        {
            // Tạo một đối tượng MD5
            using (MD5 md5 = MD5.Create())
            {
                // Chuyển đổi chuỗi mật khẩu vào mảng byte
                byte[] inputBytes = Encoding.ASCII.GetBytes(input);
                // Tính toán giá trị băm MD5 cho mảng byte đầu vào
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                // Tạo một StringBuilder để chứa kết quả giải mã
                StringBuilder builder = new StringBuilder();
                // Với mỗi byte trong mảng kết quả, chuyển đổi thành chuỗi hex và thêm vào StringBuilder
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    builder.Append(hashBytes[i].ToString("x2")); // "x2" để chuyển đổi thành chuỗi hex với 2 ký tự
                }
                // Trả về chuỗi đã giải mã
                return builder.ToString();
            }
        }
        public string CheckLogic(UserAccount taikhoan)
        {
            taikhoan.UserName = taikhoan.UserName.Trim();
            if (taikhoan.UserName == "")
            {
                return "requeid_taikhoan";
            }

            if (taikhoan.Pass == "")
            {
                return "requeid_password";
            }
            MD5 md5Hash = MD5.Create();
            string matkhau_mahoa = GetMd5Hash(md5Hash, taikhoan.Pass);
            taikhoan.Pass = matkhau_mahoa;
            string info = tkAccess.CheckLogic(taikhoan);
            return info;
        }
        public string CheckLogicRegister(UserAccount taikhoan, string subPass)
        {
            // Kiểm tra nghiệp vụ
            taikhoan.UserName = taikhoan.UserName.Trim();
            if (taikhoan.UserName == "") 
            {
                return "requeid_taikhoan";
            }
            if (taikhoan.Pass == "" )
            {
                return "requeid_password";
            }
            if (taikhoan.Pass != subPass)
                return "pass_not_match";
            if (!isEmail(taikhoan.Email))
            {
                return "requeid_email";
            }
            MD5 md5Hash = MD5.Create();
            string matkhau_mahoa = GetMd5Hash(md5Hash, taikhoan.Pass);
            taikhoan.Pass= matkhau_mahoa;
            string infor = tkAccess.CreateAccout(taikhoan);
            return infor;
        }
        public bool isEmail(string email) // kiểm tra email người dùng nhập có hợp lệ hong
        {
            return Regex.IsMatch(email, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$");
        }
        public string CheckEmail(string email)
        {
            if(isEmail(email))
            {
                return tkAccess.CheckEmail(email);
            }else
                return "Email không hợp lệ";
        }
        public UserAccount GetUser(string userName)
        {
            if(userName != null)
            {
                UserAccount us = tkAccess.GetUser(userName);
                return us;
            }
            return null;
        }

       public DataTable GetLawDataTB()
        {
            return tkAccess.GetLawDataTB();
        }

        public Law GetLaw(string userName)
        {
            if (userName != null)
            {
                return tkAccess.GetLaw(userName);
            }
            return null;
        }
        public string UpdateUser(UserAccount user)
        {
            if(user != null)
            {
                if (!isEmail(user.Email))
                    return "requeid_email";
                MD5 md5Hash = MD5.Create();
                string matkhau_mahoa = GetMd5Hash(md5Hash, user.Pass);
                user.Pass = matkhau_mahoa;
                return tkAccess.UpdateUser(user);
            }
            return null;
        }
        public string ProvideLawUser(UserAccount user, string law_name)
        {
            if (user != null)
            {
                return tkAccess.ProvideLawUser(user , law_name);
            }
            return null;
        }
        public DataTable GetListUserAccess()
        {
            return tkAccess.GetListUserAccess();
        }
        public string DeleteUser(string userName)
        {
            return tkAccess.DeleteUser(userName);
        }


    }
}
