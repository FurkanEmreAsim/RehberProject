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
    public class AdresService : IAdresService
    {
        private IAdresDAL _adresDAL;

        public AdresService(IAdresDAL adresDAL)
        {
            _adresDAL = adresDAL;
        }

        public void Add(Adres item)
        {
            _adresDAL.Add(item);
        }

        public void Delete(Adres item)
        {
            _adresDAL.Delete(item);
        }

        public Adres Get(int ID)
        {
            return _adresDAL.Get(x => x.ID == ID);
        }

        public ICollection<Adres> GetAll()
        {
            return _adresDAL.GetList();
        }

        public void Update(Adres item)
        {
            _adresDAL.Update(item);
        }
    }
}
