﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrlaubsPlaner.Entities
{
    public class DataBaseContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Absence> Absences { get; set; }
        public DbSet<AbsenceType> AbsenceTypes { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=UrlaubsPlaner;Trusted_Connection=True;");
        }

        public DataBaseContext()
        {
        }
    }
}