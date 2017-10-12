using RehberProje.Business.Abstract;
using RehberProje.Entities.Entities;
using RehberProje.MVCWeb.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RehberProje.MVCWeb.UI.Controllers
{
    public class KisiController : Controller
    {
        private readonly IKisiService _kisiService;

        public KisiController(IKisiService kisiService)
        {
            _kisiService = kisiService;
        }

        public ActionResult YeniKisi()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult YeniKisi(KisiViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Kisi kisi = model.Kisi;
                    _kisiService.Add(kisi);
                }
                catch (Exception)
                {
                }
            }
            return Redirect("/Home/HomePage");
        }

        [HttpGet]
        public ActionResult KisiDuzenle(int ID)
        {
            KisiViewModel kisi = new KisiViewModel();
            if (ID != null)
            {
                kisi.Kisi = _kisiService.Get(ID);
            }
            return View(kisi);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult KisiDuzenle(KisiViewModel model)
        {
            if (model.Kisi.ID != null)
            {
                try
                {
                    Kisi kisi = _kisiService.Get(model.Kisi.ID);

                    kisi.Ad = model.Kisi.Ad;
                    kisi.Soyad = model.Kisi.Soyad;
                    kisi.Yas = model.Kisi.Yas;

                    _kisiService.Update(kisi);
                }
                catch (Exception)
                {
                }
            }
            return Redirect("/Home/HomePage");
        }

        [HttpGet]
        public ActionResult Sil(int ID)
        {
            KisiViewModel kisi = new KisiViewModel();

            if (ID != null)
            {
                kisi.Kisi = _kisiService.Get(ID);
            }
            return View(kisi);
        }

        [HttpPost]
        [ValidateAntiForgeryToken, ActionName("Sil")]
        public ActionResult SilelimMi(int ID)
        {
            if (ID != null)
            {
                try
                {
                    Kisi kisi = _kisiService.Get(ID);
                    _kisiService.Delete(kisi);
                }
                catch (Exception)
                {
                }
            }
            return Redirect("/Home/HomePage");
        }
    }
}