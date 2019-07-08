using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Data.SqlClient;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class modifierproduit : Form
    {
        private SqlConnection connection;
        public modifierproduit()
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

        private void modifierproduit_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'agilDataSet2.produits'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.produitsTableAdapter.Fill(this.agilDataSet2.produits);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void idproduit_Leave(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String stridproduit = dataGridView1.CurrentRow.Cells["idproduitDataGridViewTextBoxColumn"].Value.ToString();
            idproduit.Text = stridproduit;
            String strnomproduit = dataGridView1.CurrentRow.Cells["nomDataGridViewTextBoxColumn"].Value.ToString();
            nomproduit.Text = strnomproduit;
            String strmarque = dataGridView1.CurrentRow.Cells["marqueDataGridViewTextBoxColumn"].Value.ToString();
            marque.Text = strmarque;
            String strdesc = dataGridView1.CurrentRow.Cells["descriptionDataGridViewTextBoxColumn"].Value.ToString();
            description.Text = strdesc;
            String strprix = dataGridView1.CurrentRow.Cells["prixDataGridViewTextBoxColumn"].Value.ToString();
            prix.Text = strprix;
            String strqte = dataGridView1.CurrentRow.Cells["quantiteDataGridViewTextBoxColumn"].Value.ToString();
            quantite.Text = strqte;
            String strtype = dataGridView1.CurrentRow.Cells["typeDataGridViewTextBoxColumn"].Value.ToString();
            if (strtype == "Huile") { huile.Checked = true; } else { graisse.Checked = true; };
            String stremballage = dataGridView1.CurrentRow.Cells["emballageDataGridViewTextBoxColumn"].Value.ToString();
            int i=3;
            switch (stremballage)
            {
                case "1L":i = 0;break;
                case "2L":i = 1;break;
                case "4L":i = 2;break;
                case "5L":i = 3;break;
                case "20L":i = 4;break;
                case "200L":i = 5;break;             
            }
            emballage.SelectedIndex = i;
            var img= (Byte[])(dataGridView1.CurrentRow.Cells["pictureDataGridViewImageColumn"].Value);
            var ms = new MemoryStream(img);
            image_produit.Image = Image.FromStream(ms);
        }

        private void parcourir_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                String nomimage = openFileDialog1.FileName;
                chemin.Text = nomimage;
                image_produit.Image = Image.FromFile(nomimage);


            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            idproduit.Clear();
            nomproduit.Clear();
            marque.Clear();
            description.Clear();
            prix.Clear();
            quantite.Clear();
            emballage.SelectedIndex = 3;
            huile.Checked = true;
            chemin.Text = "";
            image_produit.Image = image_produit.InitialImage;
        }
        private String huile_graisse()
        {
            String t = "Huile";
            if (graisse.Checked == true)
            {
                t = "Graisse";

            }
            return t;

        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            if (idproduit.Text != "" && nomproduit.Text != "" && marque.Text != "" && description.Text != "" && prix.Text != "" && quantite.Text != "")
            {
                String connectionString;
                connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Rafik\\source\\repos\\WindowsFormsApp1\\WindowsFormsApp1\\agil.mdf;Integrated Security=True;Connect Timeout=30";
                SqlConnection cn = new SqlConnection(connectionString);
                SqlCommand cmd = cn.CreateCommand();
                String huilegraisse = huile_graisse();
                String typeemballage = (String)emballage.SelectedItem;
                String id =idproduit.Text;
                String textdecommand;
                textdecommand = "UPDATE produits SET nom='" + nomproduit.Text + "',marque='" + marque.Text + "',description='" + description.Text + "',type='" + huilegraisse + "',emballage='" + typeemballage + "',prix='" + prix.Text + "',Quantite='" + quantite.Text + "' WHERE Idproduit="+id+"";
                cmd.CommandText = textdecommand;
                
                cn.Open();
                cmd.ExecuteNonQuery();
                MemoryStream ms = new MemoryStream();
                image_produit.Image.Save(ms, image_produit.Image.RawFormat);
                byte[] img = ms.ToArray();
                SqlCommand imgcmd = cn.CreateCommand();
                String updatingimg = "update produits set picture=@img where Idproduit=" + idproduit.Text;
                imgcmd.Parameters.Add("@img", SqlDbType.Image);
                imgcmd.Parameters["@img"].Value = img;
                imgcmd.CommandText = updatingimg;
                imgcmd.ExecuteNonQuery();
                if (imgcmd.ExecuteNonQuery() == 1) { MessageBox.Show("insertion effectuee"); }
                cn.Close();

            }
            else { MessageBox.Show("entrer des donnees valides"); }
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            String connectionString;
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Rafik\\source\\repos\\WindowsFormsApp1\\WindowsFormsApp1\\agil.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection cn = new SqlConnection(connectionString);
            SqlCommand cmd = cn.CreateCommand();
            String id = idproduit.Text;
            String textdecommand;
            textdecommand = "DELETE FROM produits WHERE Idproduit="+id;
            cmd.CommandText = textdecommand;
            
            if (id == "") { MessageBox.Show("veuillez selectionner un produit"); }
            else
            {   
            cn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("supprime");
            cn.Close();
            }
        }

        private void nomproduit_Leave(object sender, EventArgs e)
        {
            if (nomproduit.Text.Length == 0)
            {
                MessageBox.Show("le nom de produit ne peut pas etre null");
                nomproduit.Focus();
            }
        }

        private void prix_TextChanged(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.openconnection() == true)
            {
                SqlDataAdapter DA = new SqlDataAdapter("Select * from produits", connection);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];
                this.closeconnection();
            }
        }
    }
}
