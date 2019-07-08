namespace WindowsFormsApp1
{
    partial class historique
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idfactureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcaissierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomcaissierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.immatriculeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeDePaymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalhtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totaltvaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalttcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facturesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agilDataSet6 = new WindowsFormsApp1.agilDataSet6();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.utilisateursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agilDataSet5 = new WindowsFormsApp1.agilDataSet5();
            this.utilisateursTableAdapter = new WindowsFormsApp1.agilDataSet5TableAdapters.utilisateursTableAdapter();
            this.facturesTableAdapter = new WindowsFormsApp1.agilDataSet6TableAdapters.facturesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agilDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateursBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agilDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idfactureDataGridViewTextBoxColumn,
            this.detailsDataGridViewTextBoxColumn,
            this.idcaissierDataGridViewTextBoxColumn,
            this.nomcaissierDataGridViewTextBoxColumn,
            this.nomclientDataGridViewTextBoxColumn,
            this.immatriculeDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.modeDePaymentDataGridViewTextBoxColumn,
            this.totalhtDataGridViewTextBoxColumn,
            this.totaltvaDataGridViewTextBoxColumn,
            this.totalttcDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.facturesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(4, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1138, 315);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // idfactureDataGridViewTextBoxColumn
            // 
            this.idfactureDataGridViewTextBoxColumn.DataPropertyName = "Idfacture";
            this.idfactureDataGridViewTextBoxColumn.HeaderText = "Idfacture";
            this.idfactureDataGridViewTextBoxColumn.Name = "idfactureDataGridViewTextBoxColumn";
            this.idfactureDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // detailsDataGridViewTextBoxColumn
            // 
            this.detailsDataGridViewTextBoxColumn.DataPropertyName = "details";
            this.detailsDataGridViewTextBoxColumn.HeaderText = "details";
            this.detailsDataGridViewTextBoxColumn.Name = "detailsDataGridViewTextBoxColumn";
            this.detailsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idcaissierDataGridViewTextBoxColumn
            // 
            this.idcaissierDataGridViewTextBoxColumn.DataPropertyName = "idcaissier";
            this.idcaissierDataGridViewTextBoxColumn.HeaderText = "idcaissier";
            this.idcaissierDataGridViewTextBoxColumn.Name = "idcaissierDataGridViewTextBoxColumn";
            this.idcaissierDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomcaissierDataGridViewTextBoxColumn
            // 
            this.nomcaissierDataGridViewTextBoxColumn.DataPropertyName = "nomcaissier";
            this.nomcaissierDataGridViewTextBoxColumn.HeaderText = "nomcaissier";
            this.nomcaissierDataGridViewTextBoxColumn.Name = "nomcaissierDataGridViewTextBoxColumn";
            this.nomcaissierDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomclientDataGridViewTextBoxColumn
            // 
            this.nomclientDataGridViewTextBoxColumn.DataPropertyName = "nomclient";
            this.nomclientDataGridViewTextBoxColumn.HeaderText = "nomclient";
            this.nomclientDataGridViewTextBoxColumn.Name = "nomclientDataGridViewTextBoxColumn";
            this.nomclientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // immatriculeDataGridViewTextBoxColumn
            // 
            this.immatriculeDataGridViewTextBoxColumn.DataPropertyName = "immatricule";
            this.immatriculeDataGridViewTextBoxColumn.HeaderText = "immatricule";
            this.immatriculeDataGridViewTextBoxColumn.Name = "immatriculeDataGridViewTextBoxColumn";
            this.immatriculeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modeDePaymentDataGridViewTextBoxColumn
            // 
            this.modeDePaymentDataGridViewTextBoxColumn.DataPropertyName = "mode de payment";
            this.modeDePaymentDataGridViewTextBoxColumn.HeaderText = "mode de payment";
            this.modeDePaymentDataGridViewTextBoxColumn.Name = "modeDePaymentDataGridViewTextBoxColumn";
            this.modeDePaymentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalhtDataGridViewTextBoxColumn
            // 
            this.totalhtDataGridViewTextBoxColumn.DataPropertyName = "totalht";
            this.totalhtDataGridViewTextBoxColumn.HeaderText = "totalht";
            this.totalhtDataGridViewTextBoxColumn.Name = "totalhtDataGridViewTextBoxColumn";
            this.totalhtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totaltvaDataGridViewTextBoxColumn
            // 
            this.totaltvaDataGridViewTextBoxColumn.DataPropertyName = "totaltva";
            this.totaltvaDataGridViewTextBoxColumn.HeaderText = "totaltva";
            this.totaltvaDataGridViewTextBoxColumn.Name = "totaltvaDataGridViewTextBoxColumn";
            this.totaltvaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalttcDataGridViewTextBoxColumn
            // 
            this.totalttcDataGridViewTextBoxColumn.DataPropertyName = "totalttc";
            this.totalttcDataGridViewTextBoxColumn.HeaderText = "totalttc";
            this.totalttcDataGridViewTextBoxColumn.Name = "totalttcDataGridViewTextBoxColumn";
            this.totalttcDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // facturesBindingSource
            // 
            this.facturesBindingSource.DataMember = "factures";
            this.facturesBindingSource.DataSource = this.agilDataSet6;
            // 
            // agilDataSet6
            // 
            this.agilDataSet6.DataSetName = "agilDataSet6";
            this.agilDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(249, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.Value = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(490, 12);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 2;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.utilisateursBindingSource;
            this.listBox1.DisplayMember = "Iduser";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(570, 67);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 43);
            this.listBox1.TabIndex = 3;
            this.listBox1.ValueMember = "Iduser";
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // utilisateursBindingSource
            // 
            this.utilisateursBindingSource.DataMember = "utilisateurs";
            this.utilisateursBindingSource.DataSource = this.agilDataSet5;
            // 
            // agilDataSet5
            // 
            this.agilDataSet5.DataSetName = "agilDataSet5";
            this.agilDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // utilisateursTableAdapter
            // 
            this.utilisateursTableAdapter.ClearBeforeFill = true;
            // 
            // facturesTableAdapter
            // 
            this.facturesTableAdapter.ClearBeforeFill = true;
            // 
            // historique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1154, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "historique";
            this.Text = "historique";
            this.Load += new System.EventHandler(this.historique_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agilDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateursBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agilDataSet5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ListBox listBox1;
        private agilDataSet5 agilDataSet5;
        private System.Windows.Forms.BindingSource utilisateursBindingSource;
        private agilDataSet5TableAdapters.utilisateursTableAdapter utilisateursTableAdapter;
        private agilDataSet6 agilDataSet6;
        private System.Windows.Forms.BindingSource facturesBindingSource;
        private agilDataSet6TableAdapters.facturesTableAdapter facturesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfactureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcaissierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomcaissierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn immatriculeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeDePaymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalhtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totaltvaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalttcDataGridViewTextBoxColumn;
    }
}