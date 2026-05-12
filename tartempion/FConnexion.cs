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
    public partial class FConnexion : Form
    {
        public FConnexion()
        {
            InitializeComponent();
        }
        public static void ThreadProc()
        {
            Application.Run(new FMenu());
        }
        private void FConnexion_Load(object sender, EventArgs e)
        {
            //pbConnexion.Image = Image.FromFile(@"U:\Romeuf\AP3 GSB 2025\Logo GSB\logo.png");
        }



        private void btnConnexion_Click_1(object sender, EventArgs e)
        {
            string id = txtIdentifiant.Text;
            string mp = txtMotDePasse.Text;
            string message = MonModelMission1.validConnexion(id, mp);

            if (MonModelMission1.ConnexionValide)
            {
                System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
                t.Start();
                this.Close();
            }
            else
            {
                MessageBox.Show(message, "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            // On ferme la fenêtre actuelle
            this.Close();

            // On réinitialise la connexion dans le modèle
            MonModelMission1.ConnexionValide = false;
            MonModelMission1.UtilisateurConnecte = null;

            // On retourne vers la fenêtre de connexion
            FConnexion f = new FConnexion();
            f.Show();
        }



    }
}
