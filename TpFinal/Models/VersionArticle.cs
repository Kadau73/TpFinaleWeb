using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TpFinal.Models
{
    public class VersionArticle
    {
        [Key]
        public int ID { get; set; }
        public int ArticleId { get; set; }
        public int Version { get; set; }
    }
}
