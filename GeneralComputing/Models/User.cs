using System;
using System.Net;
using System.Security;

namespace GeneralComputing.Models
{
    public class User
    {
        public string userName { get; set; }
        public string password { get; set; }

        public override string ToString()
        {
            return $"{userName} + {password}";
        }

        public SecureString GetToken()
        {
            return new NetworkCredential(userName, password).SecurePassword;
        }
    }
}