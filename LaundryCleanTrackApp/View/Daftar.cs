using System;
using System.Windows.Forms;
using CleanTrackLaundry.Models;
using MySql.Data.MySqlClient;

namespace LaundryCleanTrackApp.View
{
    public partial class Daftar : Form
    {
        public Daftar()
        {
            InitializeComponent();
        }

        private void groupBox_Daftar_Enter(object sender, EventArgs e)
        {

        }

        private void textBox_phone_number_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Berikutnya_Click(object sender, EventArgs e)
        {
            int result = 0;
            string phoneNumber = textBox_phone_number.Text;

            try
            {
                // Untuk membuat Koneksi ke database
                Connection connection = new Connection();
                MySqlConnection _connect = connection.Conn;

                // Query untuk menambahkan data ke db
                string sql = "INSERT INTO users (phone_number) VALUES (@phone_number)";

                // Insert data ke database
                using (MySqlCommand cmd = new MySqlCommand(sql, _connect))
                {
                    cmd.Parameters.AddWithValue("@phone_number", phoneNumber);

                    try
                    {
                        // mengeksuksi data
                        result = cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.Print(ex.StackTrace);
                        System.Diagnostics.Debug.Print(ex.Message);
                    }
                }

                if (result != 0) MessageBox.Show("Data Berhasil Ditambahkan!");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
