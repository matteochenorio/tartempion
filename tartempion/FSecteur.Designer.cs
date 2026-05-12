namespace tartempion
{
    partial class FSecteur
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
            cbVisiteur = new ComboBox();
            dgvSecteur = new DataGridView();
            button1 = new Button();
            bsVisiteur = new BindingSource(components);
            btnAjouter = new Button();
            btnModifier = new Button();
            btnSupprimer = new Button();
            cbRegion = new ComboBox();
            bsRegion = new BindingSource(components);
            bsSecteur = new BindingSource(components);
            cbSecteur = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvSecteur).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsVisiteur).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsRegion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsSecteur).BeginInit();
            SuspendLayout();
            // 
            // cbVisiteur
            // 
            cbVisiteur.FormattingEnabled = true;
            cbVisiteur.Location = new Point(12, 21);
            cbVisiteur.Name = "cbVisiteur";
            cbVisiteur.Size = new Size(101, 23);
            cbVisiteur.TabIndex = 0;
            cbVisiteur.Text = "Visiteur";
            cbVisiteur.SelectedIndexChanged += CbVisiteur_SelectedIndexChanged;
            // 
            // dgvSecteur
            // 
            dgvSecteur.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSecteur.Location = new Point(401, 63);
            dgvSecteur.Name = "dgvSecteur";
            dgvSecteur.Size = new Size(377, 388);
            dgvSecteur.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(703, 21);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Fermer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(12, 394);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(75, 23);
            btnAjouter.TabIndex = 3;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            btnModifier.Location = new Point(122, 394);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(75, 23);
            btnModifier.TabIndex = 4;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(245, 394);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(75, 23);
            btnSupprimer.TabIndex = 5;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // cbRegion
            // 
            cbRegion.FormattingEnabled = true;
            cbRegion.Location = new Point(122, 22);
            cbRegion.Name = "cbRegion";
            cbRegion.Size = new Size(105, 23);
            cbRegion.TabIndex = 6;
            cbRegion.Text = "Region";
            cbRegion.SelectedIndexChanged += cbRegion_SelectedIndexChanged;
            // 
            // cbSecteur
            // 
            cbSecteur.FormattingEnabled = true;
            cbSecteur.Location = new Point(245, 22);
            cbSecteur.Name = "cbSecteur";
            cbSecteur.Size = new Size(105, 23);
            cbSecteur.TabIndex = 7;
            cbSecteur.Text = "Secteur";
            // 
            // FSecteur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbSecteur);
            Controls.Add(cbRegion);
            Controls.Add(btnSupprimer);
            Controls.Add(btnModifier);
            Controls.Add(btnAjouter);
            Controls.Add(button1);
            Controls.Add(dgvSecteur);
            Controls.Add(cbVisiteur);
            Name = "FSecteur";
            Text = "Secteur";
            Load += FSecteur_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSecteur).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsVisiteur).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsRegion).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsSecteur).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbVisiteur;
        private DataGridView dgvSecteur;
        private Button button1;
        private BindingSource bsVisiteur;
        private Button btnAjouter;
        private Button btnModifier;
        private Button btnSupprimer;
        private ComboBox cbRegion;
        private BindingSource bsRegion;
        private BindingSource bsSecteur;
        private ComboBox cbSecteur;
    }
}