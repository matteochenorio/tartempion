namespace tartempion
{
    partial class FAjoutModifFicheDeFrais
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
            lblVisiteur = new Label();
            lblFraisForfait = new Label();
            tbMatricule = new TextBox();
            tbNom = new TextBox();
            btnAjouter = new Button();
            btnSuivant = new Button();
            btnAnnuler = new Button();
            lblFraisForfaitaires = new Label();
            lblQuantite = new Label();
            lblMontantUnitaire = new Label();
            lblTotal = new Label();
            label2 = new Label();
            dtpDate = new DateTimePicker();
            cboFraisForfait = new ComboBox();
            bsFraisForfait = new BindingSource(components);
            pFraisForfaitaires = new Panel();
            pQuantite = new Panel();
            pMontantUnitaire = new Panel();
            pTotal = new Panel();
            pSupp = new Panel();
            bsHistoriqueFrais = new BindingSource(components);
            tbTotalGeneral = new TextBox();
            lblTotalGeneral = new Label();
            ((System.ComponentModel.ISupportInitialize)bsFraisForfait).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsHistoriqueFrais).BeginInit();
            SuspendLayout();
            // 
            // lblVisiteur
            // 
            lblVisiteur.AutoSize = true;
            lblVisiteur.Location = new Point(119, 26);
            lblVisiteur.Name = "lblVisiteur";
            lblVisiteur.Size = new Size(55, 15);
            lblVisiteur.TabIndex = 0;
            lblVisiteur.Text = "Visiteur : ";
            // 
            // lblFraisForfait
            // 
            lblFraisForfait.AutoSize = true;
            lblFraisForfait.Location = new Point(12, 108);
            lblFraisForfait.Name = "lblFraisForfait";
            lblFraisForfait.Size = new Size(77, 15);
            lblFraisForfait.TabIndex = 4;
            lblFraisForfait.Text = "Frais Forfait : ";
            // 
            // tbMatricule
            // 
            tbMatricule.Location = new Point(295, 23);
            tbMatricule.Name = "tbMatricule";
            tbMatricule.Size = new Size(100, 23);
            tbMatricule.TabIndex = 5;
            // 
            // tbNom
            // 
            tbNom.Location = new Point(488, 23);
            tbNom.Name = "tbNom";
            tbNom.Size = new Size(100, 23);
            tbNom.TabIndex = 6;
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(14, 169);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(75, 23);
            btnAjouter.TabIndex = 8;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // btnSuivant
            // 
            btnSuivant.Location = new Point(713, 415);
            btnSuivant.Name = "btnSuivant";
            btnSuivant.Size = new Size(75, 23);
            btnSuivant.TabIndex = 9;
            btnSuivant.Text = "Suivant";
            btnSuivant.UseVisualStyleBackColor = true;
            btnSuivant.Click += btnSuivant_Click;
            // 
            // btnAnnuler
            // 
            btnAnnuler.Location = new Point(713, 374);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new Size(75, 23);
            btnAnnuler.TabIndex = 10;
            btnAnnuler.Text = "Annuler";
            btnAnnuler.UseVisualStyleBackColor = true;
            btnAnnuler.Click += btnAnnuler_Click;
            // 
            // lblFraisForfaitaires
            // 
            lblFraisForfaitaires.AutoSize = true;
            lblFraisForfaitaires.Location = new Point(139, 150);
            lblFraisForfaitaires.Name = "lblFraisForfaitaires";
            lblFraisForfaitaires.Size = new Size(92, 15);
            lblFraisForfaitaires.TabIndex = 12;
            lblFraisForfaitaires.Text = "Frais Forfaitaires";
            // 
            // lblQuantite
            // 
            lblQuantite.AutoSize = true;
            lblQuantite.Location = new Point(272, 151);
            lblQuantite.Name = "lblQuantite";
            lblQuantite.Size = new Size(53, 15);
            lblQuantite.TabIndex = 13;
            lblQuantite.Text = "Quantite";
            // 
            // lblMontantUnitaire
            // 
            lblMontantUnitaire.AutoSize = true;
            lblMontantUnitaire.Location = new Point(389, 151);
            lblMontantUnitaire.Name = "lblMontantUnitaire";
            lblMontantUnitaire.Size = new Size(97, 15);
            lblMontantUnitaire.TabIndex = 14;
            lblMontantUnitaire.Text = "Montant Unitaire";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(514, 150);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(33, 15);
            lblTotal.TabIndex = 15;
            lblTotal.Text = "Total";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(119, 70);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Mois :";
            // 
            // dtpDate
            // 
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.Location = new Point(164, 64);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 23);
            dtpDate.TabIndex = 16;
            // 
            // cboFraisForfait
            // 
            cboFraisForfait.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFraisForfait.FormattingEnabled = true;
            cboFraisForfait.Location = new Point(95, 105);
            cboFraisForfait.Name = "cboFraisForfait";
            cboFraisForfait.Size = new Size(269, 23);
            cboFraisForfait.TabIndex = 17;
            // 
            // pFraisForfaitaires
            // 
            pFraisForfaitaires.Location = new Point(139, 169);
            pFraisForfaitaires.Name = "pFraisForfaitaires";
            pFraisForfaitaires.Size = new Size(108, 269);
            pFraisForfaitaires.TabIndex = 18;
            // 
            // pQuantite
            // 
            pQuantite.Location = new Point(272, 169);
            pQuantite.Name = "pQuantite";
            pQuantite.Size = new Size(92, 269);
            pQuantite.TabIndex = 19;
            // 
            // pMontantUnitaire
            // 
            pMontantUnitaire.Location = new Point(389, 169);
            pMontantUnitaire.Name = "pMontantUnitaire";
            pMontantUnitaire.Size = new Size(97, 269);
            pMontantUnitaire.TabIndex = 20;
            // 
            // pTotal
            // 
            pTotal.Location = new Point(514, 169);
            pTotal.Name = "pTotal";
            pTotal.Size = new Size(74, 269);
            pTotal.TabIndex = 21;
            // 
            // pSupp
            // 
            pSupp.Location = new Point(605, 169);
            pSupp.Name = "pSupp";
            pSupp.Size = new Size(52, 269);
            pSupp.TabIndex = 22;
            // 
            // tbTotalGeneral
            // 
            tbTotalGeneral.Location = new Point(12, 235);
            tbTotalGeneral.Name = "tbTotalGeneral";
            tbTotalGeneral.Size = new Size(100, 23);
            tbTotalGeneral.TabIndex = 23;
            // 
            // lblTotalGeneral
            // 
            lblTotalGeneral.AutoSize = true;
            lblTotalGeneral.Location = new Point(14, 217);
            lblTotalGeneral.Name = "lblTotalGeneral";
            lblTotalGeneral.Size = new Size(82, 15);
            lblTotalGeneral.TabIndex = 24;
            lblTotalGeneral.Text = "Total Général :";
            // 
            // FAjoutModifFicheDeFrais
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTotalGeneral);
            Controls.Add(tbTotalGeneral);
            Controls.Add(pSupp);
            Controls.Add(pTotal);
            Controls.Add(pMontantUnitaire);
            Controls.Add(pQuantite);
            Controls.Add(pFraisForfaitaires);
            Controls.Add(cboFraisForfait);
            Controls.Add(dtpDate);
            Controls.Add(lblTotal);
            Controls.Add(lblMontantUnitaire);
            Controls.Add(lblQuantite);
            Controls.Add(lblFraisForfaitaires);
            Controls.Add(btnAnnuler);
            Controls.Add(btnSuivant);
            Controls.Add(btnAjouter);
            Controls.Add(tbNom);
            Controls.Add(tbMatricule);
            Controls.Add(lblFraisForfait);
            Controls.Add(label2);
            Controls.Add(lblVisiteur);
            Name = "FAjoutModifFicheDeFrais";
            Text = "FAjoutModifFicheDeFrais";
            Load += FAjoutModifFicheDeFrais_Load;
            ((System.ComponentModel.ISupportInitialize)bsFraisForfait).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsHistoriqueFrais).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblVisiteur;
        private Label lblFraisForfait;
        private TextBox tbMatricule;
        private TextBox tbNom;
        private Button btnAjouter;
        private Button btnSuivant;
        private Button btnAnnuler;
        private Label lblFraisForfaitaires;
        private Label lblQuantite;
        private Label lblMontantUnitaire;
        private Label lblTotal;
        private Label label2;
        private DateTimePicker dtpDate;
        private ComboBox cboFraisForfait;
        private BindingSource bsFraisForfait;
        private Panel pFraisForfaitaires;
        private Panel pQuantite;
        private Panel pMontantUnitaire;
        private Panel pTotal;
        private Panel pSupp;
        private BindingSource bsHistoriqueFrais;
        private TextBox tbTotalGeneral;
        private Label lblTotalGeneral;
    }
}