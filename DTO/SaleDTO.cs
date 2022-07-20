using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SaleDTO
    {
        public int Id { get; set; }
        public Nullable<int> PoolId { get; set; }
        public string Dis { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<int> EnteriesAmount { get; set; }
        public Nullable<int> Price { get; set; }
    }
}
