using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TpFinal.Models
{
    public class Spécialité
    {
        [Key]
        public int ID { get; set; }
        public int MembreId { get; set; }
        public string Description { get; set; }
    }
}
