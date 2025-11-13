namespace tartempion
{
    partial class FFicheDeFrais
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
            btnFiltrer = new Button();
            btnAjouter = new Button();
            btnModifier = new Button();
            btnSupprimer = new Button();
            labelVisiteur = new Label();
            label1 = new Label();
            txtVisiteurConnecte = new TextBox();
            txtMoisActuelle = new TextBox();
            dgvFicheDeFrais = new DataGridView();
            bsFicheDeFrais = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvFicheDeFrais).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsFicheDeFrais).BeginInit();
            SuspendLayout();
            // 
            // btnFiltrer
            // 
            btnFiltrer.Location = new Point(25, 98);
            btnFiltrer.Name = "btnFiltrer";
            btnFiltrer.Size = new Size(75, 23);
            btnFiltrer.TabIndex = 0;
            btnFiltrer.Text = "Filtrer";
            btnFiltrer.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(25, 415);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(75, 23);
            btnAjouter.TabIndex = 1;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            btnModifier.Location = new Point(106, 415);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(75, 23);
            btnModifier.TabIndex = 2;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(187, 415);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(75, 23);
            btnSupprimer.TabIndex = 3;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // labelVisiteur
            // 
            labelVisiteur.AutoSize = true;
            labelVisiteur.Location = new Point(61, 27);
            labelVisiteur.Name = "labelVisiteur";
            labelVisiteur.Size = new Size(52, 15);
            labelVisiteur.TabIndex = 4;
            labelVisiteur.Text = "Visiteur :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 68);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 5;
            label1.Text = "Mois :";
            // 
            // txtVisiteurConnecte
            // 
            txtVisiteurConnecte.Location = new Point(142, 24);
            txtVisiteurConnecte.Name = "txtVisiteurConnecte";
            txtVisiteurConnecte.Size = new Size(100, 23);
            txtVisiteurConnecte.TabIndex = 6;
            // 
            // txtMoisActuelle
            // 
            txtMoisActuelle.Location = new Point(142, 68);
            txtMoisActuelle.Name = "txtMoisActuelle";
            txtMoisActuelle.Size = new Size(100, 23);
            txtMoisActuelle.TabIndex = 7;
            // 
            // dgvFicheDeFrais
            // 
            dgvFicheDeFrais.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFicheDeFrais.Location = new Point(25, 145);
            dgvFicheDeFrais.Name = "dgvFicheDeFrais";
            dgvFicheDeFrais.Size = new Size(370, 264);
            dgvFicheDeFrais.TabIndex = 8;
            // 
            // FFicheDeFrais
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvFicheDeFrais);
            Controls.Add(txtMoisActuelle);
            Controls.Add(txtVisiteurConnecte);
            Controls.Add(label1);
            Controls.Add(labelVisiteur);
            Controls.Add(btnSupprimer);
            Controls.Add(btnModifier);
            Controls.Add(btnAjouter);
            Controls.Add(btnFiltrer);
            Name = "FFicheDeFrais";
            Text = "FFicheDeFrais";
            Load += FFicheDeFrais_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFicheDeFrais).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsFicheDeFrais).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFiltrer;
        private Button btnAjouter;
        private Button btnModifier;
        private Button btnSupprimer;
        private Label labelVisiteur;
        private Label label1;
        private TextBox txtVisiteurConnecte;
        private TextBox txtMoisActuelle;
        private DataGridView dgvFicheDeFrais;
        private BindingSource bsFicheDeFrais;
    }
}