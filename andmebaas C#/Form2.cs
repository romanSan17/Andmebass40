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
using System.IO;

namespace andmebaas_C_
{
    public partial class Form2 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=AndmebaasSQL;Integrated Security=True;Encrypt=False;");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        private string selectedNimetus;

        public Form2()
        {
            InitializeComponent();
            NaitaAndmed();
            dataGridView1.CellClick += dataGridView1_Click;
        }

        public void NaitaAndmed()
        {
            try
            {
                conn.Open();
                DataTable dt = new DataTable();
                cmd = new SqlCommand("SELECT * FROM Products", conn);
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при получении данных: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void Lisa_Click(object sender, EventArgs e)
        {
            if (Nimetus.Text.Trim() != string.Empty && Kogus.Text.Trim() != string.Empty && Hind.Text.Trim() != string.Empty)
            {
                try
                {
                    using (OpenFileDialog openFileDialog = new OpenFileDialog())
                    {
                        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            // Чтение изображения в массив байтов
                            byte[] imageBytes = File.ReadAllBytes(openFileDialog.FileName);

                            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=AndmebaasSQL;Integrated Security=True;Encrypt=False;"))
                            {
                                conn.Open();

                                      using (SqlCommand cmd = new SqlCommand("INSERT INTO Products (Nimetus, Kogus, Hind, PictureBox) VALUES (@Nimetus, @Kogus, @Hind, @PictureBox)", conn))
                                {
                                    cmd.Parameters.AddWithValue("@Nimetus", Nimetus.Text);
                                    cmd.Parameters.AddWithValue("@Kogus", int.Parse(Kogus.Text));
                                    cmd.Parameters.AddWithValue("@Hind", decimal.Parse(Hind.Text));
                                    cmd.Parameters.AddWithValue("@PictureBox", imageBytes); 

                                    cmd.ExecuteNonQuery();
                                }
                            }

                            NaitaAndmed(); 
                        }
                    }
                }
                catch (Exception ex)
                   {
                    MessageBox.Show("Viga" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены.");
            }
        }
        private void dataGridView1_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                selectedNimetus = selectedRow.Cells["Nimetus"].Value.ToString(); 
                Nimetus.Text = selectedRow.Cells["Nimetus"].Value.ToString();
                Kogus.Text = selectedRow.Cells["Kogus"].Value.ToString();
                Hind.Text = selectedRow.Cells["Hind"].Value.ToString();
                
                // Отображаем изображение в PictureBox
                if (selectedRow.Cells["PictureBox"].Value != DBNull.Value)
                {
                    byte[] imageBytes = (byte[])selectedRow.Cells["PictureBox"].Value;
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pictureBox1.Image = null;
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void uuendaBTN_Click_1(object sender, EventArgs e)
        {
            if (Nimetus.Text.Trim() != string.Empty && Kogus.Text.Trim() != string.Empty && Hind.Text.Trim() != string.Empty)
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("UPDATE Products SET Nimetus = @toode, Kogus = @kogus, Hind = @hind WHERE Nimetus = @Nimetus", conn);
                    cmd.Parameters.AddWithValue("@toode", Nimetus.Text); 
                    cmd.Parameters.AddWithValue("@kogus", int.Parse(Kogus.Text));
                    cmd.Parameters.AddWithValue("@hind", decimal.Parse(Hind.Text)); 
                    cmd.Parameters.AddWithValue("@Nimetus", selectedNimetus);

                    cmd.ExecuteNonQuery();

                    conn.Close();
                    NaitaAndmed();
                    MessageBox.Show("Данные успешно обновлены!", "Обновление");
                    Nimetus.Text = "";
                    Kogus.Text = "";
                    Hind.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при работе с базой данных: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, заполните все поля!");
            }
        }


     
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void kustuta_Click_1(object sender, EventArgs e)
        {  
            try
            {

                int ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                if (ID != 0)
                {
                    conn.Open();
                    cmd = new SqlCommand("DELETE FROM Products WHERE Id=@id", conn);
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    if (dataGridView1.SelectedRows[0].Cells["PictureBox"].Value != DBNull.Value)
                    {
                        byte[] imageBytes = (byte[])dataGridView1.SelectedRows[0].Cells["PictureBox"].Value;
                        string imagePath = Path.Combine(@"C:\Path\To\ImageDirectory", $"{ID}.jpg");
                        if (File.Exists(imagePath))
                        {
                            File.Delete(imagePath);
                        }
                    }

                    NaitaAndmed();

                    MessageBox.Show("Запись успешно удалена");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении записи: {ex.Message}");
            }
        }
    }
}
