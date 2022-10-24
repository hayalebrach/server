using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class poolCorsDTO : PoolDTO
    {
        public List<CoursDTO> Corses { get; set; }
        
    }
    //public class Pool_CustomerToPoolDTO : PoolDTO
    //{
    //    public List<Cours_To_CustomerDTO> customerToPool { get; set; }
    //}
    public class PoolDTO
    {
        public string Phone { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public Nullable<int> Price { get; set; }
        public Nullable<int> Amount { get; set; }
        public Nullable<int> IdUser { get; set; }
        public Nullable<int> IdErea { get; set; }
        //public  Pool_CustomerToPoolDTO [] pool_CustomerToPoolDTO { get; set; }
 
    }
}
