using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace GeneralComputing.Models
{
    public class PasswordModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Accountname { get; set; }
        public SecureString Password { get; set; }
        public DateTime? ExpirationDate { get; set; }
    }
}
