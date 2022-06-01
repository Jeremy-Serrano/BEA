using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lib_base;
using WPF_BEA.ABSTRACTION;

namespace WPF_BEA.COORDINATION
{
    class C_COORDINATION : C_NOTIFIABLE
    {
       

        private static C_COORDINATION instance = null;
        public static C_COORDINATION Get_Instance()
        {
            if (instance == null) instance =  new C_COORDINATION();
            return instance;

        }

             C_BASE La_Base = C_BASE.Get_Instance();
        C_ILLUSTRATOR Mon_Illustrator = C_ILLUSTRATOR.Get_Instance();

        private C_AUDITEUR _Auditeur = new C_AUDITEUR(); // interessant si on a pas chargé de JSON

        public C_AUDITEUR Auditeur
        {
            get { return _Auditeur; }
            set { _Auditeur = value; signal_changement(); }
        }

        private C_ENTREPRISE _Entreprise = new C_ENTREPRISE(); // interessant si on a pas chargé de JSON

        public C_ENTREPRISE Entreprise
        {
            get { return _Entreprise; }
            set { _Entreprise = value; signal_changement(); }
        }

        public ObservableCollection<C_METRIQUE> _Les_Metriques = new ObservableCollection<C_METRIQUE>();
        public ObservableCollection<C_METRIQUE> Les_Metriques
        {
            get { return _Les_Metriques; }
            set { _Les_Metriques = value; signal_changement(); }
        }

        private string _Nom_Fichier_Courant; // interessant si on a pas chargé de JSON

        public string Nom_Fichier_Courant
        {
            get { return _Nom_Fichier_Courant; }
            set { _Nom_Fichier_Courant = value; signal_changement(); }
        }

        private C_METRIQUE _Metrique_Selectionnee;

        public C_METRIQUE Metrique_Selectionnee
        {
            get { return _Metrique_Selectionnee; }
            set { _Metrique_Selectionnee = value; signal_changement(); }
        }


        private C_COORDINATION()
        {            Auditeur = La_Base.Audit.Auditeur;
            Entreprise = La_Base.Audit.Entreprise;
            Les_Metriques = La_Base.Audit.Les_Metriques;
        }

        public void Charger_Fichier(string P_nom)
        {
            La_Base.Chargement(P_nom);
            Nom_Fichier_Courant = P_nom;

            Auditeur = La_Base.Audit.Auditeur;
            Entreprise = La_Base.Audit.Entreprise;
            Les_Metriques = La_Base.Audit.Les_Metriques;
        }

        public void Ajoute_Metrique()
        {
            C_METRIQUE Une_Metrique = new C_METRIQUE();
            La_Base.Audit.Les_Metriques.Add(Une_Metrique);
            
        }

        public void Supprimer_Metrique()
        {
            C_METRIQUE Une_Metrique = new C_METRIQUE();
            La_Base.Audit.Les_Metriques.Remove(Une_Metrique);
        }

        public void sauver_fichier()
        {
            if(Nom_Fichier_Courant!=null) La_Base.Sauvegarde(Nom_Fichier_Courant);
            //TODO boite de dialogue avec confirmation OUI NON
            //TODO SUPPRIMER UNE METRIQUE, quand in appuie sur SUPP ou ECHAP -> boite de dialogue OUI/NON
        }

        public void MAJ_Illustrator_Metrique()
        {
            if (Metrique_Selectionnee != null)
            {
                var nom = Metrique_Selectionnee.NomLiaison;

                Mon_Illustrator.Ajoute_Jauge(Metrique_Selectionnee.NomLiaison, "A",Metrique_Selectionnee.valeur);
            }
        }

        public void MAJ_Illustrator_Metrique_Text()
        {
            if(Metrique_Selectionnee != null)
            { 
                La_Base.Ajout_Block(Metrique_Selectionnee.NomLiaison, Metrique_Selectionnee.Description);
            }
        }

        public void Creation_Nouvel_Audit()
        {
            La_Base.Creation_Audit_Vierge();

            Auditeur = La_Base.Audit.Auditeur;
            Entreprise = La_Base.Audit.Entreprise;
            Les_Metriques = La_Base.Audit.Les_Metriques;
            Nom_Fichier_Courant = null;
        }

    }
}
