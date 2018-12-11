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
        private IArchive archive;

        public HomeController(IArchive p_archive) => this.archive = p_archive;

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
        public ViewResult Formulaire(Participant p_participant)
        {
            if (ModelState.IsValid)
            {
                archive.AjouterParticipant(p_participant);
                return View("Inscrit", p_participant);
            }
            else
            {
                return View();
            }
        }

        public ViewResult ListInscription()
        {
            return View(archive.Participants().Where(i => i.Montant > 0));
        }

        //Formulaire Membres CO
        [HttpGet]
        public ViewResult FormulaireMembresCO()
        {
            return View();
        }

        [HttpPost]
        public ViewResult FormulaireMembresCO(Organisateur p_inscriptionMCO)
        {
            if (ModelState.IsValid &&
                archive.Participants().Count(p => p.ID == p_inscriptionMCO.ParticipantId) == 1 &&
                archive.Organisateurs().Count(o => o.CodeUtilisateur == p_inscriptionMCO.CodeUtilisateur) == 0)
            {
                archive.AjouterOrganisateur(p_inscriptionMCO);
                return View("RoleAlloué", p_inscriptionMCO);
            }
            else
            {
                return View();
            }
        }

        public ViewResult ListMembreCO()
        {
            return View(archive.Organisateurs().Where(i => i.Role != ""));
        }

        // Paiement
        [HttpGet]
        public ViewResult FormulairePaiement()
        {
            return View();
        }

        [HttpPost]
        public ViewResult FormulairePaiement(Paiement p_paiement)
        {
            if (ModelState.IsValid &&
                archive.Participants().Count(p => p.ID == p_paiement.ParticipantId) == 1 &&
                archive.Paiements().Count(p1 => p1.ParticipantId == p_paiement.ParticipantId) == 0)
            {
                archive.AjouterPaiement(p_paiement);
                return View("Payer", p_paiement);
            }
            else
            {
                return View();
            }
        }

        public ViewResult ListPaiement()
        {
            return View(archive.Paiements().Where(i => i.Montant > 0));
        }
    }
}
