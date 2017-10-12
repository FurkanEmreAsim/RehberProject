using Ninject.Modules;
using RehberProje.DataAccess.Concrete.EntityFramework.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RehberProje.DataAccess.IoC.Ninject
{
    public class DalModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<DbContext>().To<ApplicationDbContext>().InSingletonScope();
        }
    }
}
