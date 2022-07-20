using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class ActiveHourModel
    {
        //פונקצית
        //GET 
        //שמחזירה את השעות פעילות
        public List<ActiveHour> Get()
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
                return db.ActiveHours.ToList();
        }

        public ActiveHour Get(int Id)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                ActiveHour activeHour = new ActiveHour();

                return db.ActiveHours.FirstOrDefault(x => x.Id == Id);
            }
        }
        //
        public ActiveHour Post(ActiveHour ActiveHour)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {

                ActiveHour = db.ActiveHours.Add(ActiveHour);
                db.SaveChanges();
                return ActiveHour;

            }
        }
        //פונקצית עדכון
        public ActiveHour Put(ActiveHour ActiveHour)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                ActiveHour newActiveHour = db.ActiveHours.FirstOrDefault(x => x.Id == ActiveHour.Id);
                newActiveHour.Id = ActiveHour.Id;
                newActiveHour.PoolId = ActiveHour.PoolId;
                newActiveHour.Day = ActiveHour.Day;
                newActiveHour.OpenHour = ActiveHour.OpenHour;
                newActiveHour.CloseHour = ActiveHour.CloseHour;
                newActiveHour.Type = ActiveHour.Type;
                db.SaveChanges();
                return ActiveHour;

            }
        }
        //פונקצית מחיקה
        public ActiveHour Delete(ActiveHour ActiveHour)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                ActiveHour newActiveHour = db.ActiveHours.Remove(ActiveHour);
                db.SaveChanges();
                return ActiveHour;

            }
        }

    }
}
