using DataEntryPOC.Application.Interfaces;
using DataEntryPOC.Domain.Entities;
using DataEntryPOC.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;

namespace DataEntryPOC.MVC.Controllers
{
    public class PaisController : Controller
    {
        private readonly IPaisAppService _paisApp;

        public PaisController(IPaisAppService paisApp)
        {
            _paisApp = paisApp;
        }

        // GET: Pais
        public ActionResult Index()
        {
            var paisViewModel = Mapper.Map<IEnumerable<Pais>, IEnumerable<PaisViewModel>>(_paisApp.GetAll());
            return View(paisViewModel);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PaisViewModel paisViewModel)
        {
            if (ModelState.IsValid)
            {
                var pais = Mapper.Map<PaisViewModel, Pais>(paisViewModel);

                _paisApp.Add(pais);

                return RedirectToAction("Index");
            }

            return View(paisViewModel);

        }
    }
}