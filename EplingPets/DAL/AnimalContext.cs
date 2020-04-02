using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EplingPets.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace EplingPets.DAL
{
    public class AnimalContext : DbContext
    {
        public AnimalContext() : base("AnimalContext")
        { }

        public DbSet<Pet> Pets { get; set; }
        public DbSet<Breed> Breeds { get; set; }

        public DbSet<Species> SpeciesList { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}