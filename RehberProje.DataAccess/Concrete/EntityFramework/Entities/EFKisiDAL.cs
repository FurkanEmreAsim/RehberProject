using RehberProje.Entities.Entities;
using RehberProje.Core.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RehberProje.DataAccess.Concrete.EntityFramework.Context;
using RehberProje.DataAccess.Abstract;
using System.Data.Entity;

namespace RehberProje.DataAccess.Concrete.EntityFramework.Entities
{
    public class EFKisiDAL : EFEntityRepositoryBase<Kisi, ApplicationDbContext>, IKisiDAL
    {
        public EFKisiDAL(DbContext context) : base(context)
        {
        }
    }
}
