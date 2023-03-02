﻿using System;
using System.Collections.Generic;
using System.Data;
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
            string claw = CheackAccessAcountDAO(taikhoan);
            if(claw == "susccess") {
                string info = CheckLogicDTO(taikhoan);
                return info;
            }
            else
            {
                return "user_not_accepted";
            }
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

        public UserAccount GetUser(string userName)
        {
            return GetUserDAO(userName);
        }
        public Law GetLaw(string userName)
        {
            return GetLawDAO(userName);
        }
        public string UpdateUser(UserAccount user)
        {
            return UpdateUserDAO(user);
        }
        public DataTable GetListUser()
        {
            return GetListUserDAO();
        }
    }   
}
