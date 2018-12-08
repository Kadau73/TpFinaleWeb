using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TpFinal.Models
{
    public class Organisateur
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "SVP entrez l'id du participant.")]
        public int ParticipantId { get; set; }

        [Required(ErrorMessage = "SVP entrez le code d'utilisateur.")]
        public string CodeUtilisateur { get; set; }

        [Required(ErrorMessage = "SVP entrez le mot de passe")]
        //[RegularExpression("0123456789", ErrorMessage = "Mot de passe invalide.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "SVP choisir un rôle.")]
        public string Role { get; set; }
    }
}
