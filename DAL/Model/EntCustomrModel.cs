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
        public List<EnterCustomer> Get()
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
                return db.EnterCustomers.ToList();
        }


        public EnterCustomer Get(int Id)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                EnterCustomer EnterCustomer = new EnterCustomer();

                return db.EnterCustomers.FirstOrDefault(x => x.Id == Id);
            }
        }
        //
        public EnterCustomer Post(EnterCustomer EnterCustomer)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {

                EnterCustomer = db.EnterCustomers.Add(EnterCustomer);
                db.SaveChanges();
                return EnterCustomer;

            }
        }
        //פונקצית עדכון
        public EnterCustomer Put(EnterCustomer EnterCustomer)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                EnterCustomer newEntCustomr = db.EnterCustomers.FirstOrDefault(x => x.Id == EnterCustomer.Id);
                newEntCustomr.Id = EnterCustomer.Id;
                newEntCustomr.EnterDate = EnterCustomer.EnterDate;
                newEntCustomr.StartHour = EnterCustomer.StartHour;
                db.SaveChanges();
                return EnterCustomer;
    }
        }
        //פונקצית מחיקה
        public EnterCustomer Delete(EnterCustomer EnterCustomer)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                EnterCustomer newEntCustomr = db.EnterCustomers.Remove(EnterCustomer);
                db.SaveChanges();
                return EnterCustomer;

            }
        }
    }
}
