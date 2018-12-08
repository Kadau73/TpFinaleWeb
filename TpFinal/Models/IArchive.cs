using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TpFinal.Models
{
    public interface IArchive
    {
        //Participant
        IQueryable<Participant> Participants();

        void AjouterParticipant(Participant p_participant);
        Participant SupprimerParticipant(int p_idParticipant);
        Participant ObtientAvecNom(string p_nom);
        void SoumettreChangements();

        //organisateur
        IQueryable<Organisateur> Organisateurs();

        void AjouterOrganisateur(Organisateur p_organisateur);

        //paiment
        IQueryable<Paiement> Paiements();
        void AjouterPaiment(Paiement p_paiement);
    }
}
