﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject
{
    public class UserAccount
    {
   
        public String UserName { set; get; }
        public String Pass { set; get; }
        public String Email { set; get; }

        public int law_id { set; get; }
    }
}
