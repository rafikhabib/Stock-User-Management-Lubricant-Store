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
    public partial class ajoutproduit : Form
    {
        private SqlConnection connection;
        public ajoutproduit()
        {
            InitializeComponent();
            String connectionString;
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Rafik\\source\\repos\\WindowsFormsApp1\\WindowsFormsApp1\\agil.mdf;Integrated Security=True;Connect Timeout=30";
            connection = new SqlConnection(connectionString);
            emballage.SelectedIndex = 3;
            
            
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

        private void ajoutproduit_Load(object sender, EventArgs e)
        {
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }
        private static String nomimage;
        private void parcourir_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                     nomimage = openFileDialog1.FileName;
                     chemin.Text = nomimage;
                     image_produit.Image = Image.FromFile(nomimage);
                
          
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (idproduit.Text !="" && nomproduit.Text!="" && marque.Text!=""&&description.Text!="" &&prix.Text!=""&&quantite.Text!="" )
            {
            String connectionString;
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Rafik\\source\\repos\\WindowsFormsApp1\\WindowsFormsApp1\\agil.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection cn = new SqlConnection(connectionString);
            SqlCommand cmd = cn.CreateCommand();
            String huilegraisse = huile_graisse();
            String typeemballage = (String)emballage.SelectedItem;
            String textdecommand;
            textdecommand = "insert into produits values ('" + idproduit.Text + "','" + nomproduit.Text + "','" + marque.Text + "','" + description.Text + "','" + huilegraisse + "','" + typeemballage + "','" + "" + "','" + prix.Text + "','" + quantite.Text + "')" ;
            cmd.CommandText = textdecommand;
            cn.Open();
            cmd.ExecuteNonQuery();
                MemoryStream ms = new MemoryStream();
                image_produit.Image.Save(ms, image_produit.Image.RawFormat);
                byte[] img = ms.ToArray();
                SqlCommand imgcmd = cn.CreateCommand();
                String updatingimg = "update produits set picture=@img where Idproduit=" + idproduit.Text + "";
                imgcmd.Parameters.Add("@img", SqlDbType.Image);
                imgcmd.Parameters["@img"].Value = img;
                imgcmd.CommandText = updatingimg;
                imgcmd.ExecuteNonQuery();
                if (imgcmd.ExecuteNonQuery() == 1) { MessageBox.Show("insertion effectuee"); }
            cn.Close();
                
            }
            else { MessageBox.Show("entrer des donnees valides"); }
        }
        
        private void nomproduit_Leave(object sender, EventArgs e)
        {
            if (nomproduit.Text.Length == 0)
            {
                MessageBox.Show("le nom de produit ne peut pas etre null");
                nomproduit.Focus();
            }

        }

        private void prix_Leave(object sender, EventArgs e)
        {
       
            if (System.Text.RegularExpressions.Regex.IsMatch(prix.Text, "[^0-9]"))
            {
                MessageBox.Show("le prix peut contenir seulement des chiffres");
                prix.Focus();
            }
            if (prix.Text.Length == 0)
            {
                MessageBox.Show("le prix ne peut pas etre null");
                prix.Focus();
            }
            
        }
        

        private void idproduit_Leave(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(idproduit.Text, "[^0-9]"))
            {
                MessageBox.Show("l identifiant peut contenir seulement des chiffres");
                idproduit.Focus();
            }
            if (idproduit.TextLength <= 0)
            {
                MessageBox.Show("idproduit ne doit pas etre null");
                idproduit.Focus();
            }
            int x=0;
            if (idproduit.TextLength > 0)
            {
                bool ifsuccess = int.TryParse(idproduit.Text, out x);
                String connectionString;
                connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Rafik\\source\\repos\\WindowsFormsApp1\\WindowsFormsApp1\\agil.mdf;Integrated Security=True;Connect Timeout=30";
                SqlConnection cn = new SqlConnection(connectionString);
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText="select count(*) from produits where Idproduit="+x+"";
                cn.Open();
                int r = (int)cmd.ExecuteScalar();
                if (r > 0 )
                {
                    MessageBox.Show("identifant de produit existe deja");
                    idproduit.Focus();
                }
                cn.Close();
            }
            
        }

        private void quantite_Leave(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(quantite.Text, "[^0-9]"))
            {
                MessageBox.Show("la quantite peut contenir seulement des chiffres");
                quantite.Focus();
            }
            if (quantite.Text.Length == 0)
            {
                MessageBox.Show("la quantite ne peut pas etre null");
                quantite.Focus();
            }
            
        }

        private void marque_Leave(object sender, EventArgs e)
        {
            if (marque.Text.Length == 0)
            {
                MessageBox.Show("la marque de produit ne peut pas etre null");
                marque.Focus();
            }
           
        }

        private void description_Leave(object sender, EventArgs e)
        {
            if (description.Text.Length == 0)
            {
                MessageBox.Show("le description de produit ne peut pas etre null");
                description.Focus();
            }
            
        }

        private void emballage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private String huile_graisse()
        {
            String t = "Huile";
            if (graisse.Checked==true)
            {
                t = "Graisse";

            }
            return t;

        }

        private void reset_Click(object sender, EventArgs e)
        {
            idproduit.Clear();
            nomproduit.Clear();
            marque.Clear();
            description.Clear();
            prix.Clear();
            quantite.Clear();
            emballage.SelectedIndex = 3;
            huile.Checked = true;
            chemin.Text="";
            image_produit.Image=image_produit.InitialImage;
        }

        private void ajoutproduit_Leave(object sender, EventArgs e)
        {
            
        }
    }
}
