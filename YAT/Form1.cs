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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // testing the adding off the user commands
            macro myobject = new macro();
            flowLayoutPanel1.Controls.Add(myobject);
        }

        private void Form1_Shown(Object sender, EventArgs e)
        {
            //set the correct name and version
            ActiveForm.Text = Application.ProductVersion;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
