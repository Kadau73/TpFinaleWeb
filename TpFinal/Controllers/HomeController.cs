using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TpFinal.Models;

namespace TpFinal.Controllers
{
    public sealed class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Formulaire()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Formulaire(InscrireParticipant p_inscription)
        {
            if (ModelState.IsValid)
            {
                Archive.AjouterInscription(p_inscription);
                return View("Inscrit", p_inscription);
            }
            else
            {
                return View();
            }
        }

        public ViewResult ListInscription()
        {
            return View(Archive.Inscription.Where(i => i.Montant > 0));
        }
    }
}
