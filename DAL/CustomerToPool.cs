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
    
    public partial class CustomerToPool
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CustomerToPool()
        {
            this.EnterCustomers = new HashSet<EnterCustomer>();
        }
    
        public int Id { get; set; }
        public Nullable<int> IdPackages { get; set; }
        public Nullable<int> IdUser { get; set; }
        public Nullable<int> AmountLeft { get; set; }
        public Nullable<int> AmountGet { get; set; }
        public Nullable<int> TotalPrice { get; set; }
        public Nullable<System.DateTime> DateBuy { get; set; }
    
        public virtual Package Package { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EnterCustomer> EnterCustomers { get; set; }
    }
}