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
                return db.Courses.ToList();
            }
        }

        public Course Get(int Id)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {

                return db.Courses.FirstOrDefault(x => x.Id == Id);
            }
        }
        //
        public Course Post(Course Course)
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
                Course newCour = db.Courses.FirstOrDefault(x => x.Id == Course.Id);
                newCour.Id = Course.Id;
                newCour.PeopleAmount = Course.PeopleAmount;
                newCour.Dis = Course.Dis;
                db.SaveChanges();
                return Course;

            }
        }

        //פונקצית מחיקה
        public Course Delete(Course Course)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                Course newCour = db.Courses.Remove(Course);
                db.SaveChanges();
                return Course;

            }
        }

    }





}
