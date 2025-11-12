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
            cboMedicament = new ComboBox();
            checkBoxRemplacant = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            cboMedicament1 = new ComboBox();
            label3 = new Label();
            qteMedicament = new NumericUpDown();
            tbMotif = new TextBox();
            label4 = new Label();
            label5 = new Label();
            qteAvis = new NumericUpDown();
            label6 = new Label();
            label7 = new Label();
            cboEchantillon = new ComboBox();
            qteEchantillon = new NumericUpDown();
            cboEchantillon1 = new ComboBox();
            cboEchantillon2 = new ComboBox();
            label8 = new Label();
            dateRapport = new DateTimePicker();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            datePrevue = new DateTimePicker();
            dateReelle = new DateTimePicker();
            dateDuree = new DateTimePicker();
            tbBilan = new TextBox();
            bsMedecin = new BindingSource(components);
            bsMedicament = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)qteMedicament).BeginInit();
            ((System.ComponentModel.ISupportInitialize)qteAvis).BeginInit();
            ((System.ComponentModel.ISupportInitialize)qteEchantillon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsMedecin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsMedicament).BeginInit();
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
            // cboMedicament
            // 
            cboMedicament.FormattingEnabled = true;
            cboMedicament.Location = new Point(105, 50);
            cboMedicament.Name = "cboMedicament";
            cboMedicament.Size = new Size(121, 23);
            cboMedicament.TabIndex = 1;
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
            // cboMedicament1
            // 
            cboMedicament1.FormattingEnabled = true;
            cboMedicament1.Location = new Point(232, 50);
            cboMedicament1.Name = "cboMedicament1";
            cboMedicament1.Size = new Size(121, 23);
            cboMedicament1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 93);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 6;
            label3.Text = "QTE Médoc";
            // 
            // qteMedicament
            // 
            qteMedicament.Location = new Point(105, 91);
            qteMedicament.Name = "qteMedicament";
            qteMedicament.Size = new Size(120, 23);
            qteMedicament.TabIndex = 7;
            // 
            // tbMotif
            // 
            tbMotif.Location = new Point(105, 127);
            tbMotif.Name = "tbMotif";
            tbMotif.Size = new Size(248, 23);
            tbMotif.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 130);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 9;
            label4.Text = "Motif Visite";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 169);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 10;
            label5.Text = "Avis Médecin";
            // 
            // qteAvis
            // 
            qteAvis.Location = new Point(105, 167);
            qteAvis.Name = "qteAvis";
            qteAvis.Size = new Size(120, 23);
            qteAvis.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(232, 169);
            label6.Name = "label6";
            label6.Size = new Size(125, 15);
            label6.TabIndex = 12;
            label6.Text = "1 = nul, 5 = incroyable";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(446, 53);
            label7.Name = "label7";
            label7.Size = new Size(124, 15);
            label7.TabIndex = 13;
            label7.Text = "Échantillon(s) offert(s)";
            // 
            // cboEchantillon
            // 
            cboEchantillon.FormattingEnabled = true;
            cboEchantillon.Location = new Point(576, 50);
            cboEchantillon.Name = "cboEchantillon";
            cboEchantillon.Size = new Size(121, 23);
            cboEchantillon.TabIndex = 14;
            // 
            // qteEchantillon
            // 
            qteEchantillon.Location = new Point(703, 50);
            qteEchantillon.Name = "qteEchantillon";
            qteEchantillon.Size = new Size(54, 23);
            qteEchantillon.TabIndex = 15;
            // 
            // cboEchantillon1
            // 
            cboEchantillon1.FormattingEnabled = true;
            cboEchantillon1.Location = new Point(576, 85);
            cboEchantillon1.Name = "cboEchantillon1";
            cboEchantillon1.Size = new Size(121, 23);
            cboEchantillon1.TabIndex = 16;
            // 
            // cboEchantillon2
            // 
            cboEchantillon2.FormattingEnabled = true;
            cboEchantillon2.Location = new Point(576, 122);
            cboEchantillon2.Name = "cboEchantillon2";
            cboEchantillon2.Size = new Size(121, 23);
            cboEchantillon2.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 207);
            label8.Name = "label8";
            label8.Size = new Size(76, 15);
            label8.TabIndex = 18;
            label8.Text = "Date Rapport";
            // 
            // dateRapport
            // 
            dateRapport.Location = new Point(105, 201);
            dateRapport.Name = "dateRapport";
            dateRapport.Size = new Size(200, 23);
            dateRapport.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(11, 242);
            label9.Name = "label9";
            label9.Size = new Size(78, 15);
            label9.TabIndex = 20;
            label9.Text = "Heure prévue";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(11, 277);
            label10.Name = "label10";
            label10.Size = new Size(70, 15);
            label10.TabIndex = 21;
            label10.Text = "Heure réelle";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 313);
            label11.Name = "label11";
            label11.Size = new Size(68, 15);
            label11.TabIndex = 22;
            label11.Text = "Durée visite";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(12, 349);
            label12.Name = "label12";
            label12.Size = new Size(33, 15);
            label12.TabIndex = 23;
            label12.Text = "Bilan";
            // 
            // datePrevue
            // 
            datePrevue.Format = DateTimePickerFormat.Time;
            datePrevue.Location = new Point(105, 236);
            datePrevue.Name = "datePrevue";
            datePrevue.Size = new Size(200, 23);
            datePrevue.TabIndex = 26;
            // 
            // dateReelle
            // 
            dateReelle.Format = DateTimePickerFormat.Time;
            dateReelle.Location = new Point(105, 271);
            dateReelle.Name = "dateReelle";
            dateReelle.Size = new Size(200, 23);
            dateReelle.TabIndex = 27;
            // 
            // dateDuree
            // 
            dateDuree.Format = DateTimePickerFormat.Time;
            dateDuree.Location = new Point(105, 307);
            dateDuree.Name = "dateDuree";
            dateDuree.Size = new Size(200, 23);
            dateDuree.TabIndex = 28;
            // 
            // tbBilan
            // 
            tbBilan.Location = new Point(105, 346);
            tbBilan.Name = "tbBilan";
            tbBilan.Size = new Size(248, 23);
            tbBilan.TabIndex = 29;
            // 
            // FAjoutModifRapport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbBilan);
            Controls.Add(dateDuree);
            Controls.Add(dateReelle);
            Controls.Add(datePrevue);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(dateRapport);
            Controls.Add(label8);
            Controls.Add(cboEchantillon2);
            Controls.Add(cboEchantillon1);
            Controls.Add(qteEchantillon);
            Controls.Add(cboEchantillon);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(qteAvis);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(tbMotif);
            Controls.Add(qteMedicament);
            Controls.Add(label3);
            Controls.Add(cboMedicament1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(checkBoxRemplacant);
            Controls.Add(cboMedicament);
            Controls.Add(cboMedecin);
            Name = "FAjoutModifRapport";
            Text = "FAjoutModifRapport";
            Load += FAjoutModifRapport_Load;
            ((System.ComponentModel.ISupportInitialize)qteMedicament).EndInit();
            ((System.ComponentModel.ISupportInitialize)qteAvis).EndInit();
            ((System.ComponentModel.ISupportInitialize)qteEchantillon).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsMedecin).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsMedicament).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboMedecin;
        private ComboBox cboMedicament;
        private CheckBox checkBoxRemplacant;
        private Label label1;
        private Label label2;
        private ComboBox cboMedicament1;
        private Label label3;
        private NumericUpDown qteMedicament;
        private TextBox tbMotif;
        private Label label4;
        private Label label5;
        private NumericUpDown qteAvis;
        private Label label6;
        private Label label7;
        private ComboBox cboEchantillon;
        private NumericUpDown qteEchantillon;
        private ComboBox cboEchantillon1;
        private ComboBox cboEchantillon2;
        private Label label8;
        private DateTimePicker dateRapport;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private DateTimePicker datePrevue;
        private DateTimePicker dateReelle;
        private DateTimePicker dateDuree;
        private TextBox tbBilan;
        private BindingSource bsMedecin;
        private BindingSource bsMedicament;
    }
}