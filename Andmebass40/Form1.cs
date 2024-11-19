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

namespace Andmebass40
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=HP-CZC2349HTG;Initial Catalog=Toode;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        private int ID;

        public Form1()
        {
            InitializeComponent();
            NaitaAndmed();
        }

        public void NaitaAndmed()
        {

            conn.Open();
            DataTable dt = new DataTable();
            cmd = new SqlCommand("SELECT * FROM Products", conn);
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
                    cmd = new SqlCommand("INSERT INTO Products(Nimetus,Kogu,Hind) VALUES (@nimetus,@kogus,@hind)", conn);
                    cmd.Parameters.AddWithValue("@nimetus", Nimetustxt.Text);
                    cmd.Parameters.AddWithValue("@kogus", Kogustxt.Text);
                    cmd.Parameters.AddWithValue("@hind", Hindtxt.Text);
                    cmd.ExecuteNonQuery();

                    conn.Close();
                    NaitaAndmed();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Andmebaasiga viga!" + ex.Message);
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
            //this.productsTableAdapter.Fill(this.toodeDataSet.Products);
        }

        private void UuendaBtn_Click(object sender, EventArgs e)
        {
            if (Nimetustxt.Text.Trim() != string.Empty && Kogustxt.Text.Trim() != string.Empty && Hindtxt.Text.Trim() != string.Empty && ID > 0)
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("UPDATE Products SET Nimetus=@nimetus,Kogu=@kogus,Hind=@hind WHERE Id=@id", conn);
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.Parameters.AddWithValue("@nimetus", Nimetustxt.Text);
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
                catch (Exception ex)
                {
                    MessageBox.Show("Andmebaasiga viga!"+ ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Sisesta Andmeid!");
            }
        }
        private void dataGridView1_RoadHeaderMouseClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells["Id"] != null)
            {
                ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
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

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'toodeDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.toodeDataSet.Products);

        }
        //private void Kustuta_fail(string file)
        //{
        //    try
        //    {
        //        string filePath = Path.Combine(Path.GetFullPath(@"..\..\Pildid"), file); //+extension);
        //        MessageBox.Show($"Püüan kustutada faili: {filePath}");
        //        if (File.Exists(filePath))
        //        {
        //            File.Delete(filePath);
        //            MessageBox.Show("Fail on kustutatud");
        //        }
        //        else
        //        {
        //            MessageBox.Show("Fail ei leitud");
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("Failiga probleemid");
        //    }
        //}
    }
}
