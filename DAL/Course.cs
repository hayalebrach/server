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
    
    public partial class Course
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Course()
        {
            this.CoursToCustomers = new HashSet<CoursToCustomer>();
            this.DaysToCours = new HashSet<DaysToCour>();
        }
    
        public int Id { get; set; }
        public Nullable<int> IdPool { get; set; }
        public string NameCours { get; set; }
        public Nullable<int> PeopleAmount { get; set; }
        public string Dis { get; set; }
        public Nullable<int> IdUser { get; set; }
        public Nullable<bool> Status { get; set; }
    
        public virtual Pool Pool { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CoursToCustomer> CoursToCustomers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DaysToCour> DaysToCours { get; set; }
    }
}
