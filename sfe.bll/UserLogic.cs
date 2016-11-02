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
    public class UserLogic
    {
        private static DataClassesDataContext db = Database.Instance;
        private static JsonSerializerSettings settings = new JsonSerializerSettings
        {
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
            Formatting = Formatting.Indented
        };
        public static List<User> Read()
        {
            try
            {
                string json = JsonConvert.SerializeObject(db.Users.Where(u => u.active == true).ToList(), settings);
                List<User> listUsersTmp = JsonConvert.DeserializeObject<List<User>>(json);
                List<User> listUsers = new List<User>();
                listUsersTmp.ForEach(users => {
                    users.Clients = null;
                    listUsers.Add(users);
                });
                return listUsers;

            }
            catch (Exception e)
            {
                EventLog.WriteEntry("sfe", e.StackTrace.ToString(), EventLogEntryType.Error);
                throw new UserListNotFoundException("Agent list not found");
            }
        }

        public static User Read(int id)
        {
            try
            {
                return (from agent in db.Users
                        where agent.idUser == id
                        select agent).Single();
            }
            catch (Exception e)
            {
                EventLog.WriteEntry("sfe", e.StackTrace.ToString(), EventLogEntryType.Error);
                throw new UserNotFoundException("User not found");
            }
        }

        public static void Create(User user)
        {
            try
            {
                db.Users.InsertOnSubmit(user);
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                EventLog.WriteEntry("sfe", e.StackTrace.ToString(), EventLogEntryType.Error);
                throw new PostUserException("Error creating user");
            }
        }

        public static void Delete(int id)
        {
            try
            {
                User tmpUser = Read(id);
                tmpUser.active = false;
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                EventLog.WriteEntry("sfe", e.StackTrace.ToString(), EventLogEntryType.Error);
                throw new DeleteUserException("Error deleting user");
            }
        }

        public static void Update(User user)
        {
            try
            {
                User tmpUser = Read(user.idUser);
                tmpUser.name = user.name;
                tmpUser.lastName = user.lastName;
                tmpUser.username = user.username;
                tmpUser.password = user.password;
                tmpUser.country = user.country;
                tmpUser.province = user.province;
                tmpUser.address1 = user.address1;
                tmpUser.address2 = user.address2;
                tmpUser.zone = user.zone;
                tmpUser.email = user.email;
                tmpUser.phone1 = user.phone1;
                tmpUser.phone2 = user.phone2;
                tmpUser.FK_userType = user.FK_userType;
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                EventLog.WriteEntry("sfe", e.StackTrace.ToString(), EventLogEntryType.Error);
                throw new UpdateUserException("Error updating user");
            }
        }
    }
}
