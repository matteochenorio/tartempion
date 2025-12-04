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
            lblVisiteur = new Label();
            lblMoisActuelle = new Label();
            txtVisiteurConnecte = new TextBox();
            txtMoisActuelle = new TextBox();
            dgvFicheDeFrais = new DataGridView();
            bsFicheDeFrais = new BindingSource(components);
            lblMoisFiche = new Label();
            lblNbJustificatifFiche = new Label();
            lblFiche = new Label();
            lblAnnée = new Label();
            txtIdFiche = new TextBox();
            txtEtat = new TextBox();
            txtDateDeDernierModifFiche = new TextBox();
            txtMontantValideFiche = new TextBox();
            txtNbJustificatifFiche = new TextBox();
            txtAnnéeFiche = new TextBox();
            txtMoisFiche = new TextBox();
            lblEtat = new Label();
            lblDateDeDernierModifFiche = new Label();
            lblMontantValide = new Label();
            btnForfait = new Button();
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
            btnAjouter.Click += btnAjouter_Click;
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
            // lblVisiteur
            // 
            lblVisiteur.AutoSize = true;
            lblVisiteur.Location = new Point(61, 27);
            lblVisiteur.Name = "lblVisiteur";
            lblVisiteur.Size = new Size(52, 15);
            lblVisiteur.TabIndex = 4;
            lblVisiteur.Text = "Visiteur :";
            // 
            // lblMoisActuelle
            // 
            lblMoisActuelle.AutoSize = true;
            lblMoisActuelle.Location = new Point(61, 68);
            lblMoisActuelle.Name = "lblMoisActuelle";
            lblMoisActuelle.Size = new Size(39, 15);
            lblMoisActuelle.TabIndex = 5;
            lblMoisActuelle.Text = "Mois :";
            // 
            // txtVisiteurConnecte
            // 
            txtVisiteurConnecte.Location = new Point(142, 24);
            txtVisiteurConnecte.Name = "txtVisiteurConnecte";
            txtVisiteurConnecte.ReadOnly = true;
            txtVisiteurConnecte.Size = new Size(100, 23);
            txtVisiteurConnecte.TabIndex = 6;
            // 
            // txtMoisActuelle
            // 
            txtMoisActuelle.Location = new Point(142, 68);
            txtMoisActuelle.Name = "txtMoisActuelle";
            txtMoisActuelle.ReadOnly = true;
            txtMoisActuelle.Size = new Size(100, 23);
            txtMoisActuelle.TabIndex = 7;
            // 
            // dgvFicheDeFrais
            // 
            dgvFicheDeFrais.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvFicheDeFrais.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvFicheDeFrais.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFicheDeFrais.Location = new Point(25, 145);
            dgvFicheDeFrais.Name = "dgvFicheDeFrais";
            dgvFicheDeFrais.Size = new Size(370, 264);
            dgvFicheDeFrais.TabIndex = 8;
            // 
            // bsFicheDeFrais
            // 
            bsFicheDeFrais.CurrentChanged += bsFicheDeFrais_CurrentChanged;
            // 
            // lblMoisFiche
            // 
            lblMoisFiche.AutoSize = true;
            lblMoisFiche.Location = new Point(617, 56);
            lblMoisFiche.Name = "lblMoisFiche";
            lblMoisFiche.Size = new Size(39, 15);
            lblMoisFiche.TabIndex = 9;
            lblMoisFiche.Text = "Mois :";
            // 
            // lblNbJustificatifFiche
            // 
            lblNbJustificatifFiche.AutoSize = true;
            lblNbJustificatifFiche.Location = new Point(478, 84);
            lblNbJustificatifFiche.Name = "lblNbJustificatifFiche";
            lblNbJustificatifFiche.Size = new Size(128, 15);
            lblNbJustificatifFiche.TabIndex = 10;
            lblNbJustificatifFiche.Text = "Nombre de justificatif :";
            // 
            // lblFiche
            // 
            lblFiche.AutoSize = true;
            lblFiche.Location = new Point(478, 32);
            lblFiche.Name = "lblFiche";
            lblFiche.Size = new Size(84, 15);
            lblFiche.TabIndex = 11;
            lblFiche.Text = "Fiche de Frais :";
            // 
            // lblAnnée
            // 
            lblAnnée.AutoSize = true;
            lblAnnée.Location = new Point(479, 56);
            lblAnnée.Name = "lblAnnée";
            lblAnnée.Size = new Size(47, 15);
            lblAnnée.TabIndex = 12;
            lblAnnée.Text = "Année :";
            // 
            // txtIdFiche
            // 
            txtIdFiche.Location = new Point(568, 27);
            txtIdFiche.Name = "txtIdFiche";
            txtIdFiche.ReadOnly = true;
            txtIdFiche.Size = new Size(100, 23);
            txtIdFiche.TabIndex = 13;
            // 
            // txtEtat
            // 
            txtEtat.Location = new Point(518, 158);
            txtEtat.Name = "txtEtat";
            txtEtat.ReadOnly = true;
            txtEtat.Size = new Size(100, 23);
            txtEtat.TabIndex = 14;
            // 
            // txtDateDeDernierModifFiche
            // 
            txtDateDeDernierModifFiche.Location = new Point(655, 134);
            txtDateDeDernierModifFiche.Name = "txtDateDeDernierModifFiche";
            txtDateDeDernierModifFiche.ReadOnly = true;
            txtDateDeDernierModifFiche.Size = new Size(100, 23);
            txtDateDeDernierModifFiche.TabIndex = 15;
            // 
            // txtMontantValideFiche
            // 
            txtMontantValideFiche.Location = new Point(577, 105);
            txtMontantValideFiche.Name = "txtMontantValideFiche";
            txtMontantValideFiche.ReadOnly = true;
            txtMontantValideFiche.Size = new Size(100, 23);
            txtMontantValideFiche.TabIndex = 16;
            // 
            // txtNbJustificatifFiche
            // 
            txtNbJustificatifFiche.Location = new Point(612, 81);
            txtNbJustificatifFiche.Name = "txtNbJustificatifFiche";
            txtNbJustificatifFiche.ReadOnly = true;
            txtNbJustificatifFiche.Size = new Size(100, 23);
            txtNbJustificatifFiche.TabIndex = 17;
            // 
            // txtAnnéeFiche
            // 
            txtAnnéeFiche.Location = new Point(532, 53);
            txtAnnéeFiche.Name = "txtAnnéeFiche";
            txtAnnéeFiche.ReadOnly = true;
            txtAnnéeFiche.Size = new Size(79, 23);
            txtAnnéeFiche.TabIndex = 18;
            // 
            // txtMoisFiche
            // 
            txtMoisFiche.Location = new Point(662, 53);
            txtMoisFiche.Name = "txtMoisFiche";
            txtMoisFiche.ReadOnly = true;
            txtMoisFiche.Size = new Size(100, 23);
            txtMoisFiche.TabIndex = 19;
            // 
            // lblEtat
            // 
            lblEtat.AutoSize = true;
            lblEtat.Location = new Point(479, 161);
            lblEtat.Name = "lblEtat";
            lblEtat.Size = new Size(33, 15);
            lblEtat.TabIndex = 21;
            lblEtat.Text = "Etat :";
            // 
            // lblDateDeDernierModifFiche
            // 
            lblDateDeDernierModifFiche.AutoSize = true;
            lblDateDeDernierModifFiche.Location = new Point(478, 137);
            lblDateDeDernierModifFiche.Name = "lblDateDeDernierModifFiche";
            lblDateDeDernierModifFiche.Size = new Size(171, 15);
            lblDateDeDernierModifFiche.TabIndex = 22;
            lblDateDeDernierModifFiche.Text = "Date de Dernière Modification :";
            // 
            // lblMontantValide
            // 
            lblMontantValide.AutoSize = true;
            lblMontantValide.Location = new Point(478, 113);
            lblMontantValide.Name = "lblMontantValide";
            lblMontantValide.Size = new Size(93, 15);
            lblMontantValide.TabIndex = 23;
            lblMontantValide.Text = "Montant Valide :";
            // 
            // btnForfait
            // 
            btnForfait.Location = new Point(518, 365);
            btnForfait.Name = "btnForfait";
            btnForfait.Size = new Size(207, 23);
            btnForfait.TabIndex = 24;
            btnForfait.Text = "afficher frais forfait et hors forfait";
            btnForfait.UseVisualStyleBackColor = true;
            btnForfait.Click += btnForfait_Click;
            // 
            // FFicheDeFrais
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnForfait);
            Controls.Add(lblMontantValide);
            Controls.Add(lblDateDeDernierModifFiche);
            Controls.Add(lblEtat);
            Controls.Add(txtMoisFiche);
            Controls.Add(txtAnnéeFiche);
            Controls.Add(txtNbJustificatifFiche);
            Controls.Add(txtMontantValideFiche);
            Controls.Add(txtDateDeDernierModifFiche);
            Controls.Add(txtEtat);
            Controls.Add(txtIdFiche);
            Controls.Add(lblAnnée);
            Controls.Add(lblFiche);
            Controls.Add(lblNbJustificatifFiche);
            Controls.Add(lblMoisFiche);
            Controls.Add(dgvFicheDeFrais);
            Controls.Add(txtMoisActuelle);
            Controls.Add(txtVisiteurConnecte);
            Controls.Add(lblMoisActuelle);
            Controls.Add(lblVisiteur);
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
        private Label lblVisiteur;
        private Label lblMoisActuelle;
        private TextBox txtVisiteurConnecte;
        private TextBox txtMoisActuelle;
        private DataGridView dgvFicheDeFrais;
        private BindingSource bsFicheDeFrais;
        private Label lblMoisFiche;
        private Label lblNbJustificatifFiche;
        private Label lblFiche;
        private Label lblAnnée;
        private TextBox txtIdFiche;
        private TextBox txtEtat;
        private TextBox txtDateDeDernierModifFiche;
        private TextBox txtMontantValideFiche;
        private TextBox txtNbJustificatifFiche;
        private TextBox txtAnnéeFiche;
        private TextBox txtMoisFiche;
        private Label lblEtat;
        private Label lblDateDeDernierModifFiche;
        private Label lblMontantValide;
        private Button btnForfait;
    }
}