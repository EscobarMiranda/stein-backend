using Newtonsoft.Json;
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
        private static JsonSerializerSettings settings = new JsonSerializerSettings
        {
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
            Formatting = Formatting.Indented
        };

        public static User Read(LoginData loginObject)
        {
            try
            {
                string json = JsonConvert.SerializeObject(db.Users.Where(u => u.username == loginObject.username && u.password == loginObject.password && u.country == loginObject.country).SingleOrDefault(), settings);
                User user = JsonConvert.DeserializeObject<User>(json);
                user.Clients = null;
                return user;
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
                var users = (db.Users
                    .Where(u => u.username == data.username && u.password == data.password).SingleOrDefault());

                User user = new User();
                user = users;
                user.password = data.newPassword;
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
