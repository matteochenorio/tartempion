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
            pbConnexion.Image = Image.FromFile(@"U:\Romeuf\AP3 GSB 2025\Logo GSB\logo.png");
        }
    }
}
