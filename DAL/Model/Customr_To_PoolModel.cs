using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Customr_To_PoolModel
    {
        //פונקצית
        //GET 
        //פונקציה שמיבאת משתמשים לבריכה מסוימת על פי קוד בריכה
        public List<CustomerToPool> GetByIdPool(int IdPool)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                return db.CustomerToPools.Include("Package").Include("User").Where(x=>x.Package.IdPool==IdPool).ToList();
            }

        }
        //פונקציה שמביאה היסטורית קניות של לקוח בבריכה מסוימת
        public List<CustomerToPool> GetHistoryOfUser(int IdUser)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                return db.CustomerToPools.Include("Package").Include("User").Where(x => x.IdUser==IdUser).ToList();
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
