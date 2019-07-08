namespace WindowsFormsApp1
{
    partial class ajoutproduit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ajoutproduit));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.idproduit = new System.Windows.Forms.TextBox();
            this.nomproduit = new System.Windows.Forms.TextBox();
            this.marque = new System.Windows.Forms.TextBox();
            this.prix = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.RichTextBox();
            this.emballage = new System.Windows.Forms.ListBox();
            this.graisse = new System.Windows.Forms.RadioButton();
            this.huile = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.quantite = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.parcourir = new System.Windows.Forms.Button();
            this.ajouter = new System.Windows.Forms.Button();
            this.chemin = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.image_produit = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_produit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(46, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ajouter un produit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id de produit :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nom :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Marque :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Description :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(496, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "image de produit :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(496, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Type :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(496, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Emballage :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(496, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Prix :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(496, 311);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Quantité :";
            // 
            // idproduit
            // 
            this.idproduit.Location = new System.Drawing.Point(165, 103);
            this.idproduit.Name = "idproduit";
            this.idproduit.Size = new System.Drawing.Size(258, 20);
            this.idproduit.TabIndex = 10;
            this.idproduit.Leave += new System.EventHandler(this.idproduit_Leave);
            // 
            // nomproduit
            // 
            this.nomproduit.Location = new System.Drawing.Point(165, 169);
            this.nomproduit.Name = "nomproduit";
            this.nomproduit.Size = new System.Drawing.Size(258, 20);
            this.nomproduit.TabIndex = 11;
            this.nomproduit.Leave += new System.EventHandler(this.nomproduit_Leave);
            // 
            // marque
            // 
            this.marque.Location = new System.Drawing.Point(165, 238);
            this.marque.Name = "marque";
            this.marque.Size = new System.Drawing.Size(258, 20);
            this.marque.TabIndex = 12;
            this.marque.Leave += new System.EventHandler(this.marque_Leave);
            // 
            // prix
            // 
            this.prix.Location = new System.Drawing.Point(632, 238);
            this.prix.Name = "prix";
            this.prix.Size = new System.Drawing.Size(168, 20);
            this.prix.TabIndex = 13;
            this.prix.Leave += new System.EventHandler(this.prix_Leave);
            // 
            // description
            // 
            this.description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.description.Location = new System.Drawing.Point(165, 311);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(258, 72);
            this.description.TabIndex = 14;
            this.description.Text = "";
            this.description.Leave += new System.EventHandler(this.description_Leave);
            // 
            // emballage
            // 
            this.emballage.FormattingEnabled = true;
            this.emballage.Items.AddRange(new object[] {
            "1L",
            "2L",
            "4L",
            "5L",
            "20L",
            "200L"});
            this.emballage.Location = new System.Drawing.Point(632, 172);
            this.emballage.Name = "emballage";
            this.emballage.Size = new System.Drawing.Size(68, 30);
            this.emballage.TabIndex = 18;
            this.emballage.SelectedIndexChanged += new System.EventHandler(this.emballage_SelectedIndexChanged);
            // 
            // graisse
            // 
            this.graisse.AutoSize = true;
            this.graisse.Location = new System.Drawing.Point(6, 13);
            this.graisse.Name = "graisse";
            this.graisse.Size = new System.Drawing.Size(67, 17);
            this.graisse.TabIndex = 19;
            this.graisse.Text = "Graisse";
            this.graisse.UseVisualStyleBackColor = true;
            this.graisse.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // huile
            // 
            this.huile.AutoSize = true;
            this.huile.Checked = true;
            this.huile.Location = new System.Drawing.Point(116, 13);
            this.huile.Name = "huile";
            this.huile.Size = new System.Drawing.Size(54, 17);
            this.huile.TabIndex = 20;
            this.huile.TabStop = true;
            this.huile.Text = "Huile";
            this.huile.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.graisse);
            this.groupBox1.Controls.Add(this.huile);
            this.groupBox1.Location = new System.Drawing.Point(632, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 36);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // quantite
            // 
            this.quantite.Location = new System.Drawing.Point(632, 311);
            this.quantite.Name = "quantite";
            this.quantite.Size = new System.Drawing.Size(168, 20);
            this.quantite.TabIndex = 22;
            this.quantite.Leave += new System.EventHandler(this.quantite_Leave);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // parcourir
            // 
            this.parcourir.Location = new System.Drawing.Point(632, 365);
            this.parcourir.Name = "parcourir";
            this.parcourir.Size = new System.Drawing.Size(90, 23);
            this.parcourir.TabIndex = 23;
            this.parcourir.Text = "parcourir";
            this.parcourir.UseVisualStyleBackColor = true;
            this.parcourir.Click += new System.EventHandler(this.parcourir_Click);
            // 
            // ajouter
            // 
            this.ajouter.Location = new System.Drawing.Point(499, 431);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(133, 48);
            this.ajouter.TabIndex = 24;
            this.ajouter.Text = "Ajouter";
            this.ajouter.UseVisualStyleBackColor = true;
            this.ajouter.Click += new System.EventHandler(this.button1_Click);
            // 
            // chemin
            // 
            this.chemin.AutoSize = true;
            this.chemin.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.chemin.ForeColor = System.Drawing.SystemColors.GrayText;
            this.chemin.Location = new System.Drawing.Point(728, 375);
            this.chemin.Name = "chemin";
            this.chemin.Size = new System.Drawing.Size(0, 7);
            this.chemin.TabIndex = 25;
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(165, 431);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(133, 48);
            this.reset.TabIndex = 27;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // image_produit
            // 
            this.image_produit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.image_produit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.image_produit.Cursor = System.Windows.Forms.Cursors.Default;
            this.image_produit.Image = ((System.Drawing.Image)(resources.GetObject("image_produit.Image")));
            this.image_produit.InitialImage = global::WindowsFormsApp1.Properties.Resources.bid;
            this.image_produit.Location = new System.Drawing.Point(761, 393);
            this.image_produit.Name = "image_produit";
            this.image_produit.Size = new System.Drawing.Size(76, 86);
            this.image_produit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image_produit.TabIndex = 26;
            this.image_produit.TabStop = false;
            // 
            // ajoutproduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(933, 491);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.image_produit);
            this.Controls.Add(this.chemin);
            this.Controls.Add(this.ajouter);
            this.Controls.Add(this.parcourir);
            this.Controls.Add(this.quantite);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.emballage);
            this.Controls.Add(this.description);
            this.Controls.Add(this.prix);
            this.Controls.Add(this.marque);
            this.Controls.Add(this.nomproduit);
            this.Controls.Add(this.idproduit);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ajoutproduit";
            this.Text = "ajoutproduit";
            this.Load += new System.EventHandler(this.ajoutproduit_Load);
            this.Leave += new System.EventHandler(this.ajoutproduit_Leave);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_produit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox idproduit;
        private System.Windows.Forms.TextBox nomproduit;
        private System.Windows.Forms.TextBox marque;
        private System.Windows.Forms.TextBox prix;
        private System.Windows.Forms.RichTextBox description;
        private System.Windows.Forms.ListBox emballage;
        private System.Windows.Forms.RadioButton graisse;
        private System.Windows.Forms.RadioButton huile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox quantite;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button parcourir;
        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.Label chemin;
        private System.Windows.Forms.PictureBox image_produit;
        private System.Windows.Forms.Button reset;
    }
}