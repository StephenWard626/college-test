using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace KingdomHearts.Models
{
    public class OrganizationContext : DbContext
    {
        private const string connectionString =
            "Server=(localdb)\\mssqllocaldb;DataBase=Organization13;Trusted_Connection=False;";

        public DbSet<Organization13Entry> Organization13 { get; set; }

        //The below tells the system to use the connection string we entered above - directing it to the db
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer(connectionString);
        }
    }
}
