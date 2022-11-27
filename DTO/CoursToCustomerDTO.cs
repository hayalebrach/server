using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
     public  class CoursToCustomerDTO
    {
        public int Id { get; set; }
        public Nullable<int> IdUser { get; set; }
        public Nullable<int> IdCours { get; set; }
        public bool Status { get; set; }

        

    }
}
