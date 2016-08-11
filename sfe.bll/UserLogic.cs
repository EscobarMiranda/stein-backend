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
        public static List<User> Read()
        {
            try
            {
                return (from users in db.Users
                        where users.active == true
                        select users).ToList();
            }
            catch (Exception e)
            {
                EventLog.WriteEntry("sfe", e.StackTrace.ToString(), EventLogEntryType.Error);
                throw new UserListNotFoundException("User list not found");
            }
        }

        public static User Read(int id)
        {
            try
            {
                return (from user in db.Users
                        where user.idUser == id
                        select user).Single();
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

        public static bool Update(User user)
        {
            Boolean res = false;
            try
            {
                if (user == null)
                {
                    throw new Exception("The user can't be null");
                }
                User tmpUser = Read(user.idUser);
                if (tmpUser == null)
                {
                    throw new Exception(string.Format("The user {0} can't be found", user.idUser));
                }
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

                res = true;
            }
            catch (Exception e)
            {
                EventLog.WriteEntry("sfe", e.StackTrace.ToString(), EventLogEntryType.Error);
                throw new PutUserException(string.Format("Error update user ({0})", e.Message));
            }
            return res;
        }
    }
}