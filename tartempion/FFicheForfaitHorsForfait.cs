using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            bsFraisForfait.DataSource = MonModelMission3.FicheFraisChoisi.LigneFraisForfaits.Select(x => new { }).OrderBy(x => x.NomCompositeur).ToList();
        }
    }
}
