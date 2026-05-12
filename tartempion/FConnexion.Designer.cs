namespace tartempion
{
    partial class FConnexion
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
            lblIdentifiant = new Label();
            txtIdentifiant = new TextBox();
            lblMotDePasse = new Label();
            txtMotDePasse = new TextBox();
            btnConnexion = new Button();
            SuspendLayout();
            // 
            // lblIdentifiant
            // 
            lblIdentifiant.AutoSize = true;
            lblIdentifiant.Location = new Point(152, 79);
            lblIdentifiant.Name = "lblIdentifiant";
            lblIdentifiant.Size = new Size(67, 15);
            lblIdentifiant.TabIndex = 0;
            lblIdentifiant.Text = "Identifiant :";
            // 
            // txtIdentifiant
            // 
            txtIdentifiant.Location = new Point(214, 116);
            txtIdentifiant.Name = "txtIdentifiant";
            txtIdentifiant.Size = new Size(100, 23);
            txtIdentifiant.TabIndex = 1;
            // 
            // lblMotDePasse
            // 
            lblMotDePasse.AutoSize = true;
            lblMotDePasse.Location = new Point(136, 226);
            lblMotDePasse.Name = "lblMotDePasse";
            lblMotDePasse.Size = new Size(83, 15);
            lblMotDePasse.TabIndex = 2;
            lblMotDePasse.Text = "Mot de passe :";
            // 
            // txtMotDePasse
            // 
            txtMotDePasse.Location = new Point(214, 265);
            txtMotDePasse.Name = "txtMotDePasse";
            txtMotDePasse.ScrollBars = ScrollBars.Both;
            txtMotDePasse.Size = new Size(100, 23);
            txtMotDePasse.TabIndex = 3;
            txtMotDePasse.UseSystemPasswordChar = true;
            // 
            // btnConnexion
            // 
            btnConnexion.Location = new Point(385, 373);
            btnConnexion.Name = "btnConnexion";
            btnConnexion.Size = new Size(96, 23);
            btnConnexion.TabIndex = 4;
            btnConnexion.Text = "Se connecter";
            btnConnexion.UseVisualStyleBackColor = true;
            btnConnexion.Click += btnConnexion_Click_1;
            // 
            // FConnexion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 429);
            Controls.Add(btnConnexion);
            Controls.Add(txtMotDePasse);
            Controls.Add(lblMotDePasse);
            Controls.Add(txtIdentifiant);
            Controls.Add(lblIdentifiant);
            Name = "FConnexion";
            Text = "FConnexion";
            Load += FConnexion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIdentifiant;
        private TextBox txtIdentifiant;
        private Label lblMotDePasse;
        private TextBox txtMotDePasse;
        private Button btnConnexion;
    }
}