using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class PoolModel
    {
        //לוקחת את כל הבריכות
        public List<Pool> GetAllPools()
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
                return db.Pools.Where(x=>x.Status==true).ToList();
        }
        //הוספת בריכה
        public Pool AddPool(Pool Pool)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                Pool.Status = true;
                Pool = db.Pools.Add(Pool);
                db.SaveChanges();
                return Pool;

            }
        }
        public Pool Get(int Id)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                Pool Pool = new Pool();

                return db.Pools.FirstOrDefault(x => x.Id == Id&&x.Status==true);
            }
        }
        
        //פונקצית עדכון
        public Pool Put(Pool Pool)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                Pool newPool = db.Pools.FirstOrDefault(x => x.Id == Pool.Id);
                newPool.Id = Pool.Id;
                newPool.Name = Pool.Name;
                newPool.Price = Pool.Price;
                newPool.Amount = Pool.Amount;
                db.SaveChanges();
                return Pool;
    }
        }
        //פונקצית מחיקה
        public Pool Delete(Pool Pool)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                Pool newPool = db.Pools.Remove(Pool);
                db.SaveChanges();
                return Pool;

            }
        }
    }
}
