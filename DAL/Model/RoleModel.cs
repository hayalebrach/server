using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class RoleModel
    {
        //ייבוא של כל התפקידים
        public List<Role> GetAllRole()
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
                return db.Roles.ToList();
        }

        //הוספת תפקיד
        public Role AddRole(DAL.Role role)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                role = db.Roles.Add(role);
                db.SaveChanges();
                return role;

            }
        }

        //פונקצית עדכון
        public Role Put(Role Role)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                Role newCustomr_To_Pool = db.Roles.FirstOrDefault(x => x.Id == Role.Id);
                newCustomr_To_Pool.Id = Role.Id;
                db.SaveChanges();
                return Role;
            }

        }
        //פונקצית מחיקה
        public Role Delete(Role Role)
        {
            using (SwimMoodEntities db = new SwimMoodEntities())
            {
                Role newCustomr_To_Pool = db.Roles.Remove(Role);
                db.SaveChanges();
                return Role;

            }
        }

    }
}
