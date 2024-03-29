﻿using System;
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

        public List<Package> GetAllCards()
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
                return db.Packages.ToList();
        }

         //לוקחת כרטיס לפי ת"ז
        public Package GetCardsById(int Id)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                return db.Packages.FirstOrDefault(x => x.Id == Id&&x.Status==true);
            }
        }

        //פונקציה שמביאה כרטיסים לבריכה מסוימת
        public List<Package> GetCardsByIdPool(int IdPool)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                return db.Packages.Where(x => x.IdPool == IdPool && x.Status==true).ToList();
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
                newPackege.EntersAmount = Package.EntersAmount;
                newPackege.Price = Package.Price;
                newPackege.Status = true;
                db.SaveChanges();
                return Package; 
            }
        }
        //פונקצית מחיקה
        public Package PutForDelete(Package Package)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                Package newPackege = db.Packages.FirstOrDefault(x => x.Id == Package.Id);
                newPackege.Status = false;
                newPackege.Price=Package.Price;
                newPackege.EntersAmount=Package.EntersAmount;
                db.SaveChanges();
                return Package;
            }
        }


    }
}
