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
    
    public partial class Cour
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cour()
        {
            this.Cours_To_Customer = new HashSet<Cours_To_Customer>();
        }
    
        public int Id { get; set; }
        public Nullable<int> PoolId { get; set; }
        public string Name { get; set; }
        public Nullable<int> PeopleAmount { get; set; }
        public string Dis { get; set; }
        public Nullable<int> Price { get; set; }
        public Nullable<System.TimeSpan> StartHour { get; set; }
        public Nullable<System.TimeSpan> EndHour { get; set; }
        public Nullable<int> Day { get; set; }
        public Nullable<int> Type { get; set; }
    
        public virtual Pool Pool { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cours_To_Customer> Cours_To_Customer { get; set; }
    }
}
