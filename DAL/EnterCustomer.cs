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
    
    public partial class EnterCustomer
    {
        public int Id { get; set; }
        public int IdPool { get; set; }
        public Nullable<System.DateTime> EnterDate { get; set; }
        public int IdCustomerToPool { get; set; }
        public Nullable<System.TimeSpan> StartHour { get; set; }
        public Nullable<System.TimeSpan> EndHour { get; set; }
        public Nullable<int> NumPeople { get; set; }
        public Nullable<bool> Status { get; set; }
    
        public virtual CustomerToPool CustomerToPool { get; set; }
        public virtual Pool Pool { get; set; }
    }
}
