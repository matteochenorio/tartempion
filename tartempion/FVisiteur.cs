using System;
using System.Linq;
using System.Windows.Forms;
using tartempion.Models;
using Region = tartempion.Models.Region;

namespace tartempion
{
    public partial class FVisiteur : Form
    {
        public FVisiteur()
        {
            InitializeComponent();
        }

        private void FVisiteur_Load(object sender, EventArgs e)
        {
            ChargerVisiteurs();
            var regions = MonModelMission1.listRegion();
            regions.Insert(0, new Region { IdRegion = 0, LibRegion = "-- Toutes les régions --" });
            bsRegion.DataSource = regions;
            cbRegion.DataSource = bsRegion;
            cbRegion.DisplayMember = "LibRegion";
            cbRegion.ValueMember = "IdRegion";
        }

        private void ChargerVisiteurs()
        {
            dgvRegion.DataSource = MonModelMission1.listVisiteur();
        }

        private void cbRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRegion.SelectedItem is Region regionChoisie && regionChoisie.IdRegion != 0)
            {
                dgvRegion.DataSource = MonModelMission1.listVisiteur()
                    .Where(v => v.IdRegions.Any(r => r.IdRegion == regionChoisie.IdRegion))
                    .ToList();
            }
            else
            {
                ChargerVisiteurs();
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            // Ouvrir un formulaire de saisie
            using (var form = new Form())
            {
                form.Text = "Ajouter un visiteur";
                form.Size = new System.Drawing.Size(350, 350);
                form.StartPosition = FormStartPosition.CenterParent;
                form.FormBorderStyle = FormBorderStyle.FixedDialog;

                var lblNom = new Label { Text = "Nom :", Location = new System.Drawing.Point(20, 20), Width = 80 };
                var txtNom = new TextBox { Location = new System.Drawing.Point(110, 17), Width = 200 };

                var lblPrenom = new Label { Text = "Prénom :", Location = new System.Drawing.Point(20, 55), Width = 80 };
                var txtPrenom = new TextBox { Location = new System.Drawing.Point(110, 52), Width = 200 };

                var lblVille = new Label { Text = "Ville :", Location = new System.Drawing.Point(20, 90), Width = 80 };
                var txtVille = new TextBox { Location = new System.Drawing.Point(110, 87), Width = 200 };

                var lblCp = new Label { Text = "Code postal :", Location = new System.Drawing.Point(20, 125), Width = 80 };
                var txtCp = new TextBox { Location = new System.Drawing.Point(110, 122), Width = 200 };

                var lblRue = new Label { Text = "Rue :", Location = new System.Drawing.Point(20, 160), Width = 80 };
                var txtRue = new TextBox { Location = new System.Drawing.Point(110, 157), Width = 200 };

                var lblId = new Label { Text = "Identifiant :", Location = new System.Drawing.Point(20, 195), Width = 80 };
                var txtId = new TextBox { Location = new System.Drawing.Point(110, 192), Width = 200 };

                var btnOk = new Button { Text = "Valider", Location = new System.Drawing.Point(110, 240), Width = 90 };
                var btnCancel = new Button { Text = "Annuler", Location = new System.Drawing.Point(210, 240), Width = 90 };

                btnOk.Click += (s, ev) => { form.DialogResult = DialogResult.OK; };
                btnCancel.Click += (s, ev) => { form.DialogResult = DialogResult.Cancel; };

                form.Controls.AddRange(new Control[] {
                    lblNom, txtNom, lblPrenom, txtPrenom,
                    lblVille, txtVille, lblCp, txtCp,
                    lblRue, txtRue, lblId, txtId,
                    btnOk, btnCancel
                });

                if (form.ShowDialog() == DialogResult.OK)
                {
                    if (string.IsNullOrWhiteSpace(txtNom.Text) || string.IsNullOrWhiteSpace(txtId.Text))
                    {
                        MessageBox.Show("Le nom et l'identifiant sont obligatoires.", "Erreur",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string idVisiteur = txtNom.Text[0].ToString().ToLower()
                                      + new Random().Next(10, 99).ToString();

                    var nouveau = new Visiteur
                    {
                        IdVisiteur = idVisiteur,
                        Nom = txtNom.Text,
                        Prenom = txtPrenom.Text,
                        Ville = txtVille.Text,
                        Cp = txtCp.Text,
                        Rue = txtRue.Text,
                        Identifiant = txtId.Text,
                        Password = "default",
                        IdLabo = 1,
                        DateEmbauche = DateTime.Now.ToString("yyyy-MM-dd")
                    };

                    MonModelMission1.MonModel.Visiteurs.Add(nouveau);
                    MonModelMission1.MonModel.SaveChanges();
                    MessageBox.Show("Visiteur ajouté avec succès !", "Succès",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ChargerVisiteurs();
                }
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvRegion.CurrentRow?.DataBoundItem is Visiteur v)
            {
                using (var form = new Form())
                {
                    form.Text = "Modifier le visiteur";
                    form.Size = new System.Drawing.Size(350, 300);
                    form.StartPosition = FormStartPosition.CenterParent;
                    form.FormBorderStyle = FormBorderStyle.FixedDialog;

                    var lblNom = new Label { Text = "Nom :", Location = new System.Drawing.Point(20, 20), Width = 80 };
                    var txtNom = new TextBox { Location = new System.Drawing.Point(110, 17), Width = 200, Text = v.Nom };

                    var lblPrenom = new Label { Text = "Prénom :", Location = new System.Drawing.Point(20, 55), Width = 80 };
                    var txtPrenom = new TextBox { Location = new System.Drawing.Point(110, 52), Width = 200, Text = v.Prenom };

                    var lblVille = new Label { Text = "Ville :", Location = new System.Drawing.Point(20, 90), Width = 80 };
                    var txtVille = new TextBox { Location = new System.Drawing.Point(110, 87), Width = 200, Text = v.Ville };

                    var lblCp = new Label { Text = "Code postal :", Location = new System.Drawing.Point(20, 125), Width = 80 };
                    var txtCp = new TextBox { Location = new System.Drawing.Point(110, 122), Width = 200, Text = v.Cp };

                    var btnOk = new Button { Text = "Valider", Location = new System.Drawing.Point(110, 190), Width = 90 };
                    var btnCancel = new Button { Text = "Annuler", Location = new System.Drawing.Point(210, 190), Width = 90 };

                    btnOk.Click += (s, ev) => { form.DialogResult = DialogResult.OK; };
                    btnCancel.Click += (s, ev) => { form.DialogResult = DialogResult.Cancel; };

                    form.Controls.AddRange(new Control[] {
                        lblNom, txtNom, lblPrenom, txtPrenom,
                        lblVille, txtVille, lblCp, txtCp,
                        btnOk, btnCancel
                    });

                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        v.Nom = txtNom.Text;
                        v.Prenom = txtPrenom.Text;
                        v.Ville = txtVille.Text;
                        v.Cp = txtCp.Text;

                        MonModelMission1.MonModel.SaveChanges();
                        MessageBox.Show("Visiteur modifié avec succès !", "Succès",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ChargerVisiteurs();
                    }
                }
            }
            else
            {
                MessageBox.Show("Sélectionnez un visiteur dans la liste.", "Attention",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvRegion.CurrentRow?.DataBoundItem is Visiteur v)
            {
                var confirm = MessageBox.Show(
                    $"Supprimer le visiteur {v.Nom} {v.Prenom} ?",
                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    MonModelMission1.MonModel.Visiteurs.Remove(v);
                    MonModelMission1.MonModel.SaveChanges();
                    MessageBox.Show("Visiteur supprimé.", "Succès",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ChargerVisiteurs();
                }
            }
            else
            {
                MessageBox.Show("Sélectionnez un visiteur dans la liste.", "Attention",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}