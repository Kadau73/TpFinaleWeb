using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TpFinal.Models
{
    public class InscrireParticipant
    {
        //public int ID { get; set; }
        [Required(ErrorMessage = "SVP entrez votre nom")]
        public string Nom { get; set; }
        [Required(ErrorMessage = "SVP entrez votre prénom")]
        public string Prenom { get; set; }
        [Required(ErrorMessage = "SVP entrez votre adresse électronique")]
        public string Email { get; set; }
        [Required(ErrorMessage = "SVP entrez votre affiliation")]
        public string Affiliation { get; set; }
        public DateTime DateInscription { get; set; }
        public decimal Montant { get; set; }
    }
}
