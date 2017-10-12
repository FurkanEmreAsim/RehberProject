using Ninject.Modules;
using RehberProje.Core.DataAccess;
using RehberProje.Core.DataAccess.EntityFramework;
using RehberProje.DataAccess.Abstract;
using RehberProje.DataAccess.Concrete.EntityFramework.Context;
using RehberProje.DataAccess.Concrete.EntityFramework.Entities;
using RehberProje.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RehberProje.Business.IoC.Ninject
{
    public class ServiceModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IKisiDAL>().To<EFKisiDAL>();
            this.Bind<IAdresDAL>().To<EFAdresDAL>();
        }
    }
}
