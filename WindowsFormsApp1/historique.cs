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
    public partial class historique : Form
    {
        
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Rafik\\source\\repos\\WindowsFormsApp1\\WindowsFormsApp1\\agil.mdf;Integrated Security=True;Connect Timeout=30");

        public historique()
        {
            InitializeComponent();
            
        }


        private void historique_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'agilDataSet6.factures'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.facturesTableAdapter.Fill(this.agilDataSet6.factures);
            // TODO: cette ligne de code charge les données dans la table 'agilDataSet5.utilisateurs'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.utilisateursTableAdapter.Fill(this.agilDataSet5.utilisateurs);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedValue!= null)
            {
                String id = (String)listBox1.SelectedValue.ToString();
                con.Open();
                String t = "select * from factures where idcaissier =" + id;
                SqlDataAdapter DA = new SqlDataAdapter(t, con);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];
                con.Close();
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            string d1, d2;
            d1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            d2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            
            con.Open();
            String t = "select * from factures where date>='" + d1+"'and date<=+'"+d2+"'";
            SqlDataAdapter DA = new SqlDataAdapter(t, con);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
            con.Close();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            con.Open();
            String t = "select * from factures";
            SqlDataAdapter DA = new SqlDataAdapter(t, con);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
            con.Close();
        }
    }
}
