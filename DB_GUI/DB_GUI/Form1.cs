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

            listView1.View = View.Details;
            listView1.FullRowSelect = true;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void getDataFromDb()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=test";
                                      

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);

            try
            {
                databaseConnection.Open();

                getDataIntoLv(databaseConnection);

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void getDataIntoLv(MySqlConnection databaseConnection)
        {
            string query = "SELECT * FROM users";
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            reader = commandDatabase.ExecuteReader();
            listView1.Items.Clear();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string[] row = { reader.GetInt32(0).ToString(), reader.GetString(1), reader.GetString(2) };
                    var listViewItem = new ListViewItem(row);
                    listView1.Items.Add(listViewItem);
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
