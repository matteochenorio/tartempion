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
using tartempion.Models;

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
                }

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
                bsEchantillon.DataSource = MonModelMission2.LeRapportChoisi.Offrirs.ToList();
                dgvEchantillon.DataSource = bsEchantillon;

                for (int i = 0; i < dgvEchantillon.Columns.Count; i++)
                {
                    dgvEchantillon.Columns[i].Visible = false;
                }
                dgvEchantillon.Columns[1].Visible = true;
                dgvEchantillon.Columns[2].Visible = true;
                dgvEchantillon.Columns[1].HeaderCell.Value = "Nom Commercial";
                dgvEchantillon.Columns[2].HeaderCell.Value = "Quantité";
            }
        }

        private Medicament ChoixMedicament()
        {
            var medicaments = MonModelMission2.ListeMedicament();
            var form = new Form();
            var combo = new ComboBox();
            combo.DataSource = medicaments;
            combo.DisplayMember = "NomCommercial";
            combo.ValueMember = "IdMedicament";
            form.Controls.Add(combo);
            combo.Dock = DockStyle.Fill;
            form.Text = "sélectionner médicament!";
            var btnOk = new Button { Text = "OK", DialogResult = DialogResult.OK };
            btnOk.Dock = DockStyle.Bottom;
            form.Controls.Add(btnOk);
            form.AcceptButton = btnOk;
            if (form.ShowDialog() == DialogResult.OK)
            {
                return combo.SelectedItem as Medicament;
            }
            return null;
        }

        private void btnCancelAjoutModif_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAjoutPresentes_Click(object sender, EventArgs e)
        {
            var medicament = ChoixMedicament();
            if (medicament != null)
            {
                var liste = bsMedicamentPresentes.DataSource as List<Medicament>;
                if (liste == null)
                {
                    liste = new List<Medicament>();
                    bsMedicamentPresentes.DataSource = liste;
                }
                if (liste.Any(m => m.IdMedicament == medicament.IdMedicament))
                {
                    MessageBox.Show("déjà dans médicaments présentés!");
                    return;
                }
                liste.Add(medicament);
                bsMedicamentPresentes.ResetBindings(false);
            }
        }

        private void btnDeletePresentes_Click(object sender, EventArgs e)
        {
            if (dgvPresentes.CurrentRow != null)
            {
                var medicament = dgvPresentes.CurrentRow.DataBoundItem as Medicament;
                var liste = bsMedicamentPresentes.DataSource as List<Medicament>;
                if (liste != null && medicament != null)
                {
                    liste.Remove(medicament);
                    bsMedicamentPresentes.ResetBindings(false);
                }
            }
            else
            {
                MessageBox.Show("sélectionner médicament!");
            }
        }

        private void btnAjoutEchantillon_Click(object sender, EventArgs e)
        {
            var medicament = ChoixMedicament();//comme pour médicaments présentés
            if (medicament == null) return;

            //demander quantité
            var qteForm = new Form();
            var num = new NumericUpDown() { Minimum = 1, Maximum = 100, Value = 1, Dock = DockStyle.Top };
            var ok = new Button() { Text = "OK", DialogResult = DialogResult.OK, Dock = DockStyle.Bottom };
            qteForm.Controls.Add(num);
            qteForm.Controls.Add(ok);
            qteForm.AcceptButton = ok;

            if (qteForm.ShowDialog() != DialogResult.OK) return;

            var liste = bsEchantillon.DataSource as List<Offrir>;
            if (liste == null)
            {
                liste = new List<Offrir>();
                bsEchantillon.DataSource = liste;
            }

            if (liste.Any(o => o.IdMedicament == medicament.IdMedicament))
            {
                MessageBox.Show("déjà dans échantillons offerts!");
                return;
            }

            liste.Add(new Offrir
            {
                IdRapport = MonModelMission2.LeRapportChoisi.IdRapport,
                IdMedicament = medicament.IdMedicament,
                IdMedicamentNavigation = medicament,
                Quantite = (int)num.Value
            });

            bsEchantillon.ResetBindings(false);
        }

        private void btnDeleteEchantillon_Click(object sender, EventArgs e)
        {
            if (dgvEchantillon.CurrentRow != null)
            {
                var ech = dgvEchantillon.CurrentRow.DataBoundItem as Offrir;
                var liste = bsEchantillon.DataSource as List<Offrir>;
                liste.Remove(ech);
                bsEchantillon.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("sélectionnez échantillon!");
            }
        }

        private void btnModifQuantite_Click(object sender, EventArgs e)
        {
            if (dgvEchantillon.CurrentRow == null)
            {
                MessageBox.Show("sélectionner échantillon!");
                return;
            }

            var ech = dgvEchantillon.CurrentRow.DataBoundItem as Offrir;
            if (ech == null) return;

            var form = new Form();
            var num = new NumericUpDown()
            {
                Minimum = 1,
                Maximum = 100,
                Value = ech.Quantite.HasValue ? ech.Quantite.Value : 1,
                Dock = DockStyle.Top
            };
            var ok = new Button() { Text = "OK", DialogResult = DialogResult.OK, Dock = DockStyle.Bottom };
            form.Controls.Add(num);
            form.Controls.Add(ok);
            form.AcceptButton = ok;

            if (form.ShowDialog() == DialogResult.OK)
            {
                ech.Quantite = (int)num.Value;
                bsEchantillon.ResetBindings(false);
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

        private void btnOKAjoutModif_Click(object sender, EventArgs e)
        {
            //    if (tests() && ModelProjet.ActionCompositeur == 1)
            //    {
            //        string nom = tbNom.Text;
            //        string prenom = tbPrenom.Text;
            //        string remarque = tbCommentaire.Text;
            //        int anNais = int.Parse(tbDateDebut.Text);
            //        int anMort = int.Parse(tbDateFin.Text);
            //        int idNation = (int)cboNation.SelectedValue;
            //        int idStyle = (int)cboStyle.SelectedValue;

            //        vretour = ModelProjet.AjoutCompositeur(nom, prenom, remarque, anNais, anMort, idNation, idStyle);

            //        if (vretour)
            //        {
            //            MessageBox.Show("Compositeur ajouté !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            this.Close();
            //        }
            //        else
            //        {
            //            MessageBox.Show("Erreur", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }

            //    else if (tests() && ModelProjet.ActionCompositeur == 2)
            //    {
            //        string nom = tbNom.Text;
            //        string prenom = tbPrenom.Text;
            //        string remarque = tbCommentaire.Text;
            //        int anNais = int.Parse(tbDateDebut.Text);
            //        int anMort = int.Parse(tbDateFin.Text);
            //        int idNation = (int)cboNation.SelectedValue;
            //        int idStyle = (int)cboStyle.SelectedValue;

            //        vretour = ModelProjet.ModifCompositeur(nom, prenom, remarque, anNais, anMort, idNation, idStyle);

            //        if (vretour)
            //        {
            //            MessageBox.Show("Compositeur modifié !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            this.Close();
            //        }
            //        else
            //        {
            //            MessageBox.Show("Erreur", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Erreur(s) dans le formulaire", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //}
        }
    }
}