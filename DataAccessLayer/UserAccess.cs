﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using ValueObject;
namespace DataAccessLayer
{
     public class UserAccess : DatabaseAccess
    {
        public string CheckLogic(UserAccount taikhoan)
        {
            string claw = CheckLogicDTO (taikhoan);
            if(claw == "susccess") {
                string info = CheackAccessAcountDAO(taikhoan);
                return info;
            }
            else
            {
                return claw;
            }
        }
        
        public string CheckEmail(string  email)
        {
            return CheckEmailDAO(email);            
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
        public DataTable GetLawDataTB()
        {
            return GetLawDataTBDAO();
        }
        public string UpdateUser(UserAccount user)
        {
            return UpdateUserDAO(user);
        }
        public string ProvideLawUser(UserAccount user, string law_name)
        {
            return ProvideLawUserDAO(user , law_name);
        }
        public DataTable GetListUserAccess()
        {
            return GetListUserAccessDAO();
        }
        public string DeleteUser(string userName)
        {
            return DeleteUserDAO(userName);
        }
        public string UpdateUserByEmail(UserAccount us)
        {
            return UpdateUserByEmailDAO(us);
        }
    }   
}
