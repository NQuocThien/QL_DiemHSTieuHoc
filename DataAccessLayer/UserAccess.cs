using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;
namespace DataAccessLayer
{
     public class UserAccess : DatabaseAccess
    {
        public string CheckLogic(UserAccount taikhoan)
        {
            string info = CheckLogicDTO(taikhoan);
            return info;
        }
        public string CheckEmail(string  email)
        {
            string pass = CheckEmailDAO(email);
            return pass;
        }
        public string CreateAccout(UserAccount user)
        {
           string status =  CreateAccoutDAO(user);
            return status;
        }
    }   
}
