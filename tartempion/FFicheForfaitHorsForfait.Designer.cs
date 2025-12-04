namespace tartempion
{
    partial class FFicheForfaitHorsForfait
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
            dgvFraisForfait = new DataGridView();
            lblForfait = new Label();
            lblFraisHorsForfait = new Label();
            dgvFraisHorsForfait = new DataGridView();
            bsFraisForfait = new BindingSource(components);
            bsFraisHorsForfait = new BindingSource(components);
            btnRetour = new Button();
            lblTotal = new Label();
            tbTotal = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvFraisForfait).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvFraisHorsForfait).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsFraisForfait).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsFraisHorsForfait).BeginInit();
            SuspendLayout();
            // 
            // dgvFraisForfait
            // 
            dgvFraisForfait.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFraisForfait.Location = new Point(31, 77);
            dgvFraisForfait.Name = "dgvFraisForfait";
            dgvFraisForfait.Size = new Size(278, 258);
            dgvFraisForfait.TabIndex = 0;
            // 
            // lblForfait
            // 
            lblForfait.AutoSize = true;
            lblForfait.Location = new Point(70, 45);
            lblForfait.Name = "lblForfait";
            lblForfait.Size = new Size(77, 15);
            lblForfait.TabIndex = 1;
            lblForfait.Text = "Frais Forfait : ";
            // 
            // lblFraisHorsForfait
            // 
            lblFraisHorsForfait.AutoSize = true;
            lblFraisHorsForfait.Location = new Point(527, 45);
            lblFraisHorsForfait.Name = "lblFraisHorsForfait";
            lblFraisHorsForfait.Size = new Size(102, 15);
            lblFraisHorsForfait.TabIndex = 2;
            lblFraisHorsForfait.Text = "Frais Hors Forfait :";
            // 
            // dgvFraisHorsForfait
            // 
            dgvFraisHorsForfait.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFraisHorsForfait.Location = new Point(481, 77);
            dgvFraisHorsForfait.Name = "dgvFraisHorsForfait";
            dgvFraisHorsForfait.Size = new Size(308, 256);
            dgvFraisHorsForfait.TabIndex = 3;
            // 
            // btnRetour
            // 
            btnRetour.Location = new Point(48, 382);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(75, 23);
            btnRetour.TabIndex = 4;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = true;
            btnRetour.Click += button1_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(614, 380);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(42, 15);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Total : ";
            // 
            // tbTotal
            // 
            tbTotal.Location = new Point(662, 377);
            tbTotal.Name = "tbTotal";
            tbTotal.ReadOnly = true;
            tbTotal.Size = new Size(100, 23);
            tbTotal.TabIndex = 6;
            // 
            // FFicheForfaitHorsForfait
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbTotal);
            Controls.Add(lblTotal);
            Controls.Add(btnRetour);
            Controls.Add(dgvFraisHorsForfait);
            Controls.Add(lblFraisHorsForfait);
            Controls.Add(lblForfait);
            Controls.Add(dgvFraisForfait);
            Name = "FFicheForfaitHorsForfait";
            Text = "FFicheForfaitHorsForfait";
            Load += FFicheForfaitHorsForfait_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFraisForfait).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvFraisHorsForfait).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsFraisForfait).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsFraisHorsForfait).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvFraisForfait;
        private Label lblForfait;
        private Label lblFraisHorsForfait;
        private DataGridView dgvFraisHorsForfait;
        private BindingSource bsFraisForfait;
        private BindingSource bsFraisHorsForfait;
        private Button btnRetour;
        private Label lblTotal;
        private TextBox tbTotal;
    }
}