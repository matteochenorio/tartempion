namespace tartempion
{
    partial class FMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            mISSION1ToolStripMenuItem = new ToolStripMenuItem();
            vISITEURToolStripMenuItem = new ToolStripMenuItem();
            regionToolStripMenuItem = new ToolStripMenuItem();
            secteurToolStripMenuItem = new ToolStripMenuItem();
            quitterToolStripMenuItem = new ToolStripMenuItem();
            mISSION2ToolStripMenuItem = new ToolStripMenuItem();
            mISSION3ToolStripMenuItem = new ToolStripMenuItem();
            pbMenu = new PictureBox();
            label1 = new Label();
            btnDeconnexion = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbMenu).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mISSION1ToolStripMenuItem, mISSION2ToolStripMenuItem, mISSION3ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mISSION1ToolStripMenuItem
            // 
            mISSION1ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { vISITEURToolStripMenuItem, regionToolStripMenuItem, secteurToolStripMenuItem, quitterToolStripMenuItem });
            mISSION1ToolStripMenuItem.Name = "mISSION1ToolStripMenuItem";
            mISSION1ToolStripMenuItem.Size = new Size(75, 20);
            mISSION1ToolStripMenuItem.Text = "MISSION 1";
            // 
            // vISITEURToolStripMenuItem
            // 
            vISITEURToolStripMenuItem.Name = "vISITEURToolStripMenuItem";
            vISITEURToolStripMenuItem.Size = new Size(114, 22);
            vISITEURToolStripMenuItem.Text = "Visiteur";
            vISITEURToolStripMenuItem.Click += vISITEURToolStripMenuItem_Click;
            // 
            // regionToolStripMenuItem
            // 
            regionToolStripMenuItem.Name = "regionToolStripMenuItem";
            regionToolStripMenuItem.Size = new Size(114, 22);
            regionToolStripMenuItem.Text = "Region ";
            regionToolStripMenuItem.Click += regionToolStripMenuItem_Click;
            // 
            // secteurToolStripMenuItem
            // 
            secteurToolStripMenuItem.Name = "secteurToolStripMenuItem";
            secteurToolStripMenuItem.Size = new Size(114, 22);
            secteurToolStripMenuItem.Text = "Secteur";
            secteurToolStripMenuItem.Click += secteurToolStripMenuItem_Click;
            // 
            // quitterToolStripMenuItem
            // 
            quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            quitterToolStripMenuItem.Size = new Size(114, 22);
            quitterToolStripMenuItem.Text = "Quitter";
            quitterToolStripMenuItem.Click += quitterToolStripMenuItem_Click;
            // 
            // mISSION2ToolStripMenuItem
            // 
            mISSION2ToolStripMenuItem.Name = "mISSION2ToolStripMenuItem";
            mISSION2ToolStripMenuItem.Size = new Size(75, 20);
            mISSION2ToolStripMenuItem.Text = "MISSION 2";
            // 
            // mISSION3ToolStripMenuItem
            // 
            mISSION3ToolStripMenuItem.Name = "mISSION3ToolStripMenuItem";
            mISSION3ToolStripMenuItem.Size = new Size(75, 20);
            mISSION3ToolStripMenuItem.Text = "MISSION 3";
            // 
            // pbMenu
            // 
            pbMenu.Location = new Point(423, 98);
            pbMenu.Name = "pbMenu";
            pbMenu.Size = new Size(326, 244);
            pbMenu.TabIndex = 1;
            pbMenu.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 174);
            label1.Name = "label1";
            label1.Size = new Size(235, 15);
            label1.TabIndex = 2;
            label1.Text = "BIENVENUR SUR LE TABLEAU DE BORD GSB";
            // 
            // btnDeconnexion
            // 
            btnDeconnexion.Location = new Point(657, 39);
            btnDeconnexion.Name = "btnDeconnexion";
            btnDeconnexion.Size = new Size(92, 23);
            btnDeconnexion.TabIndex = 3;
            btnDeconnexion.Text = "Deconnexion";
            btnDeconnexion.UseVisualStyleBackColor = true;
            btnDeconnexion.Click += btnDeconnexion_Click;
            // 
            // FMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDeconnexion);
            Controls.Add(label1);
            Controls.Add(pbMenu);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FMenu";
            Text = "FMenu";
            Load += FMenu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbMenu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private PictureBox pbMenu;
        private Label label1;
        private ToolStripMenuItem mISSION1ToolStripMenuItem;
        private ToolStripMenuItem mISSION2ToolStripMenuItem;
        private ToolStripMenuItem mISSION3ToolStripMenuItem;
        private ToolStripMenuItem vISITEURToolStripMenuItem;
        private ToolStripMenuItem regionToolStripMenuItem;
        private ToolStripMenuItem secteurToolStripMenuItem;
        private Button btnDeconnexion;
        private ToolStripMenuItem quitterToolStripMenuItem;
    }
}