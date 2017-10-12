using RehberProje.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RehberProje.MVCWeb.UI.Models
{
    public class HomeViewModel
    {
        public List<Kisi> Kisiler { get; set; }
        public List<Adres> Adresler { get; set; }
    }
}