using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tartempion.Models;

namespace tartempion
{
    public partial class FFicheDeFrais : Form
    {
        public FFicheDeFrais()
        {
            InitializeComponent();
        }

        private void FFicheDeFrais_Load(object sender, EventArgs e)
        {

            // 1. Récupérer l'ID de l'utilisateur connecté
            string userId = MonModelMission3.VisiteurConnecte.IdVisiteur.Trim().ToUpper();

            // 2. Filtrer les fiches de frais (en ignorant la casse)
            var toutesLesFiches = MonModelMission3.listeFicheFrais();
            var fichesFiltrees = toutesLesFiches
                .Where(f => f.IdVisiteur.Trim().ToUpper() == userId)
                .ToList();

            // 3. Mettre à jour le BindingSource et le DataGridView
            bsFicheDeFrais.DataSource = fichesFiltrees;
            dgvFicheDeFrais.DataSource = bsFicheDeFrais;
            dgvFicheDeFrais.Columns[0].Visible = false;
            dgvFicheDeFrais.Columns[1].HeaderText = "année et mois";
            dgvFicheDeFrais.Columns[2].HeaderText = "nombre de justificatif";
            dgvFicheDeFrais.Columns[3].HeaderText = "Montant Valide";
            dgvFicheDeFrais.Columns[4].HeaderText = "date de dernière modification";
            dgvFicheDeFrais.Columns[5].HeaderText = "Etat";
            dgvFicheDeFrais.Columns[6].Visible = false;
            dgvFicheDeFrais.Columns[7].Visible = false;
            dgvFicheDeFrais.Columns[8].Visible = false;
            dgvFicheDeFrais.Columns[9].Visible = false;


            txtMoisActuelle.Text = DateTime.Now.ToString("MMMM");
            txtVisiteurConnecte.Text = MonModelMission3.VisiteurConnecte.Nom.Trim() + " " + MonModelMission3.VisiteurConnecte.Prenom.ToString().Trim();

        }

        private void bsFicheDeFrais_CurrentChanged(object sender, EventArgs e)
        {
            Fichefrai laFicheDeFraisChoisie = (Fichefrai)bsFicheDeFrais.Current;
            txtDateDeDernierModifFiche.Text = laFicheDeFraisChoisie.DateModif.ToString();
            txtIdFiche.Text = laFicheDeFraisChoisie.IdVisiteur.Trim() + "/" + laFicheDeFraisChoisie.Mois.ToString().Trim();
            txtAnnéeFiche.Text = laFicheDeFraisChoisie.Mois.Substring(0, 4);
            txtMoisFiche.Text = laFicheDeFraisChoisie.Mois.Substring(4, 2);
            txtMontantValideFiche.Text = laFicheDeFraisChoisie.MontantValide.ToString();
            txtEtat.Text = laFicheDeFraisChoisie.IdEtatNavigation.Libelle;
            MonModelMission3.FicheFraisChoisi = laFicheDeFraisChoisie;


        }

        private void btnForfait_Click(object sender, EventArgs e)
        {
            if (dgvFicheDeFrais.CurrentRow == null)
            {
                MessageBox.Show("Veuillez sélectionner une fiche de frais.");
                return;
            }

            FFicheForfaitHorsForfait newFFicheForfaitHorsForfait = new FFicheForfaitHorsForfait();
            newFFicheForfaitHorsForfait.Show();
            this.Close();

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            MonModelMission3.AjoutModif = 1;
            FAjoutModifFicheDeFrais newFAjoutModifFicheDeFrais = new FAjoutModifFicheDeFrais();
            newFAjoutModifFicheDeFrais.Show();
            this.Close();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            // 1. Vérifier si une fiche est bien sélectionnée
            if (MonModelMission3.FicheFraisChoisi == null)
            {
                MessageBox.Show("Veuillez sélectionner une fiche de frais dans la liste avant de supprimer.",
                                "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Demander confirmation à l'utilisateur
            DialogResult dr = MessageBox.Show(
                $"Êtes-vous sûr de vouloir supprimer la fiche de {MonModelMission3.FicheFraisChoisi.Mois} " +
                $"pour le visiteur {MonModelMission3.FicheFraisChoisi.IdVisiteur} ?\n" +
                "Toutes les lignes de frais associées seront également supprimées.",
                "Confirmation de suppression",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                // 3. Appel de la méthode de suppression dans le modèle
                if (MonModelMission3.SuppficheFrais())
                {
                    MessageBox.Show("La fiche a été supprimée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 4. Actualiser l'affichage (ex: recharger la liste dans un DataGridView)
                    // Imaginons que ton DataGridView s'appelle dgvFiches
                    // 1. Récupérer l'ID de l'utilisateur connecté
                    string userId = MonModelMission3.VisiteurConnecte.IdVisiteur.Trim().ToUpper();

                    // 2. Filtrer les fiches de frais (en ignorant la casse)
                    var toutesLesFiches = MonModelMission3.listeFicheFrais();
                    var fichesFiltrees = toutesLesFiches
                        .Where(f => f.IdVisiteur.Trim().ToUpper() == userId)
                        .ToList();

                    // 3. Mettre à jour le BindingSource et le DataGridView
                    bsFicheDeFrais.DataSource = fichesFiltrees;
                    dgvFicheDeFrais.DataSource = bsFicheDeFrais;
                    dgvFicheDeFrais.Columns[0].Visible = false;
                    dgvFicheDeFrais.Columns[1].HeaderText = "année et mois";
                    dgvFicheDeFrais.Columns[2].HeaderText = "nombre de justificatif";
                    dgvFicheDeFrais.Columns[3].HeaderText = "Montant Valide";
                    dgvFicheDeFrais.Columns[4].HeaderText = "date de dernière modification";
                    dgvFicheDeFrais.Columns[5].HeaderText = "Etat";
                    dgvFicheDeFrais.Columns[6].Visible = false;
                    dgvFicheDeFrais.Columns[7].Visible = false;
                    dgvFicheDeFrais.Columns[8].Visible = false;
                    dgvFicheDeFrais.Columns[9].Visible = false;


                    txtMoisActuelle.Text = DateTime.Now.ToString("MMMM");
                    txtVisiteurConnecte.Text = MonModelMission3.VisiteurConnecte.Nom.Trim() + " " + MonModelMission3.VisiteurConnecte.Prenom.ToString().Trim();

                    // On remet la sélection à null pour éviter de supprimer deux fois la même chose
                    MonModelMission3.FicheFraisChoisi = null;
                }
                else
                {
                    // Le message d'erreur détaillé est déjà géré par le MessageBox dans le modèle
                    MessageBox.Show("La suppression a échoué.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

