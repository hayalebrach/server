//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class RolesToPool
    {
        public int Id { get; set; }
        public int IdRole { get; set; }
        public int IdUser { get; set; }
        public int IdPool { get; set; }
    
        public virtual Pool Pool { get; set; }
        public virtual Role Role { get; set; }
        public virtual User User { get; set; }
    }
}
