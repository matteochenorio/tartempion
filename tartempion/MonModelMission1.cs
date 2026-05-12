using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using tartempion.Models;
using Region = tartempion.Models.Region;

namespace tartempion
{
    internal class MonModelMission1
    {
        private static TartempionContext monModel;
        private static Visiteur visiteurConnecte;
        private static bool connexionValide;
        private static Visiteur utilisateurConnecte;
        public static TartempionContext MonModel { get => monModel; set => monModel = value; }
        public static Visiteur VisiteurConnecte { get => visiteurConnecte; set => visiteurConnecte = value; }
        public static bool ConnexionValide { get => connexionValide; set => connexionValide = value; }
        public static Visiteur UtilisateurConnecte { get => utilisateurConnecte; set => utilisateurConnecte = value; }
        public static List<Visiteur> LesVisiteurs => MonModel.Visiteurs.ToList();
        public static List<Secteur> LesSecteurs => MonModel.Secteurs.ToList();
        public static List<Models.Region> LesRegions => MonModel.Regions.ToList();

        public static int ActionFvisiteur { get => actionFvisiteur; set => actionFvisiteur = value; }

        private static int actionFvisiteur=1; // si 1 visiteur normal affichage de mes collegue

      

        public static void init()
        {
            MonModel = new TartempionContext();
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
        
        public static List <Visiteur> listVisiteur()
        {
            return MonModel.Visiteurs.ToList();
        }


        public static List<Region> listRegion()
        {
            return MonModel.Regions.ToList();
        }


        public static List<Secteur> listSecteur()
        {
            return MonModel.Secteurs.ToList();
        }
    }
}
