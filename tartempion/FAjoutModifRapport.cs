using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace tartempion
{
    public partial class FAjoutModifRapport : Form
    {
        public FAjoutModifRapport()
        {
            InitializeComponent();
        }

        private bool vretour = false;

        private void FAjoutModifRapport_Load(object sender, EventArgs e)
        {
            //cboMedecin
            cboMedecin.ValueMember = "idMedecin";
            cboMedecin.DisplayMember = "nom";
            bsMedecin.DataSource = MonModelMission2.ListeMedecin();
            cboMedecin.DataSource = bsMedecin;

            cboMedecin.SelectedValue = MonModelMission2.LeRapportChoisi.IdMedecin;

            if (MonModelMission2.ActionRapport == 2)
            {

                if (MonModelMission2.LeRapportChoisi.EstRemplacant == true)
                {
                    checkBoxRemplacant.Checked = true;
                }
                else
                {
                    checkBoxRemplacant.Checked = false;
                    tbMotif.Text = MonModelMission2.LeRapportChoisi.IdMotifNavigation?.LibMotif?.ToString();
                    qteAvis.Value = (MonModelMission2.LeRapportChoisi.AvisMedecin == 1) ? 1 : 5;
                    tbDateRapport.Text = MonModelMission2.LeRapportChoisi.DateRapport?.ToString("dd/MM/yyyy");
                    tbHeurePrevue.Text = MonModelMission2.LeRapportChoisi.HeurePrevue.ToString("HH:mm:ss");
                    tbHeureReelle.Text = MonModelMission2.LeRapportChoisi.HeureReelle.ToString("HH:mm:ss");
                    tbDureeVisite.Text = MonModelMission2.LeRapportChoisi.DureeVisite.ToString();

                    tbBilan.Text = MonModelMission2.LeRapportChoisi.Bilan.ToString();

                    //cboEchantillon.SelectedValue = MonModelMission2.LeRapportChoisi.IdVisiteurNavigation?.Nom.ToString();

                    //médicaments présentés
                    bsMedicamentPresentes.DataSource = MonModelMission2.LeRapportChoisi.IdMedicaments.ToList();
                    dgvPresentes.DataSource = bsMedicamentPresentes;

                    for (int i = 0; i < dgvPresentes.Columns.Count; i++)
                    {
                        dgvPresentes.Columns[i].Visible = false;

                    }
                    dgvPresentes.Columns[1].Visible = true;
                    dgvPresentes.Columns[1].HeaderCell.Value = "Nom Commercial";

                    //echantillons
                    bsEchantillon.DataSource = MonModelMission2.LeRapportChoisi.IdMedicament.ToList();
                    dgvEchantillon.DataSource = bsEchantillon;

                    //for (int i = 0; i < dgvEchantillon.Columns.Count; i++)
                    //{
                    //    dgvEchantillon.Columns[i].Visible = false;
                    //}
                    //dgvEchantillon.Columns[1].Visible = true;
                    //dgvEchantillon.Columns[1].HeaderCell.Value = "Id Medicament";
                    //dgvEchantillon.Columns[2].Visible = true;
                    //dgvEchantillon.Columns[2].HeaderCell.Value = "Quantité Offerte";
                }
            }
        }

        private bool tests()
        {
            if (System.String.IsNullOrEmpty(tbMotif.Text))
            {
                errorProvider.SetError(tbMotif, "Le motif du rapport doit être renseigné.");
                vretour = false;
            }
            return vretour;
        }

        private void btnCancelAjoutModif_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
