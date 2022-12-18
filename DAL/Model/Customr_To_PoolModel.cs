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
        public CustomerToPool Purchasing(CustomerToPool purchase)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {

                purchase = db.CustomerToPools.Add(purchase);
                db.SaveChanges();
                return purchase;

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
