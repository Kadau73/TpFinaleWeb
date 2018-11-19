﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TpFinal.Models
{
    public class InscrireMembresCO
    {
        [Required(ErrorMessage = "SVP entrez l'identifiant.")]
        public string Identifiant { get; set; }
        [Required(ErrorMessage = "SVP entrez le code d'utilisateur.")]
        public string CodeUtilisateur { get; set; }
        [Required(ErrorMessage = "SVP entrez le mot de passe")]
        //[RegularExpression("0123456789", ErrorMessage = "Mot de passe invalide.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "SVP choisir un rôle.")]
        public string Role { get; set; }
    }
}
