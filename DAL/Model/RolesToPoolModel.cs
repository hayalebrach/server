using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class RolesToPoolModel
    {
        //פונקציה שמכניסה מדריך לקורס ולבריכה
        public RolesToPool AddGuide(RolesToPool RolesToPool)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                RolesToPool = db.RolesToPools.Add(RolesToPool);
                db.SaveChanges();
                return RolesToPool;
            }
        }

        //פונקציה שלוקחת מדריכים לבריכות
        public List<RolesToPool> GetTheGuideToPool(int IdPool)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                return db.RolesToPools.Where(p => p.Id == IdPool&&p.IdRole==3).ToList();
            }
        }
        
    }
}
