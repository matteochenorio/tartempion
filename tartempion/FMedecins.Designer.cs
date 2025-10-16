namespace tartempion
{
    partial class FMedecins
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
            label1 = new Label();
            cboSpecialite = new ComboBox();
            btnSpecialiteMedecin = new Button();
            dgvMedecin = new DataGridView();
            bsMedecin = new BindingSource(components);
            bsSpecialite = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvMedecin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsMedecin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsSpecialite).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 0;
            label1.Text = "Spécialité Médecin";
            // 
            // cboSpecialite
            // 
            cboSpecialite.FormattingEnabled = true;
            cboSpecialite.Location = new Point(124, 6);
            cboSpecialite.Name = "cboSpecialite";
            cboSpecialite.Size = new Size(284, 23);
            cboSpecialite.TabIndex = 1;
            // 
            // btnSpecialiteMedecin
            // 
            btnSpecialiteMedecin.Location = new Point(584, 5);
            btnSpecialiteMedecin.Name = "btnSpecialiteMedecin";
            btnSpecialiteMedecin.Size = new Size(204, 23);
            btnSpecialiteMedecin.TabIndex = 4;
            btnSpecialiteMedecin.Text = "Filtrer";
            btnSpecialiteMedecin.UseVisualStyleBackColor = true;
            btnSpecialiteMedecin.Click += btnSpecialiteMedecin_Click;
            // 
            // dgvMedecin
            // 
            dgvMedecin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedecin.Location = new Point(12, 35);
            dgvMedecin.Name = "dgvMedecin";
            dgvMedecin.Size = new Size(776, 403);
            dgvMedecin.TabIndex = 5;
            // 
            // bsSpecialite
            // 
            bsSpecialite.CurrentChanged += bsSpecialite_CurrentChanged;
            // 
            // FMedecins
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvMedecin);
            Controls.Add(btnSpecialiteMedecin);
            Controls.Add(cboSpecialite);
            Controls.Add(label1);
            Name = "FMedecins";
            Text = "FMedecins";
            Load += FMedecins_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMedecin).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsMedecin).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsSpecialite).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboSpecialite;
        private Button btnSpecialiteMedecin;
        private DataGridView dgvMedecin;
        private BindingSource bsMedecin;
        private BindingSource bsSpecialite;
    }
}