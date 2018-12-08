using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TpFinal.Models
{
    public class Paiement
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "SVP entrez l'id du participant.")]
        public int ParticipantId { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DatePaiement { get; set; }

        public decimal Montant { get; set; }
    }
}
