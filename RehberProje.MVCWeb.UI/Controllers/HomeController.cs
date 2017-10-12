using RehberProje.Business.Abstract;
using RehberProje.MVCWeb.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RehberProje.MVCWeb.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IKisiService _kisiService;
        private readonly IAdresService _adresService;

        public HomeController(IKisiService kisiService, IAdresService adresService)
        {
            _kisiService = kisiService;
            _adresService = adresService;
        }

        public ActionResult HomePage()
        {
            HomeViewModel model = new HomeViewModel { Kisiler = _kisiService.GetAll().ToList(), Adresler = _adresService.GetAll().ToList() };

            return View(model);
        }
    }
}