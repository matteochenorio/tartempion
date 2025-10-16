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
    public partial class FMedecins : Form
    {
        private bool afficherTousLesMedecins = false;
        public FMedecins()
        {
            InitializeComponent();
        }

        private void FMedecins_Load(object sender, EventArgs e)
        {
            cboSpecialite.ValueMember = "IdSpecialite";//bien mettre l'id de specialite et non de médecin !
            cboSpecialite.DisplayMember = "LibSpecialite";//pareil pour le lib
            bsSpecialite.DataSource = MonModelMission2.ListeSpecialite();
            cboSpecialite.DataSource = bsSpecialite;
        }

        private void bsSpecialite_CurrentChanged(object sender, EventArgs e)
        {
            Specialite laSpecialiteChoisie = (Specialite)bsSpecialite.Current;
            bsMedecin.DataSource = MonModelMission2.ListeMedecin().Where(x => x.IdSpecialite == laSpecialiteChoisie.IdSpecialite).ToList();
            dgvMedecin.DataSource = bsMedecin;
            dgvMedecin.Columns[0].Visible = false;
            dgvMedecin.Columns[1].HeaderText = "NOM";
            dgvMedecin.Columns[2].HeaderText = "PRENOM";
            dgvMedecin.Columns[3].HeaderText = "ADRESSE";
            dgvMedecin.Columns[4].HeaderText = "TELEPHONE";
            dgvMedecin.Columns[5].Visible = false;
            dgvMedecin.Columns[6].HeaderText = "N° DEPARTEMENT GSB";
            dgvMedecin.Columns[7].Visible = false;
            dgvMedecin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnSpecialiteMedecin_Click(object sender, EventArgs e)
        {
            afficherTousLesMedecins = !afficherTousLesMedecins;

            if (afficherTousLesMedecins)
            {
                bsMedecin.DataSource = MonModelMission2.ListeMedecin() 
                .Select(x => new { x.IdMedecin, x.Nom, x.Prenom, x.Adresse, x.Tel, x.IdSpecialite, x.Departement }).OrderBy(x => x.Nom).ToList();
                cboSpecialite.Enabled = false;
                btnSpecialiteMedecin.Text = "Filtrer sur 1 spécialité";
                btnSpecialiteMedecin.BackColor = Color.LightGreen;
            }
            else
            {
                Specialite laSpecialiteChoisie = (Specialite)bsSpecialite.Current;
                bsMedecin.DataSource = laSpecialiteChoisie.Medecins
                .Select(x => new { x.IdMedecin, x.Nom, x.Prenom, x.Adresse, x.Tel, x.IdSpecialite, x.Departement }).OrderBy(x => x.Nom).ToList();
                cboSpecialite.Enabled = true;
                btnSpecialiteMedecin.Text = "Filtrer sur toutes les spécialités";
                btnSpecialiteMedecin.BackColor = Color.Red;
            }

        }
    }
}
