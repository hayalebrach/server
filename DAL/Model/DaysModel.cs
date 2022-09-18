using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class DaysModel
    {
        public List<Day> Get()  //כל המשתמשים
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
                return db.Days.ToList();
        }
    }
}
