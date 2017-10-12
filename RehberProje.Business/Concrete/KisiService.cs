using RehberProje.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RehberProje.Entities.Entities;
using RehberProje.DataAccess.Abstract;

namespace RehberProje.Business.Concrete
{
    public class KisiService : IKisiService
    {
        private IKisiDAL _kisiDAL;

        public KisiService(IKisiDAL kisiDAL)
        {
            _kisiDAL = kisiDAL;
        }

        public void Add(Kisi item)
        {
            _kisiDAL.Add(item);
        }

        public void Delete(Kisi item)
        {
            _kisiDAL.Delete(item);
        }

        public Kisi Get(int ID)
        {
            return _kisiDAL.Get(x => x.ID == ID);
        }

        public ICollection<Kisi> GetAll()
        {
            return _kisiDAL.GetList();
        }

        public void Update(Kisi item)
        {
            _kisiDAL.Update(item);
        }
    }
}
