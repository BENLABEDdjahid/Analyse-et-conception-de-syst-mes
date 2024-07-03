using System;


// Classe représentant une demande de formation.
public class DemandeDeFormation
{
    // Identifiant unique de la demande de formation
    public int DemandeId { get; set; }

    // Date de la demande
    public DateTime DateDemandee { get; set; }

    // Fournisseur du cours
    public string CoursFournisseur { get; set; }

    // Code du cours
    public string CoursCode { get; set; }

    // Titre du cours
    public string CoursTitre { get; set; }

    // Date limite pour l'inscription au cours
    public DateTime DateLimiteInscription { get; set; }

    // Durée du cours pendant les heures de travail
    public int DureePendantTravail { get; set; }

    // Durée du cours en dehors des heures de travail
    public int DureeApresTravail { get; set; }

    // Frais du cours
    public float FraisCours { get; set; }

    // Frais de voyage pour le cours
    public float FraisVoyage { get; set; }

    // Date de début du cours
    public DateTime CoursDateDebut { get; set; }

    // Date de fin du cours
    public DateTime CoursDateFin { get; set; }

    // État actuel de la demande de formation
    public DemandeEtat Etat { get; set; }

    // Constructeur pour initialiser une demande de formation
    public DemandeDeFormation(int demandeId, DateTime dateDemandee, string coursFournisseur, string coursCode,
                              string coursTitre, DateTime dateLimiteInscription, int dureePendantTravail,
                              int dureeApresTravail, float fraisCours, float fraisVoyage,
                              DateTime coursDateDebut, DateTime coursDateFin, DemandeEtat etat)
    {
        DemandeId = demandeId;
        DateDemandee = dateDemandee;
        CoursFournisseur = coursFournisseur;
        CoursCode = coursCode;
        CoursTitre = coursTitre;
        DateLimiteInscription = dateLimiteInscription;
        DureePendantTravail = dureePendantTravail;
        DureeApresTravail = dureeApresTravail;
        FraisCours = fraisCours;
        FraisVoyage = fraisVoyage;
        CoursDateDebut = coursDateDebut;
        CoursDateFin = coursDateFin;
        Etat = etat;
    }

    // Méthode pour soumettre la demande de formation
    public void SoumettreDemande()
    {
        // Vérifier si la demande est valide avant de la soumettre
        if (ValiderDemande())
        {
            // Changer l'état de la demande à "soumise"
            Etat.ChangerEtat("Soumise");

            // Notifier le gestionnaire
            NotifierGestionnaire();
        }
        else
        {
            // Afficher les messages d'erreur si la validation échoue
            AfficherMessageErreurs();
        }
    }

    // Méthode pour valider la demande de formation
    public bool ValiderDemande()
    {
        // Ajoutez ici la logique de validation
        return true;
    }

    // Méthode pour approuver la demande de formation
    public void ApprouverDemande()
    {
        // Changer l'état de la demande à "approuvée"
        Etat.ChangerEtat("Approuvée");

        // Notifier l'agent RH
        NotifierRH();
    }

    // Méthode pour rejeter la demande de formation
    public void RejeterDemande()
    {
        // Changer l'état de la demande à "rejetée"
        Etat.ChangerEtat("Rejetée");
    }

    // Méthodes privées pour notifier les utilisateurs et afficher les messages d'erreur
    private void NotifierGestionnaire()
    {
        // Logique pour notifier le gestionnaire
    }

    private void NotifierRH()
    {
        // Logique pour notifier l'agent RH
    }

    private void AfficherMessageErreurs()
    {
        // Logique pour afficher les messages d'erreurs
    }
}

/// <summary>
/// Classe représentant l'état d'une demande de formation.
/// </summary>
public class DemandeEtat
{
    // Identifiant unique de l'état
    public int EtatId { get; set; }

    // Nom de l'état
    public string Etat { get; set; }

    // Constructeur pour initialiser un état de demande
    public DemandeEtat(int etatId, string etat)
    {
        EtatId = etatId;
        Etat = etat;
    }

    // Méthode pour changer l'état de la demande
    public void ChangerEtat(string nouvelEtat)
    {
        Etat = nouvelEtat;
    }
}
