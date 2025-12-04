using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        public static bool AjoutRapport(string ?motif, string bilan, string dateRapport, string heurePrevue, 
            string heureReelle, int dureeVisite, int idMedecin, List<Medicament> medsPresentes, List<Offrir> echantillons)
        {
            bool vretour = true;
            try
            {
                if (UtilisateurConnecte == null)
                    throw new Exception("Aucun utilisateur connecté");

                leRapportChoisi = new Rapport();
                //leRapportChoisi.IdMotifNavigation.LibMotif = motif;

                // Gestion du motif
                var motifObj = monModel.Motifs.FirstOrDefault(m => m.LibMotif == motif);
                if (motifObj == null)
                {
                    motifObj = new Motif { LibMotif = motif };
                    monModel.Motifs.Add(motifObj);
                    monModel.SaveChanges();
                }
                leRapportChoisi.IdMotif = motifObj.IdMotif; // Assigner l'ID

                leRapportChoisi.Bilan = bilan;
                
                if (DateOnly.TryParse(dateRapport, out var d))
                    leRapportChoisi.DateRapport = d;
                else
                    throw new Exception("Date invalide");

                leRapportChoisi.HeurePrevue = TimeOnly.Parse(heurePrevue); ;
                leRapportChoisi.HeureReelle = TimeOnly.Parse(heureReelle); ;
                leRapportChoisi.DureeVisite = dureeVisite;
                leRapportChoisi.IdMedecin = idMedecin;
                leRapportChoisi.IdVisiteur = UtilisateurConnecte.IdVisiteur;

                leRapportChoisi.IdMedicaments = new List<Medicament>();
                foreach (var m in medsPresentes)
                {
                    var medTracked = monModel.Medicaments.Find(m.IdMedicament) ?? m;
                    leRapportChoisi.IdMedicaments.Add(medTracked);
                }

                leRapportChoisi.Offrirs = new List<Offrir>();
                foreach (var o in echantillons)
                {
                    leRapportChoisi.Offrirs.Add(new Offrir
                    {
                        IdMedicament = o.IdMedicament,
                        Quantite = o.Quantite
                    });
                }

                monModel.Rapports.Add(leRapportChoisi); 
                monModel.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
                Debug.WriteLine(ex.ToString()); // plus complet
                MessageBox.Show(ex.InnerException?.Message ?? ex.Message);
            }
            return vretour;
        }

        public static bool ModifRapport(string? motif, string bilan, string dateRapport, string heurePrevue, 
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
                    monModel.SaveChanges();
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

               leRapportChoisi.IdMedicaments.Clear();
                foreach (var m in medsPresentes)
                {
                    var medTracked = monModel.Medicaments.Find(m.IdMedicament) ?? m;
                    leRapportChoisi.IdMedicaments.Add(medTracked);
                }

                //supprimer ancien échantillon, ajouter nouveau
                var anciensEch = leRapportChoisi.Offrirs.ToList();
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

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException?.Message ?? ex.Message);
                return false;
            }
        }
    }
}
