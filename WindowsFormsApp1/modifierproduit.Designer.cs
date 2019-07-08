namespace WindowsFormsApp1
{
    partial class modifierproduit
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modifierproduit));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idproduitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emballageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.prixDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agilDataSet2 = new WindowsFormsApp1.agilDataSet2();
            this.produitsTableAdapter = new WindowsFormsApp1.agilDataSet2TableAdapters.produitsTableAdapter();
            this.chemin = new System.Windows.Forms.Label();
            this.parcourir = new System.Windows.Forms.Button();
            this.quantite = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.graisse = new System.Windows.Forms.RadioButton();
            this.huile = new System.Windows.Forms.RadioButton();
            this.emballage = new System.Windows.Forms.ListBox();
            this.description = new System.Windows.Forms.RichTextBox();
            this.prix = new System.Windows.Forms.TextBox();
            this.marque = new System.Windows.Forms.TextBox();
            this.nomproduit = new System.Windows.Forms.TextBox();
            this.idproduit = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.ajouter = new System.Windows.Forms.Button();
            this.supprimer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.image_produit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agilDataSet2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_produit)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproduitDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.marqueDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.emballageDataGridViewTextBoxColumn,
            this.pictureDataGridViewImageColumn,
            this.prixDataGridViewTextBoxColumn,
            this.quantiteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.produitsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(193, 71);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(619, 334);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idproduitDataGridViewTextBoxColumn
            // 
            this.idproduitDataGridViewTextBoxColumn.DataPropertyName = "Idproduit";
            this.idproduitDataGridViewTextBoxColumn.HeaderText = "Idproduit";
            this.idproduitDataGridViewTextBoxColumn.Name = "idproduitDataGridViewTextBoxColumn";
            this.idproduitDataGridViewTextBoxColumn.ReadOnly = true;
            this.idproduitDataGridViewTextBoxColumn.Width = 73;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomDataGridViewTextBoxColumn.Width = 52;
            // 
            // marqueDataGridViewTextBoxColumn
            // 
            this.marqueDataGridViewTextBoxColumn.DataPropertyName = "marque ";
            this.marqueDataGridViewTextBoxColumn.HeaderText = "marque ";
            this.marqueDataGridViewTextBoxColumn.Name = "marqueDataGridViewTextBoxColumn";
            this.marqueDataGridViewTextBoxColumn.ReadOnly = true;
            this.marqueDataGridViewTextBoxColumn.Width = 70;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 83;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeDataGridViewTextBoxColumn.Width = 52;
            // 
            // emballageDataGridViewTextBoxColumn
            // 
            this.emballageDataGridViewTextBoxColumn.DataPropertyName = "emballage";
            this.emballageDataGridViewTextBoxColumn.HeaderText = "emballage";
            this.emballageDataGridViewTextBoxColumn.Name = "emballageDataGridViewTextBoxColumn";
            this.emballageDataGridViewTextBoxColumn.ReadOnly = true;
            this.emballageDataGridViewTextBoxColumn.Width = 80;
            // 
            // pictureDataGridViewImageColumn
            // 
            this.pictureDataGridViewImageColumn.DataPropertyName = "picture";
            this.pictureDataGridViewImageColumn.HeaderText = "picture";
            this.pictureDataGridViewImageColumn.Name = "pictureDataGridViewImageColumn";
            this.pictureDataGridViewImageColumn.ReadOnly = true;
            this.pictureDataGridViewImageColumn.Width = 45;
            // 
            // prixDataGridViewTextBoxColumn
            // 
            this.prixDataGridViewTextBoxColumn.DataPropertyName = "prix ";
            this.prixDataGridViewTextBoxColumn.HeaderText = "prix ";
            this.prixDataGridViewTextBoxColumn.Name = "prixDataGridViewTextBoxColumn";
            this.prixDataGridViewTextBoxColumn.ReadOnly = true;
            this.prixDataGridViewTextBoxColumn.Width = 48;
            // 
            // quantiteDataGridViewTextBoxColumn
            // 
            this.quantiteDataGridViewTextBoxColumn.DataPropertyName = "Quantite";
            this.quantiteDataGridViewTextBoxColumn.HeaderText = "Quantite";
            this.quantiteDataGridViewTextBoxColumn.Name = "quantiteDataGridViewTextBoxColumn";
            this.quantiteDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantiteDataGridViewTextBoxColumn.Width = 72;
            // 
            // produitsBindingSource
            // 
            this.produitsBindingSource.DataMember = "produits";
            this.produitsBindingSource.DataSource = this.agilDataSet2;
            // 
            // agilDataSet2
            // 
            this.agilDataSet2.DataSetName = "agilDataSet2";
            this.agilDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produitsTableAdapter
            // 
            this.produitsTableAdapter.ClearBeforeFill = true;
            // 
            // chemin
            // 
            this.chemin.AutoSize = true;
            this.chemin.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.chemin.ForeColor = System.Drawing.SystemColors.GrayText;
            this.chemin.Location = new System.Drawing.Point(24, 532);
            this.chemin.Name = "chemin";
            this.chemin.Size = new System.Drawing.Size(0, 7);
            this.chemin.TabIndex = 46;
            // 
            // parcourir
            // 
            this.parcourir.Location = new System.Drawing.Point(10, 439);
            this.parcourir.Name = "parcourir";
            this.parcourir.Size = new System.Drawing.Size(90, 23);
            this.parcourir.TabIndex = 45;
            this.parcourir.Text = "parcourir";
            this.parcourir.UseVisualStyleBackColor = true;
            this.parcourir.Click += new System.EventHandler(this.parcourir_Click);
            // 
            // quantite
            // 
            this.quantite.Location = new System.Drawing.Point(850, 316);
            this.quantite.Name = "quantite";
            this.quantite.Size = new System.Drawing.Size(68, 20);
            this.quantite.TabIndex = 44;
            this.quantite.Leave += new System.EventHandler(this.quantite_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.graisse);
            this.groupBox1.Controls.Add(this.huile);
            this.groupBox1.Location = new System.Drawing.Point(850, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(58, 53);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            // 
            // graisse
            // 
            this.graisse.AutoSize = true;
            this.graisse.Location = new System.Drawing.Point(0, 3);
            this.graisse.Name = "graisse";
            this.graisse.Size = new System.Drawing.Size(60, 17);
            this.graisse.TabIndex = 19;
            this.graisse.Text = "Graisse";
            this.graisse.UseVisualStyleBackColor = true;
            // 
            // huile
            // 
            this.huile.AutoSize = true;
            this.huile.Checked = true;
            this.huile.Location = new System.Drawing.Point(0, 26);
            this.huile.Name = "huile";
            this.huile.Size = new System.Drawing.Size(49, 17);
            this.huile.TabIndex = 20;
            this.huile.TabStop = true;
            this.huile.Text = "Huile";
            this.huile.UseVisualStyleBackColor = true;
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
            this.emballage.Location = new System.Drawing.Point(850, 180);
            this.emballage.Name = "emballage";
            this.emballage.Size = new System.Drawing.Size(68, 30);
            this.emballage.TabIndex = 42;
            // 
            // description
            // 
            this.description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.description.Location = new System.Drawing.Point(12, 312);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(137, 72);
            this.description.TabIndex = 41;
            this.description.Text = "";
            this.description.Leave += new System.EventHandler(this.description_Leave);
            // 
            // prix
            // 
            this.prix.Location = new System.Drawing.Point(850, 254);
            this.prix.Name = "prix";
            this.prix.Size = new System.Drawing.Size(68, 20);
            this.prix.TabIndex = 40;
            this.prix.TextChanged += new System.EventHandler(this.prix_TextChanged);
            this.prix.Leave += new System.EventHandler(this.prix_Leave);
            // 
            // marque
            // 
            this.marque.Location = new System.Drawing.Point(12, 234);
            this.marque.Name = "marque";
            this.marque.Size = new System.Drawing.Size(137, 20);
            this.marque.TabIndex = 39;
            this.marque.Leave += new System.EventHandler(this.marque_Leave);
            // 
            // nomproduit
            // 
            this.nomproduit.Location = new System.Drawing.Point(12, 165);
            this.nomproduit.Name = "nomproduit";
            this.nomproduit.Size = new System.Drawing.Size(137, 20);
            this.nomproduit.TabIndex = 38;
            this.nomproduit.Leave += new System.EventHandler(this.nomproduit_Leave);
            // 
            // idproduit
            // 
            this.idproduit.Enabled = false;
            this.idproduit.Location = new System.Drawing.Point(12, 99);
            this.idproduit.Name = "idproduit";
            this.idproduit.Size = new System.Drawing.Size(137, 20);
            this.idproduit.TabIndex = 37;
            this.idproduit.Leave += new System.EventHandler(this.idproduit_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(847, 291);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Quantité :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(847, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Prix :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(848, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Emballage :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(847, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Type :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 417);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "image de produit :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Description :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Marque :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Id de produit :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(39, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 31);
            this.label1.TabIndex = 27;
            this.label1.Text = "Modifier un produit";
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(246, 439);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(133, 48);
            this.reset.TabIndex = 49;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // ajouter
            // 
            this.ajouter.Location = new System.Drawing.Point(679, 439);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(133, 48);
            this.ajouter.TabIndex = 48;
            this.ajouter.Text = "Modifier";
            this.ajouter.UseVisualStyleBackColor = true;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // supprimer
            // 
            this.supprimer.Location = new System.Drawing.Point(463, 439);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(133, 48);
            this.supprimer.TabIndex = 50;
            this.supprimer.Text = "Supprimer";
            this.supprimer.UseVisualStyleBackColor = true;
            this.supprimer.Click += new System.EventHandler(this.supprimer_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(905, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 46);
            this.button1.TabIndex = 51;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // image_produit
            // 
            this.image_produit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.image_produit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.image_produit.Cursor = System.Windows.Forms.Cursors.Default;
            this.image_produit.Image = ((System.Drawing.Image)(resources.GetObject("image_produit.Image")));
            this.image_produit.InitialImage = global::WindowsFormsApp1.Properties.Resources.bid;
            this.image_produit.Location = new System.Drawing.Point(122, 439);
            this.image_produit.Name = "image_produit";
            this.image_produit.Size = new System.Drawing.Size(76, 86);
            this.image_produit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image_produit.TabIndex = 47;
            this.image_produit.TabStop = false;
            // 
            // modifierproduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(963, 548);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.supprimer);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.ajouter);
            this.Controls.Add(this.image_produit);
            this.Controls.Add(this.chemin);
            this.Controls.Add(this.label7);
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
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "modifierproduit";
            this.Text = "modifierproduit";
            this.Load += new System.EventHandler(this.modifierproduit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agilDataSet2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_produit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private agilDataSet2 agilDataSet2;
        private System.Windows.Forms.BindingSource produitsBindingSource;
        private agilDataSet2TableAdapters.produitsTableAdapter produitsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproduitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emballageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn pictureDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox image_produit;
        private System.Windows.Forms.Label chemin;
        private System.Windows.Forms.Button parcourir;
        private System.Windows.Forms.TextBox quantite;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton graisse;
        private System.Windows.Forms.RadioButton huile;
        private System.Windows.Forms.ListBox emballage;
        private System.Windows.Forms.RichTextBox description;
        private System.Windows.Forms.TextBox prix;
        private System.Windows.Forms.TextBox marque;
        private System.Windows.Forms.TextBox nomproduit;
        private System.Windows.Forms.TextBox idproduit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.Button supprimer;
        private System.Windows.Forms.Button button1;
    }
}