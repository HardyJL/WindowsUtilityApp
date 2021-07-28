using System;

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
    }
}
