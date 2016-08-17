using sfe.bll.Exceptions;
using sfe.dal;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sfe.bll
{
    public class LoginLogic
    {
        private static DataClassesDataContext db = Database.Instance;

        public static User Read(LoginData loginObject)
        {
            try
            {
                User tmpUser = (from User in db.Users
                                where User.username == loginObject.username && 
                                User.password == loginObject.password &&
                                User.country == loginObject.country
                                select User).Single();
                tmpUser.password = "";
                return tmpUser;
            }
            catch (Exception e)
            {
                EventLog.WriteEntry("sfe", e.StackTrace.ToString(), EventLogEntryType.Error);
                throw new UserNotValidException("User is not valid");
            }
        }
    }
}
