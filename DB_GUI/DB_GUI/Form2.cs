using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_GUI
{
    public partial class Form2 : Form
    {
        private string typeOfValue;
        public string tempValue;

        public Form2(string typeOfForm)
        {
            InitializeComponent();

            if (typeOfForm == "addMode")
            {
                label1.Text = "Dodawanie obiektów do tabeli ";
            }

        }     

        public void Set(string typeOfValue, string defaultValue)
        {
            this.typeOfValue = typeOfValue;
            textBox1.Text = defaultValue;
            tempValue = "";
        }

        private void conf()
        {
            tempValue = textBox1.Text;
            this.Hide();
        }

        private void valueTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
            {
                conf();
            }
        }

        private void confButton_Click(object sender, EventArgs e)
        {
            conf();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            throw new Exception("Anulowanio");
        }
    }
}