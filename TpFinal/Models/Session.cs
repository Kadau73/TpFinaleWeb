using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TpFinal.Models
{
    public class Session
    {
        public int ArticleId { get; set; }
        public int MembreId { get; set; }
        public string Titre { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DateSoumission { get; set; }
    }
}
