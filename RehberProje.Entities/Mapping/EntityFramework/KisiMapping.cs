using RehberProje.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RehberProje.Entities.Mapping.EntityFramework
{
    public class KisiMapping : EntityTypeConfiguration<Kisi>
    {
        public KisiMapping()
        {

            HasKey(x => x.ID);

            Property(x => x.Ad).IsRequired().HasMaxLength(50);
            Property(x => x.Soyad).IsRequired().HasMaxLength(50);
            Property(x => x.Yas).IsRequired();
        }
    }
}
