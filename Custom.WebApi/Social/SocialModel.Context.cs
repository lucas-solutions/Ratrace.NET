﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Custom.Social
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SocialModelContainer : DbContext
    {
        public SocialModelContainer()
            : base("name=SocialModelContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Message> Messages { get; set; }
        public DbSet<Identity> Identities { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Circle> Circles { get; set; }
        public DbSet<Exchange> Exchanges { get; set; }
        public DbSet<Broadcast> Broadcasts { get; set; }
        public DbSet<Session> Sessions { get; set; }
    }
}