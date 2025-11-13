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
    public partial class FFicheDeFrais : Form
    {
        public FFicheDeFrais()
        {
            InitializeComponent();
        }

        private void FFicheDeFrais_Load(object sender, EventArgs e)
        {

            // 1. Récupérer l'ID de l'utilisateur connecté
string userId = MonModelMission3.VisiteurConnecte.IdVisiteur;

// 2. Filtrer les fiches de frais
var toutesLesFiches = MonModelMission3.listeFicheFrais();
var fichesFiltrees = toutesLesFiches
    .Where(f => f.UserId == userId)
    .ToList();

// 3. Mettre à jour le BindingSource et le DataGridView
bsFicheDeFrais.DataSource = fichesFiltrees;
dgvFicheDeFrais.DataSource = bsFicheDeFrais;
            bsFicheDeFrais.DataSource = MonModelMission3.listeFicheFrais();
            dgvFicheDeFrais.DataSource = bsFicheDeFrais;
            txtMoisActuelle.Text = DateTime.Now.ToString("MMMM");
            txtVisiteurConnecte.Text = MonModelMission3.VisiteurConnecte.Nom.Trim() + " " + MonModelMission3.VisiteurConnecte.Prenom.ToString().Trim();

        }
    }
}
