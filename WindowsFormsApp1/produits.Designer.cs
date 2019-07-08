namespace WindowsFormsApp1
{
    partial class produits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(produits));
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
            this.agilDataSet1 = new WindowsFormsApp1.agilDataSet1();
            this.agilDataSet = new WindowsFormsApp1.agilDataSet();
            this.agilDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ajouter_produit = new System.Windows.Forms.LinkLabel();
            this.modifier_produit = new System.Windows.Forms.LinkLabel();
            this.produitsTableAdapter = new WindowsFormsApp1.agilDataSet1TableAdapters.produitsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agilDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agilDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agilDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.dataGridView1.GridColor = System.Drawing.Color.Khaki;
            this.dataGridView1.Location = new System.Drawing.Point(12, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 290);
            this.dataGridView1.TabIndex = 0;
            // 
            // idproduitDataGridViewTextBoxColumn
            // 
            this.idproduitDataGridViewTextBoxColumn.DataPropertyName = "Idproduit";
            this.idproduitDataGridViewTextBoxColumn.HeaderText = "Idproduit";
            this.idproduitDataGridViewTextBoxColumn.Name = "idproduitDataGridViewTextBoxColumn";
            this.idproduitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // marqueDataGridViewTextBoxColumn
            // 
            this.marqueDataGridViewTextBoxColumn.DataPropertyName = "marque ";
            this.marqueDataGridViewTextBoxColumn.HeaderText = "marque ";
            this.marqueDataGridViewTextBoxColumn.Name = "marqueDataGridViewTextBoxColumn";
            this.marqueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emballageDataGridViewTextBoxColumn
            // 
            this.emballageDataGridViewTextBoxColumn.DataPropertyName = "emballage";
            this.emballageDataGridViewTextBoxColumn.HeaderText = "emballage";
            this.emballageDataGridViewTextBoxColumn.Name = "emballageDataGridViewTextBoxColumn";
            this.emballageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pictureDataGridViewImageColumn
            // 
            this.pictureDataGridViewImageColumn.DataPropertyName = "picture";
            this.pictureDataGridViewImageColumn.HeaderText = "picture";
            this.pictureDataGridViewImageColumn.Name = "pictureDataGridViewImageColumn";
            this.pictureDataGridViewImageColumn.ReadOnly = true;
            // 
            // prixDataGridViewTextBoxColumn
            // 
            this.prixDataGridViewTextBoxColumn.DataPropertyName = "prix ";
            this.prixDataGridViewTextBoxColumn.HeaderText = "prix ";
            this.prixDataGridViewTextBoxColumn.Name = "prixDataGridViewTextBoxColumn";
            this.prixDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantiteDataGridViewTextBoxColumn
            // 
            this.quantiteDataGridViewTextBoxColumn.DataPropertyName = "Quantite";
            this.quantiteDataGridViewTextBoxColumn.HeaderText = "Quantite";
            this.quantiteDataGridViewTextBoxColumn.Name = "quantiteDataGridViewTextBoxColumn";
            this.quantiteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // produitsBindingSource
            // 
            this.produitsBindingSource.DataMember = "produits";
            this.produitsBindingSource.DataSource = this.agilDataSet1;
            // 
            // agilDataSet1
            // 
            this.agilDataSet1.DataSetName = "agilDataSet1";
            this.agilDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agilDataSet
            // 
            this.agilDataSet.DataSetName = "agilDataSet";
            this.agilDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agilDataSetBindingSource
            // 
            this.agilDataSetBindingSource.DataSource = this.agilDataSet;
            this.agilDataSetBindingSource.Position = 0;
            // 
            // ajouter_produit
            // 
            this.ajouter_produit.AutoSize = true;
            this.ajouter_produit.BackColor = System.Drawing.Color.Gold;
            this.ajouter_produit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ajouter_produit.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouter_produit.LinkColor = System.Drawing.Color.Black;
            this.ajouter_produit.Location = new System.Drawing.Point(25, 18);
            this.ajouter_produit.Name = "ajouter_produit";
            this.ajouter_produit.Size = new System.Drawing.Size(123, 21);
            this.ajouter_produit.TabIndex = 1;
            this.ajouter_produit.TabStop = true;
            this.ajouter_produit.Text = "Ajouter produit";
            this.ajouter_produit.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.ajouter_produit.VisitedLinkColor = System.Drawing.Color.Black;
            this.ajouter_produit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ajouter_produit_LinkClicked);
            // 
            // modifier_produit
            // 
            this.modifier_produit.ActiveLinkColor = System.Drawing.Color.Black;
            this.modifier_produit.AutoSize = true;
            this.modifier_produit.BackColor = System.Drawing.Color.Gold;
            this.modifier_produit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modifier_produit.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifier_produit.LinkColor = System.Drawing.Color.Black;
            this.modifier_produit.Location = new System.Drawing.Point(232, 18);
            this.modifier_produit.Name = "modifier_produit";
            this.modifier_produit.Size = new System.Drawing.Size(131, 21);
            this.modifier_produit.TabIndex = 2;
            this.modifier_produit.TabStop = true;
            this.modifier_produit.Text = "Modifier produit";
            this.modifier_produit.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.modifier_produit.VisitedLinkColor = System.Drawing.Color.Black;
            this.modifier_produit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.modifier_produit_LinkClicked);
            // 
            // produitsTableAdapter
            // 
            this.produitsTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(728, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 60);
            this.button1.TabIndex = 3;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // produits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.modifier_produit);
            this.Controls.Add(this.ajouter_produit);
            this.Controls.Add(this.dataGridView1);
            this.Name = "produits";
            this.Text = "produits";
            this.Load += new System.EventHandler(this.produits_Load);
            this.Enter += new System.EventHandler(this.produits_Enter);
            this.Leave += new System.EventHandler(this.produits_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agilDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agilDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agilDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private agilDataSet agilDataSet;
        private System.Windows.Forms.BindingSource agilDataSetBindingSource;
        private System.Windows.Forms.LinkLabel ajouter_produit;
        private System.Windows.Forms.LinkLabel modifier_produit;
        private agilDataSet1 agilDataSet1;
        private System.Windows.Forms.BindingSource produitsBindingSource;
        private agilDataSet1TableAdapters.produitsTableAdapter produitsTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproduitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emballageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn pictureDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantiteDataGridViewTextBoxColumn;
    }
}