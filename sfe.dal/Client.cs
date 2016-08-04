using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace sfe.dal
{
    [Serializable]
    [DataContract]
    public class Client
    {
        [DataMember]
        public int Id { set; get; }
        [DataMember]
        public string Name { set; get; }
    }
}
