using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class EreaModel
    {
        //פונקצית
        //GET 
        //שמחזירה את כל האיזורים
        public List<Erea> GetAllEreas()
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                return db.Ereas.ToList();
            }
        }
        //פונקציה שמחזירה לי אוביקט שהשם שלו שווה לשם שהיא קיבלה
        public Erea GetByName(string Name)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                Erea Erea = new Erea();

                return db.Ereas.FirstOrDefault(x => x.Name == Name);
            }
        }
        public Erea Get(int Id)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                Erea Erea = new Erea();

                return db.Ereas.FirstOrDefault(x => x.Id == Id);
            }
        }
        //
        public Erea Post(Erea Erea)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {

                Erea = db.Ereas.Add(Erea);
                db.SaveChanges();
                return Erea;

            }
        }
        //פונקצית עדכון
        public Erea Put(Erea Erea)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                Erea newErea = db.Ereas.FirstOrDefault(x => x.Id == Erea.Id);
                newErea.Id = Erea.Id;
                newErea.Name = Erea.Name;
                db.SaveChanges();
                return Erea;

            }
        }
        //פונקצית מחיקה
        public Erea Delete(Erea Erea)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                Erea newErea = db.Ereas.Remove(Erea);
                db.SaveChanges();
                return Erea;

            }
        }
    }
}
