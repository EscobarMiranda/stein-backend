using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sfe.dal
{
    public class QuestionOptions
    {
        public Question question { get; set; }
        public List<Option> options { get; set; }
    }
}
