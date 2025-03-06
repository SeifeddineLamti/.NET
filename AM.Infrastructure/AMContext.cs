﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.ApplicationCore.Domain;
using AM.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;

namespace AM.Infrastructure
{
    public class AMContext : DbContext
    {
        // 1  Dbset
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Plane> Planes { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Traveller> Travellers { get; set; }

        // 2 chaine de connection

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb; 
            Initial Catalog=4Arctic4;Integrated Security=true");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //wehed menhom yekhdem mech ezouz    
            
            base.OnModelCreating(modelBuilder);
            // 1ere methode avec classe de configuration
           // modelBuilder.ApplyConfiguration(new PlaneConfiguration());

            // 2eme methode sans classe de configuration
            modelBuilder.Entity<Plane>().
                ToTable("MyPlanes").
                Property(p => p.Capacity).
                HasColumnName("PlaneCapacity");
            modelBuilder.Entity<Plane>().
                HasKey(p => p.PlaneId)

            ;

            modelBuilder.ApplyConfiguration(new FlightConfiguration());
        }

    }
}
