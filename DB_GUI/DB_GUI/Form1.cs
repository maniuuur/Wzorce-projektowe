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
        DBconnect linker = new DBconnect();

        public Form1()
        {
            InitializeComponent();
        
            ipTB.Text = "127.0.0.1";
            portTB.Text = "3306";
            usernameTB.Text = "root";
            dbTB.Text = "test";

            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            lv.View = View.Details;
            lv.FullRowSelect = true;
            pwTB.UseSystemPasswordChar = true;

            addButton.Enabled = false;
            delButton.Enabled = false;
            editButton.Enabled = false;
            sortButton.Enabled = false;
        }

        private void lv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv.SelectedItems.Count == 0)
            {
                delButton.Enabled = false;
                editButton.Enabled = false;
            }
            else if (lv.SelectedItems.Count == 1)
            {
                delButton.Enabled = true;
                editButton.Enabled = true;
            }
            else
            {
                delButton.Enabled = true;
                editButton.Enabled = false;
            }
        }

        private void getDataFromDb()
        {
            linker.setData(ipTB.Text, portTB.Text, usernameTB.Text, pwTB.Text, dbTB.Text);

            comboBox.Items.Clear();

            try
            {
                linker.Open();
                comboBox.Items.AddRange(linker.getTableNames().ToArray());
                linker.Close();

                if (comboBox.Items.Count > 0)
                    comboBox.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void getDataIntoLV()
        {
            lv.Columns.Clear();
            lv.Items.Clear();

            foreach (string listItem in linker.getColumnsName(comboBox.SelectedItem.ToString()))
            {     
                lv.Columns.Add(listItem, -2, HorizontalAlignment.Left);
            }
            foreach (string[] item in linker.getData(comboBox.SelectedItem.ToString()))
            {
                lv.Items.Add(new ListViewItem(item));
            }

            lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        private void add()
        {
            //lv.Columns.Count.ToString();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            getDataFromDb();
        }

        private void comboBox_SelectedIndexChange(object sender, EventArgs e)
        {
            linker.Open();
            getDataIntoLV();
            linker.Close();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            getDataFromDb();
        }

        private void ipTB_Enter(object sender, EventArgs e)
        {
            if (ipTB.Text == "IP Address")
            {
                ipTB.Text = "";
                ipTB.ForeColor = Color.Black;
            }
        }

        private void ipTB_Leave(object sender, EventArgs e)
        {
            if (ipTB.Text == "")
            {
                ipTB.Text = "IP Address";
                ipTB.ForeColor = Color.Gray;
            }
        }

        private void portTB_Enter(object sender, EventArgs e)
        {
            if (portTB.Text == "Port number")
            {
                portTB.Text = "";
                portTB.ForeColor = Color.Black;
            }
        }

        private void portTB_Leave(object sender, EventArgs e)
        {
            if (portTB.Text == "")
            {
                portTB.Text = "Port number";
                portTB.ForeColor = Color.Gray;
            }
        }

        private void usernameTB_Enter(object sender, EventArgs e)
        {
            if (usernameTB.Text == "Username")
            {
                usernameTB.Text = "";
                usernameTB.ForeColor = Color.Black;
            }
        }

        private void usernameTB_Leave(object sender, EventArgs e)
        {
            if (usernameTB.Text == "")
            {
                usernameTB.Text = "Username";
                usernameTB.ForeColor = Color.Gray;
            }
        }

        private void pwTB_Enter(object sender, EventArgs e)
        {
            if (pwTB.Text == "password")
            {
                pwTB.Text = "";
                pwTB.ForeColor = Color.Black;
            }
        }

        private void pwTB_Leave(object sender, EventArgs e)
        {    
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pwTB.Text = "password";
        }

        private void dbTB_Enter(object sender, EventArgs e)
        {
            if (dbTB.Text == "DB Name")
            {
                dbTB.Text = "";
                dbTB.ForeColor = Color.Black;
            }
        }

        private void dbTB_Leave(object sender, EventArgs e)
        {
            if (dbTB.Text == "")
            {
                dbTB.Text = "DB Name";
                dbTB.ForeColor = Color.Gray;
            }
        }
    }
}
