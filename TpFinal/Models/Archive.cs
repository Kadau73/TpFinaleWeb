using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TpFinal.Models
{
    public class Archive
    {
        private static List<InscrireParticipant> lstInscription = new List<InscrireParticipant>();

        public static IEnumerable<InscrireParticipant> Inscription
        {
            get { return lstInscription; }
        }

        public static void AjouterInscription(InscrireParticipant p_inscription)
        {
            lstInscription.Add(p_inscription);
        }
    }
}
