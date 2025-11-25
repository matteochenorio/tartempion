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

            //cboMedicament et echantillon
            cboMedicament.ValueMember = "idMedicament";
            cboMedicament.DisplayMember = "nomCommercial";
            bsMedicament.DataSource = MonModelMission2.ListeMedicament();
            cboMedicament.DataSource = bsMedicament;

            cboMedicament1.ValueMember = "idMedicament";
            cboMedicament1.DisplayMember = "nomCommercial";
            bsMedicament1.DataSource = MonModelMission2.ListeMedicament();
            cboMedicament1.DataSource = bsMedicament1;

            cboEchantillon.ValueMember = "idMedicament";
            cboEchantillon.DisplayMember = "nomCommercial";
            bsEchantillon.DataSource = MonModelMission2.ListeMedicament();
            cboEchantillon.DataSource = bsEchantillon;

            cboEchantillon1.ValueMember = "idMedicament";
            cboEchantillon1.DisplayMember = "nomCommercial";
            bsEchantillon1.DataSource = MonModelMission2.ListeMedicament();
            cboEchantillon1.DataSource = bsEchantillon1;

            cboEchantillon2.ValueMember = "idMedicament";
            cboEchantillon2.DisplayMember = "nomCommercial";
            bsEchantillon2.DataSource = MonModelMission2.ListeMedicament();
            cboEchantillon2.DataSource = bsEchantillon2;

            if (MonModelMission2.ActionRapport == 2)
            {
                cboMedecin.SelectedValue = MonModelMission2.LeRapportChoisi.IdMedecin;

                //if (MonModelMission2.LeRapportChoisi.EstRemplacant = true)
                //{
                //    checkBoxRemplacant.Checked == true;
                //}
                //else
                //{
                //    checkBoxRemplacant.Checked == false;

                cboMedecin.SelectedValue = MonModelMission2.LeRapportChoisi.IdMedicament;
                tbMotif.Text = MonModelMission2.LeRapportChoisi.IdMotifNavigation?.LibMotif?.ToString();
                qteAvis.Value = (MonModelMission2.LeRapportChoisi.AvisMedecin == 1) ? 1 : 5;
                tbDateRapport.Text = MonModelMission2.LeRapportChoisi.DateRapport?.ToString("dd/MM/yyyy");
                tbHeurePrevue.Text = MonModelMission2.LeRapportChoisi.HeurePrevue.ToString("HH:mm:ss");
                tbHeureReelle.Text = MonModelMission2.LeRapportChoisi.HeureReelle.ToString("HH:mm:ss");
                tbDureeVisite.Text = MonModelMission2.LeRapportChoisi.DureeVisite.ToString();

                tbBilan.Text = MonModelMission2.LeRapportChoisi.Bilan.ToString();


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
