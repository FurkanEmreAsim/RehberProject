using RehberProje.Core.Entities;

namespace RehberProje.Entities.Entities
{
    public class Adres : IEntity
    {
        public int ID { get; set; }
        public string AdresTanim { get; set; }

        public int KisiID { get; set; }
        public virtual Kisi Kisi { get; set; }
    }
}