using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DayToCoursDTO
    {
        public int Id { get; set; }
        public int IdCours { get; set; }
        public int IdDays { get; set; }
        public Nullable<System.TimeSpan> StartHour { get; set; }
        public Nullable<System.TimeSpan> EndHour { get; set; }
        public Nullable<bool> Type { get; set; }
        public int IdPool { get; set; }
        public Nullable<bool> Status { get; set; }

    }
}
