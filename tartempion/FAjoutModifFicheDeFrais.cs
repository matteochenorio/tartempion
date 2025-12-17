using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tartempion.Models;

namespace tartempion
{
    public partial class FAjoutModifFicheDeFrais : Form
    {
        int repetition = 0;
        FMenu fMenuMission3 = new FMenu();
        List<(Button supprimer, TextBox ficheFrais, TextBox quantite, TextBox montant, TextBox total)> lignes = new();
        public FAjoutModifFicheDeFrais()
        {
            InitializeComponent();
        }

        private void FAjoutModifFicheDeFrais_Load(object sender, EventArgs e)
        {
            tbMatricule.Text = MonModelMission3.VisiteurConnecte.IdVisiteur.ToString();
            tbNom.Text = MonModelMission3.VisiteurConnecte.Prenom.ToString().Trim() + " " + MonModelMission3.VisiteurConnecte.Nom.ToString().Trim();
            bsFraisForfait.DataSource = MonModelMission3.listeFraisForfait();
            cboFraisForfait.ValueMember = "id";
            cboFraisForfait.DisplayMember = "libelle";
            cboFraisForfait.DataSource = bsFraisForfait;
            bsHistoriqueFrais.DataSource = MonModelMission3.listeHistoriqueFrais();
            MettreAJourTotalGeneral();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            int espacement = 35;
            int nouvelleY = lignes.Count * espacement + 30;
            bool existeDeja = false;
            FraisForfait fraisSelectionne = (FraisForfait)bsFraisForfait.Current;

            Button btnSupp = new Button
            {
                Size = new Size(25, 25),
                Location = new Point(5, nouvelleY),
                Text = "x"
            };
            btnSupp.Click += new EventHandler(Supp2);
            pSupp.Controls.Add(btnSupp);

            TextBox tbFraisForfaitaires = new TextBox
            {
                Size = new Size(200, 25),
                Location = new Point(5, nouvelleY),
                PlaceholderText = "Frais Forfaitaires"
            };
            pFraisForfaitaires.Controls.Add(tbFraisForfaitaires);
            tbFraisForfaitaires.Text = cboFraisForfait.Text;
            tbFraisForfaitaires.KeyPress += new KeyPressEventHandler(bloqueTout);
            if (lignes.Any(ligne => ligne.ficheFrais.Text == tbFraisForfaitaires.Text))
            {
                MessageBox.Show("Ce type de frais forfait a déjà été ajouté.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pSupp.Controls.Remove(btnSupp);
                pFraisForfaitaires.Controls.Remove(tbFraisForfaitaires);
                return;
            }
            pFraisForfaitaires.Controls.Add(tbFraisForfaitaires);
            tbFraisForfaitaires.Text = cboFraisForfait.Text;
            tbFraisForfaitaires.KeyPress += new KeyPressEventHandler(bloqueTout);

            TextBox tbQuantite = new TextBox
            {
                Size = new Size(200, 25),
                Location = new Point(5, nouvelleY),
                PlaceholderText = "Quantité"
            };
            if (fraisSelectionne.Mensuel == true)
            {
                tbQuantite.Visible = false;
            }
            pQuantite.Controls.Add(tbQuantite);
            tbQuantite.KeyPress += new KeyPressEventHandler(bloquageLettre);

            TextBox tbMontantUnitaire = new TextBox
            {
                Size = new Size(200, 25),
                Location = new Point(5, nouvelleY),
                PlaceholderText = "Montant Unitaire"
            };
            pMontantUnitaire.Controls.Add(tbMontantUnitaire);
            tbMontantUnitaire.KeyPress += new KeyPressEventHandler(bloqueTout);
            tbMontantUnitaire.Text = ((HistoriqueFrai)bsHistoriqueFrais.Current).Montant.ToString("N2", CultureInfo.CurrentCulture);

            TextBox tbTotal = new TextBox
            {
                Size = new Size(200, 25),
                Location = new Point(5, nouvelleY),
                PlaceholderText = "Total"
            };
            pTotal.Controls.Add(tbTotal);
            tbTotal.KeyPress += new KeyPressEventHandler(bloqueTout);
            tbQuantite.TextChanged += MettreAJourTotal;

            tbTotal.Text = 0.0m.ToString("N2", CultureInfo.CurrentCulture);

            lignes.Add((btnSupp, tbFraisForfaitaires, tbQuantite, tbMontantUnitaire, tbTotal));
            MettreAJourTotal(tbQuantite, EventArgs.Empty);
            MettreAJourTotalGeneral();
        }

        private void bloquageLettre(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar.ToString() == CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void bloqueTout(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void bsTypeFrais_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void MettreAJourTotal(object sender, EventArgs e)
        {
            TextBox tbQuantiteModifie = sender as TextBox;
            if (tbQuantiteModifie == null) return;

            var ligneAModifier = lignes.FirstOrDefault(ligne => ligne.quantite == tbQuantiteModifie);

            if (ligneAModifier.Item1 != null)
            {
                decimal montant = 0.0m;
                decimal quantite = 0.0m;
                decimal total;

                decimal.TryParse(ligneAModifier.montant.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out montant);
                decimal.TryParse(tbQuantiteModifie.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out quantite);
                if (ligneAModifier.quantite.Visible == false)
                {
                    total = montant;
                }
                else
                {
                    total = montant * quantite;
                }

                ligneAModifier.total.Text = total.ToString("N2", CultureInfo.CurrentCulture);

                MettreAJourTotalGeneral();
            }
        }

        private void MettreAJourTotalGeneral()
        {

            decimal totalGeneral = 0.0m;
            foreach (var ligne in lignes)
            {
                decimal totalLigne = 0.0m;
                decimal.TryParse(ligne.total.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out totalLigne);
                totalGeneral += totalLigne;
            }
            if (tbTotalGeneral != null)
            {
                tbTotalGeneral.Text = totalGeneral.ToString("N2", CultureInfo.CurrentCulture);
                tbTotalGeneral.KeyPress += new KeyPressEventHandler(bloqueTout);
            }
        }

        public void Supp2(object sender, EventArgs e)
        {
            Button btnASupprimer = sender as Button;
            if (btnASupprimer == null) return;

            var ligneASupprimer = lignes.FirstOrDefault(ligne => ligne.supprimer == btnASupprimer);

            if (ligneASupprimer.Item1 != null)
            {
                pSupp.Controls.Remove(ligneASupprimer.supprimer);
                pFraisForfaitaires.Controls.Remove(ligneASupprimer.ficheFrais);
                pQuantite.Controls.Remove(ligneASupprimer.quantite);
                pMontantUnitaire.Controls.Remove(ligneASupprimer.montant);
                pTotal.Controls.Remove(ligneASupprimer.total);

                lignes.Remove(ligneASupprimer);

                MettreAJourTotalGeneral();
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            fMenuMission3.Show();
            this.Close();
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {

            string date = dtpDate.Value.ToString("yyyyMM");
            if (MonModelMission3.AjoutModif == 1)
            {
                MonModelMission3.AjoutFicheDeFrais(date);
                foreach(var ligne in lignes)
                {
                    //MonModelMission3.AjoutLigneFiche(date,,ligne.quantite.Text )
                }
            }
        }
    }
}

