using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class UserModel
    {
        public List<User> GetAllGuide()
        {

            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                List<User> guide = new List<User>();
                return db.Users.Where(x => x.IdRole == 3).ToList();
            }
        }
        public List<User> GetAllManagers()
        {

            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                List<User> managers = new List<User>();
                return db.Users.Where(x => x.IdRole == 2).ToList();
            }
        }


        public User GetUsersToPool(string name, string password)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                return db.Users.FirstOrDefault(x => x.Name == name && x.Password == password);
            }
        }
        

        //פונקצית GET שמקבלת לפי שם וסיסמא
        public User GetByIdAndPassword(string name,string password)
      
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                return db.Users.FirstOrDefault(x => x.Name == name&&x.Password==password);
            }
        } 

        public User AddUser(User User)  //הוספת משתמש
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
                newUser.Password = User.Password;
                newUser.Type = User.Type;
                newUser.IdRole = User.IdRole;
                newUser.LastEntery = User.LastEntery;
                newUser.Phone = User.Phone;
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
