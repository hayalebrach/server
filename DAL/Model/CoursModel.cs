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

              return  db.Courses.Include("pool").Where(x=>x.IdPool==IdPool).ToList();
                //List<Course> x = new List<Course>();
                //foreach(Course c in db.Courses)
                //{
                //    if(c.IdPool == IdPool)
                //    x.Add(c);
                //}
                //return x;
            }
        }
        //

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
        public Course UpdateCourse(Course Course)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                Course newCour = db.Courses.FirstOrDefault(x => x.Id == Course.Id);
                newCour.Id = Course.Id;
                newCour.PeopleAmount = Course.PeopleAmount;
                newCour.Dis = Course.Dis;
                db.SaveChanges();
                return Course;

            }
        }

        //פונקצית מחיקה
        public Course DeleteCourse(int Id)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                Course Cour = db.Courses.FirstOrDefault(x => x.Id == Id);
                //db.Courses.Remove(Cour);
                db.SaveChanges();
                return Cour;

            }
        }

        

        
        

    }





}
