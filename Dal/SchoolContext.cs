﻿using DomainModel;
using Microsoft.EntityFrameworkCore;
using System;

namespace Dal
{
    public class SchoolContext :DbContext
    {
        public DbSet<Person> People { get; set; }
        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseInMemoryDatabase("SchoolDatabaseMemory");
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=SchoolBDD;Integrated Security=true");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
