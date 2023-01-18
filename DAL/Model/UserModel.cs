using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
namespace DAL.Model
{
    public class UserModel
    {
        //פונקצית GET לפי מייל
        public User getUserByMail(string mail)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                return db.Users.FirstOrDefault(x => x.Email == mail && x.Status == true);
            }
        }
        //פונקתיה ששולחת מייל
        public User SendMail(string body,string mail,string subject)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                Customr_To_PoolModel.send(body, mail,subject);
                return db.Users.FirstOrDefault(x=>x.Email==mail&x.Status==true);
            }
        }
        //פונקצית GET שמקבלת לפי שם וסיסמא
        public User GetByIdAndPassword(string name, string password)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                return db.Users.FirstOrDefault(x => x.Name == name && x.Password == password&&x.Status==true);
            }
        }
        //פונקציה שלוקחת את כל המדריכים לקורסים שבאותה בריכה
        public List<User> GetAllGuide()
        {

            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                List<User> guide = new List<User>();
                return db.Users.Where(x => x.IdRole == 3&&x.Status==true).ToList();
            }
        }
        //פונקציה שלוקחת את כל המשתמשים
        public List<User> GetAllUsers()
        {
            using(SwimMoodEntities db=new SwimMoodEntities())
            {
                return db.Users.Where(x=>x.Status==true).ToList();
            }
        }
        //פונקציה שלוקחת את כל מנהלי הבריכות
        public List<User> GetAllManagers()
        {

            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                List<User> managers = new List<User>();
                return db.Users.Where(x => x.IdRole == 2&&x.Status==true).ToList();
            }
        }
        //פונקציה שמוסיפה משתמש/מנהל בריכה/מנהל אתר
        public User AddUser(User User)  //הוספת משתמש
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                User = db.Users.Add(User);
                db.SaveChanges();
                return User;

            }
        }
        //פונקצית עדכון סיסמא
        public User PutPassWord(string PassWord, int Id)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                User newUser = db.Users.FirstOrDefault(x => x.Id == Id&&x.Status==true);
                newUser.Password = PassWord;
                db.SaveChanges();
                return newUser;
            }
        }

        //פונקציה שמעדכנת כניסה אחרונה
        public User LastEnteryDate(User user)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                User newUser = db.Users.FirstOrDefault(x => x.Id == user.Id&&x.Status==true);
                newUser.LastEntery = user.LastEntery;
                db.SaveChanges();
                return newUser;
            }
        }

        //פונקצית עדכון

        //public User Put(User User)
        //{
        //    using (SwimMoodEntities db = new SwimMoodEntities())
        //    {
        //        User newUser = db.Users.FirstOrDefault(x => x.Id == User.Id);
        //        newUser.Id = User.Id;
        //        newUser.Name = User.Name;
        //        newUser.Email = User.Email;
        //        newUser.Password = User.Password;
        //        newUser.Type = User.Type;
        //        newUser.IdRole = User.IdRole;
        //        newUser.LastEntery = User.LastEntery;
        //        newUser.Phone = User.Phone;
        //        db.SaveChanges();
        //        return User;
        //    }
        //}


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
