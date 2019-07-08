namespace WindowsFormsApp1
{
    partial class users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(users));
            this.supprimer = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.modifier = new System.Windows.Forms.Button();
            this.chemin = new System.Windows.Forms.Label();
            this.superadmin1 = new System.Windows.Forms.Label();
            this.parcourir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.oui = new System.Windows.Forms.RadioButton();
            this.non = new System.Windows.Forms.RadioButton();
            this.prenomuser = new System.Windows.Forms.TextBox();
            this.nomuser = new System.Windows.Forms.TextBox();
            this.iduser = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.utilisateurs = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.image_user = new System.Windows.Forms.PictureBox();
            this.motdepasse = new System.Windows.Forms.TextBox();
            this.numcin = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ajouter = new System.Windows.Forms.Button();
            this.agilDataSet3 = new WindowsFormsApp1.agilDataSet3();
            this.utilisateursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.utilisateursTableAdapter = new WindowsFormsApp1.agilDataSet3TableAdapters.utilisateursTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agilDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateursBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // supprimer
            // 
            this.supprimer.Location = new System.Drawing.Point(424, 452);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(133, 48);
            this.supprimer.TabIndex = 76;
            this.supprimer.Text = "Supprimer";
            this.supprimer.UseVisualStyleBackColor = true;
            this.supprimer.Click += new System.EventHandler(this.supprimer_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(798, 452);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(133, 48);
            this.reset.TabIndex = 75;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // modifier
            // 
            this.modifier.Location = new System.Drawing.Point(611, 452);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(133, 48);
            this.modifier.TabIndex = 74;
            this.modifier.Text = "Modifier";
            this.modifier.UseVisualStyleBackColor = true;
            this.modifier.Click += new System.EventHandler(this.modifier_Click);
            // 
            // chemin
            // 
            this.chemin.AutoSize = true;
            this.chemin.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.chemin.ForeColor = System.Drawing.SystemColors.GrayText;
            this.chemin.Location = new System.Drawing.Point(-1, 535);
            this.chemin.Name = "chemin";
            this.chemin.Size = new System.Drawing.Size(0, 7);
            this.chemin.TabIndex = 72;
            // 
            // superadmin1
            // 
            this.superadmin1.AutoSize = true;
            this.superadmin1.Location = new System.Drawing.Point(854, 72);
            this.superadmin1.Name = "superadmin1";
            this.superadmin1.Size = new System.Drawing.Size(73, 13);
            this.superadmin1.TabIndex = 59;
            this.superadmin1.Text = "Super Admin :";
            // 
            // parcourir
            // 
            this.parcourir.Location = new System.Drawing.Point(19, 442);
            this.parcourir.Name = "parcourir";
            this.parcourir.Size = new System.Drawing.Size(90, 23);
            this.parcourir.TabIndex = 71;
            this.parcourir.Text = "parcourir";
            this.parcourir.UseVisualStyleBackColor = true;
            this.parcourir.Click += new System.EventHandler(this.parcourir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.oui);
            this.groupBox1.Controls.Add(this.non);
            this.groupBox1.Location = new System.Drawing.Point(857, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(58, 53);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            // 
            // oui
            // 
            this.oui.AutoSize = true;
            this.oui.Location = new System.Drawing.Point(0, 3);
            this.oui.Name = "oui";
            this.oui.Size = new System.Drawing.Size(41, 17);
            this.oui.TabIndex = 19;
            this.oui.Text = "Oui";
            this.oui.UseVisualStyleBackColor = true;
            // 
            // non
            // 
            this.non.AutoSize = true;
            this.non.Checked = true;
            this.non.Location = new System.Drawing.Point(0, 26);
            this.non.Name = "non";
            this.non.Size = new System.Drawing.Size(45, 17);
            this.non.TabIndex = 20;
            this.non.TabStop = true;
            this.non.Text = "Non";
            this.non.UseVisualStyleBackColor = true;
            // 
            // prenomuser
            // 
            this.prenomuser.Location = new System.Drawing.Point(19, 242);
            this.prenomuser.Name = "prenomuser";
            this.prenomuser.Size = new System.Drawing.Size(137, 20);
            this.prenomuser.TabIndex = 65;
            // 
            // nomuser
            // 
            this.nomuser.Location = new System.Drawing.Point(19, 174);
            this.nomuser.Name = "nomuser";
            this.nomuser.Size = new System.Drawing.Size(137, 20);
            this.nomuser.TabIndex = 64;
            // 
            // iduser
            // 
            this.iduser.Location = new System.Drawing.Point(19, 105);
            this.iduser.Name = "iduser";
            this.iduser.Size = new System.Drawing.Size(137, 20);
            this.iduser.TabIndex = 63;
            this.iduser.Leave += new System.EventHandler(this.iduser_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 417);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 58;
            this.label6.Text = "image :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "Mot De Passe :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "Prenom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Id d\'utilisateur:";
            // 
            // utilisateurs
            // 
            this.utilisateurs.AutoSize = true;
            this.utilisateurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.utilisateurs.Location = new System.Drawing.Point(46, 27);
            this.utilisateurs.Name = "utilisateurs";
            this.utilisateurs.Size = new System.Drawing.Size(293, 31);
            this.utilisateurs.TabIndex = 53;
            this.utilisateurs.Text = "Gestion D\'utilisateurs";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(200, 84);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(619, 334);
            this.dataGridView1.TabIndex = 52;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(912, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 46);
            this.button1.TabIndex = 77;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // image_user
            // 
            this.image_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.image_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.image_user.Cursor = System.Windows.Forms.Cursors.Default;
            this.image_user.Image = ((System.Drawing.Image)(resources.GetObject("image_user.Image")));
            this.image_user.InitialImage = ((System.Drawing.Image)(resources.GetObject("image_user.InitialImage")));
            this.image_user.Location = new System.Drawing.Point(130, 442);
            this.image_user.Name = "image_user";
            this.image_user.Size = new System.Drawing.Size(76, 82);
            this.image_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image_user.TabIndex = 73;
            this.image_user.TabStop = false;
            // 
            // motdepasse
            // 
            this.motdepasse.Location = new System.Drawing.Point(19, 306);
            this.motdepasse.Name = "motdepasse";
            this.motdepasse.Size = new System.Drawing.Size(137, 20);
            this.motdepasse.TabIndex = 78;
            // 
            // numcin
            // 
            this.numcin.Location = new System.Drawing.Point(19, 372);
            this.numcin.Name = "numcin";
            this.numcin.Size = new System.Drawing.Size(137, 20);
            this.numcin.TabIndex = 80;
            this.numcin.Leave += new System.EventHandler(this.numcin_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 347);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 79;
            this.label9.Text = "Num CIN :";
            // 
            // ajouter
            // 
            this.ajouter.Location = new System.Drawing.Point(238, 452);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(133, 48);
            this.ajouter.TabIndex = 81;
            this.ajouter.Text = "Ajouter";
            this.ajouter.UseVisualStyleBackColor = true;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // agilDataSet3
            // 
            this.agilDataSet3.DataSetName = "agilDataSet3";
            this.agilDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // utilisateursBindingSource
            // 
            this.utilisateursBindingSource.DataMember = "utilisateurs";
            this.utilisateursBindingSource.DataSource = this.agilDataSet3;
            // 
            // utilisateursTableAdapter
            // 
            this.utilisateursTableAdapter.ClearBeforeFill = true;
            // 
            // users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(962, 546);
            this.Controls.Add(this.ajouter);
            this.Controls.Add(this.numcin);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.motdepasse);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.supprimer);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.modifier);
            this.Controls.Add(this.image_user);
            this.Controls.Add(this.chemin);
            this.Controls.Add(this.superadmin1);
            this.Controls.Add(this.parcourir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.prenomuser);
            this.Controls.Add(this.nomuser);
            this.Controls.Add(this.iduser);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.utilisateurs);
            this.Controls.Add(this.dataGridView1);
            this.Name = "users";
            this.Text = "users";
            this.Load += new System.EventHandler(this.users_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agilDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateursBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button supprimer;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button modifier;
        private System.Windows.Forms.PictureBox image_user;
        private System.Windows.Forms.Label chemin;
        private System.Windows.Forms.Label superadmin1;
        private System.Windows.Forms.Button parcourir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton oui;
        private System.Windows.Forms.RadioButton non;
        private System.Windows.Forms.TextBox prenomuser;
        private System.Windows.Forms.TextBox nomuser;
        private System.Windows.Forms.TextBox iduser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label utilisateurs;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox motdepasse;
        private System.Windows.Forms.TextBox numcin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ajouter;
        private agilDataSet3 agilDataSet3;
        private System.Windows.Forms.BindingSource utilisateursBindingSource;
        private agilDataSet3TableAdapters.utilisateursTableAdapter utilisateursTableAdapter;
    }
}