namespace tartempion
{
    partial class FAjoutModifRapport
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
            cboMedecin = new ComboBox();
            checkBoxRemplacant = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            tbMotif = new TextBox();
            label4 = new Label();
            label5 = new Label();
            qteAvis = new NumericUpDown();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            tbBilan = new TextBox();
            bsMedecin = new BindingSource(components);
            bsMedicamentPresentes = new BindingSource(components);
            btnOKAjoutModif = new Button();
            btnCancelAjoutModif = new Button();
            errorProvider = new ErrorProvider(components);
            bsEchantillon = new BindingSource(components);
            tbDateRapport = new TextBox();
            tbHeurePrevue = new TextBox();
            tbHeureReelle = new TextBox();
            tbDureeVisite = new TextBox();
            dgvPresentes = new DataGridView();
            dgvEchantillon = new DataGridView();
            btnModifPresentes = new Button();
            btnModifEchantillon = new Button();
            ((System.ComponentModel.ISupportInitialize)qteAvis).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsMedecin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsMedicamentPresentes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsEchantillon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPresentes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEchantillon).BeginInit();
            SuspendLayout();
            // 
            // cboMedecin
            // 
            cboMedecin.FormattingEnabled = true;
            cboMedecin.Location = new Point(105, 12);
            cboMedecin.Name = "cboMedecin";
            cboMedecin.Size = new Size(121, 23);
            cboMedecin.TabIndex = 0;
            // 
            // checkBoxRemplacant
            // 
            checkBoxRemplacant.AutoSize = true;
            checkBoxRemplacant.Location = new Point(232, 16);
            checkBoxRemplacant.Name = "checkBoxRemplacant";
            checkBoxRemplacant.Size = new Size(97, 19);
            checkBoxRemplacant.TabIndex = 2;
            checkBoxRemplacant.Text = "Remplaçant ?";
            checkBoxRemplacant.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 3;
            label1.Text = "Médecin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 4;
            label2.Text = "Médicament(s)";
            // 
            // tbMotif
            // 
            tbMotif.Location = new Point(105, 185);
            tbMotif.Name = "tbMotif";
            tbMotif.Size = new Size(248, 23);
            tbMotif.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 185);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 9;
            label4.Text = "Motif Visite";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 218);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 10;
            label5.Text = "Avis Médecin";
            // 
            // qteAvis
            // 
            qteAvis.Location = new Point(106, 218);
            qteAvis.Name = "qteAvis";
            qteAvis.Size = new Size(120, 23);
            qteAvis.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(228, 226);
            label6.Name = "label6";
            label6.Size = new Size(125, 15);
            label6.TabIndex = 12;
            label6.Text = "1 = nul, 5 = incroyable";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(414, 53);
            label7.Name = "label7";
            label7.Size = new Size(124, 15);
            label7.TabIndex = 13;
            label7.Text = "Échantillon(s) offert(s)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 250);
            label8.Name = "label8";
            label8.Size = new Size(76, 15);
            label8.TabIndex = 18;
            label8.Text = "Date Rapport";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 279);
            label9.Name = "label9";
            label9.Size = new Size(78, 15);
            label9.TabIndex = 20;
            label9.Text = "Heure prévue";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 312);
            label10.Name = "label10";
            label10.Size = new Size(70, 15);
            label10.TabIndex = 21;
            label10.Text = "Heure réelle";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(11, 342);
            label11.Name = "label11";
            label11.Size = new Size(68, 15);
            label11.TabIndex = 22;
            label11.Text = "Durée visite";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(12, 373);
            label12.Name = "label12";
            label12.Size = new Size(33, 15);
            label12.TabIndex = 23;
            label12.Text = "Bilan";
            // 
            // tbBilan
            // 
            tbBilan.Location = new Point(105, 370);
            tbBilan.Name = "tbBilan";
            tbBilan.Size = new Size(248, 23);
            tbBilan.TabIndex = 29;
            // 
            // btnOKAjoutModif
            // 
            btnOKAjoutModif.Location = new Point(12, 415);
            btnOKAjoutModif.Name = "btnOKAjoutModif";
            btnOKAjoutModif.Size = new Size(75, 23);
            btnOKAjoutModif.TabIndex = 30;
            btnOKAjoutModif.Text = "OK";
            btnOKAjoutModif.UseVisualStyleBackColor = true;
            // 
            // btnCancelAjoutModif
            // 
            btnCancelAjoutModif.Location = new Point(105, 415);
            btnCancelAjoutModif.Name = "btnCancelAjoutModif";
            btnCancelAjoutModif.Size = new Size(75, 23);
            btnCancelAjoutModif.TabIndex = 31;
            btnCancelAjoutModif.Text = "ANNULER";
            btnCancelAjoutModif.UseVisualStyleBackColor = true;
            btnCancelAjoutModif.Click += btnCancelAjoutModif_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // tbDateRapport
            // 
            tbDateRapport.Location = new Point(105, 247);
            tbDateRapport.Name = "tbDateRapport";
            tbDateRapport.Size = new Size(248, 23);
            tbDateRapport.TabIndex = 32;
            // 
            // tbHeurePrevue
            // 
            tbHeurePrevue.Location = new Point(105, 276);
            tbHeurePrevue.Name = "tbHeurePrevue";
            tbHeurePrevue.Size = new Size(248, 23);
            tbHeurePrevue.TabIndex = 33;
            // 
            // tbHeureReelle
            // 
            tbHeureReelle.Location = new Point(105, 309);
            tbHeureReelle.Name = "tbHeureReelle";
            tbHeureReelle.Size = new Size(248, 23);
            tbHeureReelle.TabIndex = 34;
            // 
            // tbDureeVisite
            // 
            tbDureeVisite.Location = new Point(105, 339);
            tbDureeVisite.Name = "tbDureeVisite";
            tbDureeVisite.Size = new Size(248, 23);
            tbDureeVisite.TabIndex = 35;
            // 
            // dgvPresentes
            // 
            dgvPresentes.AllowUserToAddRows = false;
            dgvPresentes.AllowUserToDeleteRows = false;
            dgvPresentes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPresentes.Location = new Point(105, 41);
            dgvPresentes.Name = "dgvPresentes";
            dgvPresentes.ReadOnly = true;
            dgvPresentes.Size = new Size(248, 109);
            dgvPresentes.TabIndex = 36;
            // 
            // dgvEchantillon
            // 
            dgvEchantillon.AllowUserToAddRows = false;
            dgvEchantillon.AllowUserToDeleteRows = false;
            dgvEchantillon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEchantillon.Location = new Point(544, 41);
            dgvEchantillon.Name = "dgvEchantillon";
            dgvEchantillon.ReadOnly = true;
            dgvEchantillon.Size = new Size(248, 109);
            dgvEchantillon.TabIndex = 37;
            // 
            // btnModifPresentes
            // 
            btnModifPresentes.Location = new Point(105, 156);
            btnModifPresentes.Name = "btnModifPresentes";
            btnModifPresentes.Size = new Size(75, 23);
            btnModifPresentes.TabIndex = 38;
            btnModifPresentes.Text = "Modifier";
            btnModifPresentes.UseVisualStyleBackColor = true;
            // 
            // btnModifEchantillon
            // 
            btnModifEchantillon.Location = new Point(544, 156);
            btnModifEchantillon.Name = "btnModifEchantillon";
            btnModifEchantillon.Size = new Size(75, 23);
            btnModifEchantillon.TabIndex = 39;
            btnModifEchantillon.Text = "Modifier";
            btnModifEchantillon.UseVisualStyleBackColor = true;
            // 
            // FAjoutModifRapport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnModifEchantillon);
            Controls.Add(btnModifPresentes);
            Controls.Add(dgvEchantillon);
            Controls.Add(dgvPresentes);
            Controls.Add(tbDureeVisite);
            Controls.Add(tbHeureReelle);
            Controls.Add(tbHeurePrevue);
            Controls.Add(tbDateRapport);
            Controls.Add(btnCancelAjoutModif);
            Controls.Add(btnOKAjoutModif);
            Controls.Add(tbBilan);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(qteAvis);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(tbMotif);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(checkBoxRemplacant);
            Controls.Add(cboMedecin);
            Name = "FAjoutModifRapport";
            Text = "FAjoutModifRapport";
            Load += FAjoutModifRapport_Load;
            ((System.ComponentModel.ISupportInitialize)qteAvis).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsMedecin).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsMedicamentPresentes).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsEchantillon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPresentes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEchantillon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboMedecin;
        private CheckBox checkBoxRemplacant;
        private Label label1;
        private Label label2;
        private TextBox tbMotif;
        private Label label4;
        private Label label5;
        private NumericUpDown qteAvis;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox tbBilan;
        private BindingSource bsMedecin;
        private BindingSource bsMedicamentPresentes;
        private Button btnOKAjoutModif;
        private Button btnCancelAjoutModif;
        private ErrorProvider errorProvider;
        private BindingSource bsEchantillon;
        private TextBox tbDureeVisite;
        private TextBox tbHeureReelle;
        private TextBox tbHeurePrevue;
        private TextBox tbDateRapport;
        private DataGridView dgvPresentes;
        private DataGridView dgvEchantillon;
        private Button btnModifEchantillon;
        private Button btnModifPresentes;
    }
}