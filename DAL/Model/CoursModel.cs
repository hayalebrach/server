using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class CoursModel
    {
        //פונקצית
        //GET 
        //שמחזירה את השעות פעילות
        public List<Cour> Get()
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
                return db.Cours.ToList();
        }

        public Cour Get(int Id)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                Cour Cour = new Cour();

                return db.Cours.FirstOrDefault(x => x.Id == Id);
            }
        }
        //
        public Cour Post(Cour Cour)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {

                Cour = db.Cours.Add(Cour);
                db.SaveChanges();
                return Cour;

            }
        }
     
        //פונקצית עדכון
        public Cour Put(Cour Cour)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                Cour newCour = db.Cours.FirstOrDefault(x => x.Id == Cour.Id);
                newCour.Id = Cour.Id;
                newCour.PoolId = Cour.PoolId;
                newCour.Name = Cour.Name;
                newCour.PeopleAmount = Cour.PeopleAmount;
                newCour.Dis = Cour.Dis;
                newCour.Price = Cour.Price;
                newCour.StartHour = Cour.StartHour;
                newCour.EndHour = Cour.EndHour;
                newCour.Day = Cour.Day;
                newCour.Type = Cour.Type;
                db.SaveChanges();
                return Cour;

            }
        }

        //פונקצית מחיקה
        public Cour Delete(Cour Cour)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                Cour newCour = db.Cours.Remove(Cour);
                db.SaveChanges();
                return Cour;

            }
        }

    }





}
