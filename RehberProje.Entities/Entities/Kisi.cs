using RehberProje.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RehberProje.Entities.Entities
{
    public class Kisi : IEntity
    {
        //public Kisi()
        //{
        //    Adresler = new HashSet<Adres>();
        //}

        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }

        public virtual ICollection<Adres> Adresler { get; set; }
    }
}
