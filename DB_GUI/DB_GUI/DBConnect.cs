using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace DB_GUI
{
    class DBconnect
    {
        private string ip;
        private string port;
        private string username;
        private string password;
        private string datebase;

        private string[] ColumnsName;
        public string[] ColumnsTypes;

        MySqlConnection databaseConnection;
        MySqlCommand commandDatabase;
        MySqlDataReader reader;
        
        public void SetData(string ipBox, string portBox, string userBox, string pwBox, string dbBox){
            try{
                this.ip = ipBox;
                this.port = portBox;
                this.username = userBox;
                this.password = pwBox;
                this.datebase = dbBox;

                string connectionString = "datasource=" + this.ip + ";port=" + this.port + ";username=" + this.username +
                                          ";password=" + this.password + ";database=" + this.datebase + ";"
                                          ;
                this.databaseConnection = new MySqlConnection(connectionString);
            }
            catch(Exception ex){
                MessageBox.Show(ex.ToString());
            }
        }

        public List<string> GetColumnsName(string selectedTable){
            List<string> list = new List<string>();
            List<string> listOfTypes = new List<string>();
            string query = "SELECT COLUMN_NAME, DATA_TYPE FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = '" + datebase + "' AND TABLE_NAME = '" + selectedTable + "';";
            this.commandDatabase = new MySqlCommand(query, this.databaseConnection){
                CommandTimeout = 60
            };
            this.reader = commandDatabase.ExecuteReader();

            if (this.reader.HasRows){
                while (this.reader.Read()){
                    list.Add(this.reader.GetString(0));
                    listOfTypes.Add(this.reader.GetString(1));
                }
            }
            else{
                MessageBox.Show("Brak kolumn w danej tabeli");
            }

            this.reader.Close();
            this.ColumnsName = list.ToArray();
            ColumnsTypes = listOfTypes.ToArray();
            return list;
        }

        public List<string> GetTables(){
            List<string> list = new List<string>();
            string query = "SELECT table_name FROM information_schema.tables where table_schema = '" + this.datebase + "'";
            commandDatabase = new MySqlCommand(query, databaseConnection);
            this.commandDatabase.CommandTimeout = 60;
            this.reader = commandDatabase.ExecuteReader();

            if (this.reader.HasRows){
                while (this.reader.Read()){
                    list.Add(this.reader.GetString(0));
                }
            }
            else{
                MessageBox.Show("Brak tabel w danej bazie");
            }
            this.reader.Close();
            return list;
        }

        public List<string[]> GetData(string selectedTable){
            List<string[]> list = new List<string[]>();

            string query = "SELECT * FROM " + selectedTable;
            MySqlCommand mySqlCommand = new MySqlCommand(query, this.databaseConnection);
            commandDatabase = mySqlCommand;
            this.commandDatabase.CommandTimeout = 60;
            this.reader = commandDatabase.ExecuteReader();

            if (this.reader.HasRows){
                while (this.reader.Read()){
                    string[] row = new string[this.ColumnsTypes.Length];
                    for (int i = 0; i < this.ColumnsTypes.Length; i++){
                        switch (this.ColumnsTypes[i]){
                            case "int":
                                row[i] = reader.GetInt32(i).ToString();
                                break;
                            case "varchar":
                                row[i] = reader.GetString(i);
                                break;
                            case "boolean":
                                row[i] = reader.GetBoolean(i).ToString();
                                break;
                        }
                    }
                    list.Add(row);
                }
            }
            else{
                MessageBox.Show("Brak danych w tabeli");
            }
            this.reader.Close();
            return list;

        }

        public void DoQuery(string query){
            using (MySqlCommand commandDatabase = new MySqlCommand(query, this.databaseConnection)){
                commandDatabase.ExecuteNonQuery();
            }
        }

        public void Open(){
            try{

                this.databaseConnection.Open();
            }
            catch(Exception ex){
                MessageBox.Show(ex.ToString());
            }
        }

        public void Close() => this.databaseConnection.Close();
    }
}
