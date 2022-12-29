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
        public List<Course> Get()
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                return db.Courses.Include("Pool").ToList();
            }
        }

        public List<Course> GetCoursesByPool(int IdPool)
        {

            using (SwimMoodEntities db = new SwimMoodEntities())
            {
              return  db.Courses.Include("pool").Include("user").Where(x=>x.IdPool==IdPool&&x.Status==true).ToList();
            }
        }

        
        //הוספת קורס

        public Course AddCourse(Course Course)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {

                Course = db.Courses.Add(Course);
                
                db.SaveChanges();
                return Course;

            }
        }
        //פונקצית עדכון
        public Course Put(Course Course)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                Course newCourse = db.Courses.FirstOrDefault(x => x.Id == Course.Id);
                newCourse.NameCours = Course.NameCours;
                newCourse.PeopleAmount = Course.PeopleAmount;
                newCourse.Dis = Course.Dis; 
                newCourse.Price = Course.Price;
                newCourse.Status = true;
                db.SaveChanges();
                return Course;
            }
        }

        //פונקצית מחיקה
        public Course PutForDelete(Course Course)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                Course newPackege = db.Courses.FirstOrDefault(x => x.Id == Course.Id);
                newPackege.Status = false;         
                db.SaveChanges();
                return Course;
            }
        }






    }





}
