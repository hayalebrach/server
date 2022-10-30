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

        //public List<CustomerToPool> GetByIdPool(int IdPool)
        //{
        //    using (SwimMoodEntities db = new SwimMoodEntities())
        //    {
        //        Package package = new Package();
        //        CustomerToPool pool = new CustomerToPool();
        //        //return db.CustomerToPools.Where(pool.IdPackages.Select()package.Id);
        //    }
             
        //}

        public CustomerToPool Get(int Id)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                CustomerToPool CustomerToPool = new CustomerToPool();

                return db.CustomerToPools.FirstOrDefault(x => x.Id == Id);
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
