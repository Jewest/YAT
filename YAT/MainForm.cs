using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YAT
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            // testing the adding off the user commands
            macro myobject = new macro();
            myobject.Width = flowLayoutPanel1.Width - 25;
            flowLayoutPanel1.Controls.Add(myobject);
        }

        private void Form1_Shown(Object sender, EventArgs e)
        {
            //set the correct name and version
            this.Text = Application.ProductName  + " " +   Application.ProductVersion;
        }

    }
}
