namespace tartempion
{
    partial class FMedicaments
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
            bsMedicament = new BindingSource(components);
            bsFamille = new BindingSource(components);
            cboFamille = new ComboBox();
            label1 = new Label();
            button1 = new Button();
            btnFamilleMedica = new Button();
            dgvMedicament = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)bsMedicament).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsFamille).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMedicament).BeginInit();
            SuspendLayout();
            // 
            // bsFamille
            // 
            bsFamille.CurrentChanged += bsFamille_CurrentChanged;
            // 
            // cboFamille
            // 
            cboFamille.FormattingEnabled = true;
            cboFamille.Location = new Point(149, 6);
            cboFamille.Name = "cboFamille";
            cboFamille.Size = new Size(284, 23);
            cboFamille.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(131, 15);
            label1.TabIndex = 1;
            label1.Text = "Famille de Médicament";
            // 
            // button1
            // 
            button1.Location = new Point(1584, 635);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Filtrer";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnFamilleMedica
            // 
            btnFamilleMedica.Location = new Point(584, 6);
            btnFamilleMedica.Name = "btnFamilleMedica";
            btnFamilleMedica.Size = new Size(204, 23);
            btnFamilleMedica.TabIndex = 3;
            btnFamilleMedica.Text = "Filtrer";
            btnFamilleMedica.UseVisualStyleBackColor = true;
            btnFamilleMedica.Click += btnFamilleMedica_Click;
            // 
            // dgvMedicament
            // 
            dgvMedicament.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedicament.Location = new Point(12, 35);
            dgvMedicament.Name = "dgvMedicament";
            dgvMedicament.Size = new Size(776, 403);
            dgvMedicament.TabIndex = 4;
            // 
            // FMedicaments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvMedicament);
            Controls.Add(btnFamilleMedica);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(cboFamille);
            Name = "FMedicaments";
            Text = "FMedicaments";
            Load += FMedicaments_Load;
            ((System.ComponentModel.ISupportInitialize)bsMedicament).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsFamille).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMedicament).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource bsMedicament;
        private BindingSource bsFamille;
        private ComboBox cboFamille;
        private Label label1;
        private Button button1;
        private Button btnFamilleMedica;
        private DataGridView dgvMedicament;
    }
}