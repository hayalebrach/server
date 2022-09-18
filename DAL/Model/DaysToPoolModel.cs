using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class DaysToPoolModel
    {
        public List<DaysToPool> Get()
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                return db.DaysToPools.ToList();
            }
        }
        public DaysToPool Get(int Id)
        {

            using (SwimMoodEntities db = new SwimMoodEntities())
            {

                return db.DaysToPools.FirstOrDefault(x => x.Id == Id);
            }
        }
        //

        public DaysToPool AddDaysToPool(DaysToPool DaysToPool)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {

                DaysToPool = db.DaysToPools.Add(DaysToPool);
                db.SaveChanges();
                return DaysToPool;

            }
        }

        //פונקצית עדכון
        public DaysToPool Put(DaysToPool DaysToPool)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                DaysToPool newDaysToPool = db.DaysToPools.FirstOrDefault(x => x.Id == DaysToPool.Id);
                newDaysToPool.Id = DaysToPool.Id;
                db.SaveChanges();
                return DaysToPool;

            }
        }

        //פונקצית מחיקה
        public DaysToPool Delete(DaysToPool DaysToPool)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                DaysToPool newDaysToPool = db.DaysToPools.Remove(DaysToPool);
                db.SaveChanges();
                return DaysToPool;

            }
        }
    }
}
