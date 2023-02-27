using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;

namespace BusinessLogicLayer
{
    public class UserBLL
    {
        UserAccess tkAccess = new UserAccess();
        public string CheckLogic(UserAccount taikhoan)
        {
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
    }
}
