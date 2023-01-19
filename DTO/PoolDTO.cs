using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    //public class poolCorsDTO : PoolDTO
    //{
    //    public List<CoursDTO> Corses { get; set; }
        
    //}
    //public class Pool_CustomerToPoolDTO : PoolDTO
    //{
    //    public List<Cours_To_CustomerDTO> customerToPool { get; set; }
    //}
    public class PoolDTO
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public Nullable<int> Price { get; set; }
        public Nullable<int> Amount { get; set; }
        public int IdUser { get; set; }
        public int IdErea { get; set; }
        public string Phone { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<int> Lat { get; set; }
        public Nullable<int> Lng { get; set; }
        public string Dis { get; set; }
        public string Pic { get; set; }


    }
}
