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
           // FConnexion.mage = Image.FromFile(@"U:\Romeuf\AP3 GSB 2025\Logo GSB\logo.png");
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string mp = textBox2.Text;
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
    }
}
