using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace lib_base
{
    public class C_AUDIT
    {
        public C_AUDITEUR Auditeur { get; set; }
        public C_ENTREPRISE Entreprise { get; set; }
        public DateTime La_Date { get; set; }

        public ObservableCollection<C_METRIQUE> Les_Metriques { get; set; }

        public C_AUDIT()
        {
            Les_Metriques = new ObservableCollection<C_METRIQUE>();
            Auditeur = new C_AUDITEUR();
            Entreprise = new C_ENTREPRISE();
            La_Date = DateTime.Now;
        }

        public void affiche_toi()
        {
            Console.WriteLine(Auditeur);
            Console.WriteLine(Entreprise);
            Console.WriteLine(La_Date.ToString());

            foreach(C_METRIQUE Une_Metrique in Les_Metriques)
            {
                Console.WriteLine(Une_Metrique);
            }
        }
    }
}
