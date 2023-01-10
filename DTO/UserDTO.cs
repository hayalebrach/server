using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UserMInDTO
    { 
        public int Id { get; set; }
        public string Name { get; set; }
    }

        public class UserDTO:UserMInDTO
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public Nullable<bool> Type { get; set; }
        public int IdRole { get; set; }
        public Nullable<System.DateTime> LastEntery { get; set; }
        public string Phone { get; set; }
        public Nullable<bool> Status { get; set; }

    }
    public class UserWithCorse : UserDTO
    {
        public List<CoursDTO> coursec { get; set; }
        public PoolDTO pool { get; set; }
    }
}
