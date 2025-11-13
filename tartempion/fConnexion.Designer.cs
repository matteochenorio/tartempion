namespace tartempion
{
    partial class fConnexion
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
            tbMdp = new TextBox();
            tbLogin = new TextBox();
            btnOk = new Button();
            SuspendLayout();
            // 
            // tbMdp
            // 
            tbMdp.Location = new Point(274, 224);
            tbMdp.Name = "tbMdp";
            tbMdp.Size = new Size(100, 23);
            tbMdp.TabIndex = 0;
            // 
            // tbLogin
            // 
            tbLogin.Location = new Point(274, 129);
            tbLogin.Name = "tbLogin";
            tbLogin.Size = new Size(100, 23);
            tbLogin.TabIndex = 1;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(180, 330);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 2;
            btnOk.Text = "button1";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // fConnexion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOk);
            Controls.Add(tbLogin);
            Controls.Add(tbMdp);
            Name = "fConnexion";
            Text = "fConnexion";
            Load += fConnexion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbMdp;
        private TextBox tbLogin;
        private Button btnOk;
    }
}