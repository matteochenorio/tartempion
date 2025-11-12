using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tartempion
{
    public partial class FAjoutModifRapport : Form
    {
        public FAjoutModifRapport()
        {
            InitializeComponent();
        }

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
            bsMedicament.DataSource = MonModelMission2.ListeMedicament();
            cboMedicament1.DataSource = bsMedicament;

            cboEchantillon.ValueMember = "idMedicament";
            cboEchantillon.DisplayMember = "nomCommercial";
            bsMedicament.DataSource = MonModelMission2.ListeMedicament();
            cboEchantillon.DataSource = bsMedicament;

            cboEchantillon1.ValueMember = "idMedicament";
            cboEchantillon1.DisplayMember = "nomCommercial";
            bsMedicament.DataSource = MonModelMission2.ListeMedicament();
            cboEchantillon1.DataSource = bsMedicament;

            cboEchantillon2.ValueMember = "idMedicament";
            cboEchantillon2.DisplayMember = "nomCommercial";
            bsMedicament.DataSource = MonModelMission2.ListeMedicament();
            cboEchantillon2.DataSource = bsMedicament;

            if (MonModelMission2.ActionRapport == 2)
            {
                tbMotif.Text = MonModelMission2.LeRapportChoisi.IdMotif.ToString();
                tbBilan.Text = MonModelMission2.LeRapportChoisi.Bilan.ToString();
            }

        }
    }
}
