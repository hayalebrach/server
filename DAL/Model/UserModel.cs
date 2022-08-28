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
        //שמחזירה את השעות פעילות
        public List<User> Get()
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
                return db.Users.ToList();
        }

        public User Get(string name,int password)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {

                return db.Users.FirstOrDefault(x => x.Name == name&&x.Password==password);
            }
        }

        public User Get(int Id)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {

                return db.Users.FirstOrDefault(x => x.Id == Id);
            }
        }
        //
        public User Post(User User)
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
