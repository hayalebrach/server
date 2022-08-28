using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    //public class poolCorsDTO:PoolDTO
    //{
    //    public List<CoursDTO> Corses { get; set; }
    //}
    public class PoolDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public Nullable<int> Price { get; set; }
        public Nullable<int> Amount { get; set; }
        public Nullable<int> ManagerId { get; set; }
        public Nullable<int> PositionId { get; set; }
    }
}
