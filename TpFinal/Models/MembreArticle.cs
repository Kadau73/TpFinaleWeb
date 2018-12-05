using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TpFinal.Models
{
    public class MembreArticle
    {
        [Key]
        public int ArticleId { get; set; }
        public int MembreId { get; set; }
        public int Note { get; set; }
    }
}
