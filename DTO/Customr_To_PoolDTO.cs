using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{

    public class Customr_To_PoolDTO
    {
        //כל אלא הם משתנים שיש אותם בכרטיסים צריך לבדוק
        //איך אני משתמשת בכל האוביקט במקום כל פעם 
        //להביא לי משתנה אחר שאני צריכה
        public int IdPackage { get; set; }
        public int IdPool { get; set; }
        public Nullable<int> EntersAmount { get; set; }
        public Nullable<int> Price { get; set; }
        //-----------------------------------------------------------//
        public string PasswordUser { get; set; }
        public string NameUser { get; set; }
<<<<<<< Updated upstream
        public string PasswordUser { get; set; }
        public Nullable<int> IdUser { get; set; }
=======
        public string EmailUser { get; set; }

        //-----------------------------------------------------------//
        public int Id { get; set; }
        public int IdUser { get; set; }
>>>>>>> Stashed changes
        public Nullable<int> AmountLeft { get; set; }
        public Nullable<int> AmountGet { get; set; }
        public Nullable<int> TotalPrice { get; set; }
        public Nullable<System.DateTime> DateBuy { get; set; }
        public Nullable<bool> Status { get; set; }

    }
}
