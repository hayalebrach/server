using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Nullable<int> Type { get; set; }
        public Nullable<int> Authorization { get; set; }
        public Nullable<System.DateTime> LastEentry { get; set; }
    }
}
