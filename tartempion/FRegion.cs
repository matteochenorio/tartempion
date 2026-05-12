using System;
using System.Windows.Forms;
using tartempion.Models;
using Region = tartempion.Models.Region;

namespace tartempion
{
    public partial class FRegion : Form
    {
        public FRegion()
        {
            InitializeComponent();
        }

        private void FRegion_Load(object sender, EventArgs e)
        {
            bsSecteur.DataSource = MonModelMission1.listRegion();
            dgvSecteur.DataSource = bsSecteur;
            cbSecteur.DataSource = MonModelMission1.listVisiteur();
            cbSecteur.DisplayMember = "Nom";
            cbSecteur.ValueMember = "IdVisiteur";
        }

        private void bsSecteur_CurrentChanged(object sender, EventArgs e)
        {
            if (bsSecteur.Current is Region r)
                cbSecteur.SelectedValue = r.IdVisiteur;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (bsSecteur.Current is Region regionSelectionnee
                && cbSecteur.SelectedValue is string idVisiteur)
            {
                regionSelectionnee.IdVisiteur = idVisiteur;
                MonModelMission1.MonModel.SaveChanges();
                MessageBox.Show("Responsable affecté avec succès !", "Succès",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                bsSecteur.DataSource = MonModelMission1.listRegion();
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (bsSecteur.Current is Region regionSelectionnee)
            {
                var confirm = MessageBox.Show(
                    $"Supprimer la région {regionSelectionnee.LibRegion} ?",
                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    MonModelMission1.MonModel.Regions.Remove(regionSelectionnee);
                    MonModelMission1.MonModel.SaveChanges();
                    bsSecteur.DataSource = MonModelMission1.listRegion();
                }
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fonctionnalité Ajouter à implémenter.");
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}