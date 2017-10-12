using RehberProje.Business.Abstract;
using RehberProje.DataAccess.Concrete.EntityFramework.Context;
using RehberProje.Entities.Entities;
using RehberProje.MVCWeb.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RehberProje.MVCWeb.UI.Controllers
{
    public class AdresController : Controller
    {
        private readonly IAdresService _adresService;
        private readonly IKisiService _kisiService;

        public AdresController(IAdresService adresService, IKisiService kisiService)
        {
            _adresService = adresService;
            _kisiService = kisiService;
        }

        [HttpGet]
        public ActionResult YeniAdres()
        {
            var kisiler = _kisiService.GetAll();
            List<SelectListItem> kisilerList = (from p in kisiler
                                                select new SelectListItem()
                                                {
                                                    Text = p.Ad + " " + p.Soyad,
                                                    Value = p.ID.ToString()
                                                }).ToList();
            ViewBag.kisiler = kisilerList;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult YeniAdres(AdresViewModel model)
        {
            try
            {
                model.Adres.Kisi = _kisiService.Get(model.Adres.Kisi.ID);
                _adresService.Add(model.Adres);
            }
            catch (Exception)
            {
            }
            return Redirect("/Home/HomePage");
        }

        [HttpGet]
        public ActionResult AdresDuzenle(int? adresId)
        {
            AdresViewModel adres = new AdresViewModel();

            if (adresId != null)
            {
                var kisiler = _kisiService.GetAll();
                List<SelectListItem> kisilerList = (from p in kisiler
                                                    select new SelectListItem()
                                                    {
                                                        Text = p.Ad + " " + p.Soyad,
                                                        Value = p.ID.ToString()
                                                    }).ToList();
                ViewBag.kisiler = kisilerList;
                adres.Adres = _adresService.Get((int)adresId);
            }

            return View(adres);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AdresDuzenle(AdresViewModel model)
        {
            try
            {
                Kisi kisi = _kisiService.Get(model.Adres.KisiID);

                Adres eskiAdres = _adresService.Get(model.Adres.ID);
                eskiAdres.Kisi = kisi;
                eskiAdres.AdresTanim = model.Adres.AdresTanim;

                _adresService.Update(eskiAdres);
            }
            catch (Exception)
            {
            }
            return Redirect("/Home/HomePage");
        }

        [HttpGet]
        public ActionResult AdresSil(int? adresId)
        {
            AdresViewModel adres = new AdresViewModel();

            if (adresId != null)
            {
                adres.Adres = _adresService.Get((int)adresId);
            }
            return View(adres);
        }

        [HttpPost]
        [ValidateAntiForgeryToken, ActionName("AdresSil")]
        public ActionResult SilelimMi(int? adresId)
        {
            if (adresId != null)
            {
                try
                {
                    Adres adres = _adresService.Get((int)adresId);
                    _adresService.Delete(adres);
                }
                catch (Exception)
                {
                }
            }
            return Redirect("/Home/HomePage");
        }
    }
}