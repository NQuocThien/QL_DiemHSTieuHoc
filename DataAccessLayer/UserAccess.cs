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
    }
}
