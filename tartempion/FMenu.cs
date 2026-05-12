using System;
using System.Windows.Forms;
using tartempion.Models;

namespace tartempion
{
    public partial class FMenu : Form
    {
        public FMenu()
        {
            InitializeComponent();
        }

        private void FMenu_Load(object sender, EventArgs e)
        {
        }

        private void secteurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FSecteur f = new FSecteur();
            f.ShowDialog();
        }

        private void regionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRegion f = new FRegion();
            f.ShowDialog();
        }

        private void vISITEURToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FVisiteur f = new FVisiteur();
            f.ShowDialog();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            this.Close();
            MonModelMission1.ConnexionValide = false;
            MonModelMission1.UtilisateurConnecte = null;
            FConnexion f = new FConnexion();
            f.Show();
        }
    }
}