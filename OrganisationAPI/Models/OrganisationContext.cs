using System;
using Microsoft.EntityFrameworkCore;

namespace OrganisationAPI.Models
{
     public class OrganisationContext:DbContext
    {
         public DbSet<Organisation> Organisations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost;Database=OrganisationDB;Username=postgres;Password=psql123");
    }

    public class Organisation
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime eventDate { get; set; }
        public string hour { get; set; }
    }
}