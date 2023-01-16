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
        



        public static string send(string body,string mail,string subject)
        {
                MailMessage msg = new MailMessage() { From = new MailAddress("swimmood8@gmail.com", "swimMood")};
                msg.To.Add(mail);
                msg.Body =body ;
                msg.Subject = subject;
                msg.IsBodyHtml = false;
                msg.BodyEncoding = System.Text.Encoding.UTF8;
                msg.Priority = MailPriority.High;
                try
                {
                    using (SmtpClient client = new SmtpClient())
                    {
                        client.EnableSsl = true;
                        client.UseDefaultCredentials = false;
                        client.Credentials = new NetworkCredential("swimmood8@gmail.com", "bfvussfffeigxlqz");
                        client.Host = "smtp.gmail.com";
                        client.Port = 587;
                        client.DeliveryMethod = SmtpDeliveryMethod.Network;
                        client.Send(msg);
                    }
                return "succses";
                }
                catch (Exception e)
                {
                return "filed";

                }
        }

       
        //פונקצית
        //GET 
        //פונקציה שמיבאת משתמשים לבריכה מסוימת על פי קוד בריכה
        public List<CustomerToPool> GetByIdPool(int IdPool)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                string EmailBody = "hb05331875890@gmail.com";
               //send(EmailBody);
                return db.CustomerToPools.Include("Package").Include("User").Where(x => x.Package.IdPool == IdPool).ToList();
            }

        }
        //פונקציה שמביאה היסטורית קניות של לקוח 
        public List<CustomerToPool> GetHistoryOfUser(int IdUser)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                return db.CustomerToPools.Include("Package").Include("User").Where(x => x.IdUser == IdUser&&x.Status==true).ToList();
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
        public CustomerToPool Put(int Id, int AmountGet)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                CustomerToPool newCustomr_To_Pool = db.CustomerToPools.FirstOrDefault(x => x.Id == Id);
                newCustomr_To_Pool.AmountGet = AmountGet;
                if (AmountGet == newCustomr_To_Pool.AmountLeft)
                    newCustomr_To_Pool.Status = false; 
                db.SaveChanges();
                return db.CustomerToPools.Include("Package").Include("User").FirstOrDefault(x=>x.Id==Id);
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
