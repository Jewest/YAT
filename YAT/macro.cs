using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YAT.View;

namespace YAT
{
    public partial class macro
    {
        public macro()
        {
            
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            //send the data now
            Program.g_mainView.SendCommand(txtCommand.Text);
        }

        private void chkSendCommand_CheckedChanged(object sender, EventArgs e)
        {
            Datachanged?.Invoke(this, e);
        }

        public void SendIfChecked()
        {
            if(chkSendCommand.Checked == true)
            {
                btnSend.PerformClick();
            }
        }

        public void SetChecked(bool checkedValue)
        {
            chkSendCommand.Checked = checkedValue;
        }

        // declaring an event using built-in EventHandler
        public event EventHandler InsertBeforeMe;
        public event EventHandler Datachanged;
        public event EventHandler RemoveMe;

        private void txtCommand_TextChanged(object sender, EventArgs e)
        {
            Datachanged?.Invoke(this, e);
        }

        private void txtCommand_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                btnSend.PerformClick();
            }
        }


        void HandleRightMouseCLick(Control theControl, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu cm = new ContextMenu();

                if (theControl is Button)
                {
                    MenuItem item2 = cm.MenuItems.Add("Rename");
                    item2.Click += Item_Rename;
                }
                
                MenuItem item3 = cm.MenuItems.Add("Insert Before");
                item3.Click += Item_InsertBefore;

                MenuItem item = cm.MenuItems.Add("Remove");
                item.Click += Item_Click;

                cm.Show(theControl, e.Location);                
            }
        }

        private void Item_Click(object sender, EventArgs e)
        {
            // remove this element
            RemoveMe?.Invoke(this, e);
        }


        private void Item_Rename(object sender, EventArgs e)
        {
            // insert the rename 
            AskController getNewName = new AskController(Program.g_mainView);
            //get the new name
            string newName = getNewName.GetNewName(m_buttonName);

            //check the length
            if (newName.Length > 0)
            {
                if (btnSend.Text != newName)
                {
                    btnSend.Text = newName;
                    //raise change
                    Datachanged?.Invoke(this, e);
                }
            }
            else
            {
                if (btnSend.Text != "Send")
                {
                    btnSend.Text = "Send";
                    //raise change
                    Datachanged?.Invoke(this, e);
                }
            }
        }

        private void Item_InsertBefore(object sender, EventArgs e)
        {
            // remove this element
            InsertBeforeMe?.Invoke(this, e);
        }

        private void chkSendCommand_MouseDown(object sender, MouseEventArgs e)
        {
            HandleRightMouseCLick(chkSendCommand, e);
        }

        private void btnSend_MouseDown(object sender, MouseEventArgs e)
        {
            HandleRightMouseCLick(btnSend, e);
        }

        private void txtCommand_MouseDown(object sender, MouseEventArgs e)
        {
            HandleRightMouseCLick(txtCommand, e);
        }

        private void tableLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
           // HandleRightMouseCLick(tableLayoutPanel1, e);
        }
         
    }
}
