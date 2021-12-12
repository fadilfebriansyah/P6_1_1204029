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


namespace P6_1_1204029
{

    public partial class Form1 : Form
    {
        private void UpdateDB(string cmd)
        {
            try
            {
                //string connectionString = "Data Source = DESKTOP - N3JOE60\FADILDB; Initial Catalog = P6_1204029; Integrated Security = True";
                //SqlConnection myConnection = new SqlConnection(connectionString);

                SqlConnection myConnection = new SqlConnection(@"Data Source=DESKTOP-N3JOE60\FADILDB;Initial Catalog=P6_1204029;Integrated Security=True");
                myConnection.Open();

                SqlCommand MyCommand  = new SqlCommand ();
                MyCommand.Connection = myConnection;
                MyCommand.CommandText = cmd;
                MyCommand.ExecuteNonQuery();
                MessageBox.Show("Database has been Updated", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string cmd = "insert into msprodi values('" 
                + txtIdProdi.Text + "','" 
                + txtNamaProdi.Text + "','" 
                + txtSingkatan.Text + "','" 
                + txtKaProdi.Text + "','" 
                + txtSekProdi.Text + "')";
            UpdateDB(cmd);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtIdProdi.Text = "";
            txtKaProdi.Text = "";
            txtNamaProdi.Text = "";
            txtSekProdi.Text = "";
            txtSingkatan.Text = "";
        }
    }
}
