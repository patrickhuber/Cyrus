﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Cyrus.Http.Credentials
{
    public class BasicAuthenticationCredential
    {
        public string UserName { get; }
        public string Password { get; }

        public BasicAuthenticationCredential(string userName, string password)
        {
            Password = password;
            UserName = userName;
        }
    }
}