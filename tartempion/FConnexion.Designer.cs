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
            tbLogin = new TextBox();
            tbMdp = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pbConnexion = new PictureBox();
            btnOK = new Button();
            ((System.ComponentModel.ISupportInitialize)pbConnexion).BeginInit();
            SuspendLayout();
            // 
            // tbLogin
            // 
            tbLogin.Location = new Point(109, 12);
            tbLogin.Name = "tbLogin";
            tbLogin.Size = new Size(154, 23);
            tbLogin.TabIndex = 0;
            // 
            // tbMdp
            // 
            tbMdp.Location = new Point(109, 50);
            tbMdp.Name = "tbMdp";
            tbMdp.Size = new Size(154, 23);
            tbMdp.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 2;
            label1.Text = "Utilisateur";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 3;
            label2.Text = "Mot de passe";
            // 
            // pbConnexion
            // 
            pbConnexion.Location = new Point(330, 12);
            pbConnexion.Name = "pbConnexion";
            pbConnexion.Size = new Size(458, 426);
            pbConnexion.TabIndex = 4;
            pbConnexion.TabStop = false;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(12, 103);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(251, 23);
            btnOK.TabIndex = 6;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            // 
            // FConnexion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOK);
            Controls.Add(pbConnexion);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbMdp);
            Controls.Add(tbLogin);
            Name = "FConnexion";
            Text = "FConnexion";
            Load += FConnexion_Load;
            ((System.ComponentModel.ISupportInitialize)pbConnexion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbLogin;
        private TextBox tbMdp;
        private Label label1;
        private Label label2;
        private PictureBox pbConnexion;
        private Button btnOK;
    }
}