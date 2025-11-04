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
    public partial class FVoirRapports : Form
    {
        public FVoirRapports()
        {
            InitializeComponent();
        }

        private void FVoirRapports_Load(object sender, EventArgs e)
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

        private void bsMedecin_CurrentChanged(object sender, EventArgs e)
        {
            bsRapport.DataSource = MonModelMission2.ListeRapport();
            Medecin leMedecinChoisi = (Medecin)bsMedecin.Current;

            bsRapport.DataSource = leMedecinChoisi.Rapports.ToList();
            dgvMedecin.DataSource = bsMedecin;
            dgvMedecin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dgvRapport.DataSource = bsRapport;
            dgvRapport.AutoGenerateColumns = false;
            dgvRapport.Columns[0].Visible = false;
            dgvRapport.Columns[1].HeaderText = "DATE RAPPORT";
            dgvRapport.Columns[2].Visible = false;
            dgvRapport.Columns[3].HeaderText = "BILAN RAPPORT";
            dgvRapport.Columns[4].HeaderText = "ID DU VISITEUR";
            dgvRapport.Columns[5].HeaderText = "ID DU MEDECIN";
            //dgvRapport.Columns[5].Visible = false;
            //dgvRapport.Columns[6].Visible = false;
            //dgvRapport.Columns[7].Visible = false;
            //dgvRapport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //dgvRapport.Visible = (bsRapport.Count > 0);
        }

        private void bsRapport_CurrentChanged(object sender, EventArgs e)
        {
            cboFiltreRapport.ValueMember = "IdRapport";
            cboFiltreRapport.DisplayMember = "bilan";
            cboFiltreRapport.DataSource = MonModelMission2.ListeRapport();
            cboFiltreRapport.DataSource = bsFiltreRapport;
        }
    }
}
