using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TpFinal.Models
{
    public class Archive
    {
        private static List<InscrireParticipant> lstInscription = new List<InscrireParticipant>();
        private static List<InscrireMembresCO> lstInscriptionMCO = new List<InscrireMembresCO>();

        public static IEnumerable<InscrireParticipant> Inscription
        {
            get { return lstInscription; }
        }

        public static void AjouterInscription(InscrireParticipant p_inscription)
        {
            lstInscription.Add(p_inscription);
        }
        public static IEnumerable<InscrireMembresCO> InscriptionMCO
        {
            get { return lstInscriptionMCO; }
        }

        public static void AjouterInscriptionMCO(InscrireMembresCO p_inscriptionMCO)
        {
            lstInscriptionMCO.Add(p_inscriptionMCO);
        }
    }
}
