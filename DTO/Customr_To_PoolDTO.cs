using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{

    public class Customr_To_PoolDTO
    {
        public int Id { get; set; }
        public int IdPackage { get; set; }
        public int UserId { get; set; }
        //public int PoolId { get; set; }
        public int AmountLeft { get; set; }
        public int AmountGet { get; set; }
        public int TotalPrice { get; set; }
        public Nullable<System.DateTime> DateBuy { get; set; }
    }
}
