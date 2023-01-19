using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class DaysToCoursModel
    {
        //לוקחת מערכת שעות לבריכה
        public List<DaysToCour> GetTimeByIdPool(int IdPool)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                return db.DaysToCours.Where(x => x.IdPool == IdPool && x.Status == true).ToList();
            }
        }
        //מוסיפה שעה לבריכה
        public DaysToCour AddDaysToCours(DaysToCour DaysToCours)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                List<DaysToCour> daysToPoolList = new List<DaysToCour>();
                daysToPoolList = db.DaysToCours.Where(x => x.IdPool == DaysToCours.IdPool && x.IdDays == DaysToCours.IdDays).ToList();
                //על דרך השלילה
                //שעת התחלה של פרמטר מתקבל גדולה משעת סיום של פרמטרים שיש לנו
                //ושעת סיום של פרמטר מתקבל קטנה משעת התחלה של פרמטר שיש לנו
                int num = daysToPoolList.FindIndex(x => !(x.EndHour <= DaysToCours.StartHour || x.StartHour >= DaysToCours.EndHour));
                //אם NUM שווה למינוס 1 זה אמר שהוא לא מצא ואז זה טובולכן יוסיף 
                if (num == -1)
                {
                    DaysToCours.Status = true;
                    DaysToCours = db.DaysToCours.Add(DaysToCours);
                }             
                db.SaveChanges();
                return DaysToCours;
            }
        }



    }
}
