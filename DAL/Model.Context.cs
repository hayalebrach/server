﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SwimMoodEntities : DbContext
    {
        public SwimMoodEntities()
            : base("name=SwimMoodEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<CoursToCustomer> CoursToCustomers { get; set; }
        public virtual DbSet<CustomerToPool> CustomerToPools { get; set; }
        public virtual DbSet<Day> Days { get; set; }
        public virtual DbSet<DaysToCour> DaysToCours { get; set; }
        public virtual DbSet<DaysToPool> DaysToPools { get; set; }
        public virtual DbSet<EnterCustomer> EnterCustomers { get; set; }
        public virtual DbSet<Erea> Ereas { get; set; }
        public virtual DbSet<Package> Packages { get; set; }
        public virtual DbSet<Pool> Pools { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
