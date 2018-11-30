using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TpFinal.Models
{
    public class Membre
    {
        [Key]
        public int ID { get; set; }
        public int ParticipantId { get; set; }
        //spécialité
    }
}
