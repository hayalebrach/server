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
        public int Phone { get; set; }
        //public Nullable<int> Type { get; set; }
        //public Nullable<System.DateTime> LastEentry { get; set; }

        public int Password { get; set; }
        public bool Type { get; set; }
        public int IdRole { get; set; }
        public DateTime LastEntery { get; set; }


    }
}
