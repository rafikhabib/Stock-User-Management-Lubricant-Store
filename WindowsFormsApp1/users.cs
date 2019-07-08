using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;


namespace WindowsFormsApp1
{
    public partial class users : Form
    {
        private SqlConnection connection;
        int identifiant = home.identifiant;
        public users()
        {
            InitializeComponent();
            String connectionString;
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Rafik\\source\\repos\\WindowsFormsApp1\\WindowsFormsApp1\\agil.mdf;Integrated Security=True;Connect Timeout=30";
            connection = new SqlConnection(connectionString);
        }
        private bool superadmin()
        {
            bool t = false;
            if (oui.Checked == true)
            {
                t = true;

            }
            return t;

        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            String connectionString;
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Rafik\\source\\repos\\WindowsFormsApp1\\WindowsFormsApp1\\agil.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmdid = con.CreateCommand();
            int i=-1;
            if (iduser.Text == "") { MessageBox.Show("id est null"); }
            else
            {
                con.Open();
                String textcmdid = "select count(*) from utilisateurs where Iduser=" + iduser.Text;
                cmdid.CommandText = textcmdid;
                 i = (int)cmdid.ExecuteScalar();
                con.Close();
            }

            if (i > 0) { MessageBox.Show("utilisateur existe deja"); }
            else
            {
                if (iduser.Text != "" && nomuser.Text != "" && prenomuser.Text != "" && motdepasse.Text != "" && numcin.Text != "")
                {

                    SqlConnection cn = new SqlConnection(connectionString);
                    SqlCommand cmd = cn.CreateCommand();
                    bool superad = superadmin();
                    String id = iduser.Text;
                    String textdecommand;
                    textdecommand = "insert into utilisateurs values ('"+id+"','" + nomuser.Text + "','" + prenomuser.Text + "','" + motdepasse.Text + "','" + superad.ToString() + "','" + numcin.Text + "','"+""+"')";
                    cmd.CommandText = textdecommand;
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    MemoryStream ms = new MemoryStream();
                    image_user.Image.Save(ms, image_user.Image.RawFormat);
                    byte[] img = ms.ToArray();
                    SqlCommand imgcmd = cn.CreateCommand();
                    String updatingimg = "update utilisateurs set photo=@img where Iduser=" + iduser.Text;
                    imgcmd.Parameters.Add("@img", SqlDbType.Image);
                    imgcmd.Parameters["@img"].Value = img;
                    imgcmd.CommandText = updatingimg;
                    imgcmd.ExecuteNonQuery();
                    if (imgcmd.ExecuteNonQuery() == 1) { MessageBox.Show("insertion effectuee"); }
                    cn.Close();

                }
                else { MessageBox.Show("entrer des donnees valides"); }
            }
        }

        private void parcourir_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                String nomimage = openFileDialog1.FileName;
                chemin.Text = nomimage;
                image_user.Image = Image.FromFile(nomimage);


            }
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
        private void users_Load(object sender, EventArgs e)
        {
                     
            String connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Rafik\\source\\repos\\WindowsFormsApp1\\WindowsFormsApp1\\agil.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection cn = new SqlConnection(connectionString);
            SqlCommand cmd = cn.CreateCommand();
            String textdecommand;
            textdecommand = "select count(*) from utilisateurs where Iduser=" + identifiant + "and superadmin=1;";
            cmd.CommandText = textdecommand;
            cn.Open();
            cmd.ExecuteNonQuery();       
            
            if ((int)cmd.ExecuteScalar()==1)
            {
                // TODO: cette ligne de code charge les données dans la table 'agilDataSet3.utilisateurs'. Vous pouvez la déplacer ou la supprimer selon les besoins.
                this.utilisateursTableAdapter.Fill(this.agilDataSet3.utilisateurs);
                dataGridView1.DataSource = agilDataSet3.utilisateurs;
            }
            else
            {
                iduser.Enabled = false;
                ajouter.Enabled = false;
                oui.Enabled = false;

                if (this.openconnection() == true)
                {
                    String t = "Select * from utilisateurs where Iduser=" + identifiant;
                    SqlDataAdapter DA = new SqlDataAdapter(t, connection);
                    DataSet DS = new DataSet();
                    DA.Fill(DS);
                    dataGridView1.DataSource = DS.Tables[0];
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    this.closeconnection();
                }
            }
            cn.Close();
        }

        private void modifier_Click(object sender, EventArgs e)
        {
            String connectionString;
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Rafik\\source\\repos\\WindowsFormsApp1\\WindowsFormsApp1\\agil.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmdid = con.CreateCommand();
            int i = -1;
            if (iduser.Text == "") { MessageBox.Show("id est null"); }
            else
            {
                con.Open();
                String textcmdid = "select count(*) from utilisateurs where Iduser=" + iduser.Text;
                cmdid.CommandText = textcmdid;
                i = (int)cmdid.ExecuteScalar();
                con.Close();
            }

            if (i == 0) { MessageBox.Show("utilisateur n'existe pas"); }
            else
            {
                if (iduser.Text != "" && nomuser.Text != "" && prenomuser.Text != "" && motdepasse.Text != "" && numcin.Text != "")
                {

                    SqlConnection cn = new SqlConnection(connectionString);
                    SqlCommand cmd = cn.CreateCommand();
                    bool superad = superadmin();
                    String id = iduser.Text;
                    String textdecommand;
                    textdecommand = "update utilisateurs set nom='"+ nomuser.Text + "',prenom='" + prenomuser.Text + "',motdepasse='" + motdepasse.Text + "',superadmin='" + superad.ToString() + "',numcin='" + numcin.Text + "',photo='" + "" + "' where Iduser="+id;
                    cmd.CommandText = textdecommand;
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    MemoryStream ms = new MemoryStream();
                    image_user.Image.Save(ms, image_user.Image.RawFormat);
                    byte[] img = ms.ToArray();
                    SqlCommand imgcmd = cn.CreateCommand();
                    String updatingimg = "update utilisateurs set photo=@img where Iduser=" + id+"";
                    imgcmd.Parameters.Add("@img", SqlDbType.Image);
                    imgcmd.Parameters["@img"].Value = img;
                    imgcmd.CommandText = updatingimg;
                    imgcmd.ExecuteNonQuery();
                    if (imgcmd.ExecuteNonQuery() == 1) { MessageBox.Show("insertion effectuee"); }
                    cn.Close();

                }
                else { MessageBox.Show("entrer des donnees valides"); }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String stridproduit = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            iduser.Text = stridproduit;
            String strnomproduit = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            nomuser.Text = strnomproduit;
            String strmarque = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            prenomuser.Text = strmarque;
            String strdesc = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            motdepasse.Text = strdesc;
            String strprix = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            numcin.Text = strprix;
            if (dataGridView1.CurrentRow.Cells[4].Value.ToString() == "True")
            { oui.Checked = true; } else { non.Checked = true; };
            var img = (byte[])(dataGridView1.CurrentRow.Cells[6].Value);
            var ms = new MemoryStream(img);
            image_user.Image = Image.FromStream(ms);
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Rafik\\source\\repos\\WindowsFormsApp1\\WindowsFormsApp1\\agil.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection cn = new SqlConnection(connectionString);
            SqlCommand cmd = cn.CreateCommand();
            String textdecommand;
            textdecommand = "select count(*) from utilisateurs where Iduser=" + identifiant + "and superadmin=1;";
            cmd.CommandText = textdecommand;
            cn.Open();
            cmd.ExecuteNonQuery();
            if ((int)cmd.ExecuteScalar() == 1)
            {
                if (this.openconnection() == true)
                {
                    String t = "Select * from utilisateurs ";
                    SqlDataAdapter DA = new SqlDataAdapter(t, connection);
                    DataSet DS = new DataSet();
                    DA.Fill(DS);
                    dataGridView1.DataSource = DS.Tables[0];
                    this.closeconnection();
                }
            }
            else
            {
                if (this.openconnection() == true)
                {
                    String t = "Select * from utilisateurs where Iduser=" + identifiant;
                    SqlDataAdapter DA = new SqlDataAdapter(t, connection);
                    DataSet DS = new DataSet();
                    DA.Fill(DS);
                    dataGridView1.DataSource = DS.Tables[0];
                    this.closeconnection();
                }
            }
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            String connectionString;
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Rafik\\source\\repos\\WindowsFormsApp1\\WindowsFormsApp1\\agil.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection cn = new SqlConnection(connectionString);
            SqlCommand cmd = cn.CreateCommand();
            String id = iduser.Text;
            String textdecommand;
            textdecommand = "DELETE FROM utilisateurs WHERE Iduser=" + id;
            cmd.CommandText = textdecommand;
            if (id == "") { MessageBox.Show("veuillez selectionner un utilisateur"); }
            else
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("supprime");
                cn.Close();
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            iduser.Clear();
            nomuser.Clear();
            prenomuser.Clear();
            motdepasse.Clear();
            numcin.Clear();
            non.Checked = true;
            chemin.Text = "";
            image_user.Image = image_user.InitialImage;
        }

        private void iduser_Leave(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(iduser.Text, "[^0-9]"))
            {
                MessageBox.Show("l id peut contenir seulement des chiffres");
                iduser.Focus();
            }
        }

        private void numcin_Leave(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(numcin.Text, "[^0-9]"))
            {
                MessageBox.Show("le numero de CIN peut contenir seulement des chiffres");
                numcin.Focus();
            }
        }
    }
}
