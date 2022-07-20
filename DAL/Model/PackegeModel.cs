using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class PackegeModel
    {
        //פונקצית
        //GET 
        //שמחזירה את השעות פעילות
        public List<Packege> Get()
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
                return db.Packeges.ToList();
        }
        public Packege Get(int Id)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                Packege Packege = new Packege();

                return db.Packeges.FirstOrDefault(x => x.Id == Id);
            }
        }
        //
        public Packege Post(Packege Packege)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {

                Packege = db.Packeges.Add(Packege);
                db.SaveChanges();
                return Packege;

            }
        }
        //פונקצית עדכון
        public Packege Put(Packege Packege)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                Packege newPackege = db.Packeges.FirstOrDefault(x => x.Id == Packege.Id);
                newPackege.Id = Packege.Id;
                newPackege.PoolId = Packege.PoolId;
                newPackege.EntersAmount = Packege.EntersAmount;
                newPackege.Price = Packege.Price;
                db.SaveChanges();
                return Packege; 
    }
        }
        //פונקצית מחיקה
        public Packege Delete(Packege Packege)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                Packege newPackege = db.Packeges.Remove(Packege);
                db.SaveChanges();
                return Packege;

            }
        }

    }
}
