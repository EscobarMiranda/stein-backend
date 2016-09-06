using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sfe.dal
{
    public class ChangePasswordData
    {
        public string username { get; set; }
        public string password { get; set; }
        public string newPassword { get; set; }
    }
}
