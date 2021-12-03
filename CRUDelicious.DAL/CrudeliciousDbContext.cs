using System;
using System.Collections.Generic;
using CRUDelicious.CORE;
using Microsoft.EntityFrameworkCore;

namespace CRUDelicious.DAL
{
    public class CrudeliciousDbContext : DbContext
    {
        public DbSet<Dishes> Dishes { get; set; }
        public DbSet<Chef> Chefs { get; set; }
        public CrudeliciousDbContext() : base()
        {

        }
        public CrudeliciousDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseNpgsql("Host=192.168.1.104;Username=postgres;Password=root;Database=CRUDelicious");
    }
}
