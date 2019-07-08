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
using System.Drawing.Printing;




namespace WindowsFormsApp1
{
    public partial class facture : Form
    {

        private PrintDocument printDocument1 = new PrintDocument();
        int identifiant = home.identifiant;
        public facture()
        {
            InitializeComponent();
            printButton.Click += new EventHandler(printButton_Click);
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            this.Controls.Add(printButton);
            
        }

        private void facture_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'agilDataSet4.produits'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.produitsTableAdapter.Fill(this.agilDataSet4.produits);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Rafik\\source\\repos\\WindowsFormsApp1\\WindowsFormsApp1\\agil.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            String t = "select * from produits";
            SqlDataAdapter DA = new SqlDataAdapter(t, con);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
            con.Close();
            dataGridView1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool test(String codearticle1)
            {
                bool t = true;
                foreach (DataGridViewRow row1 in dataGridView2.Rows)
                {

                    if (codearticle1 == row1.Cells[0].Value.ToString())
                    {
                        MessageBox.Show("le produit de code " + codearticle1 + " ne peut pas etre ajouté plusieurs foix au meme facture");
                        t = false;
                    }


                }
                return t;
            }
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                String codearticle = row.Cells[0].Value.ToString();
                String designation = row.Cells[1].Value.ToString() + " " + row.Cells[2].Value.ToString() + " " + row.Cells[4].Value.ToString() + " " + row.Cells[5].Value.ToString();
                String qte = "";
                String puht = row.Cells[7].Value.ToString();
                String montantht = "";
                String tva = "19";
                if (test(codearticle))
                {
                    dataGridView2.Rows.Add(codearticle, designation, qte, puht, montantht, tva);

                }
                
            }



            dataGridView1.Visible = false;
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dataGridView2.CurrentCell.ColumnIndex == 2)
            {
                
                String s = dataGridView2.CurrentRow.Cells[0].Value.ToString();    
                String connectionString;
                connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Rafik\\source\\repos\\WindowsFormsApp1\\WindowsFormsApp1\\agil.mdf;Integrated Security=True;Connect Timeout=30";
                SqlConnection cn = new SqlConnection(connectionString);
                SqlCommand cmd = cn.CreateCommand();
                String textdecommand = "select Quantite from produits where Idproduit=" + s;
                cmd.CommandText = textdecommand;
                cn.Open();
                cmd.ExecuteNonQuery();
                SqlDataReader reader= cmd.ExecuteReader();
                int qtbdd = -1; ;
                while (reader.Read())
                {
                     qtbdd = reader.GetInt32(0);
                }
                cn.Close();
                string q = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                float x = 0;
                bool ifsuccess = float.TryParse(q, out x);
                if (x>qtbdd)
                {
                    
                    MessageBox.Show("ce quantite nexiste pas dans le stock");
                    dataGridView2.CurrentRow.Cells[2].Value = qtbdd;
                }
                else
                {
                    float y = 0;
                    bool ifsucess = float.TryParse(dataGridView2.CurrentRow.Cells[3].Value.ToString(), out y);
                    float w = x * y;
                    dataGridView2.CurrentRow.Cells[4].Value = w;
                    dataGridView2.CurrentRow.Cells[6].Value = w / 100 * 19;
                }


            }
            if(dataGridView2.CurrentCell.ColumnIndex == 5)
            {
                bool ifsuccess = float.TryParse(dataGridView2.CurrentRow.Cells[5].Value.ToString(), out float a);
                if(a>=0 && a < 60)
                {
                    bool l = float.TryParse(dataGridView2.CurrentRow.Cells[4].Value.ToString(), out float b);
                    float aa=(b/100*a);
                    dataGridView2.CurrentRow.Cells[6].Value = aa;
                    
                }

            }
                

        }

        private void dataGridView2_Leave(object sender, EventArgs e)
        {
            float sommeht=0;
            float sommetva=0;
            float sommettc=0;
            float mht=0, mtva=0;
            bool l;
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                string r = "";
                r = row.Cells[4].Value.ToString();
                l = float.TryParse(r, out  mht);
                sommeht += mht;
                string r1 = "";
                 if (row.Cells[6].Value != null) { r1 = row.Cells[6].Value.ToString(); }
                l = float.TryParse(r1, out  mtva);
                sommetva += mtva;
            }
            sommettc = sommeht + sommetva;
            textBox7.Text = sommeht.ToString();
            textBox8.Text = sommetva.ToString();
            textBox9.Text = sommettc.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Rafik\\source\\repos\\WindowsFormsApp1\\WindowsFormsApp1\\agil.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection cn = new SqlConnection(connectionString);
            SqlCommand cmd = cn.CreateCommand();
            String textdecommand = "select MAX(Idfacture)+1 from factures";
            cmd.CommandText = textdecommand;
            cn.Open();
            textBox3.Text = cmd.ExecuteScalar().ToString();
            dateTimePicker1.Value = DateTime.Now;
            string nnpp = "";
            textdecommand = "select nom,prenom from utilisateurs where Iduser=" + identifiant;
            cmd.CommandText = textdecommand;
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nnpp += dr.GetValue(0);
                nnpp += " ";
                nnpp += dr.GetValue(1);
            }
            textBox6.Text = nnpp;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            String idf, details = "", ncaiss, nomcl, imm, mdpay;
            DateTime date;
            if (textBox1.Text != "" && textBox3.Text != "" && dateTimePicker1.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "0")
            {
                nomcl = textBox1.Text;
                imm = textBox2.Text;
                idf = textBox3.Text;
                date = DateTime.Today;//1
                mdpay = textBox5.Text;
                ncaiss = textBox6.Text;
                bool tthtb = float.TryParse(textBox7.Text, out float ttht);
                bool tttvab = float.TryParse(textBox8.Text, out float tttva);
                bool ttttcb = float.TryParse(textBox9.Text, out float ttttc);
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    details += row.Cells[0].Value.ToString() + "-" + row.Cells[1].Value.ToString() + "-" + row.Cells[2].Value.ToString() + "\n";
                }
                String connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Rafik\\source\\repos\\WindowsFormsApp1\\WindowsFormsApp1\\agil.mdf;Integrated Security=True;Connect Timeout=30";
                SqlConnection cn = new SqlConnection(connectionString);
                SqlCommand cmd = cn.CreateCommand();
                string textdecommand = "insert into factures values('" + idf + "','" + details + "','" + identifiant + "','" + ncaiss + "','" + nomcl + "','" + imm + "',@date,'" + mdpay + "',@ttht,@tttva,@ttttc)";
                cmd.Parameters.Add("@date", SqlDbType.Date); //2
                cmd.Parameters["@date"].Value = date;
                cmd.Parameters.AddWithValue("@ttht", ttht);
                cmd.Parameters.AddWithValue("@tttva", tttva);
                cmd.Parameters.AddWithValue("@ttttc", ttttc);
                cmd.CommandText = textdecommand;
                cn.Open();
                cmd.ExecuteNonQuery();
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    SqlCommand cmd1 = cn.CreateCommand();
                    int qte = 0, ide = 0;
                    bool v = int.TryParse(row.Cells[2].Value.ToString(), out qte);
                    bool d = int.TryParse(row.Cells[0].Value.ToString(), out ide);
                    textdecommand = "update produits set Quantite-=" + qte + " where Idproduit=" + ide;
                    cmd1.CommandText = textdecommand;
                    cmd1.ExecuteNonQuery();
                }
                cn.Close();

                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                printButton.Visible = true;
            }

        }

        private void printButton_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            dataGridView1.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            printButton.Visible = false;
            CaptureScreen();
            printDocument1.Print();
            textBox3.Clear();
            textBox6.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            dataGridView1.ClearSelection();
            //dataGridView2.Columns.Clear();
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                dataGridView2.Rows.Remove(row);
            }
            button3.Visible = true;
            button4.Visible = true;
            button2.Visible = true;
            button1.Visible = true;
        }
        Bitmap memoryImage;

        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X+10, this.Location.Y+25, 0, 100, s);
        }

        private void printDocument1_PrintPage(System.Object sender,
               System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }
    }
}
