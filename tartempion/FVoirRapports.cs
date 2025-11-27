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
        private bool afficherTousLesMedecins = false;
        private bool afficherTousLesRapports = false;
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


            cboFiltreRapport.ValueMember = "IdRapport";
            cboFiltreRapport.DisplayMember = "bilan";
            cboFiltreRapport.DataSource = MonModelMission2.ListeRapport();
            cboFiltreRapport.DataSource = bsFiltreRapport;
        }

        private void bsSpecialite_CurrentChanged(object sender, EventArgs e)
        {
            Specialite laSpecialiteChoisie = (Specialite)bsSpecialite.Current;
            bsMedecin.DataSource = MonModelMission2.ListeMedecin().Where(x => x.IdSpecialite == laSpecialiteChoisie.IdSpecialite).ToList();
            dgvMedecin.DataSource = bsMedecin;
            //dgvMedecin.Columns[0].Visible = false;
            dgvMedecin.Columns[0].Visible = true;
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
            //cboFiltreRapport.ValueMember = "IdRapport";
            //cboFiltreRapport.DisplayMember = "bilan";
            //cboFiltreRapport.DataSource = MonModelMission2.ListeRapport();
            //cboFiltreRapport.DataSource = bsFiltreRapport;
        }

        private void btnSpecialiteMedecin_Click(object sender, EventArgs e)
        {
            afficherTousLesMedecins = !afficherTousLesMedecins;

            if (afficherTousLesMedecins)
            {
                bsMedecin.DataSource = MonModelMission2.ListeMedecin()
                .OrderBy(x => x.Nom)
                .ToList();
                //bsMedecin.DataSource = MonModelMission2.ListeMedecin()
                //.Select(x => new { x.IdMedecin, x.Nom, x.Prenom, x.Adresse, x.Tel, x.IdSpecialite, x.Departement }).OrderBy(x => x.Nom).ToList();
                cboSpecialite.Enabled = false;
                btnSpecialiteMedecin.Text = "Filtrer sur 1 spécialité";
                btnSpecialiteMedecin.BackColor = Color.LightGreen;
            }
            else
            {
                Specialite laSpecialiteChoisie = (Specialite)bsSpecialite.Current;
                bsMedecin.DataSource = laSpecialiteChoisie.Medecins
                .OrderBy(x => x.Nom)
                .ToList();
                cboSpecialite.Enabled = true;
                btnSpecialiteMedecin.Text = "Filtrer sur toutes les spécialités";
                btnSpecialiteMedecin.BackColor = Color.Red;
            }
        }

        private void btnFiltreRapport_Click(object sender, EventArgs e)
        {
            afficherTousLesRapports = !afficherTousLesRapports;

            if (afficherTousLesRapports)
            {
                bsRapport.DataSource = MonModelMission2.ListeRapport();
                dgvRapport.DataSource = bsRapport;
                cboSpecialite.Enabled = false;
                dgvMedecin.Enabled = false;
                btnFiltreRapport.BackColor = Color.LightGreen;
                btnFiltreRapport.Text = "Tous les rapports";
            }
            else
            {
                if (bsMedecin.Current != null)
                {
                    Medecin leMedecinChoisi = (Medecin)bsMedecin.Current;
                    bsRapport.DataSource = leMedecinChoisi.Rapports.ToList();
                    dgvRapport.DataSource = bsRapport;
                }
                cboSpecialite.Enabled = true;
                dgvMedecin.Enabled = true;
                btnFiltreRapport.BackColor = Color.Red;
                btnFiltreRapport.Text = "Filtrer par médecin";
            }
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            MonModelMission2.ActionRapport = 1;
            FAjoutModifRapport newFAjoutModifCompositeur = new FAjoutModifRapport();
            newFAjoutModifCompositeur.ShowDialog();
            bsRapport_CurrentChanged(this, null);
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            MonModelMission2.ActionRapport = 2;
            System.Type type = bsRapport.Current.GetType();
            int id = (int)type.GetProperty("IdRapport").GetValue(bsRapport.Current, null);

            MonModelMission2.setLeRapportChoisi(id);
            FAjoutModifRapport newFAjoutModifRapport = new FAjoutModifRapport();
            newFAjoutModifRapport.ShowDialog();
            bsRapport_CurrentChanged(this, null);
        }
    }
}
