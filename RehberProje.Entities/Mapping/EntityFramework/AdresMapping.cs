using RehberProje.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RehberProje.Entities.Mapping.EntityFramework
{
    public class AdresMapping : EntityTypeConfiguration<Adres>
    {
        public AdresMapping()
        {
            HasKey(x => x.ID);

            Property(x => x.AdresTanim).IsRequired().HasMaxLength(150);

            HasRequired<Kisi>(x => x.Kisi)
                .WithMany(x => x.Adresler)
                .HasForeignKey(fk => fk.KisiID);
        }
    }
}
