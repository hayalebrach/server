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
        public List<Package> Get()
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
                return db.Packages.ToList();
        }
        public Package Get(int Id)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                Package Package = new Package();

                return db.Packages.FirstOrDefault(x => x.Id == Id);
            }
        }
        //
        public Package Post(Package Package)
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
