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
                User tmpUser = (from user in db.Users
                                where user.username == loginObject.username && 
                                user.password == loginObject.password &&
                                user.country == loginObject.country
                                select user).Single();
                tmpUser.password = "";
                return tmpUser;
            }
            catch (Exception e)
            {
                EventLog.WriteEntry("sfe", e.StackTrace.ToString(), EventLogEntryType.Error);
                throw new UserNotValidException("User is not valid");
            }
        }

        public static void ChangePassword(ChangePasswordData data)
        {
            try
            {
                User tmpUser = (from user in db.Users
                                where user.username == data.username &&
                                user.password == data.password
                                select user).Single();
                tmpUser.password = data.newPassword;
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                EventLog.WriteEntry("sfe", e.StackTrace.ToString(), EventLogEntryType.Error);
                throw new ChangePasswordException("Error updating password");
            }
        }
    }
}
