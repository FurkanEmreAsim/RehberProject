using RehberProje.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RehberProje.Business.Abstract
{
    public interface IAdresService
    {
        void Add(Adres item);
        void Update(Adres item);
        void Delete(Adres item);
        Adres Get(int ID);
        ICollection<Adres> GetAll();
    }
}
