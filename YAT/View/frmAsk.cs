using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YAT.View
{
    public partial class frmAsk : Form
    {
        string m_result;
        public frmAsk()
        {
            InitializeComponent();
        }

        public string GetResult()
        {
            return m_result;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            m_result = "";
            this.Hide();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(txtNewName.Text.Count() > 0)
            {
                m_result = txtNewName.Text;
                this.Hide();
            }
            else
            {
                //show message box
                MessageBox.Show(this, "Input is empty");

            }
        }
    }
}
