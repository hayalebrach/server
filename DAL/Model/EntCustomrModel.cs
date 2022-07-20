using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class EntCustomrModel
    {

        //פונקצית
        //GET 
        //שמחזירה את השעות פעילות
        public List<EntCustomr> Get()
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
                return db.EntCustomrs.ToList();
        }


        public EntCustomr Get(int Id)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                EntCustomr EntCustomr = new EntCustomr();

                return db.EntCustomrs.FirstOrDefault(x => x.Id == Id);
            }
        }
        //
        public EntCustomr Post(EntCustomr EntCustomr)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {

                EntCustomr = db.EntCustomrs.Add(EntCustomr);
                db.SaveChanges();
                return EntCustomr;

            }
        }
        //פונקצית עדכון
        public EntCustomr Put(EntCustomr EntCustomr)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                EntCustomr newEntCustomr = db.EntCustomrs.FirstOrDefault(x => x.Id == EntCustomr.Id);
                newEntCustomr.Id = EntCustomr.Id;
                newEntCustomr.PoolId = EntCustomr.PoolId;
                newEntCustomr.CustomerToPool_Id = EntCustomr.CustomerToPool_Id;
                newEntCustomr.EnterDate = EntCustomr.EnterDate;
                newEntCustomr.StartHour = EntCustomr.StartHour;
                newEntCustomr.FinishHour = EntCustomr.FinishHour;
                db.SaveChanges();
                return EntCustomr;
    }
        }
        //פונקצית מחיקה
        public EntCustomr Delete(EntCustomr EntCustomr)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                EntCustomr newEntCustomr = db.EntCustomrs.Remove(EntCustomr);
                db.SaveChanges();
                return EntCustomr;

            }
        }
    }
}
