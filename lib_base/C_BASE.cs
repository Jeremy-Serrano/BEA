using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using System.Security.Cryptography;
using Illustrator;

namespace lib_base
{
   

   

    public class C_BASE
    {
        byte[] Vecteur_Initial = new byte[] { 69, 235, 118, 86, 174, 235, 208, 226 };
        byte[] Cle = new byte[] { 113, 8, 164, 244, 166, 161, 126, 8, 1, 29, 206, 71, 248, 226, 184, 106, 88, 107, 250, 117, 43, 220, 6, 239 };



        //        byte[] cle = Triple_DES.Key;
        static private C_BASE Instance = null;

        static public C_BASE Get_Instance()
        {
            if (Instance == null) Instance = new C_BASE();
            return Instance;
        }

        public C_AUDIT Audit { get; set; }

        private C_BASE()
        {
            Audit = new C_AUDIT();
        }

        public void Creation_Audit_Vierge()
        {
            Audit = new C_AUDIT();
        }

        public void Initialisation_Demo()
        {
            Audit.Auditeur = new C_AUDITEUR() { Nom = "Auditeur 1", Mail = "Auditeur_1@gmail.com" };
            Audit.Entreprise = new C_ENTREPRISE() { NomEntreprise = "Entreprise_1", SIRET = "12345678" };
            Audit.La_Date = DateTime.Now;

            Audit.Les_Metriques.Add(new C_METRIQUE() { NomMetrique = "Metrique_1", Description = "C LA METRIQUE 1", valeur = 1 });
            Audit.Les_Metriques.Add(new C_METRIQUE() { NomMetrique = "Metrique_2", Description = "C LA METRIQUE 2", valeur = 2 });
            Audit.Les_Metriques.Add(new C_METRIQUE() { NomMetrique = "Metrique_3", Description = "C LA METRIQUE 3", valeur = 3 });

            
        }

        public void Sauvegarde(string P_nom)
        {
            string DataJson = JsonSerializer.Serialize<C_AUDIT>(Audit);

           // File.WriteAllText(P_nom, DataJson);

            TripleDESCryptoServiceProvider Triple_DES = new TripleDESCryptoServiceProvider();
            var Encrypteur = Triple_DES.CreateEncryptor(Cle, Vecteur_Initial);

            byte[] Data_Json_Byte = Encoding.Default.GetBytes(DataJson);
            byte[] Data_Crypt_Byte = Encrypteur.TransformFinalBlock(Data_Json_Byte, 0, DataJson.Length);


            File.WriteAllBytes(P_nom, Data_Crypt_Byte);

        }

        public void Chargement(string P_nom)
        {
            try
            {
                byte[] Data_Cryptees = File.ReadAllBytes(P_nom);
                TripleDESCryptoServiceProvider Triple_DES = new TripleDESCryptoServiceProvider();

                var decrypteur = Triple_DES.CreateDecryptor(Cle, Vecteur_Initial);
                byte[] Data_Decrypt = decrypteur.TransformFinalBlock(Data_Cryptees, 0, Data_Cryptees.Length);


                Audit = JsonSerializer.Deserialize<C_AUDIT>(Data_Decrypt); 
            }
            catch(Exception P_Erreur)
            {
                Audit = new C_AUDIT();
                throw (P_Erreur);
                //Console.WriteLine(P_Erreur.Message);
            }
        }
        public void Ajout_Block(string P_nomZone,string P_textZone)
        {
            Document mon_document;
            Application mon_application = new Application();

            if (mon_application.Documents.Count == 0) mon_document = mon_application.Documents.Add();
            else mon_document = mon_application.ActiveDocument;

            TextFrame Mon_Objet = mon_document.TextFrames[P_nomZone];

            Mon_Objet.Contents = P_textZone;
        }
    }
}
