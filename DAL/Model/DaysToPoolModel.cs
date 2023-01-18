using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class DaysToPoolModel
    {
        //לוקחת שעה בבריכה לפי ת"ז
        public DaysToPool Get(int Id)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                return db.DaysToPools.FirstOrDefault(x=>x.Id==Id&&x.Status==true);
            }
        }
        //לוקחת מערכת שעות לבריכה
        public List<DaysToPool> GetTimeByIdPool(int IdPool)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                return db.DaysToPools.Where(x=>x.IdPool==IdPool&&x.Status==true).ToList();
            }
        }

        public DaysToPool AddDaysToPool(DaysToPool DaysToPool)
        {

            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                List<DaysToPool> daysToPoolList = new List<DaysToPool>();
                daysToPoolList = db.DaysToPools.Where(x => x.IdPool == DaysToPool.IdPool && x.IdDays == DaysToPool.IdDays).ToList();
                //על דרך השלילה
                //שעת התחלה של פרמטר מתקבל גדולה משעת סיום של פרמטרים שיש לנו
                //ושעת סיום של פרמטר מתקבל קטנה משעת התחלה של פרמטר שיש לנו
                int num = daysToPoolList.FindIndex(x => !(x.EndHour <= DaysToPool.StartHour || x.StartHour >= DaysToPool.EndHour));
                //אם NUM שווה למינוס 1 זה אמר שהוא לא מצא ואז זה טובולכן יוסיף 
                if (num == -1)
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
