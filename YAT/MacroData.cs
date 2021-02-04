using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using YAT.View;

namespace YAT
{
    class MacroData : IXmlSerializable
    {
        private string m_buttonName = "Send";
        private string m_command = "";
        private bool m_valueChecked = false;
        private bool m_updatingControl = false;

        private System.Windows.Forms.CheckBox chkSendCommand = null;
        private System.Windows.Forms.Button btnSend = null;
        private System.Windows.Forms.TextBox txtCommand = null;

        // Xml Serialization Infrastructure

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteStartElement("Macro");
            writer.WriteAttributeString("command", m_command);
            writer.WriteAttributeString("checked", m_valueChecked.ToString());
            writer.WriteAttributeString("name", m_buttonName);
            writer.WriteEndElement();
        }

        public void ReadXml(XmlReader reader)
        {
            m_command = reader.GetAttribute("command");
            m_valueChecked = Convert.ToBoolean(reader.GetAttribute("checked"));
            m_buttonName = reader.GetAttribute("name");
        }

        public XmlSchema GetSchema()
        {
            return (null);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            //send the data now
            Program.g_mainView.SendCommand(m_command);
        }

        private void chkSendCommand_CheckedChanged(object sender, EventArgs e)
        {
            if (m_updatingControl == false)
            {
                if(sender is CheckBox)
                {
                    if (m_valueChecked != ((CheckBox)sender).Checked)
                    {
                        m_valueChecked = ((CheckBox)sender).Checked;
                        Datachanged?.Invoke(this, e);
                    }
                }
            }
        }

        public void SendIfChecked()
        {
            if ((m_valueChecked == true) && (btnSend is not null))
            {
                btnSend.PerformClick();
            }
        }

        public void SetChecked(bool checkedValue)
        {
            m_valueChecked = checkedValue;
            UpdateControls();
        }

        // declaring an event using built-in EventHandler
        public event EventHandler InsertBeforeMe;
        public event EventHandler Datachanged;
        public event EventHandler RemoveMe;

        private void txtCommand_TextChanged(object sender, EventArgs e)
        {
            if (m_updatingControl == false)
            {
                if (sender is TextBox)
                {
                    if (((TextBox)(sender)).Text != m_command)
                    {
                        m_command = ((TextBox)(sender)).Text;
                        Datachanged?.Invoke(this, e);
                    }
                }
                
            }
        }

        private void txtCommand_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                if (btnSend is not null)
                {
                    btnSend.PerformClick();
                }
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
                if (m_buttonName != newName)
                {
                    m_buttonName = newName;
                    //raise change
                    Datachanged?.Invoke(this, e);

                    UpdateControls();
                }
            }
            else
            {
                if (m_buttonName != "Send")
                {
                    m_buttonName = "Send";
                    //raise change
                    Datachanged?.Invoke(this, e);

                    UpdateControls();
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

        public void CloneSettings(MacroData other)
        {
            this.m_command = other.m_command;
            this.m_valueChecked = other.m_valueChecked;
            UpdateControls();
        }

        public void AttachTo(Button sendButton, CheckBox chkBox, TextBox textBox)
        {
            this.btnSend = sendButton;
            this.btnSend.Text = m_buttonName;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            this.btnSend.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSend_MouseDown);

            this.chkSendCommand = chkBox;
            this.chkSendCommand.CheckedChanged += new System.EventHandler(this.chkSendCommand_CheckedChanged);
            this.chkSendCommand.MouseDown += new System.Windows.Forms.MouseEventHandler(this.chkSendCommand_MouseDown);

            this.txtCommand = textBox;
            this.txtCommand.TextChanged += new System.EventHandler(this.txtCommand_TextChanged);
            this.txtCommand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCommand_KeyDown);
            this.txtCommand.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtCommand_MouseDown);

            UpdateControls();
        }

        private void UpdateControls()
        {
            m_updatingControl = true;


            if (this.btnSend is not null)
            {
                this.btnSend.Text = m_buttonName;
            }

            if (this.chkSendCommand is not null)
            {
                this.chkSendCommand.Checked = m_valueChecked;
            }
            if (this.txtCommand is not null)
            {
                this.txtCommand.Text = m_command;
            }

            m_updatingControl = false;
        }

    }
}
