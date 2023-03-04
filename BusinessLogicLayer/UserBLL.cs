using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ValueObject;

namespace BusinessLogicLayer
{
    public class UserBLL
    {
        UserAccess tkAccess = new UserAccess();
        public string CheckLogic(UserAccount taikhoan)
        {
            taikhoan.UserName = taikhoan.UserName.Trim();
            // Kiểm tra nghiệp vụ

            if (taikhoan.UserName == "")
            {
                return "requeid_taikhoan";
            }

            if (taikhoan.Pass == "")
            {
                return "requeid_password";
            }

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
            string infor = tkAccess.CreateAccout(taikhoan);
            return infor;
        }
        public bool isEmail(string email) // kiểm tra email người dùng nhập có hợp lệ hong
        {
            return Regex.IsMatch(email, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$");
        }
        public string CheckEmail(string email)
        {
            string pass = "";
            if(isEmail(email))
            {
                pass = tkAccess.CheckEmail(email);
                return pass;
            }else
                return "Email không hợp lệ";
        }

        public UserAccount GetUser(string userName)
        {
            if(userName != null)
            {
               return tkAccess.GetUser(userName);
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
