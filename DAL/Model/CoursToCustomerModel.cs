using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class CoursToCustomerModel
    {
        public CoursToCustomer Course_Enrollment(CoursToCustomer user)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {

                user = db.CoursToCustomers.Add(user);

                db.SaveChanges();
                return user;

            }


            
        }

        public List<CoursToCustomer> GetCoursesByUser(int IdUser)
        {

            using (SwimMoodEntities db = new SwimMoodEntities())
            {

                return db.CoursToCustomers.Where(x => x.IdUser == IdUser).ToList();

            }
        }
    }
}
