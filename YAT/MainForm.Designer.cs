﻿namespace YAT
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.cboSerialPorts = new System.Windows.Forms.ComboBox();
            this.btnRescan = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboBaudRate = new System.Windows.Forms.ComboBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripCurrentStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.cboCommandTerminator = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxPreFix = new System.Windows.Forms.TextBox();
            this.tabctl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabMacro = new System.Windows.Forms.TabControl();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRemoveTab = new System.Windows.Forms.Button();
            this.btnRenameTab = new System.Windows.Forms.Button();
            this.btnDuplicateTab = new System.Windows.Forms.Button();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.cboTimerSendSelected = new System.Windows.Forms.ComboBox();
            this.btnSendAll = new System.Windows.Forms.Button();
            this.chkSelectAll = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAppendMacro = new System.Windows.Forms.Button();
            this.btnSaveMacro = new System.Windows.Forms.Button();
            this.btnLoadMacro = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.chkWaitForTerminator = new System.Windows.Forms.CheckBox();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.lblCountTerminator = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboDecodeType = new System.Windows.Forms.ComboBox();
            this.dataGridViewLog = new System.Windows.Forms.DataGridView();
            this.chkShowHeaderTimer = new System.Windows.Forms.CheckBox();
            this.chkShowSend = new System.Windows.Forms.CheckBox();
            this.chkAddLengthHeader = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelGraphShowHide = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelChart2 = new System.Windows.Forms.TableLayoutPanel();
            this.chrtLoggingData2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSendGraphCommand2 = new System.Windows.Forms.TextBox();
            this.txtDecodeValue2 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.chrtLoggingData1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSendGraphCommand1 = new System.Windows.Forms.TextBox();
            this.txtDecodeValue1 = new System.Windows.Forms.TextBox();
            this.chkBoxLogValue = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.chkGraphSelection = new System.Windows.Forms.CheckBox();
            this.txtTimerSpeed = new System.Windows.Forms.TextBox();
            this.btnClearGraphs = new System.Windows.Forms.Button();
            this.tmrSendAllCommands = new System.Windows.Forms.Timer(this.components);
            this.tmrLog = new System.Windows.Forms.Timer(this.components);
            this.mnustrForm = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminalToolStripMenuItemImportTerminalpp = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabctl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLog)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanelGraphShowHide.SuspendLayout();
            this.tableLayoutPanelChart2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtLoggingData2)).BeginInit();
            this.tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtLoggingData1)).BeginInit();
            this.tableLayoutPanel12.SuspendLayout();
            this.mnustrForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.statusStrip1, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.groupBox4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tabctl, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1046, 676);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.SetColumnSpan(this.groupBox1, 2);
            this.groupBox1.Controls.Add(this.tableLayoutPanel6);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1040, 54);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Com settings";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 8;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.99812F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanel6.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.cboSerialPorts, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnRescan, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnConnect, 5, 0);
            this.tableLayoutPanel6.Controls.Add(this.label1, 3, 0);
            this.tableLayoutPanel6.Controls.Add(this.cboBaudRate, 4, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnDisconnect, 7, 0);
            this.tableLayoutPanel6.Controls.Add(this.checkBox1, 6, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1034, 35);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(185, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 30);
            this.label5.TabIndex = 45;
            this.label5.Text = "Port:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboSerialPorts
            // 
            this.cboSerialPorts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboSerialPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSerialPorts.FormattingEnabled = true;
            this.cboSerialPorts.Location = new System.Drawing.Point(226, 0);
            this.cboSerialPorts.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.cboSerialPorts.Name = "cboSerialPorts";
            this.cboSerialPorts.Size = new System.Drawing.Size(94, 21);
            this.cboSerialPorts.TabIndex = 7;
            this.cboSerialPorts.SelectedIndexChanged += new System.EventHandler(this.cboSerialPorts_SelectedIndexChanged);
            // 
            // btnRescan
            // 
            this.btnRescan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRescan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRescan.Location = new System.Drawing.Point(0, 0);
            this.btnRescan.Margin = new System.Windows.Forms.Padding(0);
            this.btnRescan.Name = "btnRescan";
            this.btnRescan.Size = new System.Drawing.Size(183, 30);
            this.btnRescan.TabIndex = 2;
            this.btnRescan.Text = "Rescan";
            this.btnRescan.UseVisualStyleBackColor = true;
            this.btnRescan.Click += new System.EventHandler(this.btnRescan_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConnect.Location = new System.Drawing.Point(483, 0);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(0);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(183, 30);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(325, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "Baudrate:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboBaudRate
            // 
            this.cboBaudRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBaudRate.FormattingEnabled = true;
            this.cboBaudRate.Location = new System.Drawing.Point(386, 0);
            this.cboBaudRate.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.cboBaudRate.Name = "cboBaudRate";
            this.cboBaudRate.Size = new System.Drawing.Size(94, 21);
            this.cboBaudRate.TabIndex = 44;
            this.cboBaudRate.SelectedIndexChanged += new System.EventHandler(this.cboBaudRate_SelectedIndexChanged);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDisconnect.Location = new System.Drawing.Point(849, 0);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(0);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(185, 30);
            this.btnDisconnect.TabIndex = 46;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox1.Location = new System.Drawing.Point(669, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(177, 24);
            this.checkBox1.TabIndex = 47;
            this.checkBox1.Text = "Auto reconnect";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            // 
            // statusStrip1
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.statusStrip1, 2);
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripCurrentStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 651);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1046, 25);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripCurrentStatusLabel
            // 
            this.toolStripCurrentStatusLabel.Name = "toolStripCurrentStatusLabel";
            this.toolStripCurrentStatusLabel.Size = new System.Drawing.Size(86, 20);
            this.toolStripCurrentStatusLabel.Text = "Not connected";
            // 
            // groupBox4
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.groupBox4, 2);
            this.groupBox4.Controls.Add(this.tableLayoutPanel3);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 63);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1040, 44);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Command Settings";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.99999F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.cboCommandTerminator, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtBoxPreFix, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1034, 25);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // cboCommandTerminator
            // 
            this.cboCommandTerminator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboCommandTerminator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCommandTerminator.FormattingEnabled = true;
            this.cboCommandTerminator.Location = new System.Drawing.Point(594, 3);
            this.cboCommandTerminator.Name = "cboCommandTerminator";
            this.cboCommandTerminator.Size = new System.Drawing.Size(437, 21);
            this.cboCommandTerminator.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(519, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Terminator:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prefix:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBoxPreFix
            // 
            this.txtBoxPreFix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxPreFix.Location = new System.Drawing.Point(78, 3);
            this.txtBoxPreFix.Name = "txtBoxPreFix";
            this.txtBoxPreFix.Size = new System.Drawing.Size(435, 20);
            this.txtBoxPreFix.TabIndex = 3;
            // 
            // tabctl
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.tabctl, 2);
            this.tabctl.Controls.Add(this.tabPage1);
            this.tabctl.Controls.Add(this.tabPage2);
            this.tabctl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabctl.Location = new System.Drawing.Point(3, 113);
            this.tabctl.Name = "tabctl";
            this.tabctl.SelectedIndex = 0;
            this.tabctl.Size = new System.Drawing.Size(1040, 535);
            this.tabctl.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1032, 509);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Commands";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Size = new System.Drawing.Size(1026, 503);
            this.splitContainer1.SplitterDistance = 490;
            this.splitContainer1.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.MinimumSize = new System.Drawing.Size(250, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(490, 503);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Commands";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 484);
            this.panel1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28816F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tabMacro, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel8, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(484, 484);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tabMacro
            // 
            this.tabMacro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMacro.Location = new System.Drawing.Point(0, 73);
            this.tabMacro.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.tabMacro.Name = "tabMacro";
            this.tabMacro.SelectedIndex = 0;
            this.tabMacro.Size = new System.Drawing.Size(481, 378);
            this.tabMacro.TabIndex = 5;
            this.tabMacro.SelectedIndexChanged += new System.EventHandler(this.tabMacro_SelectedIndexChanged);
            this.tabMacro.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabMacro_MouseDown);
            this.tabMacro.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tabMacro_MouseMove);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Controls.Add(this.btnRemoveTab, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnRenameTab, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnDuplicateTab, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 454);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(484, 30);
            this.tableLayoutPanel5.TabIndex = 12;
            // 
            // btnRemoveTab
            // 
            this.btnRemoveTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemoveTab.Location = new System.Drawing.Point(325, 3);
            this.btnRemoveTab.Name = "btnRemoveTab";
            this.btnRemoveTab.Size = new System.Drawing.Size(156, 24);
            this.btnRemoveTab.TabIndex = 11;
            this.btnRemoveTab.Text = "Remove tab";
            this.btnRemoveTab.UseVisualStyleBackColor = true;
            this.btnRemoveTab.Click += new System.EventHandler(this.btnRemoveTab_Click);
            // 
            // btnRenameTab
            // 
            this.btnRenameTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRenameTab.Location = new System.Drawing.Point(164, 3);
            this.btnRenameTab.Name = "btnRenameTab";
            this.btnRenameTab.Size = new System.Drawing.Size(155, 24);
            this.btnRenameTab.TabIndex = 10;
            this.btnRenameTab.Text = "Rename tab";
            this.btnRenameTab.UseVisualStyleBackColor = true;
            this.btnRenameTab.Click += new System.EventHandler(this.btnRenameTab_Click);
            // 
            // btnDuplicateTab
            // 
            this.btnDuplicateTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDuplicateTab.Location = new System.Drawing.Point(3, 3);
            this.btnDuplicateTab.Name = "btnDuplicateTab";
            this.btnDuplicateTab.Size = new System.Drawing.Size(155, 24);
            this.btnDuplicateTab.TabIndex = 9;
            this.btnDuplicateTab.Text = "Duplicate tab";
            this.btnDuplicateTab.UseVisualStyleBackColor = true;
            this.btnDuplicateTab.Click += new System.EventHandler(this.btnDuplicateTab_Click);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 4;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel7.Controls.Add(this.cboTimerSendSelected, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.btnSendAll, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.chkSelectAll, 3, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 40);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(484, 30);
            this.tableLayoutPanel7.TabIndex = 13;
            // 
            // cboTimerSendSelected
            // 
            this.cboTimerSendSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboTimerSendSelected.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimerSendSelected.FormattingEnabled = true;
            this.cboTimerSendSelected.Location = new System.Drawing.Point(3, 3);
            this.cboTimerSendSelected.Name = "cboTimerSendSelected";
            this.cboTimerSendSelected.Size = new System.Drawing.Size(146, 21);
            this.cboTimerSendSelected.TabIndex = 14;
            this.cboTimerSendSelected.SelectedIndexChanged += new System.EventHandler(this.cboTimerSendSelected_SelectedIndexChanged);
            // 
            // btnSendAll
            // 
            this.btnSendAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSendAll.Location = new System.Drawing.Point(307, 3);
            this.btnSendAll.Name = "btnSendAll";
            this.btnSendAll.Size = new System.Drawing.Size(84, 24);
            this.btnSendAll.TabIndex = 13;
            this.btnSendAll.Text = "Send selected";
            this.btnSendAll.UseVisualStyleBackColor = true;
            this.btnSendAll.Click += new System.EventHandler(this.btnSendAll_Click);
            // 
            // chkSelectAll
            // 
            this.chkSelectAll.AutoSize = true;
            this.chkSelectAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkSelectAll.Location = new System.Drawing.Point(397, 3);
            this.chkSelectAll.Name = "chkSelectAll";
            this.chkSelectAll.Size = new System.Drawing.Size(84, 24);
            this.chkSelectAll.TabIndex = 12;
            this.chkSelectAll.Text = "Select all";
            this.chkSelectAll.UseVisualStyleBackColor = true;
            this.chkSelectAll.CheckedChanged += new System.EventHandler(this.chkSelectAll_CheckedChanged);
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 5;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0005F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0005F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.99851F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0005F));
            this.tableLayoutPanel8.Controls.Add(this.btnAppendMacro, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.btnSaveMacro, 2, 0);
            this.tableLayoutPanel8.Controls.Add(this.btnLoadMacro, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.btnNew, 4, 0);
            this.tableLayoutPanel8.Controls.Add(this.btnSaveAs, 3, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(484, 30);
            this.tableLayoutPanel8.TabIndex = 14;
            // 
            // btnAppendMacro
            // 
            this.btnAppendMacro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAppendMacro.Location = new System.Drawing.Point(99, 3);
            this.btnAppendMacro.Name = "btnAppendMacro";
            this.btnAppendMacro.Size = new System.Drawing.Size(90, 24);
            this.btnAppendMacro.TabIndex = 5;
            this.btnAppendMacro.Text = "Append";
            this.btnAppendMacro.UseVisualStyleBackColor = true;
            this.btnAppendMacro.Click += new System.EventHandler(this.btnImportMacro_Click);
            // 
            // btnSaveMacro
            // 
            this.btnSaveMacro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaveMacro.Location = new System.Drawing.Point(195, 3);
            this.btnSaveMacro.Name = "btnSaveMacro";
            this.btnSaveMacro.Size = new System.Drawing.Size(90, 24);
            this.btnSaveMacro.TabIndex = 2;
            this.btnSaveMacro.Text = "Save";
            this.btnSaveMacro.UseVisualStyleBackColor = true;
            this.btnSaveMacro.Click += new System.EventHandler(this.btnSaveMacro_Click);
            // 
            // btnLoadMacro
            // 
            this.btnLoadMacro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoadMacro.Location = new System.Drawing.Point(3, 3);
            this.btnLoadMacro.Name = "btnLoadMacro";
            this.btnLoadMacro.Size = new System.Drawing.Size(90, 24);
            this.btnLoadMacro.TabIndex = 1;
            this.btnLoadMacro.Text = "Load";
            this.btnLoadMacro.UseVisualStyleBackColor = true;
            this.btnLoadMacro.Click += new System.EventHandler(this.btnLoadMacro_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNew.Location = new System.Drawing.Point(387, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(94, 24);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "Clear configuration";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSaveAs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaveAs.Location = new System.Drawing.Point(291, 3);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(90, 24);
            this.btnSaveAs.TabIndex = 4;
            this.btnSaveAs.Text = "Save as";
            this.btnSaveAs.UseVisualStyleBackColor = false;
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel4);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(532, 503);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Reply";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 8;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel4.Controls.Add(this.chkWaitForTerminator, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.btnClearLog, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblCountTerminator, 7, 0);
            this.tableLayoutPanel4.Controls.Add(this.label4, 6, 0);
            this.tableLayoutPanel4.Controls.Add(this.cboDecodeType, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.dataGridViewLog, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.chkShowHeaderTimer, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.chkShowSend, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.chkAddLengthHeader, 4, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(526, 484);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // chkWaitForTerminator
            // 
            this.chkWaitForTerminator.AutoSize = true;
            this.chkWaitForTerminator.Checked = true;
            this.chkWaitForTerminator.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tableLayoutPanel4.SetColumnSpan(this.chkWaitForTerminator, 2);
            this.chkWaitForTerminator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkWaitForTerminator.Location = new System.Drawing.Point(267, 457);
            this.chkWaitForTerminator.Name = "chkWaitForTerminator";
            this.chkWaitForTerminator.Size = new System.Drawing.Size(126, 24);
            this.chkWaitForTerminator.TabIndex = 9;
            this.chkWaitForTerminator.Text = "Terminator check";
            this.chkWaitForTerminator.UseVisualStyleBackColor = true;
            // 
            // btnClearLog
            // 
            this.tableLayoutPanel4.SetColumnSpan(this.btnClearLog, 3);
            this.btnClearLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClearLog.Location = new System.Drawing.Point(3, 3);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(192, 24);
            this.btnClearLog.TabIndex = 2;
            this.btnClearLog.Text = "Clear";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // lblCountTerminator
            // 
            this.lblCountTerminator.AutoSize = true;
            this.lblCountTerminator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCountTerminator.Location = new System.Drawing.Point(449, 0);
            this.lblCountTerminator.Name = "lblCountTerminator";
            this.lblCountTerminator.Size = new System.Drawing.Size(74, 30);
            this.lblCountTerminator.TabIndex = 3;
            this.lblCountTerminator.Text = "0";
            this.lblCountTerminator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(399, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 30);
            this.label4.TabIndex = 4;
            this.label4.Text = "Count:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboDecodeType
            // 
            this.tableLayoutPanel4.SetColumnSpan(this.cboDecodeType, 3);
            this.cboDecodeType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboDecodeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDecodeType.FormattingEnabled = true;
            this.cboDecodeType.Location = new System.Drawing.Point(201, 3);
            this.cboDecodeType.Name = "cboDecodeType";
            this.cboDecodeType.Size = new System.Drawing.Size(192, 21);
            this.cboDecodeType.TabIndex = 5;
            this.cboDecodeType.SelectedIndexChanged += new System.EventHandler(this.cboDecodeType_SelectedIndexChanged);
            // 
            // dataGridViewLog
            // 
            this.dataGridViewLog.AllowUserToAddRows = false;
            this.dataGridViewLog.AllowUserToDeleteRows = false;
            this.dataGridViewLog.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel4.SetColumnSpan(this.dataGridViewLog, 8);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLog.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewLog.Location = new System.Drawing.Point(3, 33);
            this.dataGridViewLog.Name = "dataGridViewLog";
            this.dataGridViewLog.ReadOnly = true;
            this.dataGridViewLog.RowHeadersWidth = 62;
            this.dataGridViewLog.Size = new System.Drawing.Size(520, 418);
            this.dataGridViewLog.TabIndex = 6;
            this.dataGridViewLog.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewLog_CellFormatting);
            this.dataGridViewLog.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewLog_MouseClick);
            // 
            // chkShowHeaderTimer
            // 
            this.chkShowHeaderTimer.AutoSize = true;
            this.chkShowHeaderTimer.Checked = true;
            this.chkShowHeaderTimer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tableLayoutPanel4.SetColumnSpan(this.chkShowHeaderTimer, 2);
            this.chkShowHeaderTimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkShowHeaderTimer.Location = new System.Drawing.Point(135, 457);
            this.chkShowHeaderTimer.Name = "chkShowHeaderTimer";
            this.chkShowHeaderTimer.Size = new System.Drawing.Size(126, 24);
            this.chkShowHeaderTimer.TabIndex = 8;
            this.chkShowHeaderTimer.Text = "Show header timer";
            this.chkShowHeaderTimer.UseVisualStyleBackColor = true;
            // 
            // chkShowSend
            // 
            this.chkShowSend.AutoSize = true;
            this.chkShowSend.Checked = true;
            this.chkShowSend.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tableLayoutPanel4.SetColumnSpan(this.chkShowSend, 2);
            this.chkShowSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkShowSend.Location = new System.Drawing.Point(3, 457);
            this.chkShowSend.Name = "chkShowSend";
            this.chkShowSend.Size = new System.Drawing.Size(126, 24);
            this.chkShowSend.TabIndex = 7;
            this.chkShowSend.Text = "Show send command";
            this.chkShowSend.UseVisualStyleBackColor = true;
            // 
            // chkAddLengthHeader
            // 
            this.chkAddLengthHeader.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.chkAddLengthHeader, 2);
            this.chkAddLengthHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkAddLengthHeader.Location = new System.Drawing.Point(399, 457);
            this.chkAddLengthHeader.Name = "chkAddLengthHeader";
            this.chkAddLengthHeader.Size = new System.Drawing.Size(124, 24);
            this.chkAddLengthHeader.TabIndex = 10;
            this.chkAddLengthHeader.Text = "Add length header";
            this.chkAddLengthHeader.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanelGraphShowHide);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1032, 509);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Log";
            // 
            // tableLayoutPanelGraphShowHide
            // 
            this.tableLayoutPanelGraphShowHide.ColumnCount = 1;
            this.tableLayoutPanelGraphShowHide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelGraphShowHide.Controls.Add(this.tableLayoutPanelChart2, 0, 2);
            this.tableLayoutPanelGraphShowHide.Controls.Add(this.tableLayoutPanel9, 0, 1);
            this.tableLayoutPanelGraphShowHide.Controls.Add(this.tableLayoutPanel12, 0, 0);
            this.tableLayoutPanelGraphShowHide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelGraphShowHide.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelGraphShowHide.Name = "tableLayoutPanelGraphShowHide";
            this.tableLayoutPanelGraphShowHide.RowCount = 3;
            this.tableLayoutPanelGraphShowHide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelGraphShowHide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelGraphShowHide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelGraphShowHide.Size = new System.Drawing.Size(1026, 503);
            this.tableLayoutPanelGraphShowHide.TabIndex = 1;
            // 
            // tableLayoutPanelChart2
            // 
            this.tableLayoutPanelChart2.ColumnCount = 5;
            this.tableLayoutPanelChart2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelChart2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelChart2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanelChart2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelChart2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutPanelChart2.Controls.Add(this.chrtLoggingData2, 0, 0);
            this.tableLayoutPanelChart2.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanelChart2.Controls.Add(this.label9, 2, 1);
            this.tableLayoutPanelChart2.Controls.Add(this.txtSendGraphCommand2, 1, 1);
            this.tableLayoutPanelChart2.Controls.Add(this.txtDecodeValue2, 3, 1);
            this.tableLayoutPanelChart2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelChart2.Location = new System.Drawing.Point(3, 274);
            this.tableLayoutPanelChart2.Name = "tableLayoutPanelChart2";
            this.tableLayoutPanelChart2.RowCount = 2;
            this.tableLayoutPanelChart2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelChart2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelChart2.Size = new System.Drawing.Size(1020, 226);
            this.tableLayoutPanelChart2.TabIndex = 1;
            // 
            // chrtLoggingData2
            // 
            chartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisY2.IsStartedFromZero = false;
            chartArea1.Name = "ChartArea1";
            this.chrtLoggingData2.ChartAreas.Add(chartArea1);
            this.tableLayoutPanelChart2.SetColumnSpan(this.chrtLoggingData2, 5);
            this.chrtLoggingData2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chrtLoggingData2.Location = new System.Drawing.Point(3, 3);
            this.chrtLoggingData2.Name = "chrtLoggingData2";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.MarkerSize = 10;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            this.chrtLoggingData2.Series.Add(series1);
            this.chrtLoggingData2.Size = new System.Drawing.Size(1014, 190);
            this.chrtLoggingData2.TabIndex = 0;
            this.chrtLoggingData2.Text = "chart1";
            this.chrtLoggingData2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chrtLoggingData2_MouseClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 30);
            this.label8.TabIndex = 1;
            this.label8.Text = "Send:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(448, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 30);
            this.label9.TabIndex = 2;
            this.label9.Text = "Decode:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSendGraphCommand2
            // 
            this.txtSendGraphCommand2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSendGraphCommand2.Location = new System.Drawing.Point(53, 199);
            this.txtSendGraphCommand2.Name = "txtSendGraphCommand2";
            this.txtSendGraphCommand2.Size = new System.Drawing.Size(389, 20);
            this.txtSendGraphCommand2.TabIndex = 3;
            // 
            // txtDecodeValue2
            // 
            this.txtDecodeValue2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDecodeValue2.Location = new System.Drawing.Point(523, 199);
            this.txtDecodeValue2.Name = "txtDecodeValue2";
            this.txtDecodeValue2.Size = new System.Drawing.Size(389, 20);
            this.txtDecodeValue2.TabIndex = 4;
            this.txtDecodeValue2.Text = "(-?\\d+(.\\d+)?)";
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 5;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutPanel9.Controls.Add(this.chrtLoggingData1, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel9.Controls.Add(this.label7, 2, 1);
            this.tableLayoutPanel9.Controls.Add(this.txtSendGraphCommand1, 1, 1);
            this.tableLayoutPanel9.Controls.Add(this.txtDecodeValue1, 3, 1);
            this.tableLayoutPanel9.Controls.Add(this.chkBoxLogValue, 4, 1);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 43);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 2;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(1020, 225);
            this.tableLayoutPanel9.TabIndex = 0;
            // 
            // chrtLoggingData1
            // 
            chartArea2.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea2.AxisY.IsStartedFromZero = false;
            chartArea2.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea2.AxisY2.IsStartedFromZero = false;
            chartArea2.Name = "ChartArea1";
            this.chrtLoggingData1.ChartAreas.Add(chartArea2);
            this.tableLayoutPanel9.SetColumnSpan(this.chrtLoggingData1, 5);
            this.chrtLoggingData1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chrtLoggingData1.Location = new System.Drawing.Point(3, 3);
            this.chrtLoggingData1.Name = "chrtLoggingData1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.MarkerSize = 10;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "Series1";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            this.chrtLoggingData1.Series.Add(series2);
            this.chrtLoggingData1.Size = new System.Drawing.Size(1014, 189);
            this.chrtLoggingData1.TabIndex = 0;
            this.chrtLoggingData1.Text = "chart1";
            this.chrtLoggingData1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chrtLoggingData1_MouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 30);
            this.label6.TabIndex = 1;
            this.label6.Text = "Send:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(448, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 30);
            this.label7.TabIndex = 2;
            this.label7.Text = "Decode:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSendGraphCommand1
            // 
            this.txtSendGraphCommand1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSendGraphCommand1.Location = new System.Drawing.Point(53, 198);
            this.txtSendGraphCommand1.Name = "txtSendGraphCommand1";
            this.txtSendGraphCommand1.Size = new System.Drawing.Size(389, 20);
            this.txtSendGraphCommand1.TabIndex = 3;
            // 
            // txtDecodeValue1
            // 
            this.txtDecodeValue1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDecodeValue1.Location = new System.Drawing.Point(523, 198);
            this.txtDecodeValue1.Name = "txtDecodeValue1";
            this.txtDecodeValue1.Size = new System.Drawing.Size(389, 20);
            this.txtDecodeValue1.TabIndex = 4;
            this.txtDecodeValue1.Text = "(-?\\d+(.\\d+)?)";
            // 
            // chkBoxLogValue
            // 
            this.chkBoxLogValue.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkBoxLogValue.AutoSize = true;
            this.chkBoxLogValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkBoxLogValue.Location = new System.Drawing.Point(918, 198);
            this.chkBoxLogValue.Name = "chkBoxLogValue";
            this.chkBoxLogValue.Size = new System.Drawing.Size(99, 24);
            this.chkBoxLogValue.TabIndex = 5;
            this.chkBoxLogValue.Text = "Log Value";
            this.chkBoxLogValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkBoxLogValue.UseVisualStyleBackColor = true;
            this.chkBoxLogValue.CheckedChanged += new System.EventHandler(this.chkBoxLogValue_CheckedChanged);
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 5;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33444F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33444F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33111F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 207F));
            this.tableLayoutPanel12.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel12.Controls.Add(this.chkGraphSelection, 2, 0);
            this.tableLayoutPanel12.Controls.Add(this.txtTimerSpeed, 1, 0);
            this.tableLayoutPanel12.Controls.Add(this.btnClearGraphs, 4, 0);
            this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel12.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 1;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(1020, 34);
            this.tableLayoutPanel12.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 34);
            this.label10.TabIndex = 0;
            this.label10.Text = "Time per sample (ms):";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkGraphSelection
            // 
            this.chkGraphSelection.AutoSize = true;
            this.chkGraphSelection.Checked = true;
            this.chkGraphSelection.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGraphSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkGraphSelection.Location = new System.Drawing.Point(350, 3);
            this.chkGraphSelection.Name = "chkGraphSelection";
            this.chkGraphSelection.Size = new System.Drawing.Size(226, 28);
            this.chkGraphSelection.TabIndex = 1;
            this.chkGraphSelection.Text = "Both the graphs";
            this.chkGraphSelection.UseVisualStyleBackColor = true;
            this.chkGraphSelection.CheckedChanged += new System.EventHandler(this.chkGraphSelection_CheckedChanged);
            // 
            // txtTimerSpeed
            // 
            this.txtTimerSpeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimerSpeed.Location = new System.Drawing.Point(118, 3);
            this.txtTimerSpeed.Name = "txtTimerSpeed";
            this.txtTimerSpeed.Size = new System.Drawing.Size(226, 20);
            this.txtTimerSpeed.TabIndex = 2;
            this.txtTimerSpeed.Text = "1000";
            // 
            // btnClearGraphs
            // 
            this.btnClearGraphs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClearGraphs.Location = new System.Drawing.Point(814, 3);
            this.btnClearGraphs.Name = "btnClearGraphs";
            this.btnClearGraphs.Size = new System.Drawing.Size(203, 28);
            this.btnClearGraphs.TabIndex = 3;
            this.btnClearGraphs.Text = "Clear graph(s)";
            this.btnClearGraphs.UseVisualStyleBackColor = true;
            this.btnClearGraphs.Click += new System.EventHandler(this.btnClearGraphs_Click);
            // 
            // tmrSendAllCommands
            // 
            this.tmrSendAllCommands.Tick += new System.EventHandler(this.tmrSendAllCommands_Tick);
            // 
            // tmrLog
            // 
            this.tmrLog.Interval = 500;
            this.tmrLog.Tick += new System.EventHandler(this.tmrLog_Tick);
            // 
            // mnustrForm
            // 
            this.mnustrForm.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnustrForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mnustrForm.Location = new System.Drawing.Point(0, 0);
            this.mnustrForm.Name = "mnustrForm";
            this.mnustrForm.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.mnustrForm.Size = new System.Drawing.Size(1046, 24);
            this.mnustrForm.TabIndex = 7;
            this.mnustrForm.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.terminalToolStripMenuItemImportTerminalpp});
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // terminalToolStripMenuItemImportTerminalpp
            // 
            this.terminalToolStripMenuItemImportTerminalpp.Name = "terminalToolStripMenuItemImportTerminalpp";
            this.terminalToolStripMenuItemImportTerminalpp.Size = new System.Drawing.Size(135, 22);
            this.terminalToolStripMenuItemImportTerminalpp.Text = "Terminal++";
            this.terminalToolStripMenuItemImportTerminalpp.Click += new System.EventHandler(this.terminalToolStripMenuItemImportTerminalpp_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 700);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.mnustrForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnustrForm;
            this.Name = "MainForm";
            this.Text = "Yat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tabctl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLog)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanelGraphShowHide.ResumeLayout(false);
            this.tableLayoutPanelChart2.ResumeLayout(false);
            this.tableLayoutPanelChart2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtLoggingData2)).EndInit();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtLoggingData1)).EndInit();
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel12.PerformLayout();
            this.mnustrForm.ResumeLayout(false);
            this.mnustrForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripCurrentStatusLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboSerialPorts;
        private System.Windows.Forms.Button btnRescan;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboBaudRate;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tabMacro;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ComboBox cboCommandTerminator;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxPreFix;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.Timer tmrSendAllCommands;
        private System.Windows.Forms.Label lblCountTerminator;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button btnDuplicateTab;
        private System.Windows.Forms.Button btnRemoveTab;
        private System.Windows.Forms.Button btnRenameTab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.ComboBox cboTimerSendSelected;
        private System.Windows.Forms.Button btnSendAll;
        private System.Windows.Forms.CheckBox chkSelectAll;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Button btnSaveMacro;
        private System.Windows.Forms.Button btnLoadMacro;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSaveAs;
        private System.Windows.Forms.ComboBox cboDecodeType;
        private System.Windows.Forms.DataGridView dataGridViewLog;

        private System.Windows.Forms.TabControl tabctl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtLoggingData1;
        private System.Windows.Forms.Timer tmrLog;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSendGraphCommand1;
        private System.Windows.Forms.TextBox txtDecodeValue1;
        private System.Windows.Forms.CheckBox chkBoxLogValue;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelGraphShowHide;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelChart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtLoggingData2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSendGraphCommand2;
        private System.Windows.Forms.TextBox txtDecodeValue2;

        private System.Windows.Forms.CheckBox chkShowSend;
        private System.Windows.Forms.CheckBox chkShowHeaderTimer;
        private System.Windows.Forms.MenuStrip mnustrForm;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terminalToolStripMenuItemImportTerminalpp;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chkGraphSelection;
        private System.Windows.Forms.TextBox txtTimerSpeed;
        private System.Windows.Forms.Button btnClearGraphs;
        private System.Windows.Forms.Button btnAppendMacro;
        private System.Windows.Forms.CheckBox chkWaitForTerminator;
        private System.Windows.Forms.CheckBox chkAddLengthHeader;
    }
}

