using RehberProje.Entities.Entities;
using RehberProje.Entities.Mapping.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RehberProje.DataAccess.Concrete.EntityFramework.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("Server=.;Database=RehberimDB;Integrated Security=true;")
        {

        }

        #region Entities

        public DbSet<Kisi> Kisi { get; set; }
        public DbSet<Adres> Adres { get; set; }

        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new KisiMapping());
            modelBuilder.Configurations.Add(new AdresMapping());
        }
    }
}
