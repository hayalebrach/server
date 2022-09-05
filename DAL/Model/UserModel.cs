using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class UserModel
    {
        //פונקצית
        //GET 
        //כל המשתמשים
        public List<User> GetAllUsers()
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
                return db.Users.ToList();
        }

        //פונקצית GET שמקבלת לפי שם וסיסמא
        public User GetByIdAndPassword(string name,int password)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                return db.Users.FirstOrDefault(x => x.Name == name&&x.Password==password);
            }
        }

        //הוספת משתמש
        public User AddUser(User User)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {

                User = db.Users.Add(User);
                db.SaveChanges();
                return User;

            }
        }
        //פונקצית עדכון
        public User Put(User User)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                User newUser = db.Users.FirstOrDefault(x => x.Id == User.Id);
                newUser.Id = User.Id;
                newUser.Name = User.Name;
                newUser.Email = User.Email;
                newUser.Phone = User.Phone;
                newUser.Type = User.Type;
                db.SaveChanges();
                return User;
    }
        }
        //פונקצית מחיקה
        public User Delete(User User)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                User newUser = db.Users.Remove(User);
                db.SaveChanges();
                return User;

            }
        }
    }
}
