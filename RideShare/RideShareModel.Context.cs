﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RideShare
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RideShareEntities1 : DbContext
    {
        public RideShareEntities1()
            : base("name=RideShareEntities1")
        {
            this.Configuration.LazyLoadingEnabled = true;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<TripPlans> TripPlans { get; set; }
    }
}
