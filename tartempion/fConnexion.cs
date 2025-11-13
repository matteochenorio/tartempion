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
    public partial class fConnexion : Form
    {
        public fConnexion()
        {
            InitializeComponent();
        }

        public static void ThreadProc()
        {
            Application.Run(new FMenu());
        }

        private void fConnexion_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string id = tbLogin.Text;
            string mp = tbMdp.Text;
            string message = MonModelMission3.validConnexion(id, mp);

            if (MonModelMission3.ConnexionValide)
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
