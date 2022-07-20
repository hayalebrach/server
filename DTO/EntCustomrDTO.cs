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
        public Nullable<int> PoolId { get; set; }
        public Nullable<int> CustomerToPool_Id { get; set; }
        public Nullable<System.DateTime> EnterDate { get; set; }
        public Nullable<System.TimeSpan> StartHour { get; set; }
        public Nullable<System.TimeSpan> FinishHour { get; set; }
    }
}
