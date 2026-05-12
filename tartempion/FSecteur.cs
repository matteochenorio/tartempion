using System;
using System.Linq;
using System.Windows.Forms;
using tartempion.Models;
using Region = tartempion.Models.Region;

namespace tartempion
{
    public partial class FSecteur : Form
    {
        public FSecteur()
        {
            InitializeComponent();
        }

        private void FSecteur_Load(object sender, EventArgs e)
        {
            bsSecteur.DataSource = MonModelMission1.listSecteur();
            cbSecteur.DataSource = bsSecteur;
            cbSecteur.DisplayMember = "LibSecteur";
            cbSecteur.ValueMember = "IdSecteur";
            bsRegion.DataSource = MonModelMission1.listRegion();
            cbRegion.DataSource = bsRegion;
            cbRegion.DisplayMember = "LibRegion";
            cbRegion.ValueMember = "IdRegion";
            bsVisiteur.DataSource = MonModelMission1.listVisiteur();
            cbVisiteur.DataSource = bsVisiteur;
            cbVisiteur.DisplayMember = "Nom";
            cbVisiteur.ValueMember = "IdVisiteur";
            dgvSecteur.DataSource = bsSecteur;
        }

        private void cbRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSecteur.SelectedItem is Secteur secteurChoisi)
            {
                bsRegion.DataSource = MonModelMission1.listRegion()
                    .Where(r => r.IdSecteur == secteurChoisi.IdSecteur)
                    .ToList();
            }
        }

        private void CbVisiteur_SelectedIndexChanged(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (cbSecteur.SelectedItem is Secteur secteurSelectionne
                && cbVisiteur.SelectedValue is string idVisiteur)
            {
                bool estEligible = MonModelMission1.listRegion()
                    .Any(r => r.IdSecteur == secteurSelectionne.IdSecteur
                           && r.IdVisiteur == idVisiteur);
                if (!estEligible)
                {
                    MessageBox.Show("Ce visiteur doit d'abord être responsable d'une région de ce secteur !",
                        "Règle non respectée", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                secteurSelectionne.IdVisiteur = idVisiteur;
                MonModelMission1.MonModel.SaveChanges();
                MessageBox.Show("Chef de secteur affecté !", "Succès",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                bsSecteur.DataSource = MonModelMission1.listSecteur();
                dgvSecteur.DataSource = bsSecteur;
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fonctionnalité Ajouter à implémenter.");
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (bsSecteur.Current is Secteur secteurSelectionne)
            {
                var confirm = MessageBox.Show($"Supprimer le secteur {secteurSelectionne.LibSecteur} ?",
                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    MonModelMission1.MonModel.Secteurs.Remove(secteurSelectionne);
                    MonModelMission1.MonModel.SaveChanges();
                    bsSecteur.DataSource = MonModelMission1.listSecteur();
                    dgvSecteur.DataSource = bsSecteur;
                }
            }
        }
    }
}