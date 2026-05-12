namespace tartempion
{
    partial class FVisiteur
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
            dgvRegion = new System.Windows.Forms.DataGridView();
            btnFermer = new System.Windows.Forms.Button();
            btnAjouter = new System.Windows.Forms.Button();
            btnModifier = new System.Windows.Forms.Button();
            btnSupprimer = new System.Windows.Forms.Button();
            cbRegion = new System.Windows.Forms.ComboBox();
            bsRegion = new System.Windows.Forms.BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvRegion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsRegion).BeginInit();
            this.SuspendLayout();

            dgvRegion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegion.Location = new System.Drawing.Point(200, 40);
            dgvRegion.Name = "dgvRegion";
            dgvRegion.Size = new System.Drawing.Size(580, 360);
            dgvRegion.TabIndex = 4;

            btnFermer.Location = new System.Drawing.Point(705, 11);
            btnFermer.Name = "btnFermer";
            btnFermer.Size = new System.Drawing.Size(75, 23);
            btnFermer.TabIndex = 5;
            btnFermer.Text = "Fermer";
            btnFermer.UseVisualStyleBackColor = true;
            btnFermer.Click += new System.EventHandler(this.btnFermer_Click);

            cbRegion.FormattingEnabled = true;
            cbRegion.Location = new System.Drawing.Point(12, 12);
            cbRegion.Name = "cbRegion";
            cbRegion.Size = new System.Drawing.Size(160, 23);
            cbRegion.TabIndex = 6;
            cbRegion.Text = "-- Toutes les régions --";
            cbRegion.SelectedIndexChanged += new System.EventHandler(this.cbRegion_SelectedIndexChanged);

            btnAjouter.Location = new System.Drawing.Point(12, 410);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new System.Drawing.Size(75, 23);
            btnAjouter.TabIndex = 7;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);

            btnModifier.Location = new System.Drawing.Point(100, 410);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new System.Drawing.Size(75, 23);
            btnModifier.TabIndex = 8;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = true;
            btnModifier.Click += new System.EventHandler(this.btnModifier_Click);

            btnSupprimer.Location = new System.Drawing.Point(188, 410);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new System.Drawing.Size(75, 23);
            btnSupprimer.TabIndex = 9;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(cbRegion);
            this.Controls.Add(btnFermer);
            this.Controls.Add(dgvRegion);
            this.Controls.Add(btnAjouter);
            this.Controls.Add(btnModifier);
            this.Controls.Add(btnSupprimer);
            this.Name = "FVisiteur";
            this.Text = "Visiteurs";
            this.Load += new System.EventHandler(this.FVisiteur_Load);
            ((System.ComponentModel.ISupportInitialize)dgvRegion).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsRegion).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dgvRegion;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.ComboBox cbRegion;
        private System.Windows.Forms.BindingSource bsRegion;
    }
}