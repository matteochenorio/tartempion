namespace tartempion
{
    partial class FRegion
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dgvSecteur = new DataGridView();
            cbSecteur = new ComboBox();
            btnAjouter = new Button();
            btnSupprimer = new Button();
            btnModifier = new Button();
            bsSecteur = new BindingSource(components);
            btnFermer = new Button();
            bsVisiteur = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvSecteur).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsSecteur).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsVisiteur).BeginInit();
            SuspendLayout();

            dgvSecteur.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSecteur.Location = new Point(402, 52);
            dgvSecteur.Name = "dgvSecteur";
            dgvSecteur.Size = new Size(375, 377);
            dgvSecteur.TabIndex = 0;

            cbSecteur.FormattingEnabled = true;
            cbSecteur.Location = new Point(22, 24);
            cbSecteur.Name = "cbSecteur";
            cbSecteur.Size = new Size(121, 23);
            cbSecteur.TabIndex = 1;
            cbSecteur.Text = "Visiteur responsable";

            btnAjouter.Location = new Point(12, 406);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(75, 23);
            btnAjouter.TabIndex = 2;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);

            btnSupprimer.Location = new Point(257, 406);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(75, 23);
            btnSupprimer.TabIndex = 3;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);

            btnModifier.Location = new Point(129, 406);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(75, 23);
            btnModifier.TabIndex = 4;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = true;
            btnModifier.Click += new System.EventHandler(this.btnModifier_Click);

            bsSecteur.CurrentChanged += new System.EventHandler(this.bsSecteur_CurrentChanged);

            btnFermer.Location = new Point(702, 23);
            btnFermer.Name = "btnFermer";
            btnFermer.Size = new Size(75, 23);
            btnFermer.TabIndex = 5;
            btnFermer.Text = "Fermer";
            btnFermer.UseVisualStyleBackColor = true;
            btnFermer.Click += new System.EventHandler(this.btnFermer_Click);

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFermer);
            Controls.Add(btnModifier);
            Controls.Add(btnSupprimer);
            Controls.Add(btnAjouter);
            Controls.Add(cbSecteur);
            Controls.Add(dgvSecteur);
            Name = "FRegion";
            Text = "Régions";
            Load += FRegion_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSecteur).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsSecteur).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsVisiteur).EndInit();
            ResumeLayout(false);
        }

        private DataGridView dgvSecteur;
        private ComboBox cbSecteur;
        private Button btnAjouter;
        private Button btnSupprimer;
        private Button btnModifier;
        private BindingSource bsSecteur;
        private Button btnFermer;
        private BindingSource bsVisiteur;
    }
}