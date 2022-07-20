﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Customr_To_PoolDTO
    {
        public int Id { get; set; }
        public Nullable<int> PackageId { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> AmountLeft { get; set; }
        public Nullable<int> AmountGet { get; set; }
        public Nullable<int> TotalPrice { get; set; }
        public Nullable<System.DateTime> DateBuy { get; set; }
    }
}
