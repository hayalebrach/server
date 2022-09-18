using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class SaleModel
    {
        //פונקצית
        //GET 
        //שמחזירה את השעות פעילות
        public List<Sale> Get()
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
                return db.Sales.ToList();
        }

        public Sale Get(int Id)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                Sale Sale = new Sale();

                return db.Sales.FirstOrDefault(x => x.Id == Id);
            }
        }
        //
        public Sale AddSale(Sale Sale)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {

                Sale = db.Sales.Add(Sale);
                db.SaveChanges();
                return Sale;

            }
        }
        //פונקצית עדכון
        public Sale Put(Sale Sale)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                Sale newSale = db.Sales.FirstOrDefault(x => x.Id == Sale.Id);
                newSale.Id = Sale.Id;
                newSale.Dis = Sale.Dis;
                newSale.StartDate = Sale.StartDate;
                newSale.EndDate = Sale.EndDate;
                newSale.Price = Sale.Price;
                db.SaveChanges();
                return Sale;
    }
        }
        //פונקצית מחיקה
        public Sale Delete(Sale Sale)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                Sale newSale = db.Sales.Remove(Sale);
                db.SaveChanges();
                return Sale;

            }
        }
    }
}
