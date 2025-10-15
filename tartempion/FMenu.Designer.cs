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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            rAPPORTSToolStripMenuItem = new ToolStripMenuItem();
            mÉDICAMENTSToolStripMenuItem = new ToolStripMenuItem();
            mÉDECINSToolStripMenuItem = new ToolStripMenuItem();
            pbMenu = new PictureBox();
            label1 = new Label();
            btnDeconnexion = new Button();
            tbRole = new TextBox();
            bsRole = new BindingSource(components);
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsRole).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { rAPPORTSToolStripMenuItem, mÉDICAMENTSToolStripMenuItem, mÉDECINSToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // rAPPORTSToolStripMenuItem
            // 
            rAPPORTSToolStripMenuItem.Name = "rAPPORTSToolStripMenuItem";
            rAPPORTSToolStripMenuItem.Size = new Size(76, 20);
            rAPPORTSToolStripMenuItem.Text = "RAPPORTS";
            // 
            // mÉDICAMENTSToolStripMenuItem
            // 
            mÉDICAMENTSToolStripMenuItem.Name = "mÉDICAMENTSToolStripMenuItem";
            mÉDICAMENTSToolStripMenuItem.Size = new Size(102, 20);
            mÉDICAMENTSToolStripMenuItem.Text = "MÉDICAMENTS";
            // 
            // mÉDECINSToolStripMenuItem
            // 
            mÉDECINSToolStripMenuItem.Name = "mÉDECINSToolStripMenuItem";
            mÉDECINSToolStripMenuItem.Size = new Size(76, 20);
            mÉDECINSToolStripMenuItem.Text = "MÉDECINS";
            // 
            // pbMenu
            // 
            pbMenu.Location = new Point(474, 64);
            pbMenu.Name = "pbMenu";
            pbMenu.Size = new Size(326, 244);
            pbMenu.TabIndex = 1;
            pbMenu.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 42);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 2;
            label1.Text = "BONJOUR !";
            // 
            // btnDeconnexion
            // 
            btnDeconnexion.Location = new Point(703, 27);
            btnDeconnexion.Name = "btnDeconnexion";
            btnDeconnexion.Size = new Size(85, 23);
            btnDeconnexion.TabIndex = 3;
            btnDeconnexion.Text = "Déconnexion";
            btnDeconnexion.UseVisualStyleBackColor = true;
            btnDeconnexion.Click += btnDeconnexion_Click;
            // 
            // tbRole
            // 
            tbRole.Location = new Point(474, 27);
            tbRole.Name = "tbRole";
            tbRole.Size = new Size(223, 23);
            tbRole.TabIndex = 4;
            // 
            // bsRole
            // 
            bsRole.CurrentChanged += bsRole_CurrentChanged;
            // 
            // FMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbRole);
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
            ((System.ComponentModel.ISupportInitialize)bsRole).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem rAPPORTSToolStripMenuItem;
        private ToolStripMenuItem mÉDICAMENTSToolStripMenuItem;
        private ToolStripMenuItem mÉDECINSToolStripMenuItem;
        private PictureBox pbMenu;
        private Label label1;
        private Button btnDeconnexion;
        private TextBox tbRole;
        private BindingSource bsRole;
    }
}