using System.Linq;

namespace TpFinal.Models
{
    public sealed class ArchiveDb : IArchive
    {
        private ContextBD contexte;
        public ArchiveDb(ContextBD p_contexte)
        {
            contexte = p_contexte;
        }
        //Participant
        public IQueryable<Participant> Participants() => contexte.Participants;

        public void AjouterParticipant(Participant p_participant)
        {
            if (p_participant.ID == 0)
            {
                contexte.Participants.Add(p_participant);
            }
            else
            {
                Participant maRéponse = contexte.Participants
                .FirstOrDefault(r => r.ID == p_participant.ID);
                if (maRéponse != null)
                {
                    maRéponse.Nom = p_participant.Nom;
                    maRéponse.Email = p_participant.Email;
                    maRéponse.Affiliation = p_participant.Affiliation;
                    maRéponse.Montant = p_participant.Montant;
                }
            }
            contexte.SaveChanges();
        }

        public Participant SupprimerParticipant(int p_idRéponse)
        {
            Participant maRéponse = contexte.Participants
            .FirstOrDefault(r => r.ID == p_idRéponse);
            if (maRéponse != null)
            {
                contexte.Participants.Remove(maRéponse);
                contexte.SaveChanges();
            }
            return maRéponse;
        }

        public Participant ObtientAvecNom(string p_nom)
        {
            // TODO
            // Méthode bidon
            return new Participant() { Nom = p_nom };
        }

        public void SoumettreChangements()
        {
            // TODO
        }

        //Organisateur
        public IQueryable<Organisateur> Organisateurs() => contexte.Organisateurs;

        public void AjouterOrganisateur(Organisateur p_organisateur)
        {
            if (p_organisateur.ID == 0)
            {
                contexte.Organisateurs.Add(p_organisateur);
            }
            else
            {
                Organisateur maRéponse = contexte.Organisateurs
                .FirstOrDefault(r => r.ID == p_organisateur.ID);
                if (maRéponse != null)
                {
                    maRéponse.ParticipantId = p_organisateur.ParticipantId;
                    maRéponse.CodeUtilisateur = p_organisateur.CodeUtilisateur;
                    maRéponse.Role = p_organisateur.Role;
                }
            }
            contexte.SaveChanges();
        }

        //Paiment
        public IQueryable<Paiement> Paiements() => contexte.Paiements;

        public void AjouterPaiment(Paiement p_paiement)
        {
            if (p_paiement.ID == 0)
            {
                contexte.Paiements.Add(p_paiement);
            }
            else
            {
                Paiement maRéponse = contexte.Paiements
                .FirstOrDefault(r => r.ID == p_paiement.ID);
                if (maRéponse != null)
                {
                    maRéponse.ParticipantId = p_paiement.ParticipantId;
                    maRéponse.DatePaiement = p_paiement.DatePaiement;
                    maRéponse.Montant = p_paiement.Montant;
                }
            }
            contexte.SaveChanges();
        }
    }
}
