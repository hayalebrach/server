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
        //פונקציה שמביאה כרטיסים לבריכה מסוימת
        public List<Package> GetCardsByIdPool(int IdPool)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                List<Package> CardsToPool = new List<Package>();
                foreach (Package p in db.Packages)
                {
                    if(p.IdPool == IdPool)
                    CardsToPool.Add(p);
                } 
                 return CardsToPool;
            }
               
        }
        public Package Get(int Id)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                Package Package = new Package();

                return db.Packages.FirstOrDefault(x => x.Id == Id);
            }
        }
        //מוסיפה כרטיסיה
        public Package AddCard(Package Package)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {

                Package = db.Packages.Add(Package);
                db.SaveChanges();
                return Package;

            }
        }
        //פונקצית עדכון
        public Package Put(Package Package)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                Package newPackege = db.Packages.FirstOrDefault(x => x.Id == Package.Id);
                newPackege.Id = Package.Id;
                newPackege.EntersAmount = Package.EntersAmount;
                newPackege.Price = Package.Price;
                db.SaveChanges();
                return Package; 
    }
        }
        //פונקצית מחיקה
        public Package Delete(Package Package)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                Package newPackege = db.Packages.Remove(Package);
                db.SaveChanges();
                return Package;

            }
        }

    }
}
