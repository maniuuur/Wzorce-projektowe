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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ListViewItem lvi = new ListViewItem();
            lvi.SubItems.Add("s");
            lvi.SubItems.Add("");
            lvi.SubItems.Add("dasd");

            listView1.Items.Add(lvi);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
