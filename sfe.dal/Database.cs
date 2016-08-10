using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sfe.dal
{
    public class Database
    {
        private static volatile DataClassesDataContext instance;
        private static object syncRoot = new Object();

        private Database() { }

        public static DataClassesDataContext Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new DataClassesDataContext();
                    }
                }
                return instance;
            }
        }
    }
}
