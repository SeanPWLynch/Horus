namespace HorusAdmin
{
    partial class HorusAdminMain
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
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("ID: ");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Operating System: ");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Computer Name: ");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Computer Details", new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode18,
            treeNode19});
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Name: ", 1, 1);
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Physical Cores: ", 1, 1);
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Logical Cores:", 1, 1);
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("CPU", 1, 1, new System.Windows.Forms.TreeNode[] {
            treeNode21,
            treeNode22,
            treeNode23});
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Manufacturer:", 3, 3);
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Model:", 3, 3);
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("System Model: ", 3, 3);
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Motherboard", 3, 3, new System.Windows.Forms.TreeNode[] {
            treeNode25,
            treeNode26,
            treeNode27});
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Memory", 4, 4);
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Storage", 5, 5);
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Display Adapters", 2, 2);
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("System", new System.Windows.Forms.TreeNode[] {
            treeNode20,
            treeNode24,
            treeNode28,
            treeNode29,
            treeNode30,
            treeNode31});
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverMainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.tabControlCliens = new System.Windows.Forms.TabControl();
            this.onlineClients = new System.Windows.Forms.TabPage();
            this.offlinClients = new System.Windows.Forms.TabPage();
            this.tabInfoContainer = new System.Windows.Forms.TabControl();
            this.tabHardwarePage = new System.Windows.Forms.TabPage();
            this.tabControlHardware = new System.Windows.Forms.TabControl();
            this.tabPageHardwareDetails = new System.Windows.Forms.TabPage();
            this.hardwareTreeView = new System.Windows.Forms.TreeView();
            this.tabPageHardwareUsage = new System.Windows.Forms.TabPage();
            this.tblLayoutHardwareUsage = new System.Windows.Forms.TableLayoutPanel();
            this.grpBoxRAMUsage = new System.Windows.Forms.GroupBox();
            this.lblInUseRAMAns = new System.Windows.Forms.Label();
            this.lblInUseRAM = new System.Windows.Forms.Label();
            this.lblFreeRAMAns = new System.Windows.Forms.Label();
            this.lblTotalRAMAns = new System.Windows.Forms.Label();
            this.lblFreeRAM = new System.Windows.Forms.Label();
            this.lblTotalRAM = new System.Windows.Forms.Label();
            this.grpNetworkUsage = new System.Windows.Forms.GroupBox();
            this.txtBoxNetworkUsage = new System.Windows.Forms.RichTextBox();
            this.grpBoxVolUsage = new System.Windows.Forms.GroupBox();
            this.txtBoxVolUsage = new System.Windows.Forms.RichTextBox();
            this.grpBoxCPUUsage = new System.Windows.Forms.GroupBox();
            this.lblThreadsAns = new System.Windows.Forms.Label();
            this.lblProcessesAns = new System.Windows.Forms.Label();
            this.lblCPUUsageAns = new System.Windows.Forms.Label();
            this.lblUptimeAns = new System.Windows.Forms.Label();
            this.lblNumthreads = new System.Windows.Forms.Label();
            this.lblNumProcesses = new System.Windows.Forms.Label();
            this.lblCPUUsage = new System.Windows.Forms.Label();
            this.lblUptime = new System.Windows.Forms.Label();
            this.tabProcessPage = new System.Windows.Forms.TabPage();
            this.dataGridProcess = new System.Windows.Forms.DataGridView();
            this.tabServicePage = new System.Windows.Forms.TabPage();
            this.dataGridService = new System.Windows.Forms.DataGridView();
            this.tabPageSchedule = new System.Windows.Forms.TabPage();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridTaskTrigger = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridTaskAction = new System.Windows.Forms.DataGridView();
            this.dataGridTask = new System.Windows.Forms.DataGridView();
            this.tabpageStatistics = new System.Windows.Forms.TabPage();
            this.tblLayoutStats = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutStatLabels = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCommonProcessor = new System.Windows.Forms.Label();
            this.lblMostCommonMobo = new System.Windows.Forms.Label();
            this.lblMostCommonDisplay = new System.Windows.Forms.Label();
            this.lblAverageRAM = new System.Windows.Forms.Label();
            this.lblAverageStorage = new System.Windows.Forms.Label();
            this.lblAvgUptime = new System.Windows.Forms.Label();
            this.flowLayoutStatText = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCommonProcessorAns = new System.Windows.Forms.Label();
            this.lblCommonMoboAns = new System.Windows.Forms.Label();
            this.lblCommonDisplayAns = new System.Windows.Forms.Label();
            this.lblAverageRAMAns = new System.Windows.Forms.Label();
            this.lblAverageStorageAns = new System.Windows.Forms.Label();
            this.lblAvgUptimeAns = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serverMainSplitContainer)).BeginInit();
            this.serverMainSplitContainer.Panel1.SuspendLayout();
            this.serverMainSplitContainer.Panel2.SuspendLayout();
            this.serverMainSplitContainer.SuspendLayout();
            this.tabControlCliens.SuspendLayout();
            this.tabInfoContainer.SuspendLayout();
            this.tabHardwarePage.SuspendLayout();
            this.tabControlHardware.SuspendLayout();
            this.tabPageHardwareDetails.SuspendLayout();
            this.tabPageHardwareUsage.SuspendLayout();
            this.tblLayoutHardwareUsage.SuspendLayout();
            this.grpBoxRAMUsage.SuspendLayout();
            this.grpNetworkUsage.SuspendLayout();
            this.grpBoxVolUsage.SuspendLayout();
            this.grpBoxCPUUsage.SuspendLayout();
            this.tabProcessPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProcess)).BeginInit();
            this.tabServicePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridService)).BeginInit();
            this.tabPageSchedule.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTaskTrigger)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTaskAction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTask)).BeginInit();
            this.tabpageStatistics.SuspendLayout();
            this.tblLayoutStats.SuspendLayout();
            this.flowLayoutStatLabels.SuspendLayout();
            this.flowLayoutStatText.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1160, 24);
            this.menuStrip.TabIndex = 7;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseSettingsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // databaseSettingsToolStripMenuItem
            // 
            this.databaseSettingsToolStripMenuItem.Name = "databaseSettingsToolStripMenuItem";
            this.databaseSettingsToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.databaseSettingsToolStripMenuItem.Text = "Database Settings";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // serverMainSplitContainer
            // 
            this.serverMainSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.serverMainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serverMainSplitContainer.Location = new System.Drawing.Point(0, 24);
            this.serverMainSplitContainer.Margin = new System.Windows.Forms.Padding(5);
            this.serverMainSplitContainer.Name = "serverMainSplitContainer";
            // 
            // serverMainSplitContainer.Panel1
            // 
            this.serverMainSplitContainer.Panel1.Controls.Add(this.tabControlCliens);
            // 
            // serverMainSplitContainer.Panel2
            // 
            this.serverMainSplitContainer.Panel2.Controls.Add(this.tabInfoContainer);
            this.serverMainSplitContainer.Size = new System.Drawing.Size(1160, 426);
            this.serverMainSplitContainer.SplitterDistance = 570;
            this.serverMainSplitContainer.SplitterWidth = 5;
            this.serverMainSplitContainer.TabIndex = 8;
            // 
            // tabControlCliens
            // 
            this.tabControlCliens.Controls.Add(this.onlineClients);
            this.tabControlCliens.Controls.Add(this.offlinClients);
            this.tabControlCliens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlCliens.Location = new System.Drawing.Point(0, 0);
            this.tabControlCliens.Name = "tabControlCliens";
            this.tabControlCliens.SelectedIndex = 0;
            this.tabControlCliens.Size = new System.Drawing.Size(566, 422);
            this.tabControlCliens.TabIndex = 1;
            // 
            // onlineClients
            // 
            this.onlineClients.Location = new System.Drawing.Point(4, 22);
            this.onlineClients.Name = "onlineClients";
            this.onlineClients.Padding = new System.Windows.Forms.Padding(3);
            this.onlineClients.Size = new System.Drawing.Size(558, 396);
            this.onlineClients.TabIndex = 0;
            this.onlineClients.Text = "Online Clients";
            this.onlineClients.UseVisualStyleBackColor = true;
            // 
            // offlinClients
            // 
            this.offlinClients.Location = new System.Drawing.Point(4, 22);
            this.offlinClients.Name = "offlinClients";
            this.offlinClients.Padding = new System.Windows.Forms.Padding(3);
            this.offlinClients.Size = new System.Drawing.Size(620, 462);
            this.offlinClients.TabIndex = 1;
            this.offlinClients.Text = "Offline Clients";
            this.offlinClients.UseVisualStyleBackColor = true;
            // 
            // tabInfoContainer
            // 
            this.tabInfoContainer.Controls.Add(this.tabHardwarePage);
            this.tabInfoContainer.Controls.Add(this.tabProcessPage);
            this.tabInfoContainer.Controls.Add(this.tabServicePage);
            this.tabInfoContainer.Controls.Add(this.tabPageSchedule);
            this.tabInfoContainer.Controls.Add(this.tabpageStatistics);
            this.tabInfoContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabInfoContainer.Location = new System.Drawing.Point(0, 0);
            this.tabInfoContainer.Name = "tabInfoContainer";
            this.tabInfoContainer.SelectedIndex = 0;
            this.tabInfoContainer.Size = new System.Drawing.Size(581, 422);
            this.tabInfoContainer.TabIndex = 2;
            // 
            // tabHardwarePage
            // 
            this.tabHardwarePage.Controls.Add(this.tabControlHardware);
            this.tabHardwarePage.Location = new System.Drawing.Point(4, 22);
            this.tabHardwarePage.Name = "tabHardwarePage";
            this.tabHardwarePage.Padding = new System.Windows.Forms.Padding(3);
            this.tabHardwarePage.Size = new System.Drawing.Size(573, 396);
            this.tabHardwarePage.TabIndex = 0;
            this.tabHardwarePage.Text = "Hardware";
            this.tabHardwarePage.UseVisualStyleBackColor = true;
            // 
            // tabControlHardware
            // 
            this.tabControlHardware.Controls.Add(this.tabPageHardwareDetails);
            this.tabControlHardware.Controls.Add(this.tabPageHardwareUsage);
            this.tabControlHardware.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlHardware.Location = new System.Drawing.Point(3, 3);
            this.tabControlHardware.Name = "tabControlHardware";
            this.tabControlHardware.SelectedIndex = 0;
            this.tabControlHardware.Size = new System.Drawing.Size(567, 390);
            this.tabControlHardware.TabIndex = 2;
            // 
            // tabPageHardwareDetails
            // 
            this.tabPageHardwareDetails.Controls.Add(this.hardwareTreeView);
            this.tabPageHardwareDetails.Location = new System.Drawing.Point(4, 22);
            this.tabPageHardwareDetails.Name = "tabPageHardwareDetails";
            this.tabPageHardwareDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHardwareDetails.Size = new System.Drawing.Size(559, 364);
            this.tabPageHardwareDetails.TabIndex = 0;
            this.tabPageHardwareDetails.Text = "Details";
            this.tabPageHardwareDetails.UseVisualStyleBackColor = true;
            // 
            // hardwareTreeView
            // 
            this.hardwareTreeView.Dock = System.Windows.Forms.DockStyle.Left;
            this.hardwareTreeView.Location = new System.Drawing.Point(3, 3);
            this.hardwareTreeView.Name = "hardwareTreeView";
            treeNode17.Name = "ComputerID";
            treeNode17.Text = "ID: ";
            treeNode18.Name = "OperatingSystem";
            treeNode18.Text = "Operating System: ";
            treeNode19.Name = "ComputerName";
            treeNode19.Text = "Computer Name: ";
            treeNode20.Name = "ComputerDetails";
            treeNode20.Text = "Computer Details";
            treeNode21.ImageIndex = 1;
            treeNode21.Name = "CPUName";
            treeNode21.SelectedImageIndex = 1;
            treeNode21.Text = "Name: ";
            treeNode22.ImageIndex = 1;
            treeNode22.Name = "PhysicalCores";
            treeNode22.SelectedImageIndex = 1;
            treeNode22.Text = "Physical Cores: ";
            treeNode23.ImageIndex = 1;
            treeNode23.Name = "LogicalCores";
            treeNode23.SelectedImageIndex = 1;
            treeNode23.Text = "Logical Cores:";
            treeNode24.ImageIndex = 1;
            treeNode24.Name = "CPU";
            treeNode24.SelectedImageIndex = 1;
            treeNode24.Text = "CPU";
            treeNode25.ImageIndex = 3;
            treeNode25.Name = "MoboManufacturer";
            treeNode25.SelectedImageIndex = 3;
            treeNode25.Text = "Manufacturer:";
            treeNode26.ImageIndex = 3;
            treeNode26.Name = "MoboModel: ";
            treeNode26.SelectedImageIndex = 3;
            treeNode26.Text = "Model:";
            treeNode27.ImageIndex = 3;
            treeNode27.Name = "MoboSystemModel";
            treeNode27.SelectedImageIndex = 3;
            treeNode27.Text = "System Model: ";
            treeNode28.ImageIndex = 3;
            treeNode28.Name = "Motherboard";
            treeNode28.SelectedImageIndex = 3;
            treeNode28.Text = "Motherboard";
            treeNode29.ImageIndex = 4;
            treeNode29.Name = "Memory";
            treeNode29.SelectedImageIndex = 4;
            treeNode29.Text = "Memory";
            treeNode30.ImageIndex = 5;
            treeNode30.Name = "Storage";
            treeNode30.SelectedImageIndex = 5;
            treeNode30.Text = "Storage";
            treeNode31.ImageIndex = 2;
            treeNode31.Name = "Display";
            treeNode31.SelectedImageIndex = 2;
            treeNode31.Text = "Display Adapters";
            treeNode32.ImageIndex = 0;
            treeNode32.Name = "System";
            treeNode32.Text = "System";
            this.hardwareTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode32});
            this.hardwareTreeView.Size = new System.Drawing.Size(345, 358);
            this.hardwareTreeView.TabIndex = 0;
            // 
            // tabPageHardwareUsage
            // 
            this.tabPageHardwareUsage.Controls.Add(this.tblLayoutHardwareUsage);
            this.tabPageHardwareUsage.Location = new System.Drawing.Point(4, 22);
            this.tabPageHardwareUsage.Name = "tabPageHardwareUsage";
            this.tabPageHardwareUsage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHardwareUsage.Size = new System.Drawing.Size(642, 306);
            this.tabPageHardwareUsage.TabIndex = 1;
            this.tabPageHardwareUsage.Text = "Usage";
            this.tabPageHardwareUsage.UseVisualStyleBackColor = true;
            // 
            // tblLayoutHardwareUsage
            // 
            this.tblLayoutHardwareUsage.ColumnCount = 5;
            this.tblLayoutHardwareUsage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLayoutHardwareUsage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLayoutHardwareUsage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLayoutHardwareUsage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLayoutHardwareUsage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLayoutHardwareUsage.Controls.Add(this.grpBoxRAMUsage, 2, 0);
            this.tblLayoutHardwareUsage.Controls.Add(this.grpNetworkUsage, 0, 1);
            this.tblLayoutHardwareUsage.Controls.Add(this.grpBoxVolUsage, 2, 1);
            this.tblLayoutHardwareUsage.Controls.Add(this.grpBoxCPUUsage, 0, 0);
            this.tblLayoutHardwareUsage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutHardwareUsage.Location = new System.Drawing.Point(3, 3);
            this.tblLayoutHardwareUsage.Name = "tblLayoutHardwareUsage";
            this.tblLayoutHardwareUsage.RowCount = 3;
            this.tblLayoutHardwareUsage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblLayoutHardwareUsage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tblLayoutHardwareUsage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tblLayoutHardwareUsage.Size = new System.Drawing.Size(636, 300);
            this.tblLayoutHardwareUsage.TabIndex = 0;
            // 
            // grpBoxRAMUsage
            // 
            this.tblLayoutHardwareUsage.SetColumnSpan(this.grpBoxRAMUsage, 2);
            this.grpBoxRAMUsage.Controls.Add(this.lblInUseRAMAns);
            this.grpBoxRAMUsage.Controls.Add(this.lblInUseRAM);
            this.grpBoxRAMUsage.Controls.Add(this.lblFreeRAMAns);
            this.grpBoxRAMUsage.Controls.Add(this.lblTotalRAMAns);
            this.grpBoxRAMUsage.Controls.Add(this.lblFreeRAM);
            this.grpBoxRAMUsage.Controls.Add(this.lblTotalRAM);
            this.grpBoxRAMUsage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxRAMUsage.Location = new System.Drawing.Point(257, 3);
            this.grpBoxRAMUsage.Name = "grpBoxRAMUsage";
            this.grpBoxRAMUsage.Size = new System.Drawing.Size(248, 84);
            this.grpBoxRAMUsage.TabIndex = 2;
            this.grpBoxRAMUsage.TabStop = false;
            this.grpBoxRAMUsage.Text = "RAM";
            // 
            // lblInUseRAMAns
            // 
            this.lblInUseRAMAns.AutoSize = true;
            this.lblInUseRAMAns.Location = new System.Drawing.Point(76, 42);
            this.lblInUseRAMAns.Name = "lblInUseRAMAns";
            this.lblInUseRAMAns.Size = new System.Drawing.Size(13, 13);
            this.lblInUseRAMAns.TabIndex = 5;
            this.lblInUseRAMAns.Text = "0";
            // 
            // lblInUseRAM
            // 
            this.lblInUseRAM.AutoSize = true;
            this.lblInUseRAM.Location = new System.Drawing.Point(6, 42);
            this.lblInUseRAM.Name = "lblInUseRAM";
            this.lblInUseRAM.Size = new System.Drawing.Size(44, 13);
            this.lblInUseRAM.TabIndex = 4;
            this.lblInUseRAM.Text = "In Use: ";
            // 
            // lblFreeRAMAns
            // 
            this.lblFreeRAMAns.AutoSize = true;
            this.lblFreeRAMAns.Location = new System.Drawing.Point(76, 68);
            this.lblFreeRAMAns.Name = "lblFreeRAMAns";
            this.lblFreeRAMAns.Size = new System.Drawing.Size(13, 13);
            this.lblFreeRAMAns.TabIndex = 3;
            this.lblFreeRAMAns.Text = "0";
            // 
            // lblTotalRAMAns
            // 
            this.lblTotalRAMAns.AutoSize = true;
            this.lblTotalRAMAns.Location = new System.Drawing.Point(76, 16);
            this.lblTotalRAMAns.Name = "lblTotalRAMAns";
            this.lblTotalRAMAns.Size = new System.Drawing.Size(13, 13);
            this.lblTotalRAMAns.TabIndex = 2;
            this.lblTotalRAMAns.Text = "0";
            // 
            // lblFreeRAM
            // 
            this.lblFreeRAM.AutoSize = true;
            this.lblFreeRAM.Location = new System.Drawing.Point(6, 68);
            this.lblFreeRAM.Name = "lblFreeRAM";
            this.lblFreeRAM.Size = new System.Drawing.Size(61, 13);
            this.lblFreeRAM.TabIndex = 1;
            this.lblFreeRAM.Text = "Free RAM: ";
            // 
            // lblTotalRAM
            // 
            this.lblTotalRAM.AutoSize = true;
            this.lblTotalRAM.Location = new System.Drawing.Point(6, 16);
            this.lblTotalRAM.Name = "lblTotalRAM";
            this.lblTotalRAM.Size = new System.Drawing.Size(64, 13);
            this.lblTotalRAM.TabIndex = 0;
            this.lblTotalRAM.Text = "Total RAM: ";
            // 
            // grpNetworkUsage
            // 
            this.tblLayoutHardwareUsage.SetColumnSpan(this.grpNetworkUsage, 2);
            this.grpNetworkUsage.Controls.Add(this.txtBoxNetworkUsage);
            this.grpNetworkUsage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpNetworkUsage.Location = new System.Drawing.Point(3, 93);
            this.grpNetworkUsage.Name = "grpNetworkUsage";
            this.tblLayoutHardwareUsage.SetRowSpan(this.grpNetworkUsage, 2);
            this.grpNetworkUsage.Size = new System.Drawing.Size(248, 204);
            this.grpNetworkUsage.TabIndex = 1;
            this.grpNetworkUsage.TabStop = false;
            this.grpNetworkUsage.Text = "Network";
            // 
            // txtBoxNetworkUsage
            // 
            this.txtBoxNetworkUsage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxNetworkUsage.Location = new System.Drawing.Point(1, 20);
            this.txtBoxNetworkUsage.Name = "txtBoxNetworkUsage";
            this.txtBoxNetworkUsage.Size = new System.Drawing.Size(199, 271);
            this.txtBoxNetworkUsage.TabIndex = 0;
            this.txtBoxNetworkUsage.Text = "";
            // 
            // grpBoxVolUsage
            // 
            this.tblLayoutHardwareUsage.SetColumnSpan(this.grpBoxVolUsage, 3);
            this.grpBoxVolUsage.Controls.Add(this.txtBoxVolUsage);
            this.grpBoxVolUsage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxVolUsage.Location = new System.Drawing.Point(257, 93);
            this.grpBoxVolUsage.Name = "grpBoxVolUsage";
            this.tblLayoutHardwareUsage.SetRowSpan(this.grpBoxVolUsage, 2);
            this.grpBoxVolUsage.Size = new System.Drawing.Size(376, 204);
            this.grpBoxVolUsage.TabIndex = 3;
            this.grpBoxVolUsage.TabStop = false;
            this.grpBoxVolUsage.Text = "Hard Drives";
            // 
            // txtBoxVolUsage
            // 
            this.txtBoxVolUsage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxVolUsage.Location = new System.Drawing.Point(7, 20);
            this.txtBoxVolUsage.Name = "txtBoxVolUsage";
            this.txtBoxVolUsage.Size = new System.Drawing.Size(305, 271);
            this.txtBoxVolUsage.TabIndex = 0;
            this.txtBoxVolUsage.Text = "";
            // 
            // grpBoxCPUUsage
            // 
            this.tblLayoutHardwareUsage.SetColumnSpan(this.grpBoxCPUUsage, 2);
            this.grpBoxCPUUsage.Controls.Add(this.lblThreadsAns);
            this.grpBoxCPUUsage.Controls.Add(this.lblProcessesAns);
            this.grpBoxCPUUsage.Controls.Add(this.lblCPUUsageAns);
            this.grpBoxCPUUsage.Controls.Add(this.lblUptimeAns);
            this.grpBoxCPUUsage.Controls.Add(this.lblNumthreads);
            this.grpBoxCPUUsage.Controls.Add(this.lblNumProcesses);
            this.grpBoxCPUUsage.Controls.Add(this.lblCPUUsage);
            this.grpBoxCPUUsage.Controls.Add(this.lblUptime);
            this.grpBoxCPUUsage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxCPUUsage.Location = new System.Drawing.Point(3, 3);
            this.grpBoxCPUUsage.Name = "grpBoxCPUUsage";
            this.grpBoxCPUUsage.Size = new System.Drawing.Size(248, 84);
            this.grpBoxCPUUsage.TabIndex = 0;
            this.grpBoxCPUUsage.TabStop = false;
            this.grpBoxCPUUsage.Text = "CPU";
            // 
            // lblThreadsAns
            // 
            this.lblThreadsAns.AutoSize = true;
            this.lblThreadsAns.Location = new System.Drawing.Point(96, 87);
            this.lblThreadsAns.Name = "lblThreadsAns";
            this.lblThreadsAns.Size = new System.Drawing.Size(13, 13);
            this.lblThreadsAns.TabIndex = 7;
            this.lblThreadsAns.Text = "0";
            // 
            // lblProcessesAns
            // 
            this.lblProcessesAns.AutoSize = true;
            this.lblProcessesAns.Location = new System.Drawing.Point(96, 63);
            this.lblProcessesAns.Name = "lblProcessesAns";
            this.lblProcessesAns.Size = new System.Drawing.Size(13, 13);
            this.lblProcessesAns.TabIndex = 6;
            this.lblProcessesAns.Text = "0";
            // 
            // lblCPUUsageAns
            // 
            this.lblCPUUsageAns.AutoSize = true;
            this.lblCPUUsageAns.Location = new System.Drawing.Point(96, 40);
            this.lblCPUUsageAns.Name = "lblCPUUsageAns";
            this.lblCPUUsageAns.Size = new System.Drawing.Size(13, 13);
            this.lblCPUUsageAns.TabIndex = 5;
            this.lblCPUUsageAns.Text = "0";
            // 
            // lblUptimeAns
            // 
            this.lblUptimeAns.AutoSize = true;
            this.lblUptimeAns.Location = new System.Drawing.Point(96, 16);
            this.lblUptimeAns.Name = "lblUptimeAns";
            this.lblUptimeAns.Size = new System.Drawing.Size(13, 13);
            this.lblUptimeAns.TabIndex = 4;
            this.lblUptimeAns.Text = "0";
            // 
            // lblNumthreads
            // 
            this.lblNumthreads.AutoSize = true;
            this.lblNumthreads.Location = new System.Drawing.Point(6, 87);
            this.lblNumthreads.Name = "lblNumthreads";
            this.lblNumthreads.Size = new System.Drawing.Size(46, 13);
            this.lblNumthreads.TabIndex = 3;
            this.lblNumthreads.Text = "Threads";
            // 
            // lblNumProcesses
            // 
            this.lblNumProcesses.AutoSize = true;
            this.lblNumProcesses.Location = new System.Drawing.Point(6, 63);
            this.lblNumProcesses.Name = "lblNumProcesses";
            this.lblNumProcesses.Size = new System.Drawing.Size(62, 13);
            this.lblNumProcesses.TabIndex = 2;
            this.lblNumProcesses.Text = "Processes: ";
            // 
            // lblCPUUsage
            // 
            this.lblCPUUsage.AutoSize = true;
            this.lblCPUUsage.Location = new System.Drawing.Point(6, 40);
            this.lblCPUUsage.Name = "lblCPUUsage";
            this.lblCPUUsage.Size = new System.Drawing.Size(58, 13);
            this.lblCPUUsage.TabIndex = 1;
            this.lblCPUUsage.Text = "Utilisation: ";
            // 
            // lblUptime
            // 
            this.lblUptime.AutoSize = true;
            this.lblUptime.Location = new System.Drawing.Point(6, 16);
            this.lblUptime.Name = "lblUptime";
            this.lblUptime.Size = new System.Drawing.Size(83, 13);
            this.lblUptime.TabIndex = 0;
            this.lblUptime.Text = "System Uptime: ";
            // 
            // tabProcessPage
            // 
            this.tabProcessPage.Controls.Add(this.dataGridProcess);
            this.tabProcessPage.Location = new System.Drawing.Point(4, 22);
            this.tabProcessPage.Name = "tabProcessPage";
            this.tabProcessPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabProcessPage.Size = new System.Drawing.Size(635, 462);
            this.tabProcessPage.TabIndex = 1;
            this.tabProcessPage.Text = "Processes";
            this.tabProcessPage.UseVisualStyleBackColor = true;
            // 
            // dataGridProcess
            // 
            this.dataGridProcess.AllowUserToAddRows = false;
            this.dataGridProcess.AllowUserToDeleteRows = false;
            this.dataGridProcess.AllowUserToOrderColumns = true;
            this.dataGridProcess.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridProcess.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridProcess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridProcess.Location = new System.Drawing.Point(3, 3);
            this.dataGridProcess.Name = "dataGridProcess";
            this.dataGridProcess.ReadOnly = true;
            this.dataGridProcess.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridProcess.ShowCellErrors = false;
            this.dataGridProcess.ShowCellToolTips = false;
            this.dataGridProcess.ShowEditingIcon = false;
            this.dataGridProcess.ShowRowErrors = false;
            this.dataGridProcess.Size = new System.Drawing.Size(629, 456);
            this.dataGridProcess.TabIndex = 0;
            // 
            // tabServicePage
            // 
            this.tabServicePage.Controls.Add(this.dataGridService);
            this.tabServicePage.Location = new System.Drawing.Point(4, 22);
            this.tabServicePage.Name = "tabServicePage";
            this.tabServicePage.Size = new System.Drawing.Size(635, 462);
            this.tabServicePage.TabIndex = 2;
            this.tabServicePage.Text = "Services";
            this.tabServicePage.UseVisualStyleBackColor = true;
            // 
            // dataGridService
            // 
            this.dataGridService.AllowUserToAddRows = false;
            this.dataGridService.AllowUserToDeleteRows = false;
            this.dataGridService.AllowUserToOrderColumns = true;
            this.dataGridService.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridService.Location = new System.Drawing.Point(0, 0);
            this.dataGridService.MultiSelect = false;
            this.dataGridService.Name = "dataGridService";
            this.dataGridService.ReadOnly = true;
            this.dataGridService.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridService.Size = new System.Drawing.Size(635, 462);
            this.dataGridService.TabIndex = 0;
            // 
            // tabPageSchedule
            // 
            this.tabPageSchedule.Controls.Add(this.button9);
            this.tabPageSchedule.Controls.Add(this.button8);
            this.tabPageSchedule.Controls.Add(this.tabControl1);
            this.tabPageSchedule.Controls.Add(this.dataGridTask);
            this.tabPageSchedule.Location = new System.Drawing.Point(4, 22);
            this.tabPageSchedule.Name = "tabPageSchedule";
            this.tabPageSchedule.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSchedule.Size = new System.Drawing.Size(635, 462);
            this.tabPageSchedule.TabIndex = 3;
            this.tabPageSchedule.Text = "Scheduled Tasks";
            this.tabPageSchedule.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(115, 435);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(99, 23);
            this.button9.TabIndex = 8;
            this.button9.Text = "Delete Task";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(10, 435);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(99, 23);
            this.button8.TabIndex = 7;
            this.button8.Text = "Add New Task";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(3, 198);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(607, 236);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.dataGridTaskTrigger);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(599, 210);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Triggers";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(389, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Add New Trigger";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(494, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Delete Trigger";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridTaskTrigger
            // 
            this.dataGridTaskTrigger.AllowUserToAddRows = false;
            this.dataGridTaskTrigger.AllowUserToDeleteRows = false;
            this.dataGridTaskTrigger.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridTaskTrigger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTaskTrigger.Location = new System.Drawing.Point(3, 3);
            this.dataGridTaskTrigger.MultiSelect = false;
            this.dataGridTaskTrigger.Name = "dataGridTaskTrigger";
            this.dataGridTaskTrigger.ReadOnly = true;
            this.dataGridTaskTrigger.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridTaskTrigger.Size = new System.Drawing.Size(596, 170);
            this.dataGridTaskTrigger.TabIndex = 2;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button3);
            this.tabPage4.Controls.Add(this.button4);
            this.tabPage4.Controls.Add(this.dataGridTaskAction);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(599, 210);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "Actions";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(390, 182);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Add New Action";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(495, 182);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Delete Action";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dataGridTaskAction
            // 
            this.dataGridTaskAction.AllowUserToAddRows = false;
            this.dataGridTaskAction.AllowUserToDeleteRows = false;
            this.dataGridTaskAction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridTaskAction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTaskAction.Location = new System.Drawing.Point(3, 3);
            this.dataGridTaskAction.MultiSelect = false;
            this.dataGridTaskAction.Name = "dataGridTaskAction";
            this.dataGridTaskAction.ReadOnly = true;
            this.dataGridTaskAction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridTaskAction.Size = new System.Drawing.Size(596, 170);
            this.dataGridTaskAction.TabIndex = 5;
            // 
            // dataGridTask
            // 
            this.dataGridTask.AllowUserToAddRows = false;
            this.dataGridTask.AllowUserToDeleteRows = false;
            this.dataGridTask.AllowUserToResizeColumns = false;
            this.dataGridTask.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTask.Location = new System.Drawing.Point(0, 0);
            this.dataGridTask.MultiSelect = false;
            this.dataGridTask.Name = "dataGridTask";
            this.dataGridTask.ReadOnly = true;
            this.dataGridTask.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridTask.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridTask.Size = new System.Drawing.Size(617, 192);
            this.dataGridTask.TabIndex = 1;
            // 
            // tabpageStatistics
            // 
            this.tabpageStatistics.Controls.Add(this.tblLayoutStats);
            this.tabpageStatistics.Location = new System.Drawing.Point(4, 22);
            this.tabpageStatistics.Name = "tabpageStatistics";
            this.tabpageStatistics.Size = new System.Drawing.Size(635, 462);
            this.tabpageStatistics.TabIndex = 4;
            this.tabpageStatistics.Text = "Network Statistics";
            this.tabpageStatistics.UseVisualStyleBackColor = true;
            // 
            // tblLayoutStats
            // 
            this.tblLayoutStats.ColumnCount = 2;
            this.tblLayoutStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblLayoutStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tblLayoutStats.Controls.Add(this.flowLayoutStatLabels, 0, 0);
            this.tblLayoutStats.Controls.Add(this.flowLayoutStatText, 1, 0);
            this.tblLayoutStats.Dock = System.Windows.Forms.DockStyle.Left;
            this.tblLayoutStats.Location = new System.Drawing.Point(0, 0);
            this.tblLayoutStats.Name = "tblLayoutStats";
            this.tblLayoutStats.RowCount = 1;
            this.tblLayoutStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutStats.Size = new System.Drawing.Size(474, 462);
            this.tblLayoutStats.TabIndex = 0;
            // 
            // flowLayoutStatLabels
            // 
            this.flowLayoutStatLabels.Controls.Add(this.lblCommonProcessor);
            this.flowLayoutStatLabels.Controls.Add(this.lblMostCommonMobo);
            this.flowLayoutStatLabels.Controls.Add(this.lblMostCommonDisplay);
            this.flowLayoutStatLabels.Controls.Add(this.lblAverageRAM);
            this.flowLayoutStatLabels.Controls.Add(this.lblAverageStorage);
            this.flowLayoutStatLabels.Controls.Add(this.lblAvgUptime);
            this.flowLayoutStatLabels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutStatLabels.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutStatLabels.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutStatLabels.Name = "flowLayoutStatLabels";
            this.flowLayoutStatLabels.Size = new System.Drawing.Size(183, 456);
            this.flowLayoutStatLabels.TabIndex = 0;
            // 
            // lblCommonProcessor
            // 
            this.lblCommonProcessor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCommonProcessor.AutoSize = true;
            this.lblCommonProcessor.Location = new System.Drawing.Point(27, 5);
            this.lblCommonProcessor.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblCommonProcessor.Name = "lblCommonProcessor";
            this.lblCommonProcessor.Size = new System.Drawing.Size(130, 13);
            this.lblCommonProcessor.TabIndex = 0;
            this.lblCommonProcessor.Text = "Most Common Processor: ";
            // 
            // lblMostCommonMobo
            // 
            this.lblMostCommonMobo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMostCommonMobo.AutoSize = true;
            this.lblMostCommonMobo.Location = new System.Drawing.Point(20, 28);
            this.lblMostCommonMobo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblMostCommonMobo.Name = "lblMostCommonMobo";
            this.lblMostCommonMobo.Size = new System.Drawing.Size(137, 13);
            this.lblMostCommonMobo.TabIndex = 1;
            this.lblMostCommonMobo.Text = "Most Common Motherboard";
            // 
            // lblMostCommonDisplay
            // 
            this.lblMostCommonDisplay.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMostCommonDisplay.AutoSize = true;
            this.lblMostCommonDisplay.Location = new System.Drawing.Point(6, 51);
            this.lblMostCommonDisplay.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblMostCommonDisplay.Name = "lblMostCommonDisplay";
            this.lblMostCommonDisplay.Size = new System.Drawing.Size(151, 13);
            this.lblMostCommonDisplay.TabIndex = 2;
            this.lblMostCommonDisplay.Text = "Most Common Display Adapter";
            // 
            // lblAverageRAM
            // 
            this.lblAverageRAM.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAverageRAM.AutoSize = true;
            this.lblAverageRAM.Location = new System.Drawing.Point(82, 74);
            this.lblAverageRAM.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblAverageRAM.Name = "lblAverageRAM";
            this.lblAverageRAM.Size = new System.Drawing.Size(75, 13);
            this.lblAverageRAM.TabIndex = 3;
            this.lblAverageRAM.Text = "Average Ram:";
            // 
            // lblAverageStorage
            // 
            this.lblAverageStorage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAverageStorage.AutoSize = true;
            this.lblAverageStorage.Location = new System.Drawing.Point(64, 97);
            this.lblAverageStorage.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblAverageStorage.Name = "lblAverageStorage";
            this.lblAverageStorage.Size = new System.Drawing.Size(93, 13);
            this.lblAverageStorage.TabIndex = 4;
            this.lblAverageStorage.Text = "Average Storage: ";
            // 
            // lblAvgUptime
            // 
            this.lblAvgUptime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAvgUptime.AutoSize = true;
            this.lblAvgUptime.Location = new System.Drawing.Point(3, 120);
            this.lblAvgUptime.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblAvgUptime.Name = "lblAvgUptime";
            this.lblAvgUptime.Size = new System.Drawing.Size(154, 13);
            this.lblAvgUptime.TabIndex = 5;
            this.lblAvgUptime.Text = "Average Uptime Last 30 Days: ";
            // 
            // flowLayoutStatText
            // 
            this.flowLayoutStatText.Controls.Add(this.lblCommonProcessorAns);
            this.flowLayoutStatText.Controls.Add(this.lblCommonMoboAns);
            this.flowLayoutStatText.Controls.Add(this.lblCommonDisplayAns);
            this.flowLayoutStatText.Controls.Add(this.lblAverageRAMAns);
            this.flowLayoutStatText.Controls.Add(this.lblAverageStorageAns);
            this.flowLayoutStatText.Controls.Add(this.lblAvgUptimeAns);
            this.flowLayoutStatText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutStatText.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutStatText.Location = new System.Drawing.Point(192, 3);
            this.flowLayoutStatText.Name = "flowLayoutStatText";
            this.flowLayoutStatText.Size = new System.Drawing.Size(279, 456);
            this.flowLayoutStatText.TabIndex = 1;
            // 
            // lblCommonProcessorAns
            // 
            this.lblCommonProcessorAns.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCommonProcessorAns.AutoSize = true;
            this.lblCommonProcessorAns.Location = new System.Drawing.Point(3, 5);
            this.lblCommonProcessorAns.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblCommonProcessorAns.Name = "lblCommonProcessorAns";
            this.lblCommonProcessorAns.Size = new System.Drawing.Size(43, 13);
            this.lblCommonProcessorAns.TabIndex = 0;
            this.lblCommonProcessorAns.Text = "Not Set";
            // 
            // lblCommonMoboAns
            // 
            this.lblCommonMoboAns.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCommonMoboAns.AutoSize = true;
            this.lblCommonMoboAns.Location = new System.Drawing.Point(3, 28);
            this.lblCommonMoboAns.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblCommonMoboAns.Name = "lblCommonMoboAns";
            this.lblCommonMoboAns.Size = new System.Drawing.Size(43, 13);
            this.lblCommonMoboAns.TabIndex = 1;
            this.lblCommonMoboAns.Text = "Not Set";
            // 
            // lblCommonDisplayAns
            // 
            this.lblCommonDisplayAns.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCommonDisplayAns.AutoSize = true;
            this.lblCommonDisplayAns.Location = new System.Drawing.Point(3, 51);
            this.lblCommonDisplayAns.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblCommonDisplayAns.Name = "lblCommonDisplayAns";
            this.lblCommonDisplayAns.Size = new System.Drawing.Size(43, 13);
            this.lblCommonDisplayAns.TabIndex = 2;
            this.lblCommonDisplayAns.Text = "Not Set";
            // 
            // lblAverageRAMAns
            // 
            this.lblAverageRAMAns.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAverageRAMAns.AutoSize = true;
            this.lblAverageRAMAns.Location = new System.Drawing.Point(3, 74);
            this.lblAverageRAMAns.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblAverageRAMAns.Name = "lblAverageRAMAns";
            this.lblAverageRAMAns.Size = new System.Drawing.Size(43, 13);
            this.lblAverageRAMAns.TabIndex = 3;
            this.lblAverageRAMAns.Text = "Not Set";
            // 
            // lblAverageStorageAns
            // 
            this.lblAverageStorageAns.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAverageStorageAns.AutoSize = true;
            this.lblAverageStorageAns.Location = new System.Drawing.Point(3, 97);
            this.lblAverageStorageAns.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblAverageStorageAns.Name = "lblAverageStorageAns";
            this.lblAverageStorageAns.Size = new System.Drawing.Size(43, 13);
            this.lblAverageStorageAns.TabIndex = 4;
            this.lblAverageStorageAns.Text = "Not Set";
            // 
            // lblAvgUptimeAns
            // 
            this.lblAvgUptimeAns.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAvgUptimeAns.AutoSize = true;
            this.lblAvgUptimeAns.Location = new System.Drawing.Point(3, 120);
            this.lblAvgUptimeAns.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblAvgUptimeAns.Name = "lblAvgUptimeAns";
            this.lblAvgUptimeAns.Size = new System.Drawing.Size(43, 13);
            this.lblAvgUptimeAns.TabIndex = 5;
            this.lblAvgUptimeAns.Text = "Not Set";
            // 
            // HorusAdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 450);
            this.Controls.Add(this.serverMainSplitContainer);
            this.Controls.Add(this.menuStrip);
            this.Name = "HorusAdminMain";
            this.Text = "Horus";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.serverMainSplitContainer.Panel1.ResumeLayout(false);
            this.serverMainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.serverMainSplitContainer)).EndInit();
            this.serverMainSplitContainer.ResumeLayout(false);
            this.tabControlCliens.ResumeLayout(false);
            this.tabInfoContainer.ResumeLayout(false);
            this.tabHardwarePage.ResumeLayout(false);
            this.tabControlHardware.ResumeLayout(false);
            this.tabPageHardwareDetails.ResumeLayout(false);
            this.tabPageHardwareUsage.ResumeLayout(false);
            this.tblLayoutHardwareUsage.ResumeLayout(false);
            this.grpBoxRAMUsage.ResumeLayout(false);
            this.grpBoxRAMUsage.PerformLayout();
            this.grpNetworkUsage.ResumeLayout(false);
            this.grpBoxVolUsage.ResumeLayout(false);
            this.grpBoxCPUUsage.ResumeLayout(false);
            this.grpBoxCPUUsage.PerformLayout();
            this.tabProcessPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProcess)).EndInit();
            this.tabServicePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridService)).EndInit();
            this.tabPageSchedule.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTaskTrigger)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTaskAction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTask)).EndInit();
            this.tabpageStatistics.ResumeLayout(false);
            this.tblLayoutStats.ResumeLayout(false);
            this.flowLayoutStatLabels.ResumeLayout(false);
            this.flowLayoutStatLabels.PerformLayout();
            this.flowLayoutStatText.ResumeLayout(false);
            this.flowLayoutStatText.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.SplitContainer serverMainSplitContainer;
        private System.Windows.Forms.TabControl tabControlCliens;
        private System.Windows.Forms.TabPage onlineClients;
        private System.Windows.Forms.TabPage offlinClients;
        private System.Windows.Forms.TabControl tabInfoContainer;
        private System.Windows.Forms.TabPage tabHardwarePage;
        private System.Windows.Forms.TabControl tabControlHardware;
        private System.Windows.Forms.TabPage tabPageHardwareDetails;
        private System.Windows.Forms.TreeView hardwareTreeView;
        private System.Windows.Forms.TabPage tabPageHardwareUsage;
        private System.Windows.Forms.TableLayoutPanel tblLayoutHardwareUsage;
        private System.Windows.Forms.GroupBox grpBoxRAMUsage;
        private System.Windows.Forms.Label lblInUseRAMAns;
        private System.Windows.Forms.Label lblInUseRAM;
        private System.Windows.Forms.Label lblFreeRAMAns;
        private System.Windows.Forms.Label lblTotalRAMAns;
        private System.Windows.Forms.Label lblFreeRAM;
        private System.Windows.Forms.Label lblTotalRAM;
        private System.Windows.Forms.GroupBox grpNetworkUsage;
        private System.Windows.Forms.RichTextBox txtBoxNetworkUsage;
        private System.Windows.Forms.GroupBox grpBoxVolUsage;
        private System.Windows.Forms.RichTextBox txtBoxVolUsage;
        private System.Windows.Forms.GroupBox grpBoxCPUUsage;
        private System.Windows.Forms.Label lblThreadsAns;
        private System.Windows.Forms.Label lblProcessesAns;
        private System.Windows.Forms.Label lblCPUUsageAns;
        private System.Windows.Forms.Label lblUptimeAns;
        private System.Windows.Forms.Label lblNumthreads;
        private System.Windows.Forms.Label lblNumProcesses;
        private System.Windows.Forms.Label lblCPUUsage;
        private System.Windows.Forms.Label lblUptime;
        private System.Windows.Forms.TabPage tabProcessPage;
        private System.Windows.Forms.DataGridView dataGridProcess;
        private System.Windows.Forms.TabPage tabServicePage;
        private System.Windows.Forms.DataGridView dataGridService;
        private System.Windows.Forms.TabPage tabPageSchedule;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridTaskTrigger;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridTaskAction;
        private System.Windows.Forms.DataGridView dataGridTask;
        private System.Windows.Forms.TabPage tabpageStatistics;
        private System.Windows.Forms.TableLayoutPanel tblLayoutStats;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutStatLabels;
        private System.Windows.Forms.Label lblCommonProcessor;
        private System.Windows.Forms.Label lblMostCommonMobo;
        private System.Windows.Forms.Label lblMostCommonDisplay;
        private System.Windows.Forms.Label lblAverageRAM;
        private System.Windows.Forms.Label lblAverageStorage;
        private System.Windows.Forms.Label lblAvgUptime;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutStatText;
        private System.Windows.Forms.Label lblCommonProcessorAns;
        private System.Windows.Forms.Label lblCommonMoboAns;
        private System.Windows.Forms.Label lblCommonDisplayAns;
        private System.Windows.Forms.Label lblAverageRAMAns;
        private System.Windows.Forms.Label lblAverageStorageAns;
        private System.Windows.Forms.Label lblAvgUptimeAns;
    }
}