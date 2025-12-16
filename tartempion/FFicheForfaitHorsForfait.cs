using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    public partial class FFicheForfaitHorsForfait : Form
    {
        public FFicheForfaitHorsForfait()
        {
            InitializeComponent();
        }

        private void FFicheForfaitHorsForfait_Load(object sender, EventArgs e)
        {
            string userId = MonModelMission3.VisiteurConnecte.IdVisiteur.Trim().ToUpper();
            string mois = MonModelMission3.FicheFraisChoisi.Mois.Trim().ToUpper();

            // 2. Filtrer les fiches de frais (en ignorant la casse)
            var toutesLesLignesHorsForfait = MonModelMission3.listeFraisHorsForfait();
            var ligneHorsForfaitFiltre = toutesLesLignesHorsForfait
                .Where(f => f.IdVisiteur.Trim().ToUpper() == userId && f.Mois.Trim().ToUpper() == mois)
                .ToList();

            bsFraisHorsForfait.DataSource = ligneHorsForfaitFiltre;
            dgvFraisHorsForfait.DataSource = bsFraisHorsForfait;

            dgvFraisHorsForfait.Columns[0].Visible = false;
            dgvFraisHorsForfait.Columns[1].Visible = false;
            dgvFraisHorsForfait.Columns[2].HeaderText = "Date";
            dgvFraisHorsForfait.Columns[3].HeaderText = "Libellé";
            dgvFraisHorsForfait.Columns[5].HeaderText = "Montant";
            dgvFraisHorsForfait.Columns[4].Visible = false;
            dgvFraisHorsForfait.Columns[6].Visible = false;

            List<LigneFraisForfait> lignesForfait = MonModelMission3.FicheFraisChoisi.LigneFraisForfaits.ToList();

            var listeAffichage = lignesForfait.Select(x => // c'est select en sql
            {
                bool modeMensuel = x.IdFraisForfaitNavigation.Mensuel ?? false;
                decimal montant = (decimal)MonModelMission3.TrouveMontant(x.IdFraisForfaitNavigation);//(decimal)x.IdFraisForfaitNavigation
                int quantite = x.Quantite ?? 0;

                decimal total = modeMensuel         // le ? remplace le if else dans ce cas la si modeMensuel a true alors total = montant sinon total = quantite x montant
                                ? montant          // Mensuel : montant unique
                                : quantite * montant;    // Sinon : quantité x montant

                return new
                {
                    Libelle = x.IdFraisForfaitNavigation.Libelle, //s'occupe de l'affichage
                    Quantite = quantite,
                    Montant = montant,
                    Total = total
                };
            })
            .ToList();
            
            bsFraisForfait.DataSource = listeAffichage;
            dgvFraisForfait.DataSource = bsFraisForfait;

            decimal totalFraisForfait = listeAffichage.Sum(l => l.Total);
            decimal totalFraisHorsForfait = ligneHorsForfaitFiltre.Sum(l => l.Montant ?? 0);
            decimal totalGeneral = totalFraisForfait + totalFraisHorsForfait;

            tbTotal.Text = totalGeneral.ToString("0.00") + " €";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FFicheDeFrais newFFicheDeFrais = new FFicheDeFrais();
            newFFicheDeFrais.Show();
            this.Close();
        }
    }
}
