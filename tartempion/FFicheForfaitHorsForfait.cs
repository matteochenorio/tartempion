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
            List<LigneFraisForfait> ls = MonModelMission3.FicheFraisChoisi.LigneFraisForfaits.ToList();
            bsFraisForfait.DataSource = MonModelMission3.FicheFraisChoisi.LigneFraisForfaits.Select(x => new { x.IdFraisForfaitNavigation.Libelle, x.Quantite, x.IdFraisForfaitNavigation.IdHistoriqueFraisNavigation.Montant }).ToList();
            dgvFraisForfait.DataSource = bsFraisForfait;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FFicheDeFrais newFFicheDeFrais = new FFicheDeFrais();
            newFFicheDeFrais.Show();
        }
    }
}
