
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
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

        public static List<Medecin> ListeMedecinParVisiteur()
        {
            if (UtilisateurConnecte == null)
                return new List<Medecin>();

            return MonModel.Medecins
                .Where(m => m.Rapports
                    .Any(r => r.IdVisiteur == UtilisateurConnecte.IdVisiteur))
                .OrderBy(m => m.Nom)
                .ToList();
        }

        public static bool SuppRapport()
        {
            bool vretour = true;
            try
            {
                
                var rapport = monModel.Rapports
         //   .Include(r => r.Presentations)
            .Include(r => r.Offrirs)
            .FirstOrDefault(r => r.IdRapport == leRapportChoisi.IdRapport);

                if (rapport == null)
                    return false;

             //   monModel.Presentations.RemoveRange(rapport.Presentations);

                monModel.Offrirs.RemoveRange(rapport.Offrirs);

                monModel.Rapports.Remove(leRapportChoisi);
                monModel.SaveChanges();
            }
            catch (Exception ex)
            {
                monModel.Dispose();
                init();
                string msg = ex.Message;
                if (ex.InnerException != null)
                    msg += " " + ex.InnerException.Message;
                System.Windows.Forms.MessageBox.Show(msg);
                vretour = false;
            }
            return vretour;
        }

        public static bool AjoutRapport(string? motif, string bilan, int avisMedecin, bool estRemplacant, string dateRapport, string heurePrevue,
            string heureReelle, int dureeVisite, int idMedecin, List<Medicament> medsPresentes, List<Offrir> echantillons)
        {
            bool vretour = true;
            try
            {
                if (UtilisateurConnecte == null)
                    throw new Exception("Aucun utilisateur connecté");

                leRapportChoisi = new Rapport();
                //leRapportChoisi.IdMotifNavigation.LibMotif = motif;

                var motifObj = monModel.Motifs.FirstOrDefault(m => m.LibMotif == motif);
                if (motifObj == null)
                {
                    motifObj = new Motif { LibMotif = motif };
                    monModel.Motifs.Add(motifObj);
                    //monModel.SaveChanges();
                }
                leRapportChoisi.IdMotif = motifObj.IdMotif;

                leRapportChoisi.Bilan = bilan;

                if (!DateOnly.TryParseExact(
                    dateRapport,
                    "dd/MM/yyyy",
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out var d))
                {
                    throw new Exception("Date invalide");
                }

                leRapportChoisi.DateRapport = d;

                leRapportChoisi.EstRemplacant = estRemplacant;
                leRapportChoisi.AvisMedecin = avisMedecin;

                string heureFormatP = string.IsNullOrEmpty(heurePrevue) ? "00:00:00" : heurePrevue;
                string heureFormatR = string.IsNullOrEmpty(heureReelle) ? "00:00:00" : heureReelle;
                leRapportChoisi.HeurePrevue = TimeOnly.Parse(heureFormatP); ;
                leRapportChoisi.HeureReelle = TimeOnly.Parse(heureFormatR); ;
                leRapportChoisi.DureeVisite = dureeVisite;
                leRapportChoisi.IdMedecin = idMedecin;
                leRapportChoisi.IdVisiteur = UtilisateurConnecte.IdVisiteur;

                leRapportChoisi.IdMedicaments = new List<Medicament>();
                foreach (var m in medsPresentes)
                {
                    var medTracked = monModel.Medicaments.Find(m.IdMedicament) ?? m;
                    leRapportChoisi.IdMedicaments.Add(medTracked);
                }

                monModel.Rapports.Add(leRapportChoisi);
               // monModel.SaveChanges();  //générer idRapport

                foreach (var m in medsPresentes)
                {
                    /*
                    monModel.Presentations.Add(new Presentation
                    {
                        IdRapport = leRapportChoisi.IdRapport,
                        IdMedicament = m.IdMedicament
                    });
                    */
                }

                //Debug.WriteLine($"Nombre d'entités modifiées : {monModel.SaveChanges()}");
                Debug.WriteLine($"ID du rapport généré : {leRapportChoisi.IdRapport}");

                foreach (var o in echantillons.ToList())
                {
                    var idMed = o.IdMedicament;
                    var qte = o.Quantite;

                    monModel.Offrirs.Add(new Offrir
                    {
                        IdRapport = leRapportChoisi.IdRapport,
                        IdMedicament = idMed,
                        Quantite = qte
                    });
                }


                monModel.SaveChanges();

                //leRapportChoisi.Offrirs = new List<Offrir>();
                //foreach (var o in echantillons)
                //{
                //    leRapportChoisi.Offrirs.Add(new Offrir
                //    {
                //        IdMedicament = o.IdMedicament,
                //        Quantite = o.Quantite
                //    });
                //}
                //monModel.Rapports.Add(leRapportChoisi); 
                //monModel.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
                monModel.Dispose();
                init();
                Debug.WriteLine(ex.ToString());
                MessageBox.Show(ex.InnerException?.Message ?? ex.Message);
            }
            return vretour;
        }

        public static bool ModifRapport(string? motif, string bilan, int avisMedecin, bool estRemplacant, string dateRapport, string heurePrevue,
            string heureReelle, int dureeVisite, int idMedecin, List<Medicament> medsPresentes, List<Offrir> echantillons)
        {
            try
            {
                //motif
                var motifObj = monModel.Motifs.FirstOrDefault(m => m.LibMotif == motif);
                if (motifObj == null)
                {
                    motifObj = new Motif { LibMotif = motif };
                    monModel.Motifs.Add(motifObj);
                   // monModel.SaveChanges();
                }
                leRapportChoisi.IdMotif = motifObj.IdMotif;

                //formats
                if (!DateOnly.TryParse(dateRapport, out var d))
                    throw new Exception("Date invalide");

                if (!TimeOnly.TryParse(heurePrevue, out var hp))
                    throw new Exception("Heure prévue invalide");

                if (!TimeOnly.TryParse(heureReelle, out var hr))
                    throw new Exception("Heure réelle invalide");

                //champs
                leRapportChoisi.Bilan = bilan;
                leRapportChoisi.DateRapport = d;
                leRapportChoisi.HeurePrevue = hp;
                leRapportChoisi.HeureReelle = hr;
                leRapportChoisi.DureeVisite = dureeVisite;
                leRapportChoisi.IdMedecin = idMedecin;

                leRapportChoisi.EstRemplacant = estRemplacant;
                leRapportChoisi.AvisMedecin = avisMedecin;

                leRapportChoisi.IdMedicaments.Clear();
                foreach (var m in medsPresentes)
                {
                    var medTracked = monModel.Medicaments.Find(m.IdMedicament) ?? m;
                    leRapportChoisi.IdMedicaments.Add(medTracked);
                }

                //supprimer anciennes présentations
                /*
                var anciennesPres = monModel.Presentations
                    .Where(p => p.IdRapport == leRapportChoisi.IdRapport)
                    .ToList();

                monModel.Presentations.RemoveRange(anciennesPres);
                */
                //ajouter nouvelles
                foreach (var m in medsPresentes)
                {
                    /*
                    monModel.Presentations.Add(new Presentation
                    {
                        IdRapport = leRapportChoisi.IdRapport,
                        IdMedicament = m.IdMedicament
                    });
                    */
                }

                //supprimer ancien échantillon, ajouter nouveau
                //var anciensEch = leRapportChoisi.Offrirs.ToList();
                var anciensEch = monModel.Offrirs
                .Where(o => o.IdRapport == leRapportChoisi.IdRapport)
                .ToList();
                foreach (var o in anciensEch)
                    monModel.Offrirs.Remove(o);

                foreach (var o in echantillons)
                {
                    monModel.Offrirs.Add(new Offrir
                    {
                        IdRapport = leRapportChoisi.IdRapport,
                        IdMedicament = o.IdMedicament,
                        Quantite = o.Quantite
                    });
                }

                //entité est déjà trackée
                monModel.SaveChanges();
               // monModel.Dispose();
               // monModel = new TartempionContext();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException?.Message ?? ex.Message);
                monModel.Dispose();
                init();
                return false;
            }
        }
    }
}