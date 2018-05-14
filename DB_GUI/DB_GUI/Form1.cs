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
using System.Collections;

namespace DB_GUI
{
    public partial class Form1 : Form{

        DBconnect linker = new DBconnect();
        private int sortColumn = -1;

        public Form1(){
            InitializeComponent();
        
            ipTB.Text = "127.0.0.1";
            portTB.Text = "3306";
            usernameTB.Text = "root";
            dbTB.Text = "db_project";

            dropdownList.DropDownStyle = ComboBoxStyle.DropDownList;
            lv.View = View.Details;
            lv.FullRowSelect = true;
            pwTB.UseSystemPasswordChar = true;

            addButton.Enabled = false;
            delButton.Enabled = false;
            editButton.Enabled = false;
            sortButton.Enabled = false;

        }

        private void Lv_SelectedIndexChanged(object sender, EventArgs e){
            if (lv.SelectedItems.Count == 0){
                delButton.Enabled = false;
                editButton.Enabled = false;
            }
            else if (lv.SelectedItems.Count == 1){
                delButton.Enabled = true;
                editButton.Enabled = true;
            }
            else{
                delButton.Enabled = true;
                editButton.Enabled = false;
            }
        }

        private void GetDataFromDb(){
            linker.SetData(ipTB.Text, portTB.Text, usernameTB.Text, pwTB.Text, dbTB.Text);
            dropdownList.Items.Clear();

            try{
                linker.Open();
                dropdownList.Items.AddRange(linker.GetTables().ToArray());
                linker.Close();

                if (dropdownList.Items.Count > 0){
                    dropdownList.SelectedIndex = 0;
                    addButton.Enabled = true;
                }
            }
            catch (Exception ex){
                MessageBox.Show(ex.ToString());
            }
        }

        private void GetDataIntoLV(){
            lv.Columns.Clear();
            lv.Items.Clear();

            foreach (string listItem in linker.GetColumnNames(dropdownList.SelectedItem.ToString())){     
                lv.Columns.Add(listItem, -2, HorizontalAlignment.Left);
            }
            foreach (string[] item in linker.GetData(dropdownList.SelectedItem.ToString())){
                lv.Items.Add(new ListViewItem(item));
            }

            lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        } 

        private void add(){
            try{
                Form2 f2 = new Form2("dodawanie");
                string query = "INSERT INTO `" + dropdownList.SelectedItem.ToString() + "` VALUES(";
                for (int i = 0; i < linker.ColumnTypes.Length; i++){
                    f2.Set(type: linker.ColumnTypes[i], defaultValue: "");
                    f2.ShowDialog();
                    query += "'" + f2.temp + "',";
                }
                query = query.Remove(query.Length - 1);
                query += ")";
                linker.Open();
                linker.DoQuery(query);
                GetDataIntoLV();
            }
            catch (Exception ex){
                MessageBox.Show(ex.ToString());
            }
            finally{
                linker.Close();
            }
        }

        private void edit(){
            try{
                Form2 f2 = new Form2("edytowanie");
                f2.StartPosition = FormStartPosition.CenterParent;
                string query = "UPDATE `" + dropdownList.SelectedItem.ToString() + "` SET";
                for (int i = 0; i < linker.ColumnTypes.Length; i++)
                {
                    f2.Set(linker.ColumnTypes[i], lv.SelectedItems[0].SubItems[i].Text);
                    f2.ShowDialog();
                    query += " `" + lv.Columns[i].Text + "`='" + f2.temp + "',";
                }
                f2.Close();
                query = query.Remove(query.Length - 1);
                query += " WHERE " + lv.Columns[0].Text + "='" + lv.SelectedItems[0].SubItems[0].Text + "'";
                linker.Open();
                linker.DoQuery(query);
                GetDataIntoLV();
            }
            catch (Exception ex){
                MessageBox.Show(ex.ToString());
            }
            finally{
                linker.Close();
            }
        }

        private void delete(){
            try{
                linker.Open();
                string query;
                foreach (ListViewItem row in lv.SelectedItems){
                    query = "DELETE FROM " + dropdownList.SelectedItem.ToString() +
                                   " WHERE " + lv.Columns[0].Text + "=" + row.SubItems[0].Text;
                    linker.DoQuery(query);
                }
                GetDataIntoLV();
            }
            catch (Exception ex){
                MessageBox.Show(ex.ToString());
            }
            finally{
                linker.Close();
            }
        }

        private void ConnectButton_Click(object sender, EventArgs e) => GetDataFromDb();

        private void IpTB_Enter(object sender, EventArgs e){
            if (ipTB.Text == "IP Address"){
                ipTB.Text = "";
                ipTB.ForeColor = Color.Black;
            }
        }

        private void IpTB_Leave(object sender, EventArgs e){
            if (ipTB.Text == ""){
                ipTB.Text = "IP Address";
                ipTB.ForeColor = Color.Gray;
            }
        }

        private void PortTB_Enter(object sender, EventArgs e){
            if (portTB.Text == "Port number"){
                portTB.Text = "";
                portTB.ForeColor = Color.Black;
            }
        }

        private void PortTB_Leave(object sender, EventArgs e){
            if (portTB.Text == ""){
                portTB.Text = "Port number";
                portTB.ForeColor = Color.Gray;
            }
        }

        private void UsernameTB_Enter(object sender, EventArgs e){
            if (usernameTB.Text == "Username"){
                usernameTB.Text = "";
                usernameTB.ForeColor = Color.Black;
            }
        }

        private void UsernameTB_Leave(object sender, EventArgs e){
            if (usernameTB.Text == ""){
                usernameTB.Text = "Username";
                usernameTB.ForeColor = Color.Gray;
            }
        }

        private void PwTB_Enter(object sender, EventArgs e){
            if (pwTB.Text == "password"){
                pwTB.Text = "";
                pwTB.ForeColor = Color.Black;
            }
        }

        private void PwTB_Leave(object sender, EventArgs e)
        {    
        }

        private void Form1_Load(object sender, EventArgs e) => pwTB.Text = "password";

        private void DbTB_Enter(object sender, EventArgs e){
            if (dbTB.Text == "DB Name"){
                dbTB.Text = "";
                dbTB.ForeColor = Color.Black;
            }
        }

        private void DbTB_Leave(object sender, EventArgs e){
            if (dbTB.Text == ""){
                dbTB.Text = "DB Name";
                dbTB.ForeColor = Color.Gray;
            }
        }

        private void dropdownList_SelectedIndexChanged(object sender, EventArgs e){
            linker.Open();
            GetDataIntoLV();
            linker.Close();
        }

        private void ipTB_TextChanged(object sender, EventArgs e)
        { 
        }

        private void delButton_Click(object sender, EventArgs e) => delete();
        private void addButton_Click(object sender, EventArgs e) => add();
        private void editButton_Click(object sender, EventArgs e) => edit();

        private void lv_ColumnClick(object sender, ColumnClickEventArgs aktualna){
            if (aktualna.Column != sortColumn){

                sortColumn = aktualna.Column;
                lv.Sorting = SortOrder.Ascending;
            }
            else{

                if (lv.Sorting == SortOrder.Ascending)
                    lv.Sorting = SortOrder.Descending;
                else
                    lv.Sorting = SortOrder.Ascending;
            }
            this.lv.ListViewItemSorter = new LvItemComparer(aktualna.Column, lv.Sorting);
        }

        public class LvItemComparer : IComparer {

            private int kolumna;
            private SortOrder porzadek;

            public LvItemComparer(){

                kolumna = 0;
                porzadek = SortOrder.Ascending; // rosnaco

            }

            public LvItemComparer(int kolumna, SortOrder porzadek){
                LvItemComparer lvItemComparer = this;
                lvItemComparer.kolumna = kolumna;
                lvItemComparer.porzadek = porzadek;
                }

            public int Compare( object a, object b){

                int returnValue = -1;
                returnValue = string.Compare(((ListViewItem)a).SubItems[kolumna].Text, ((ListViewItem)b).SubItems[kolumna].Text);

                if (porzadek == SortOrder.Descending)
                {
                    returnValue *= -1;
                }

                return returnValue;
            }
        }
    }
}
