using RehberProje.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RehberProje.Business.Abstract
{
    public interface IKisiService
    {
        void Add(Kisi item);
        void Update(Kisi item);
        void Delete(Kisi item);
        Kisi Get(int ID);
        ICollection<Kisi> GetAll();
    }
}
