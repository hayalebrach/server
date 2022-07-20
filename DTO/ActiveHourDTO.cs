
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ActiveHourDTO
    {
        public int Id { get; set; }
        public Nullable<int> PoolId { get; set; }
        public Nullable<int> Day { get; set; }
        public Nullable<System.TimeSpan> OpenHour { get; set; }
        public Nullable<System.TimeSpan> CloseHour { get; set; }
        public Nullable<int> Type { get; set; }

    }
}
