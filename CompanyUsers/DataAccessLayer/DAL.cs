using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public static class DAL
    {
        static UserRegistrationEntities DbContext;
        static DAL()
        {
            DbContext = new UserRegistrationEntities();
        }
        public static List<UserDetail> GetAllUsers()
        {
            return DbContext.UserDetails.ToList();
        }
        public static UserDetail GetUser(int userId)
        {
            return DbContext.UserDetails.Where(p => p.ID == userId).FirstOrDefault();
        }
        public static bool InsertUser(UserDetail userItem)
        {
            bool status;
            try
            {
                DbContext.UserDetails.Add(userItem);
                DbContext.SaveChanges();
                status = true;
            }
            catch (Exception)
            {
                status = false;
            }
            return status;
        }
        public static bool UpdateUser(UserDetail userItem)
        {
            bool status;
            try
            {
                UserDetail usersItem = DbContext.UserDetails.Where(p => p.ID == userItem.ID).FirstOrDefault();
                if (usersItem != null)
                {
                    usersItem.UserName = userItem.UserName;
                    usersItem.Mail = userItem.Mail;
                    usersItem.PhoneNumber = userItem.PhoneNumber;
                    usersItem.Skillsets = userItem.Skillsets;
                    usersItem.Hobby = userItem.Hobby;
                    DbContext.SaveChanges();
                }
                status = true;
            }
            catch (Exception)
            {
                status = false;
            }
            return status;
        }
        public static bool DeleteUser(int id)
        {
            bool status;
            try
            {
                UserDetail userItem = DbContext.UserDetails.Where(p => p.ID == id).FirstOrDefault();
                if (userItem != null)
                {
                    DbContext.UserDetails.Remove(userItem);
                    DbContext.SaveChanges();
                }
                status = true;
            }
            catch (Exception)
            {
                status = false;
            }
            return status;
        }
    }
}
