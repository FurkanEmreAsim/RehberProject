using RehberProje.Core.DataAccess.EntityFramework;
using RehberProje.DataAccess.Abstract;
using RehberProje.DataAccess.Concrete.EntityFramework.Context;
using RehberProje.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace RehberProje.DataAccess.Concrete.EntityFramework.Entities
{
    public class EFAdresDAL : EFEntityRepositoryBase<Adres, ApplicationDbContext>, IAdresDAL
    {
        public EFAdresDAL(DbContext context) : base(context)
        {
        }
    }
}
