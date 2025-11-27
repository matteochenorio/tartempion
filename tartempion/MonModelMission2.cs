using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using tartempion.Models;

namespace tartempion
{
    internal class MonModelMission2
    {
        private static TartempionContext monModel;
        private static int actionRapport;
        private static Rapport leRapportChoisi;
        private static Visiteur visiteurConnecte;
        private static bool connexionValide;
        private static Visiteur utilisateurConnecte;

        public static TartempionContext MonModel { get => monModel; set => monModel = value; }
        public static Visiteur VisiteurConnecte { get => visiteurConnecte; set => visiteurConnecte = value; }
        public static bool ConnexionValide { get => connexionValide; set => connexionValide = value; }
        public static Visiteur UtilisateurConnecte { get => utilisateurConnecte; set => utilisateurConnecte = value; }
        public static int ActionRapport { get => actionRapport; set => actionRapport = value; }
        public static Rapport LeRapportChoisi { get => leRapportChoisi; set => leRapportChoisi = value; }

        public static void setLeRapportChoisi(int id)
        {
            LeRapportChoisi = MonModel.Rapports.Where(x => x.IdRapport == id).ToList()[0];
        }
        public static void init()
        {
            MonModel = new TartempionContext();
           // Rapport x=MonModel.Rapports.Where(r => r.IdRapport == 1).FirstOrDefault();
        }

        public static void ThreadProc()
        {
            Application.Run(new FMenu());
        }

        private static string GetMd5Hash(string PasswdSaisi)
        {
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(PasswdSaisi);
            byte[] hash = (MD5.Create()).ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();
        }
        
        public static string validConnexion(string id, string mp)
        {
            ConnexionValide = false;
            string message = "Id ou Mdp incorrect";
            List<Visiteur> Listeu = monModel.Visiteurs.Where(x => x.Identifiant == id).ToList();
            if (Listeu.Count == 1)
            {
                UtilisateurConnecte = Listeu[0];
                if (UtilisateurConnecte.Password.Equals(GetMd5Hash(mp)))
                {
                    message = "connexion ok";
                    ConnexionValide = true;
                }
            }
            return message;
        }

        public static List<Visiteur> ListeVisiteur()
        {
            return MonModel.Visiteurs.ToList();
        }

        public static List<Medicament> ListeMedicament()
        {
            return MonModel.Medicaments.ToList();
        }

        public static List<Famille> ListeFamille()
        {
            return MonModel.Familles.ToList();
        }

        public static List<Medecin> ListeMedecin()
        {
            return MonModel.Medecins.ToList();
        }

        public static List<Specialite> ListeSpecialite()
        {
            return MonModel.Specialites.ToList();
        }

        public static List<Rapport> ListeRapport()
        {
            return MonModel.Rapports.ToList();
        }

        public static List<Offrir> ListeEchantillon()
        {
            return MonModel.Offrirs.ToList();
        }

        //public static bool AjoutRapport(string nom)
        //{
        //    bool vretour = true;

        //}
    }
}
