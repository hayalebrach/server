﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
     public  class CoursToCustomerDTO
    {
        public int Id { get; set; }
<<<<<<< Updated upstream
        public Nullable<int> IdUser { get; set; }
        public Nullable<int> IdCours { get; set; }
        public bool Status { get; set; }
=======
        public int IdUser { get; set; }
        public int IdCours { get; set; }
        public Nullable<bool> Status { get; set; }
>>>>>>> Stashed changes

    }
}
