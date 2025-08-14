﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;


namespace Infrastructure.Data
{

    public class AppDbContext : DbContext
    {
        public DbSet<Person> People { get; set; }
       
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            
            modelBuilder.Entity<Person>().HasData(
                new Person
                {
                    PersonId = 1,
                    FirstName = "Alice",
                    MI = "B.",
                    LastName = "Smith",
                    PhoneNumber = "123-456-7890",
                    CellNumber = "987-654-3210",
                    Email = "alice.smith@example.com"
                },
                new Person
                {
                    PersonId = 2,
                    FirstName = "Bob",
                    MI = "C.",
                    LastName = "Johnson",
                    PhoneNumber = "555-555-5555",
                    CellNumber = "444-444-4444",
                    Email = "bob.johnson@example.com"
                }
            );
        }
    }
}