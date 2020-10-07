using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using YAT.View;

namespace YAT
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private SerialPort m_serialPort = new SerialPort();
        private Queue<string> m_ToSendList = new Queue<string>();
        private void Form1_Shown(Object sender, EventArgs e)
        {
            //set the correct name and version
            this.Text = Application.ProductName  + " " +   Application.ProductVersion;

            cboBaudRate.Items.Clear();

            cboBaudRate.Items.Add(19200);            
            cboBaudRate.Items.Add(115200);
            cboBaudRate.SelectedIndex = 1;

            //set the callback
            m_serialPort.DataReceived += new SerialDataReceivedEventHandler(dataReceived);

            //remove the current items
            ScanForSerialPorts();


            cboCommandTerminator.Items.Clear();


            cboCommandTerminator.Items.Clear();
            object[] list =
                {
                new ComboBoxItem<string>("None", ""),    
                new ComboBoxItem<string>("CR", "\n"),
                new ComboBoxItem<string>("CR + LF", "\n\r"),
                new ComboBoxItem<string>("LF", "\r"),
            };

            cboCommandTerminator.Items.AddRange(list);
            cboCommandTerminator.SelectedIndex = 2;

            UpdateButtonsAndStatus();

            tabMacro.SelectedTab = CreateNewAndAddTabPage("Default");
            btnNewMacro.PerformClick();
        }

         // This delegate enables asynchronous calls for setting  
        // the text property on a TextBox control.  
        delegate void StringArgReturningVoidDelegate(string text);

        private void UpdateReceivedInfo(string text)
        {
            if (txtOutput.InvokeRequired)
            {
                StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(UpdateReceivedInfo);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                txtOutput.AppendText(text);
            }
        }

        //callback for the serial port
        private void dataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            UpdateReceivedInfo(m_serialPort.ReadExisting());
        }


        private void btnLoadMacro_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
            openFileDialog1.Filter = "YAT Macro files (*.ymf)|*.ymf";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            //check for the correct result
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Stream myStream = null;
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            //remove the current elements
                            tabMacro.SuspendLayout();
                            tabMacro.TabPages.Clear();

                            XmlReaderSettings settings = new XmlReaderSettings();
                            settings.Async = false;
                            
                            // Insert code to read the stream here.
                            XmlReader reader = XmlReader.Create(myStream, settings);
                            FlowLayoutPanel layout = null;
                            //create a list
                            List<macro> listToAdd = new List<macro>();

                            while (reader.Read())
                            {
                                switch (reader.NodeType)
                                {
                                    case XmlNodeType.Element:
                                        switch(reader.Name)
                                        {
                                            case "Tab":                                                
                                                if(listToAdd.Count > 0)
                                                {
                                                    layout.Controls.AddRange(listToAdd.ToArray());
                                                    listToAdd.Clear();
                                                }


                                                layout = (FlowLayoutPanel)CreateNewAndAddTabPage(reader.GetAttribute("Name")).Controls[0];
                                                
                                                break;
                                            case "Macro":
                                                macro macroSetting = new macro();
                                                macroSetting.Width = layout.Width - 25;                                                
                                                macroSetting.ReadXml(reader);
                                                // add to the short list
                                                listToAdd.Add(macroSetting);
                                                break;
                                            default:
                                                Console.WriteLine("Start Element {0}", reader.Name);
                                                break;
                                        }

                                        
                                        break;
                                    case XmlNodeType.Text:
                                        Console.WriteLine("Text Node: {0}", reader.Value);
                                        break;
                                    case XmlNodeType.EndElement:
                                        Console.WriteLine("End Element {0}", reader.Name);
                                        break;
                                    default:
                                        Console.WriteLine("Other node {0} with value {1}",
                                                        reader.NodeType, reader.Value);
                                        break;
                                }
                            }

                            if (listToAdd.Count > 0)
                            {
                                layout.Controls.AddRange(listToAdd.ToArray());
                            }

                            //close the stream
                            reader.Close();
                            tabMacro.ResumeLayout();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }                
            }
        }

        private void btnSaveMacro_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.InitialDirectory = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
            saveFile.Filter = "YAT Macro files (*.ymf)|*.ymf";
            // check for the correct result
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                Stream myStream = null;
                if((myStream = saveFile.OpenFile()) != null)
                {
                    XmlWriterSettings settings = new XmlWriterSettings();
                    settings.Indent = true;
                    settings.OmitXmlDeclaration = true;
                    settings.NewLineOnAttributes = true;
                    // Serialize the object to a file.
                    XmlWriter writer = XmlWriter.Create(myStream, settings);
                    writer.WriteStartDocument();
                    writer.WriteStartElement("YatMacro");
                    
                    // load the items
                    foreach (TabPage foundtab in tabMacro.TabPages)
                    {                        
                        writer.WriteStartElement("Tab");
                        writer.WriteAttributeString("Name", foundtab.Text);

                        FlowLayoutPanel panel = (FlowLayoutPanel)foundtab.Controls[0];
                        if(panel != null)
                        {
                            foreach(macro macroSetting in panel.Controls)
                            {
                                macroSetting.WriteXml(writer);
                            }
                        }

                        //XmlWriter
                        writer.WriteEndElement();
                                                
                    }
                    //close the document
                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                    writer.Close();
                }
                myStream.Close();
            }

        }

        private FlowLayoutPanel GetFlowLayoutPanelOnCurrentTab()
        {
            FlowLayoutPanel foundItem = null;

            if(tabMacro.TabCount > 0)
            {
                TabPage selectPage = tabMacro.SelectedTab;
                //check element
                if(selectPage != null)
                {
                    foundItem = (FlowLayoutPanel)tabMacro.SelectedTab.Controls[0];
                }                
            }

            return foundItem;
        }

        private void btnNewMacro_Click(object sender, EventArgs e)
        {
            FlowLayoutPanel layout = GetFlowLayoutPanelOnCurrentTab();

            if(layout != null)
            {
                // testing the adding off the user commands
                macro myobject = new macro();
                myobject.Width = layout.Width - 25;
                layout.Controls.Add(myobject);
            }
        }

        private void ScanForSerialPorts()
        {
            //scan all the serial ports
            string[] ports = SerialPort.GetPortNames();

            //remove the current items
            cboSerialPorts.Items.Clear();

            if (ports.Count() == 0)
            {
                //remove the current items
                cboSerialPorts.Items.Add("No port");

            }
            else
            {
                cboSerialPorts.Items.AddRange(ports);
            }
            cboSerialPorts.SelectedIndex = 0;
        }

        private void btnRescan_Click(object sender, EventArgs e)
        {
            ScanForSerialPorts();
        }

        private TabPage CreateNewAndAddTabPage(string nameTab)
        {
            
                TabPage tp = new TabPage(nameTab);
                FlowLayoutPanel fl_panel = new FlowLayoutPanel();
                fl_panel.Dock = DockStyle.Fill;
                fl_panel.AutoScroll = true;
                fl_panel.BringToFront();
                //add the panel
                tp.Controls.Add(fl_panel);
                //make the back ground nice
                tp.UseVisualStyleBackColor = true;

                tabMacro.TabPages.Add(tp);
            return tp;      
         }

        private void btnAddTab_Click(object sender, EventArgs e)
        {
            AskController getTabName = new AskController(this);

            //get the new name
            string nameTab = getTabName.GetNewName("");

            if (nameTab.Length > 0)
            {
                //select the tab
                tabMacro.SelectedTab = CreateNewAndAddTabPage(nameTab);
            }
        }

        private void btnRenameTab_Click(object sender, EventArgs e)
        {
            AskController getNewName = new AskController(this);
            //get the new name
            string newName = getNewName.GetNewName(tabMacro.SelectedTab.Text);

            //check the length
            if(newName.Length > 0)
            {
                //copy the new name
                tabMacro.SelectedTab.Text = newName;
            }
        }

        private void btnRemoveTab_Click(object sender, EventArgs e)
        {
            //check for at least one tab
            if (tabMacro.TabCount > 1)
            {
                if (MessageBox.Show(this, "Are you sure you want to remove \"" +  tabMacro.SelectedTab.Text + "\"?", "Remove tab", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //remove the selected tab
                    tabMacro.TabPages.Remove(tabMacro.SelectedTab);
                }
            }
        }

        private void ReportConnectionStatus(string status)
        {
            toolStripCurrentStatusLabel.Text = status;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            //connect with the serial port
            if(m_serialPort.IsOpen)
            {
                m_serialPort.Close();                
            }


            if (cboSerialPorts.SelectedItem != null)
            {
                //get the data from the combo port
                m_serialPort.PortName = cboSerialPorts.SelectedItem.ToString();
                m_serialPort.BaudRate = Convert.ToInt32(cboBaudRate.SelectedItem.ToString());                
                try
                {
                    m_serialPort.Open();
                }
                catch (Exception)
                {                    
                }
                
            }

            //update the info
            UpdateButtonsAndStatus();

        }

        private void UpdateButtonsAndStatus()
        {
            if(m_serialPort.IsOpen)
            {
                ReportConnectionStatus("Connected: " + m_serialPort.PortName + ", " + m_serialPort.BaudRate.ToString() + ", " + m_serialPort.DataBits.ToString() + ", " + m_serialPort.Parity.ToString() + ", " + m_serialPort.StopBits.ToString());            
            }
            else
            {
                ReportConnectionStatus("Disconnected");            
            }

            btnDisconnect.Enabled = m_serialPort.IsOpen;
            btnConnect.Enabled = !m_serialPort.IsOpen;

        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if(m_serialPort.IsOpen)
            {
                m_serialPort.Close();
            }
            //update the view
            UpdateButtonsAndStatus();
        }

        private void cboBaudRate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnDuplicateTab_Click(object sender, EventArgs e)
        {

        }

        public void SendCommand(string command)
        {
            if (m_serialPort.IsOpen == true)
            {

                if (m_ToSendList.Count() > 0)
                {
                    m_ToSendList.Enqueue(command);
                }
                else
                {
                    if(m_serialPort.BytesToWrite > 0)
                    {
                        m_ToSendList.Enqueue(command);
                    }
                    else
                    {
                        WriteStringToSerial(command);
                    }
                }

            }
        }

        private void WriteStringToSerial(string command)
        {
            if(m_serialPort.IsOpen == true)
            {
                string terminator = "";
                if (cboCommandTerminator.SelectedItem is ComboBoxItem<string>)
                {
                    ComboBoxItem<string> cast = cboCommandTerminator.SelectedItem as ComboBoxItem<string>;

                    terminator = cast.Value;
                }

                string toSend = txtBoxPreFix.Text + command + terminator;

                m_serialPort.Write(toSend);

            }
        }

        private void btnSendAll_Click(object sender, EventArgs e)
        {

        }
    }
}
