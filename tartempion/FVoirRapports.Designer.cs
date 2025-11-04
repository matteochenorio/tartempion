namespace tartempion
{
    partial class FVoirRapports
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
            cboSpecialite = new ComboBox();
            label1 = new Label();
            dgvMedecin = new DataGridView();
            dgvRapport = new DataGridView();
            label2 = new Label();
            cboFiltreRapport = new ComboBox();
            bsSpecialite = new BindingSource(components);
            bsMedecin = new BindingSource(components);
            bsRapport = new BindingSource(components);
            bsFiltreRapport = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvMedecin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRapport).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsSpecialite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsMedecin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsRapport).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsFiltreRapport).BeginInit();
            SuspendLayout();
            // 
            // cboSpecialite
            // 
            cboSpecialite.FormattingEnabled = true;
            cboSpecialite.Location = new Point(12, 27);
            cboSpecialite.Name = "cboSpecialite";
            cboSpecialite.Size = new Size(369, 23);
            cboSpecialite.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 1;
            label1.Text = "Liste des Médecins";
            // 
            // dgvMedecin
            // 
            dgvMedecin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedecin.Location = new Point(12, 66);
            dgvMedecin.Name = "dgvMedecin";
            dgvMedecin.Size = new Size(369, 372);
            dgvMedecin.TabIndex = 2;
            // 
            // dgvRapport
            // 
            dgvRapport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRapport.Location = new Point(406, 66);
            dgvRapport.Name = "dgvRapport";
            dgvRapport.Size = new Size(382, 372);
            dgvRapport.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(406, 9);
            label2.Name = "label2";
            label2.Size = new Size(151, 15);
            label2.TabIndex = 4;
            label2.Text = "Les rapports de ce médecin";
            // 
            // cboFiltreRapport
            // 
            cboFiltreRapport.FormattingEnabled = true;
            cboFiltreRapport.Location = new Point(406, 27);
            cboFiltreRapport.Name = "cboFiltreRapport";
            cboFiltreRapport.Size = new Size(382, 23);
            cboFiltreRapport.TabIndex = 5;
            // 
            // bsSpecialite
            // 
            bsSpecialite.CurrentChanged += bsSpecialite_CurrentChanged;
            // 
            // bsMedecin
            // 
            bsMedecin.CurrentChanged += bsMedecin_CurrentChanged;
            // 
            // bsRapport
            // 
            bsRapport.CurrentChanged += bsRapport_CurrentChanged;
            // 
            // FVoirRapports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cboFiltreRapport);
            Controls.Add(label2);
            Controls.Add(dgvRapport);
            Controls.Add(dgvMedecin);
            Controls.Add(label1);
            Controls.Add(cboSpecialite);
            Name = "FVoirRapports";
            Text = "FVoirRapports";
            Load += FVoirRapports_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMedecin).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRapport).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsSpecialite).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsMedecin).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsRapport).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsFiltreRapport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboSpecialite;
        private Label label1;
        private DataGridView dgvMedecin;
        private DataGridView dgvRapport;
        private Label label2;
        private ComboBox cboFiltreRapport;
        private BindingSource bsSpecialite;
        private BindingSource bsMedecin;
        private BindingSource bsRapport;
        private BindingSource bsFiltreRapport;
    }
}