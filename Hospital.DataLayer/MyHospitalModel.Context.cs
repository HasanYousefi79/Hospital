﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hospital.DataLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Hospital_DBEntities : DbContext
    {
        public Hospital_DBEntities()
            : base("name=Hospital_DBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<Manager> Managers { get; set; }
        public virtual DbSet<LogIn> LogIns { get; set; }
    }
}