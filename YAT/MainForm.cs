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

        private void Form1_Shown(Object sender, EventArgs e)
        {
            //set the correct name and version
            this.Text = Application.ProductName  + " " +   Application.ProductVersion;

            // fill the comboboxes
            cboDatabits.Items.Clear();
            cboDatabits.Items.Add("5");
            cboDatabits.Items.Add("6");
            cboDatabits.Items.Add("7");
            cboDatabits.Items.Add("8");
            cboDatabits.SelectedIndex = cboDatabits.Items.Count - 1;

            cboParity.Items.Clear();
            cboParity.Items.Add("Odd");
            cboParity.Items.Add("Even");
            cboParity.Items.Add("Parity");
            cboParity.Items.Add("None");
            cboParity.SelectedIndex = cboParity.Items.Count - 1;

            cboStopBits.Items.Clear();
            cboStopBits.Items.Add("1");
            cboStopBits.Items.Add("1.5");
            cboStopBits.Items.Add("2");
            cboStopBits.SelectedIndex = 0;

            cboBaudRate.Items.Clear();

            cboBaudRate.Items.Add(9600);
            cboBaudRate.Items.Add(19200);
            cboBaudRate.Items.Add(57600);

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
                            //                 
                            flowLayoutPanel1.Controls.Clear();

                            XmlReaderSettings settings = new XmlReaderSettings();
                            settings.Async = true;
                            
                            // Insert code to read the stream here.
                            XmlReader reader = XmlReader.Create(myStream, settings);

                            while (reader.Read())
                            {
                                if (reader.IsStartElement())
                                {
                                    if (reader.IsEmptyElement)
                                        Console.WriteLine("<{0}/>", reader.Name);
                                    else
                                    {
                                        Console.Write("<{0}> ", reader.Name);
                                        reader.Read(); // Read the start tag.
                                        if (reader.IsStartElement())  // Handle nested elements.
                                            Console.Write("\r\n<{0}>", reader.Name);
                                        Console.WriteLine(reader.ReadString());  //Read the text content of the element.
                                    }
                                }
                            }

                            //close the stream
                            reader.Close();

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
                    writer.WriteStartElement("Macro");
                    int itemcounter = 0;

                    //write the number of elements
                    writer.WriteAttributeString("count", Convert.ToString(flowLayoutPanel1.Controls.Count));

                    // load the items
                    foreach (macro foundControl in flowLayoutPanel1.Controls)
                    {
                        writer.WriteStartElement("item" + Convert.ToString(itemcounter++));
                        //XmlWriter
                        foundControl.WriteXml(writer);
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

        private void button1_Click(object sender, EventArgs e)
        {
            // testing the adding off the user commands
            macro myobject = new macro();
            myobject.Width = flowLayoutPanel1.Width - 25;
            flowLayoutPanel1.Controls.Add(myobject);
        }

        private void btnRescan_Click(object sender, EventArgs e)
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

        private void btnComs_Click(object sender, EventArgs e)
        {
            //print the information about the coms here
            //scan all the serial ports
            string[] serialPorts = SerialPort.GetPortNames();

            txtOutput.AppendText(text: "Found these ports:\n");
            //loop the ports.
            if (serialPorts.Length > 0)
            {
                foreach (string port in serialPorts)
                {
                    txtOutput.AppendText(port + "\n");
                }
            }

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox showAbout = new AboutBox();

            showAbout.ShowDialog(this);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // exit the program.         
            System.Windows.Forms.Application.Exit();
        }

        private void btnSaveMacro_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAddTab_Click(object sender, EventArgs e)
        {            
            TabPage tp = new TabPage("Test");
            tabMacro.TabPages.Add(tp);
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
    }
}
