using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using tartempion.Models;

namespace tartempion
{
    internal class MonModelMission3
    {
        private static TartempionContext monModel;
        private static Visiteur visiteurConnecte;
        private static bool connexionValide;
        private static Fichefrai ficheFraisChoisi;
        private static int ajoutModif;
        private static LigneFraisForfait LigneFraisForfaitChoisi;

        public static TartempionContext MonModel { get => monModel; set => monModel = value; }
        public static Visiteur VisiteurConnecte { get => visiteurConnecte; set => visiteurConnecte = value; }
        public static bool ConnexionValide { get => connexionValide; set => connexionValide = value; }
        public static Fichefrai FicheFraisChoisi { get => ficheFraisChoisi; set => ficheFraisChoisi = value; }
        public static int AjoutModif { get => ajoutModif; set => ajoutModif = value; }

        public static void init()
        {
            MonModel = new TartempionContext();
            visiteurConnecte = monModel.Visiteurs.Where(v => v.IdVisiteur == "a17").FirstOrDefault();
            connexionValide = true;
        }

        public static List<Fichefrai> listeFicheFrais()
        {
            return monModel.Fichefrais.ToList();
        }

        public static List<FraisForfait> listeFraisForfait()
        {
            return monModel.FraisForfaits.ToList();
        }

        public static List<LigneFraisHorsForfait> listeFraisHorsForfait()
        {
            return monModel.LigneFraisHorsForfaits.ToList();
        }

        public static List<HistoriqueFrai> listeHistoriqueFrais()
        {
            return monModel.HistoriqueFrais.ToList();
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
                visiteurConnecte = Listeu[0];
                if (visiteurConnecte.Password.Equals(GetMd5Hash(mp)))
                {
                    message = "connexion ok";
                    ConnexionValide = true;
                }
            }
            return message;
        }

        public static double? TrouveMontant(FraisForfait x)
        {
            double vretour = 0;
            vretour = MonModel.HistoriqueFrais.Where(h => h.IdFraisForfait == x.Id && (h.DateFin == null || h.DateFin >= DateOnly.FromDateTime(DateTime.Now)))
                .OrderByDescending(h => h.DateDebut)
                .Select(h => h.Montant)
                .FirstOrDefault();
            return vretour;
        }

        public static bool AjoutFicheDeFrais(string mois)
        {
            bool vretour = true;
            try
            {
                ficheFraisChoisi = new Fichefrai();
                ficheFraisChoisi.IdVisiteur = visiteurConnecte.IdVisiteur;
                ficheFraisChoisi.Mois = mois;
                ficheFraisChoisi.IdEtat = "CR";
                monModel.Fichefrais.Add(ficheFraisChoisi);
                monModel.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
            }
            return vretour;
        }

        public static bool AjoutLigneFiche(string date, string idFraisForfait, int quantite)
        {
            bool vretour = true;
            try
            {
                LigneFraisForfaitChoisi = new LigneFraisForfait();
                LigneFraisForfaitChoisi.IdVisiteur = visiteurConnecte.IdVisiteur;
                LigneFraisForfaitChoisi.Mois = date;
                LigneFraisForfaitChoisi.IdFraisForfait = idFraisForfait;
                LigneFraisForfaitChoisi.Quantite = quantite;
                monModel.LigneFraisForfaits.Add(LigneFraisForfaitChoisi);
                monModel.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
            }
            return vretour;
        }

        public static bool SuppficheFrais()
        {
            bool vretour = true;
            try
            {
                // 1. On récupère les lignes liées à cette fiche pour les supprimer d'abord
                // ficheFraisChoisi contient l'idVisiteur et le mois nécessaires

                var lignesForfait = monModel.LigneFraisForfaits
                    .Where(l => l.IdVisiteur == ficheFraisChoisi.IdVisiteur && l.Mois == ficheFraisChoisi.Mois);

                var lignesHorsForfait = monModel.LigneFraisHorsForfaits
                    .Where(l => l.IdVisiteur == ficheFraisChoisi.IdVisiteur && l.Mois == ficheFraisChoisi.Mois);

                // 2. Suppression des dépendances
                monModel.LigneFraisForfaits.RemoveRange(lignesForfait);
                monModel.LigneFraisHorsForfaits.RemoveRange(lignesHorsForfait);

                // 3. Suppression de la fiche elle-même
                monModel.Fichefrais.Remove(ficheFraisChoisi);

                // 4. Validation en base de données
                monModel.SaveChanges();
            }
            catch (Exception ex)
            {
                string errorMsg = ex.InnerException?.InnerException?.Message ?? ex.Message;
                System.Windows.Forms.MessageBox.Show("Erreur lors de la suppression : " + errorMsg);

                vretour = false;
                // On réinitialise le contexte en cas d'erreur critique
                monModel.Dispose();
                init();
            }

            return vretour;
        }
    }
}
