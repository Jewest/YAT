using System;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace YAT
{
    partial class macro : IXmlSerializable
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chkSendCommand = new System.Windows.Forms.CheckBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.chkSendCommand, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSend, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtCommand, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(288, 25);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // chkSendCommand
            // 
            this.chkSendCommand.AutoSize = true;
            this.chkSendCommand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkSendCommand.Location = new System.Drawing.Point(271, 3);
            this.chkSendCommand.Name = "chkSendCommand";
            this.chkSendCommand.Size = new System.Drawing.Size(14, 19);
            this.chkSendCommand.TabIndex = 8;
            this.chkSendCommand.UseVisualStyleBackColor = true;
            this.chkSendCommand.CheckedChanged += new System.EventHandler(this.chkSendCommand_CheckedChanged);
            // 
            // btnSend
            // 
            this.btnSend.AutoSize = true;
            this.btnSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSend.Location = new System.Drawing.Point(206, 0);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnSend.Name = "btnSend";
            this.btnSend.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnSend.Size = new System.Drawing.Size(59, 25);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtCommand
            // 
            this.txtCommand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCommand.Location = new System.Drawing.Point(3, 3);
            this.txtCommand.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(200, 20);
            this.txtCommand.TabIndex = 3;
            // 
            // macro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.MaximumSize = new System.Drawing.Size(0, 25);
            this.MinimumSize = new System.Drawing.Size(50, 25);
            this.Name = "macro";
            this.Size = new System.Drawing.Size(288, 25);
            this.Load += new System.EventHandler(this.macro_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox chkSendCommand;        
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtCommand;

        // Xml Serialization Infrastructure

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteStartElement("Macro");
            writer.WriteAttributeString("command", txtCommand.Text);
            writer.WriteAttributeString("checked", chkSendCommand.Checked.ToString());
            writer.WriteEndElement();
        }

        public void ReadXml(XmlReader reader)
        {            
            txtCommand.Text = reader.GetAttribute("command");
            chkSendCommand.Checked = Convert.ToBoolean(reader.GetAttribute("checked"));
        }

        public XmlSchema GetSchema()
        {
            return (null);
        }


    }
}
