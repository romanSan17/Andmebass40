using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using andmebass40.toodeDataSetTableAdapters;

namespace Andmebass40
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\opilane\sourse\repos\Andmebass40\Database.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        private int ID;

        public Form1()
        {
            InitializeComponent();
        }

        public void NaitaAndmed()
        {

            this.ProductsTableAdapter.Fill(this.toodeDataSet.Products);

        }



        

        private void LisaBut_Click(object sender, EventArgs e)
        {
            if (Nimetustxt.Text.Trim() != string.Empty && Kogustxt.Text.Trim() != string.Empty && Hindtxt.Text.Trim() != string.Empty)
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("INSERT INTO Toode(Nimetus,Kogus,Hind) VALUES (@toode,@kogus,@hind)", conn);
                    cmd.Parameters.AddWithValue("@toode", Nimetustxt.Text);
                    cmd.Parameters.AddWithValue("@kogus", Kogustxt.Text);
                    cmd.Parameters.AddWithValue("@hind", Hindtxt.Text);
                    cmd.ExecuteNonQuery();

                    conn.Close();
                    NaitaAndmed();
                }
                catch (Exception)
                {
                    MessageBox.Show("Andmebaasiga viga!");
                }
            }
            else
            {
                MessageBox.Show("Sisesta Andmeid!");
            }
        }

        private void KustutaBtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("DELETE FROM Toode WHERE Nimetus = @Nimetus AND Kogus = @kogus AND Hind = @hind", conn);
            cmd.Parameters.AddWithValue("@Nimetus", Nimetustxt.Text);
            cmd.Parameters.AddWithValue("@kogus", Kogustxt.Text);
            cmd.Parameters.AddWithValue("@hind", Hindtxt.Text);
            cmd.ExecuteNonQuery();

            cmd = new SqlCommand("DBCC CHECKIDENT ('Toode', RESEED, 0)", conn);
            cmd.ExecuteNonQuery();

            conn.Close();
            this.productsTableAdapter.Fill(this.toodeDataSet.Products);
        }

        private void UuendaBtn_Click(object sender, EventArgs e)
        {
            if (Nimetustxt.Text.Trim() != string.Empty && Kogustxt.Text.Trim() != string.Empty && Hindtxt.Text.Trim() != string.Empty)
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("UPDATE Toode SET Nimetus =@toode,Kogus=@kogus,Hind=@hind WHERE Id=@id", conn);
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.Parameters.AddWithValue("@toode", Nimetustxt.Text);
                    cmd.Parameters.AddWithValue("@kogus", Kogustxt.Text);
                    cmd.Parameters.AddWithValue("@hind", Hindtxt.Text);
                    cmd.ExecuteNonQuery();

                    conn.Close();
                    NaitaAndmed();
                    MessageBox.Show("Andmed edukalt uuendatud", "Uuendamie");
                    Nimetustxt.Text = "";
                    Kogustxt.Text = "";
                    Hindtxt.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("Andmebaasiga viga!");
                }
            }
            else
            {
                MessageBox.Show("Sisesta Andmeid!");
            }
        }
        private void dataGridView1_RoadHeaderMouseClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = (int)dataGridView1.Rows[e.RowIndex].Cells[id].Value;
            Nimetustxt.Text = dataGridView1.Rows[e.RowIndex].Cells["Nimetus"].Value.ToString();
            Kogustxt.Text = dataGridView1.Rows[e.RowIndex].Cells["Kogus"].Value.ToString();
            Hindtxt.Text = dataGridView1.Rows[e.RowIndex].Cells["Hind"].Value.ToString();
            try
            {
                pictureBox1.Image = Image.FromFile(Path.Combine(Path.GetFullPath(@"..\..\Pildid"),
                    dataGridView1.Rows[e.RowIndex].Cells["Pilt"].Value.ToString()));
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch (Exception)
            {
                pictureBox1.Image = Image.FromFile(Path.Combine(Path.GetFullPath(@"..\..\Pildid"), "pilt.png"));
            }
        }
    }
}
