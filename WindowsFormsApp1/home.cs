using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class home : Form
    {
        public static int identifiant;
        public home()
        {
            InitializeComponent();
        }

        private void gestion_des_produits_Click(object sender, EventArgs e)
        {
            produits produits = new produits();
            produits.Show();
        }

        private void home_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String connectionString;
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Rafik\\source\\repos\\WindowsFormsApp1\\WindowsFormsApp1\\agil.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection connection = new SqlConnection(connectionString);
            int x = 0;
            String iduser1;
            String mot_de_passe;
            iduser1 = iduser.Text;
            mot_de_passe = password.Text;
            bool ifsuccess = int.TryParse(iduser1, out x);
            SqlCommand cmd =connection.CreateCommand();
            cmd.CommandText = "select count(*) from utilisateurs where Iduser=" + x + "and motdepasse=" + mot_de_passe + ";";
            SqlCommand cmd1 = connection.CreateCommand();
            cmd1.CommandText = "select count(*) from utilisateurs where Iduser=" + x + "and motdepasse=" + mot_de_passe + "and superadmin=1";
            connection.Open();
            cmd.ExecuteNonQuery();
            cmd1.ExecuteNonQuery();
            if ((int)cmd.ExecuteScalar() == 0)
            {
                MessageBox.Show("donnees erronees");
            }else
            {
                if ((int)cmd1.ExecuteScalar() > 0)
                {
                    MessageBox.Show("connected as admin");
                    identifiant = x;
                    gestion_des_produits.Enabled = true;
                    gestion_utilisateurs.Enabled = true;
                    facture.Enabled = true;
                    historique.Enabled = true;
                    iduser.Enabled = false;
                    password.Enabled = false;
                    button1.Enabled = false;
                }
                else
                {
                    MessageBox.Show("connected as user");
                    identifiant = x;
                    gestion_utilisateurs.Enabled = true;
                    facture.Enabled = true;
                    iduser.Enabled = false;
                    password.Enabled = false;
                    button1.Enabled = false;
                }
                
            }
            connection.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void gestion_utilisateurs_Click(object sender, EventArgs e)
        {
            users users = new users();
            users.Show();

        }

        private void facture_Click(object sender, EventArgs e)
        {
            facture facture = new facture();
            facture.Show();
        }

        private void historique_Click(object sender, EventArgs e)
        {
            historique historique = new historique();
            historique.Show();
        }

        private void password_Validated(object sender, EventArgs e)
        {
            
        }
    }
}
