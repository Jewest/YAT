using System;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace YAT
{
    partial class macro : IXmlSerializable
    {
        /// <summary> 

        private string m_buttonName = "Send";
        private System.Windows.Forms.CheckBox chkSendCommand = null;        
        private System.Windows.Forms.Button btnSend = null;
        private System.Windows.Forms.TextBox txtCommand = null;

        // Xml Serialization Infrastructure

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteStartElement("Macro");
            writer.WriteAttributeString("command", txtCommand.Text);
            writer.WriteAttributeString("checked", chkSendCommand.Checked.ToString());
            writer.WriteAttributeString("name" , btnSend.Text);
            writer.WriteEndElement();
        }

        public void ReadXml(XmlReader reader)
        {            
            txtCommand.Text = reader.GetAttribute("command");
            chkSendCommand.Checked = Convert.ToBoolean(reader.GetAttribute("checked"));
            m_buttonName = reader.GetAttribute("name");
            // set the name when attached
            if (m_buttonName != null)
            {
                if (m_buttonName.Length > 0)
                {
                    btnSend.Text = m_buttonName;
                }
            }

        }

        public XmlSchema GetSchema()
        {
            return (null);
        }

        public void CloneSettings(macro other)
        {
            this.chkSendCommand.Checked = other.chkSendCommand.Checked;
            this.txtCommand.Text = other.txtCommand.Text;
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

        }

    }
}
