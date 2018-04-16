using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DB_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            lv.View = View.Details;
            lv.FullRowSelect = true;
        }

        private void lv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void getDataFromDb()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=test";
                                      

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);

            try
            {
                databaseConnection.Open();

                getTableNames(databaseConnection);
                getDataIntoLv(databaseConnection);

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void getTableNames(MySqlConnection databaseConnection)
        {
            string query = "SELECT table_name FROM information_schema.tables where table_schema = 'test'";
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            MySqlDataReader reader;
            reader = commandDatabase.ExecuteReader();
            comboBox.Items.Clear();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    comboBox.Items.Add(reader.GetString(0));
                }
                comboBox.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Brak tabel w bazie");
            }
            reader.Close();
        }

        private void getDataIntoLv(MySqlConnection databaseConnection)
        {
            string query = "SELECT * FROM users";
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            reader = commandDatabase.ExecuteReader();
            lv.Items.Clear();
            lv.Columns.Add("ID", 25, HorizontalAlignment.Left);
            lv.Columns.Add("First Name", 60, HorizontalAlignment.Left);
            lv.Columns.Add("Last Name", 60, HorizontalAlignment.Left);

            if (reader.HasRows)
            {
                while (reader.Read())
                {            
                    string[] row = { reader.GetInt32(0).ToString(), reader.GetString(1), reader.GetString(2) };
                    var listViewItem = new ListViewItem(row);
                    lv.Items.Add(listViewItem);
                }
            }
            else
            {
                MessageBox.Show("Brak danych");
            }
            reader.Close();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            getDataFromDb();
        }
    }
}
