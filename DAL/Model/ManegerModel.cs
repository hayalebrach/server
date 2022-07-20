using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class ManegerModel
    {
        //פונקצית
        //GET 
        //שמחזירה את השעות פעילות
        public List<Maneger> Get()
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
                return db.Manegers.ToList();
        }

        public Maneger Get(int Id)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                Maneger Maneger = new Maneger();

                return db.Manegers.FirstOrDefault(x => x.Id == Id);
            }
        }
        //
        public Maneger Post(Maneger Maneger)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {

                Maneger = db.Manegers.Add(Maneger);
                db.SaveChanges();
                return Maneger;

            }
        }
        //פונקצית עדכון
        public Maneger Put(Maneger Maneger)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                Maneger newManeger = db.Manegers.FirstOrDefault(x => x.Id == Maneger.Id);
                newManeger.Id = Maneger.Id;
                newManeger.Name = Maneger.Name;
                newManeger.Phone = Maneger.Phone;
                newManeger.Email = Maneger.Email;
                db.SaveChanges();
                return Maneger;

            }
        }
        //פונקצית מחיקה
        public Maneger Delete(Maneger Maneger)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                Maneger newManeger = db.Manegers.Remove(Maneger);
                db.SaveChanges();
                return Maneger;

            }
        }
    }
}
