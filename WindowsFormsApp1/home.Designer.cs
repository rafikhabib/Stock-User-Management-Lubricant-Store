namespace WindowsFormsApp1
{
    partial class home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.label1 = new System.Windows.Forms.Label();
            this.gestion_des_produits = new System.Windows.Forms.Label();
            this.gestion_utilisateurs = new System.Windows.Forms.Label();
            this.facture = new System.Windows.Forms.Label();
            this.historique = new System.Windows.Forms.Label();
            this.idutilisateur = new System.Windows.Forms.Label();
            this.motdepasse = new System.Windows.Forms.Label();
            this.iduser = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(686, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 96);
            this.label1.TabIndex = 1;
            this.label1.Text = "Station Service\r\nAgil Khetmine";
            // 
            // gestion_des_produits
            // 
            this.gestion_des_produits.AutoSize = true;
            this.gestion_des_produits.BackColor = System.Drawing.Color.Gold;
            this.gestion_des_produits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gestion_des_produits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gestion_des_produits.Enabled = false;
            this.gestion_des_produits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gestion_des_produits.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gestion_des_produits.Location = new System.Drawing.Point(34, 200);
            this.gestion_des_produits.Name = "gestion_des_produits";
            this.gestion_des_produits.Size = new System.Drawing.Size(125, 15);
            this.gestion_des_produits.TabIndex = 2;
            this.gestion_des_produits.Text = "Gestion des produits";
            this.gestion_des_produits.Click += new System.EventHandler(this.gestion_des_produits_Click);
            // 
            // gestion_utilisateurs
            // 
            this.gestion_utilisateurs.AutoSize = true;
            this.gestion_utilisateurs.BackColor = System.Drawing.Color.Gold;
            this.gestion_utilisateurs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gestion_utilisateurs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gestion_utilisateurs.Enabled = false;
            this.gestion_utilisateurs.Location = new System.Drawing.Point(308, 200);
            this.gestion_utilisateurs.Name = "gestion_utilisateurs";
            this.gestion_utilisateurs.Size = new System.Drawing.Size(127, 15);
            this.gestion_utilisateurs.TabIndex = 3;
            this.gestion_utilisateurs.Text = "Gestion d\'utilisateurs";
            this.gestion_utilisateurs.Click += new System.EventHandler(this.gestion_utilisateurs_Click);
            // 
            // facture
            // 
            this.facture.AutoSize = true;
            this.facture.BackColor = System.Drawing.Color.Gold;
            this.facture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.facture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.facture.Enabled = false;
            this.facture.Location = new System.Drawing.Point(599, 200);
            this.facture.Name = "facture";
            this.facture.Size = new System.Drawing.Size(52, 15);
            this.facture.TabIndex = 4;
            this.facture.Text = "Facture";
            this.facture.Click += new System.EventHandler(this.facture_Click);
            // 
            // historique
            // 
            this.historique.AutoSize = true;
            this.historique.BackColor = System.Drawing.Color.Gold;
            this.historique.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.historique.Cursor = System.Windows.Forms.Cursors.Hand;
            this.historique.Enabled = false;
            this.historique.Location = new System.Drawing.Point(816, 200);
            this.historique.Name = "historique";
            this.historique.Size = new System.Drawing.Size(66, 15);
            this.historique.TabIndex = 5;
            this.historique.Text = "Historique";
            this.historique.Click += new System.EventHandler(this.historique_Click);
            // 
            // idutilisateur
            // 
            this.idutilisateur.AutoSize = true;
            this.idutilisateur.Location = new System.Drawing.Point(305, 315);
            this.idutilisateur.Name = "idutilisateur";
            this.idutilisateur.Size = new System.Drawing.Size(79, 13);
            this.idutilisateur.TabIndex = 7;
            this.idutilisateur.Text = "Id Utilisateur";
            // 
            // motdepasse
            // 
            this.motdepasse.AutoSize = true;
            this.motdepasse.Location = new System.Drawing.Point(305, 376);
            this.motdepasse.Name = "motdepasse";
            this.motdepasse.Size = new System.Drawing.Size(86, 13);
            this.motdepasse.TabIndex = 8;
            this.motdepasse.Text = "Mot De Passe";
            // 
            // iduser
            // 
            this.iduser.Location = new System.Drawing.Point(425, 312);
            this.iduser.Name = "iduser";
            this.iduser.Size = new System.Drawing.Size(162, 20);
            this.iduser.TabIndex = 9;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(425, 373);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(162, 20);
            this.password.TabIndex = 10;
            this.password.WordWrap = false;
            this.password.Validated += new System.EventHandler(this.password_Validated);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(484, 436);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Authentifier";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(955, 530);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.iduser);
            this.Controls.Add(this.motdepasse);
            this.Controls.Add(this.idutilisateur);
            this.Controls.Add(this.historique);
            this.Controls.Add(this.facture);
            this.Controls.Add(this.gestion_utilisateurs);
            this.Controls.Add(this.gestion_des_produits);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.Name = "home";
            this.Text = "home";
            this.Load += new System.EventHandler(this.home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label gestion_des_produits;
        private System.Windows.Forms.Label gestion_utilisateurs;
        private System.Windows.Forms.Label facture;
        private System.Windows.Forms.Label historique;
        private System.Windows.Forms.Label idutilisateur;
        private System.Windows.Forms.Label motdepasse;
        private System.Windows.Forms.TextBox iduser;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button button1;
    }
}