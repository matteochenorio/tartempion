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
    public partial class FMedicaments : Form
    {
        private bool afficherTousLesMedicaments = false;
        public FMedicaments()
        {
            InitializeComponent();
        }

        private void FMedicaments_Load(object sender, EventArgs e)
        {
            cboFamille.ValueMember = "idFamille";//bien mettre l'id de famille et non de médica !
            cboFamille.DisplayMember = "libFamille";//pareil pour le lib
            bsFamille.DataSource = MonModelMission2.ListeFamille();
            cboFamille.DataSource = bsFamille;
            //btnFamilleMedica.Text = "Filtrer sur toutes les familles";
            //btnFamilleMedica.BackColor = Color.Red;
        }

        private void bsFamille_CurrentChanged(object sender, EventArgs e)
        {
            Famille laFamilleChoisie = (Famille)bsFamille.Current;
            bsMedicament.DataSource = MonModelMission2.ListeMedicament().Where(x => x.IdFamille == laFamilleChoisie.IdFamille).ToList();
            dgvMedicament.DataSource = bsMedicament;
            dgvMedicament.Columns[0].HeaderText = "N° MEDICAMENT";
            dgvMedicament.Columns[1].HeaderText = "NOM COMMERCIAL";
            dgvMedicament.Columns[2].HeaderText = "FAMILLE";
            dgvMedicament.Columns[3].HeaderText = "COMPOSITION";
            dgvMedicament.Columns[4].HeaderText = "EFFETS";
            dgvMedicament.Columns[5].HeaderText = "CONTRE INDICATIONS";
            //dgvMedicament.Columns[6].Visible = false;
            dgvMedicament.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnFamilleMedica_Click(object sender, EventArgs e)
        {
            afficherTousLesMedicaments = !afficherTousLesMedicaments;

            if (afficherTousLesMedicaments)
            {
                bsMedicament.DataSource = MonModelMission2.ListeMedicament()
                .Select(x => new { x.IdMedicament, x.NomCommercial, x.IdFamille, x.Composition, x.Effets, x.ContreIndications }).OrderBy(x => x.NomCommercial).ToList();
                cboFamille.Enabled = false;
                btnFamilleMedica.Text = "Filtrer sur 1 nationalité";
                btnFamilleMedica.BackColor = Color.LightGreen;
            }
            else
            {
                Famille laFamilleChoisie = (Famille)bsFamille.Current;
                bsMedicament.DataSource = laFamilleChoisie.Medicaments
                .Select(x => new { x.IdMedicament, x.NomCommercial, x.IdFamille, x.Composition, x.Effets, x.ContreIndications }).OrderBy(x => x.NomCommercial).ToList();
                cboFamille.Enabled = true;
                btnFamilleMedica.Text = "Filtrer sur toutes les familles";
                btnFamilleMedica.BackColor = Color.Red;
            }
        }
    }
}
