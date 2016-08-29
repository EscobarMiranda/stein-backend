using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sfe.dal
{
    public class Frequency
    {
        public string fullName { get; set; }
        public int frequency { get; set; }
        public int idClient { get; set; }
        public int FK_clientType { get; set; }
    }
}
