using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    //public  class UserAndPoolDTO : PackegeDTO
    //{
    //    public List<Customr_To_PoolDTO> Customr_To_Pool { get; set; }
    //}
    public class PackegeDTO
    {
        public int Id { get; set; }
        public Nullable<int> IdPool { get; set; }
        public Nullable<int> EntersAmount { get; set; }
        public Nullable<int> Price { get; set; }
     
    }
}
