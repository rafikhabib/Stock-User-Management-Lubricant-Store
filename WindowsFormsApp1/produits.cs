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
    public partial class produits : Form
    {
        private SqlConnection connection;
        int identifiant = home.identifiant;



        public produits()
        {
            InitializeComponent();
            String connectionString;
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Rafik\\source\\repos\\WindowsFormsApp1\\WindowsFormsApp1\\agil.mdf;Integrated Security=True;Connect Timeout=30";
            connection = new SqlConnection(connectionString);
        }
           

        private bool openconnection()
        {
            try
            {
                connection.Open();
                
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private bool closeconnection()
        {
            try
            {
                connection.Close();
                
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }


        private void produits_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'agilDataSet1.produits'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.produitsTableAdapter.Fill(this.agilDataSet1.produits);
            /* if (this.openconnection() == true)
             {
                 SqlDataAdapter DA = new SqlDataAdapter("Select * from produits", connection);
                 DataSet DS = new DataSet();
                 DA.Fill(DS);
                 dataGridView1.DataSource = DS.Tables[0];
                 this.closeconnection();
             }*/
        }

        private void ajouter_produit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ajoutproduit ajoutproduit = new ajoutproduit();
            ajoutproduit.Show();
        }

        private void produits_Leave(object sender, EventArgs e)
        {
            
        }

        private void produits_Enter(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // actualisation de datagridview
            if (this.openconnection() == true)
            {
                SqlDataAdapter DA = new SqlDataAdapter("Select * from produits", connection);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];
                this.closeconnection();
            }

        }

        private void modifier_produit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            modifierproduit modifierproduit = new modifierproduit();
            modifierproduit.Show();
        }
    }
}
