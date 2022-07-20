using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Customr_To_PoolModel
    {
        //פונקצית
        //GET 
        //שמחזירה את השעות פעילות
        public List<Customr_To_Pool> Get()
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
                return db.Customr_To_Pool.ToList();
        }

        public Customr_To_Pool Get(int Id)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                Customr_To_Pool Customr_To_Pool = new Customr_To_Pool();

                return db.Customr_To_Pool.FirstOrDefault(x => x.Id == Id);
            }
        }
        //
        public Customr_To_Pool Post(Customr_To_Pool Customr_To_Pool)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {

                Customr_To_Pool = db.Customr_To_Pool.Add(Customr_To_Pool);
                db.SaveChanges();
                return Customr_To_Pool;

            }
        }
        //פונקצית עדכון
        public Customr_To_Pool Put(Customr_To_Pool Customr_To_Pool)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                Customr_To_Pool newCustomr_To_Pool = db.Customr_To_Pool.FirstOrDefault(x => x.Id == Customr_To_Pool.Id);
                newCustomr_To_Pool.Id = Customr_To_Pool.Id;
                newCustomr_To_Pool.PackageId = Customr_To_Pool.PackageId;
                newCustomr_To_Pool.UserId = Customr_To_Pool.UserId;
                newCustomr_To_Pool.AmountLeft = Customr_To_Pool.AmountLeft;
                newCustomr_To_Pool.AmountGet = Customr_To_Pool.AmountGet;
                newCustomr_To_Pool.TotalPrice = Customr_To_Pool.TotalPrice;
                newCustomr_To_Pool.DateBuy = Customr_To_Pool.DateBuy;
                db.SaveChanges();
                return Customr_To_Pool;
            }
    
        }
        //פונקצית מחיקה
        public Customr_To_Pool Delete(Customr_To_Pool Customr_To_Pool)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                Customr_To_Pool newCustomr_To_Pool = db.Customr_To_Pool.Remove(Customr_To_Pool);
                db.SaveChanges();
                return Customr_To_Pool;

            }
        }

    }
}
