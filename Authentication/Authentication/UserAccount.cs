﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Authentication
{
    public class UserAccount
    {
        public String UserName { get; set; }
        public String Password { get; set; }
        public string[] Roles { get; set; }
    }
}