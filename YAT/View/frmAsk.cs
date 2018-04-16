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

        public void SetDescriptionText(string description)
        {
            //set the text
            lblQuestion.Text = description;
        }

        public void SetText(string textBox)
        {
            //copy the text
            txtNewName.Text = textBox;
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            m_result = "";
            this.Hide();
        }

        private void ProcessInsertedValue()
        {
            if (txtNewName.Text.Count() > 0)
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

        private void btnOk_Click(object sender, EventArgs e)
        {
            ProcessInsertedValue();
        }

        private void frmAsk_Shown(object sender, EventArgs e)
        {
            //select all the text
            txtNewName.SelectAll();
            txtNewName.Focus();
         }

        private void txtNewName_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                //check if its correct and close
                ProcessInsertedValue();
            }
        }

        private void txtNewName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
