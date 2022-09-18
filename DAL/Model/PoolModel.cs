using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class PoolModel
    {
        //פונקצית
        //GET 
        //שמחזירה את השעות פעילות
        public List<Pool> GetAllPools()
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
                return db.Pools.ToList();
        }

        public Pool Get(int Id)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                Pool Pool = new Pool();

                return db.Pools.FirstOrDefault(x => x.Id == Id);
            }
        }
        //
        public Pool Post(Pool Pool)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {

                Pool = db.Pools.Add(Pool);
                db.SaveChanges();
                return Pool;

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
