using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class EntCustomrDTO
    {
        public int Id { get; set; }
        public int IdPool { get; set; }
        public Nullable<System.DateTime> EnterDate { get; set; }
        public int IdCustomerToPool { get; set; }
        public Nullable<System.TimeSpan> StartHour { get; set; }
        public Nullable<System.TimeSpan> EndHour { get; set; }
        public Nullable<int> NumPeople { get; set; }
        public Nullable<bool> Status { get; set; }
    }
}
