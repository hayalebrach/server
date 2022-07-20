using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PackegeDTO
    {
        public int Id { get; set; }
        public Nullable<int> PoolId { get; set; }
        public Nullable<int> EntersAmount { get; set; }
        public Nullable<int> Price { get; set; }
    }
}
