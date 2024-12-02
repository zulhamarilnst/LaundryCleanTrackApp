using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace CleanTrackLaundry.Models
{
    public class Connection : IDisposable
    {
        private readonly string host = "localhost";
        private readonly string username = "root";
        private readonly string password = "";
        private readonly string port = "3306";
        private readonly string databaseName = "dblaundrycleantrack";

        private MySqlConnection _conn;

        public MySqlConnection Conn
        {
            get
            {
                return _conn ?? (_conn = OpenConncetionMysql());
            }
        }

        private MySqlConnection OpenConncetionMysql()
        {
            string connectToMysql = $"server={this.host};database={this.databaseName};uid={this.username};pwd={this.password};port={this.port}";
            MySqlConnection connect = new MySqlConnection(connectToMysql);

            try
            {
                connect.Open();
                Console.WriteLine("Database Terkoneksi!");
            }
            catch (Exception errors)
            {
                System.Diagnostics.Debug.WriteLine(errors);
            }

            return connect;
        }

        public void Dispose()
        {
            if (_conn != null)
            {
                try
                {
                    if (_conn.State != ConnectionState.Closed) _conn.Close();
                }
                finally
                {
                    _conn.Dispose();
                }
            }

            GC.SuppressFinalize(this);
        }
    }
}
