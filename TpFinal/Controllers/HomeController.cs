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

        //Formulaire Participant
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

        //Formulaire Membres CO
        [HttpGet]
        public ViewResult FormulaireMembresCO()
        {
            return View();
        }

        [HttpPost]
        public ViewResult FormulaireMembresCO(InscrireMembresCO p_inscriptionMCO)
        {
            if (ModelState.IsValid)
            {
                Archive.AjouterInscriptionMCO(p_inscriptionMCO);
                return View("RoleAlloué", p_inscriptionMCO);
            }
            else
            {
                return View();
            }
        }

        public ViewResult ListInscriptionMembresCO()
        {
            return View(Archive.InscriptionMCO.Where(i => i.Role != ""));
        }
    }
}
