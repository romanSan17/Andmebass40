using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Andmebass40
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\opilane\sourse\repos\Andmebass40\Database.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapter;

        public Form1()
        {
            InitializeComponent();
        }

        public void NaitaAndmed()
        {

                conn.Open();
                DataTable dt = new DataTable();
                cmd = new SqlCommand("SELECT * FROM Toode", conn);
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

        }

        private void LisaBut_Click(object sender, EventArgs e)
        {
            if (Nimetustxt.Text.Trim() != string.Empty && Kogustxt.Text.Trim() != string.Empty && Hindtxt.Text.Trim() != string.Empty)
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("INSERT INTO Products(Nimetus, Kogus, Hind) VALUES (@toode, @kogus, @hind)", conn);
                    cmd.Parameters.AddWithValue("@toode", Nimetustxt.Text);
                    cmd.Parameters.AddWithValue("@kogus", Kogustxt.Text);
                    cmd.Parameters.AddWithValue("@hind", Hindtxt.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    NaitaAndmed(); 
                }
                catch (Exception)
                {
                    MessageBox.Show("An error occurred while inserting the data.");
                }
            }
            else
            {
                MessageBox.Show("All fields must be filled out.");
            }
        }
    }
}
