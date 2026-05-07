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
            bsMedecin.DataSource = MonModelMission2.ListeMedecinParVisiteur();
            cboMedecin.DataSource = bsMedecin;

            //cboMedecin.SelectedValue = MonModelMission2.LeRapportChoisi.IdMedecin;

            if (MonModelMission2.ActionRapport == 2)
            {
                cboMedecin.SelectedValue = MonModelMission2.LeRapportChoisi.IdMedecin;

                if (MonModelMission2.LeRapportChoisi.EstRemplacant == true)
                {
                    checkBoxRemplacant.Checked = true;
                }
                else
                {
                    checkBoxRemplacant.Checked = false;
                }

                tbMotif.Text = MonModelMission2.LeRapportChoisi.IdMotifNavigation?.LibMotif?.ToString();
                //qteAvis.Value = (MonModelMission2.LeRapportChoisi.AvisMedecin == 1) ? 1 : 5;
                //qteAvis.Value = MonModelMission2.LeRapportChoisi.AvisMedecin;
                qteAvis.Minimum = 1;
                qteAvis.Maximum = 5;

                var avis = MonModelMission2.LeRapportChoisi.AvisMedecin;
                qteAvis.Value = Math.Clamp(avis, 1, 5);
                tbDateRapport.Text = MonModelMission2.LeRapportChoisi.DateRapport?.ToString("dd/MM/yyyy");
                tbHeurePrevue.Text = MonModelMission2.LeRapportChoisi.HeurePrevue.ToString("HH:mm:ss");
                tbHeureReelle.Text = MonModelMission2.LeRapportChoisi.HeureReelle.ToString("HH:mm:ss");
                tbDureeVisite.Text = MonModelMission2.LeRapportChoisi.DureeVisite.ToString();

                tbBilan.Text = MonModelMission2.LeRapportChoisi.Bilan.ToString();

                //cboEchantillon.SelectedValue = MonModelMission2.LeRapportChoisi.IdVisiteurNavigation?.Nom.ToString();

                //médicaments présentés
                bsMedicamentPresentes.DataSource = MonModelMission2.LeRapportChoisi.IdMedicaments.ToList();
                
                //bsMedicamentPresentes.DataSource = MonModelMission2.LeRapportChoisi.Presentations
                //.Select(p => p.Medicament)
                //.ToList();
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
                if (liste.Count >= 2)
                {
                    MessageBox.Show("maximum 2 médicaments présentés!");
                    return;
                }
                liste.Add(medicament);
                bsMedicamentPresentes.ResetBindings(false);
            }
        }

        //private void btnDeletePresentes_Click(object sender, EventArgs e)
        //{
        //    if (dgvPresentes.CurrentRow != null)
        //    {
        //        var medicament = dgvPresentes.CurrentRow.DataBoundItem as Medicament;
        //        var liste = bsMedicamentPresentes.DataSource as List<Medicament>;
        //        if (liste != null && medicament != null)
        //        {
        //            liste.Remove(medicament);
        //            bsMedicamentPresentes.ResetBindings(false);
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("sélectionner médicament!");
        //    }
        //}

        private void btnDeletePresentes_Click(object sender, EventArgs e)
        {
            var liste = bsMedicamentPresentes.DataSource as List<Medicament>;
            var selected = dgvPresentes.CurrentRow?.DataBoundItem as Medicament;

            if (liste == null || selected == null)
            {
                MessageBox.Show("sélectionner médicament!");
                return;
            }

            var item = liste.FirstOrDefault(m => m.IdMedicament == selected.IdMedicament);

            if (item != null)
            {
                liste.Remove(item);
                bsMedicamentPresentes.ResetBindings(false);
            }
        }

        private void btnAjoutEchantillon_Click(object sender, EventArgs e)
        {
            var medicament = ChoixMedicament();//comme pour médicaments présentés
            if (medicament == null) return;

            //demander quantité
            var qteForm = new Form();
            var num = new NumericUpDown() { Minimum = 1, Maximum = 5, Value = 1, Dock = DockStyle.Top };
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

            if (liste.Count >= 3)
            {
                MessageBox.Show("maximum 3 échantillons présentés!");
                return;
            }

            //liste.Add(new Offrir
            //{
            //    //IdRapport = MonModelMission2.LeRapportChoisi.IdRapport,
            //    IdMedicament = medicament.IdMedicament,
            //    //IdMedicamentNavigation = medicament,
            //    Quantite = (int)num.Value
            //});

            liste.Add(new Offrir
            {
                IdMedicament = medicament.IdMedicament,
                IdMedicamentNavigation = medicament,
                Quantite = (int)num.Value
            });

            bsEchantillon.ResetBindings(false);
        }

        //private void btnDeleteEchantillon_Click(object sender, EventArgs e)
        //{
        //    if (dgvEchantillon.CurrentRow != null)
        //    {
        //        var ech = dgvEchantillon.CurrentRow.DataBoundItem as Offrir;
        //        var liste = bsEchantillon.DataSource as List<Offrir>;
        //        liste.Remove(ech);
        //        bsEchantillon.ResetBindings(false);
        //    }
        //    else
        //    {
        //        MessageBox.Show("sélectionnez échantillon!");
        //    }
        //}

        private void btnDeleteEchantillon_Click(object sender, EventArgs e)
        {
            var liste = bsEchantillon.DataSource as List<Offrir>;
            var selected = dgvEchantillon.CurrentRow?.DataBoundItem as Offrir;

            if (liste == null || selected == null)
            {
                MessageBox.Show("sélectionnez échantillon!");
                return;
            }

            var item = liste.FirstOrDefault(o => o.IdMedicament == selected.IdMedicament);

            if (item != null)
            {
                liste.Remove(item);
                bsEchantillon.ResetBindings(false);
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
            vretour = true;
            errorProvider.Clear();

            //if (System.String.IsNullOrEmpty(tbMotif.Text))
            //{
            //    errorProvider.SetError(tbMotif, "Le motif du rapport doit être renseigné.");
            //    vretour = false;

            //}

            if (System.String.IsNullOrEmpty(tbBilan.Text))
            {
                errorProvider.SetError(tbBilan, "Le bilan du rapport doit être renseigné.");
                vretour = false;

            }

            //if (checkBoxRemplacant.Checked == false && System.String.IsNullOrEmpty(tbMotif.Text))
            //{
            //    errorProvider.SetError(tbMotif, "Le motif du rapport doit être renseigné si le médecin n'est pas un remplaçant.");
            //    vretour = false;
            //}

            int avisMedecin = (int)qteAvis.Value;
            if (avisMedecin < 1 || avisMedecin > 5)
            {
                errorProvider.SetError(qteAvis, "L'avis du médecin doit être un entier entre 1 et 5.");
                vretour = false;
            }

            if (!System.String.IsNullOrEmpty(tbDateRapport.Text))
            {
                DateTime dateRapport;
                bool isDateValid = DateTime.TryParse(tbDateRapport.Text, out dateRapport);
                if (!isDateValid)
                {
                    errorProvider.SetError(tbDateRapport, "La date du rapport n'est pas valide.");
                    vretour = false;
                }
            }

            if (!System.String.IsNullOrEmpty(tbHeurePrevue.Text))
            {
                TimeSpan heurePrevue;
                bool isHeureValid = TimeSpan.TryParse(tbHeurePrevue.Text, out heurePrevue);
                if (!isHeureValid)
                {
                    errorProvider.SetError(tbHeurePrevue, "L'heure prévue n'est pas valide.");
                    vretour = false;
                }
            }

            if (!System.String.IsNullOrEmpty(tbHeureReelle.Text))
            {
                TimeSpan heureReelle;
                bool isHeureValid = TimeSpan.TryParse(tbHeureReelle.Text, out heureReelle);
                if (!isHeureValid)
                {
                    errorProvider.SetError(tbHeureReelle, "L'heure réelle n'est pas valide.");
                    vretour = false;
                }
            }

            if (!System.String.IsNullOrEmpty(tbDureeVisite.Text))
            {
                int dureeVisite;
                bool isDureeValid = int.TryParse(tbDureeVisite.Text, out dureeVisite);
                if (!isDureeValid)
                {
                    errorProvider.SetError(tbDureeVisite, "La durée de la visite n'est pas valide.");
                    vretour = false;
                }
            }
            return vretour;
        }

        private void btnOKAjoutModif_Click(object sender, EventArgs e)
        {
            if (tests() && MonModelMission2.ActionRapport == 1)
            {
                string motif = tbMotif.Text;
                string bilan = tbBilan.Text;
                int avisMedecin = (int)qteAvis.Value;
                bool estRemplacant = checkBoxRemplacant.Checked;
                string dateRapport = tbDateRapport.Text;
                string heurePrevue = tbHeurePrevue.Text;
                string heureReelle = tbHeureReelle.Text;
                int dureeVisite;
                if (!int.TryParse(tbDureeVisite.Text, out dureeVisite))
                {
                    MessageBox.Show("La durée de visite est invalide.");
                    return;
                }

                int idMedecin = (int)cboMedecin.SelectedValue;

                var medsPresentes = bsMedicamentPresentes.DataSource as List<Medicament> ?? new List<Medicament>();
                //var echantillons = bsEchantillon.DataSource as List<Offrir> ?? new List<Offrir>();
                var echantillons = bsEchantillon.DataSource as List<Offrir>;
                if (echantillons == null)
                {
                    echantillons = new List<Offrir>();
                    bsEchantillon.DataSource = echantillons;
                }

                vretour = MonModelMission2.AjoutRapport(motif, bilan, avisMedecin, estRemplacant, dateRapport, heurePrevue, heureReelle, dureeVisite, idMedecin, medsPresentes, echantillons);

                if (vretour)
                {
                    MessageBox.Show("Rapport ajouté !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erreur", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else if (tests() && MonModelMission2.ActionRapport == 2)
            {
                string motif = tbMotif.Text;
                string bilan = tbBilan.Text;
                int avisMedecin = (int)qteAvis.Value;
                bool estRemplacant = checkBoxRemplacant.Checked;
                string dateRapport = tbDateRapport.Text;
                string heurePrevue = tbHeurePrevue.Text;
                string heureReelle = tbHeureReelle.Text;
                int dureeVisite;
                if (!int.TryParse(tbDureeVisite.Text, out dureeVisite))
                {
                    MessageBox.Show("La durée de visite est invalide.");
                    return;
                }

                int idMedecin = (int)cboMedecin.SelectedValue;

                var medsPresentes = bsMedicamentPresentes.DataSource as List<Medicament> ?? new List<Medicament>();
                var echantillons = bsEchantillon.DataSource as List<Offrir> ?? new List<Offrir>();


                vretour = MonModelMission2.ModifRapport(motif, bilan, avisMedecin, estRemplacant, dateRapport, heurePrevue, heureReelle, dureeVisite, idMedecin, medsPresentes, echantillons);

                if (vretour)
                {
                    MessageBox.Show("Rapport modifié !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erreur(s)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Erreur(s)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}