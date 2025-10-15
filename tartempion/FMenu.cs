using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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
        public static void ThreadProc()
        {
            Application.Run(new FConnexion());
        }

        private void FMenu_Load(object sender, EventArgs e)
        {
            pbMenu.Image = Image.FromFile(@"U:\Romeuf\AP3 GSB 2025\Logo GSB\logo.png");
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            MonModelMission2.UtilisateurConnecte = null;
            MonModelMission2.ConnexionValide = false;

            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
            t.Start();
            this.Close();
        }

        private void bsRole_CurrentChanged(object sender, EventArgs e)
        {
            //bsRole.DataSource = MonModelMission2.ListeSpecialite();
            //Visiteur visiteurConnecte = (Visiteur)bsRole.Current;
            //tbRole.Text = visiteurConnecte.Prenom.ToString();

            tbRole.Text = MonModelMission2.VisiteurConnecte.IdVisiteur.ToString();
        }
    }
}
