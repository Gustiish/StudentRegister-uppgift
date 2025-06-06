﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabasutvecklingInlämningsuppgift
{
    public class StudentDBContext : DbContext
    {

        private string connectionsString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Inlämningsuppgift;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        public DbSet<Student> Students { get; set; }
        public DbSet<AdminUser> AdminUsers { get; set; }
        public DbSet<NonAdminUser> NonAdminUsers { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connectionsString);
            }
        }
    }
}
