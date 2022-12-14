using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace DAL.Model
{
    public class Customr_To_PoolModel
    {
        #region ניסיונות של פונקציות לשליחת מיילים
        //public static void send(string Maill)
        //{
        //    string to = "hb05331875890@gmail.com";
        //    string from = "hb05331875890@gmail.com";
        //    MailMessage message = new MailMessage(from, to);
        //    message.Subject = "חיה ברכה ברגה";
        //    message.Body = @"תודה רבה לך ה'";
        //    SmtpClient client = new SmtpClient(Maill);
        //    // Credentials are necessary if the server requires the client
        //    // to authenticate before it will send email on the client's behalf.
        //    client.UseDefaultCredentials = true;

        //    try
        //    {
        //        client.Send(message);
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Exception caught in CreateTestMessage2(): {0}",
        //            ex.ToString());
        //    }
        //}
        //public static void send(string EmailBody)
        //{
        //    MailMessage mailMessage = new MailMessage("hb05331875890@gmail.com", "lielmymon@gmail.com");
        //    mailMessage.Subject = "Exception";
        //    mailMessage.Body = EmailBody;
        //    SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
        //    smtpClient.Credentials = new System.Net.NetworkCredential()
        //    {
        //        UserName = "hb05331875890@gmail.com",
        //        Password = "3240915780"
        //    };
        //    smtpClient.EnableSsl = true;
        //    smtpClient.Send(mailMessage);
        //}

        //public static void send(String toEmailAddress, String emailSubject, String emailBody)
        //{

        //    Create a variable for YOUR TEAM'S Email address
        //    This is the address that will be SENDING the emails(the FROM address)
        //    String strFromEmailAddress = "hb0@gmail.com";

        //    This is the password for YOUR TEAM'S "fake" Gmail account
        //    String strPassword = "Password";

        //    This is the name of the business from which you are sending
        //    TODO: Change this to the name of the company you are creating the website for
        //    String strCompanyName = "Team Final Project";

        //    Create an email client to send the emails
        //    port 587 is required to work, do not change it
        //    var client = new SmtpClient("smtp.gmail.com", 587)
        //    {
        //        UseDefaultCredentials = false,
        //        This is the SENDING email address and password
        //        This will be your team's email address and password
        //        Credentials = new NetworkCredential(strFromEmailAddress, strPassword),
        //        EnableSsl = true
        //    };


        //}
        //public static void send(string Maill)
        //{
        //    //יצירת אוביקט MailMessage
        //    MailMessage mail = new MailMessage();

        //    //למי לשלוח (יש אפשרות להוסיף כמה נמענים) 
        //    mail.To.Add("hb05331875890@gmail.com");

        //    //כתובת מייל לשלוח ממנה
        //    mail.From = new MailAddress("hb05331875890@gmail.com");

        //    // נושא ההודעה
        //    mail.Subject = "שלום לכלם זה רק ניסוי ובעזרת ה' הוא יצליח";

        //    //תוכן ההודעה ב- HTML
        //    mail.Body = "בעזרת ה' כמובן";

        //    //הגדרת תוכן ההודעה ל - HTML 
        //     mail.IsBodyHtml = true;

        //    // Smtp יצירת אוביקט 
        //    SmtpClient smtp = new SmtpClient();

        //    //הגדרת השרת של גוגל
        //    smtp.Host = "smtp.gmail.com";


        //    //הגדרת פרטי הכניסה לחשבון גימייל
        //    smtp.Credentials = new System.Net.NetworkCredential("hb05331875890@gmail.com", "3240915780");

        //    //אפשור SSL (חובה(
        //    smtp.EnableSsl = true;
        //    try
        //    {
        //        //שליחת ההודעה
        //        smtp.Send(mail);
        //    }
        //    catch (Exception ex)
        //    {
        //        //תפיסה וטיפול בשגיאות
        //        ex.ToString();

        //    }
        //}




        #endregion



        public static string send(string maill)
        {
           MailMessage mm = new MailMessage("swimmoodmail@gmail.com", maill);

            mm.Body = "הצלחנו";

            SmtpClient client = new SmtpClient("smtp.gmail.com");
            client.EnableSsl = true;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Timeout = 30 * 1000;
            client.Credentials = new NetworkCredential("swimmoodmail@gmail.com", "SWIMMAIL");
            client.Port = 587;
            client.EnableSsl = true;
            try
            {
                client.Send(mm);
                return "המייל נשלח בהצלחה";
            }
            catch
            {
                return mm.Body;
            }

        }

       
        //פונקצית
        //GET 
        //פונקציה שמיבאת משתמשים לבריכה מסוימת על פי קוד בריכה
        public List<CustomerToPool> GetByIdPool(int IdPool)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                //string EmailBody = "hb05331875890@gmail.com";
                //send(EmailBody);
                return db.CustomerToPools.Include("Package").Include("User").Where(x => x.Package.IdPool == IdPool).ToList();
            }

        }
        //פונקציה שמביאה היסטורית קניות של לקוח 
        public List<CustomerToPool> GetHistoryOfUser(int IdUser)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                return db.CustomerToPools.Include("Package").Include("User").Where(x => x.IdUser == IdUser).ToList();
            }

        }
        //פונקציה שמביאה היסטורית קניותשל משתמש למנהל בריכה מסוימת
        public List<CustomerToPool> GetHistoryByIdPoolAndIdUser(int IdUser, int IdPool)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                return db.CustomerToPools.Include("Package").Include("User").Where(x => x.IdUser == IdUser && x.Package.IdPool == IdPool).ToList();
            }

        }
        public List<CustomerToPool> Get()
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                CustomerToPool CustomerToPool = new CustomerToPool();

                //return db.CustomerToPools.FirstOrDefault(x => x.Id == Id);
                return db.CustomerToPools.Include("Package").Include("User").ToList();
            }
        }
        //
        public CustomerToPool Post(CustomerToPool CustomerToPool)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {

                CustomerToPool = db.CustomerToPools.Add(CustomerToPool);
                db.SaveChanges();
                return CustomerToPool;

            }
        }
        //פונקצית עדכון
        public CustomerToPool Put(CustomerToPool CustomerToPool)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                CustomerToPool newCustomr_To_Pool = db.CustomerToPools.FirstOrDefault(x => x.Id == CustomerToPool.Id);
                newCustomr_To_Pool.Id = CustomerToPool.Id;
                newCustomr_To_Pool.AmountLeft = CustomerToPool.AmountLeft;
                newCustomr_To_Pool.AmountGet = CustomerToPool.AmountGet;
                newCustomr_To_Pool.TotalPrice = CustomerToPool.TotalPrice;
                newCustomr_To_Pool.DateBuy = CustomerToPool.DateBuy;
                db.SaveChanges();
                return CustomerToPool;
            }

        }
        //פונקצית מחיקה
        public CustomerToPool Delete(CustomerToPool CustomerToPool)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                CustomerToPool newCustomr_To_Pool = db.CustomerToPools.Remove(CustomerToPool);
                db.SaveChanges();
                return CustomerToPool;

            }
        }

    }
}
