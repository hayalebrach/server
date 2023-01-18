using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CoursDTO
    {
        //פלאפון מדריך
        public Nullable<int> PhoneGuide { get; set; }
        //אימייל מדריך
        public string EmailGuide { get; set; }
        //שם הבריכה
        public string PoolName { get; set; }

        public int Id { get; set; }
        public int IdPool { get; set; }
        public string NameCours { get; set; }
        public Nullable<int> PeopleAmount { get; set; }
        public string Dis { get; set; }
        public int IdUser { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<int> Price { get; set; }
        public int IdPic { get; set; }


        public Nullable<System.TimeSpan> StartHour { get; set; }
        public Nullable<System.TimeSpan> EndHour { get; set; }
        public Nullable<int> Day { get; set; }
        public Nullable<int> Type { get; set; }


    }
}
