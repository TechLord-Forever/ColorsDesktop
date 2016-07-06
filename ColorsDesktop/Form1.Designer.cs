namespace ColorsDesktop
{
    partial class MainWindow
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
            System.Windows.Forms.StatusStrip statusStrip;
            System.Windows.Forms.PictureBox pictureBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.toolStripStatusIcon = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.tabControlMainTab = new System.Windows.Forms.TabControl();
            this.tabPageSearch = new System.Windows.Forms.TabPage();
            this.listViewSearchResults = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.tabPageSeries = new System.Windows.Forms.TabPage();
            this.numericUpDownSeries_Start = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxSeries_Title = new System.Windows.Forms.TextBox();
            this.buttonSeries_Clear = new System.Windows.Forms.Button();
            this.buttonSeries_Fetch10 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxSeries_Synopsis = new System.Windows.Forms.TextBox();
            this.textBoxSeries_TotalEpisodes = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxSeries_Name = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxSeries_ID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.listViewSeries_FetchResults = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label11 = new System.Windows.Forms.Label();
            this.tabPageEpisode = new System.Windows.Forms.TabPage();
            this.textBoxEpisode_Predm3u8 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxEpisode_EntryId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxEpisode_Number = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonFetch = new System.Windows.Forms.Button();
            this.listViewEpisode_Links = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxEpisode_URL = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxEpisode_MainTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxEpisode_ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxEpisode_Synopsis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEpisode_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageOptions = new System.Windows.Forms.TabPage();
            this.buttonOptions_ClearSettings = new System.Windows.Forms.Button();
            this.buttonOptions_SaveSettings = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxOptions_ProxyAddr = new System.Windows.Forms.TextBox();
            this.numericUpDownOptions_ProxyPort = new System.Windows.Forms.NumericUpDown();
            this.radioButtonOptions_ProxyCustom = new System.Windows.Forms.RadioButton();
            this.radioButtonOptions_ProxySystem = new System.Windows.Forms.RadioButton();
            this.radioButtonOptions_ProxyNone = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPageAbout = new System.Windows.Forms.TabPage();
            this.tabPageLog = new System.Windows.Forms.TabPage();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.imageListTabs = new System.Windows.Forms.ImageList(this.components);
            this.backgroundWorkerSearch = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerFetch = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerSeries = new System.ComponentModel.BackgroundWorker();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label18 = new System.Windows.Forms.Label();
            statusStrip = new System.Windows.Forms.StatusStrip();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.tabControlMainTab.SuspendLayout();
            this.tabPageSearch.SuspendLayout();
            this.tabPageSeries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeries_Start)).BeginInit();
            this.tabPageEpisode.SuspendLayout();
            this.tabPageOptions.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOptions_ProxyPort)).BeginInit();
            this.tabPageAbout.SuspendLayout();
            this.tabPageLog.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusIcon,
            this.toolStripStatusLabel,
            this.toolStripProgressBar});
            statusStrip.Location = new System.Drawing.Point(0, 436);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new System.Drawing.Size(751, 22);
            statusStrip.TabIndex = 1;
            statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusIcon
            // 
            this.toolStripStatusIcon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripStatusIcon.Image = global::ColorsDesktop.Properties.Resources.accept;
            this.toolStripStatusIcon.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripStatusIcon.Name = "toolStripStatusIcon";
            this.toolStripStatusIcon.Size = new System.Drawing.Size(16, 17);
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripStatusLabel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(568, 17);
            this.toolStripStatusLabel.Spring = true;
            this.toolStripStatusLabel.Text = "Ready";
            this.toolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(150, 16);
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            pictureBox1.Image = global::ColorsDesktop.Properties.Resources.logo;
            pictureBox1.Location = new System.Drawing.Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(713, 388);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tabControlMainTab
            // 
            this.tabControlMainTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMainTab.Controls.Add(this.tabPageSearch);
            this.tabControlMainTab.Controls.Add(this.tabPageSeries);
            this.tabControlMainTab.Controls.Add(this.tabPageEpisode);
            this.tabControlMainTab.Controls.Add(this.tabPage1);
            this.tabControlMainTab.Controls.Add(this.tabPageOptions);
            this.tabControlMainTab.Controls.Add(this.tabPageAbout);
            this.tabControlMainTab.Controls.Add(this.tabPageLog);
            this.tabControlMainTab.ImageList = this.imageListTabs;
            this.tabControlMainTab.Location = new System.Drawing.Point(12, 12);
            this.tabControlMainTab.Multiline = true;
            this.tabControlMainTab.Name = "tabControlMainTab";
            this.tabControlMainTab.SelectedIndex = 0;
            this.tabControlMainTab.Size = new System.Drawing.Size(727, 421);
            this.tabControlMainTab.TabIndex = 0;
            // 
            // tabPageSearch
            // 
            this.tabPageSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPageSearch.Controls.Add(this.listViewSearchResults);
            this.tabPageSearch.Controls.Add(this.buttonSearch);
            this.tabPageSearch.Controls.Add(this.textBoxSearch);
            this.tabPageSearch.ImageIndex = 0;
            this.tabPageSearch.Location = new System.Drawing.Point(4, 23);
            this.tabPageSearch.Name = "tabPageSearch";
            this.tabPageSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearch.Size = new System.Drawing.Size(719, 394);
            this.tabPageSearch.TabIndex = 0;
            this.tabPageSearch.Text = "Search";
            this.tabPageSearch.UseVisualStyleBackColor = true;
            // 
            // listViewSearchResults
            // 
            this.listViewSearchResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewSearchResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewSearchResults.FullRowSelect = true;
            this.listViewSearchResults.GridLines = true;
            this.listViewSearchResults.HideSelection = false;
            this.listViewSearchResults.Location = new System.Drawing.Point(7, 32);
            this.listViewSearchResults.MultiSelect = false;
            this.listViewSearchResults.Name = "listViewSearchResults";
            this.listViewSearchResults.ShowGroups = false;
            this.listViewSearchResults.Size = new System.Drawing.Size(707, 361);
            this.listViewSearchResults.TabIndex = 1;
            this.listViewSearchResults.UseCompatibleStateImageBehavior = false;
            this.listViewSearchResults.View = System.Windows.Forms.View.Details;
            this.listViewSearchResults.DoubleClick += new System.EventHandler(this.listViewSearchResults_DoubleClick);
            this.listViewSearchResults.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listViewSearchResults_KeyPress);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Type";
            this.columnHeader2.Width = 103;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Description";
            this.columnHeader3.Width = 473;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonSearch.Image = global::ColorsDesktop.Properties.Resources.search;
            this.buttonSearch.Location = new System.Drawing.Point(682, 6);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(35, 20);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Location = new System.Drawing.Point(6, 6);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(670, 20);
            this.textBoxSearch.TabIndex = 0;
            this.textBoxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSearch_KeyPress);
            // 
            // tabPageSeries
            // 
            this.tabPageSeries.Controls.Add(this.numericUpDownSeries_Start);
            this.tabPageSeries.Controls.Add(this.label17);
            this.tabPageSeries.Controls.Add(this.textBoxSeries_Title);
            this.tabPageSeries.Controls.Add(this.buttonSeries_Clear);
            this.tabPageSeries.Controls.Add(this.buttonSeries_Fetch10);
            this.tabPageSeries.Controls.Add(this.label16);
            this.tabPageSeries.Controls.Add(this.textBoxSeries_Synopsis);
            this.tabPageSeries.Controls.Add(this.textBoxSeries_TotalEpisodes);
            this.tabPageSeries.Controls.Add(this.label15);
            this.tabPageSeries.Controls.Add(this.textBoxSeries_Name);
            this.tabPageSeries.Controls.Add(this.label14);
            this.tabPageSeries.Controls.Add(this.textBoxSeries_ID);
            this.tabPageSeries.Controls.Add(this.label13);
            this.tabPageSeries.Controls.Add(this.listViewSeries_FetchResults);
            this.tabPageSeries.Controls.Add(this.label11);
            this.tabPageSeries.ImageIndex = 3;
            this.tabPageSeries.Location = new System.Drawing.Point(4, 23);
            this.tabPageSeries.Name = "tabPageSeries";
            this.tabPageSeries.Size = new System.Drawing.Size(719, 394);
            this.tabPageSeries.TabIndex = 2;
            this.tabPageSeries.Text = "Series";
            this.tabPageSeries.UseVisualStyleBackColor = true;
            // 
            // numericUpDownSeries_Start
            // 
            this.numericUpDownSeries_Start.Location = new System.Drawing.Point(51, 169);
            this.numericUpDownSeries_Start.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDownSeries_Start.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSeries_Start.Name = "numericUpDownSeries_Start";
            this.numericUpDownSeries_Start.Size = new System.Drawing.Size(94, 20);
            this.numericUpDownSeries_Start.TabIndex = 18;
            this.numericUpDownSeries_Start.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSeries_Start.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericUpDownSeries_Start_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(321, 18);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(30, 13);
            this.label17.TabIndex = 17;
            this.label17.Text = "Title:";
            // 
            // textBoxSeries_Title
            // 
            this.textBoxSeries_Title.Location = new System.Drawing.Point(357, 15);
            this.textBoxSeries_Title.Name = "textBoxSeries_Title";
            this.textBoxSeries_Title.ReadOnly = true;
            this.textBoxSeries_Title.Size = new System.Drawing.Size(169, 20);
            this.textBoxSeries_Title.TabIndex = 16;
            // 
            // buttonSeries_Clear
            // 
            this.buttonSeries_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSeries_Clear.Image = global::ColorsDesktop.Properties.Resources.table_delete;
            this.buttonSeries_Clear.Location = new System.Drawing.Point(631, 166);
            this.buttonSeries_Clear.Name = "buttonSeries_Clear";
            this.buttonSeries_Clear.Size = new System.Drawing.Size(75, 23);
            this.buttonSeries_Clear.TabIndex = 15;
            this.buttonSeries_Clear.Text = "Clear";
            this.buttonSeries_Clear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSeries_Clear.UseVisualStyleBackColor = true;
            this.buttonSeries_Clear.Click += new System.EventHandler(this.buttonSeries_Clear_Click);
            // 
            // buttonSeries_Fetch10
            // 
            this.buttonSeries_Fetch10.Image = global::ColorsDesktop.Properties.Resources.transmit;
            this.buttonSeries_Fetch10.Location = new System.Drawing.Point(173, 167);
            this.buttonSeries_Fetch10.Name = "buttonSeries_Fetch10";
            this.buttonSeries_Fetch10.Size = new System.Drawing.Size(128, 23);
            this.buttonSeries_Fetch10.TabIndex = 14;
            this.buttonSeries_Fetch10.Text = "Fetch 10 Episodes";
            this.buttonSeries_Fetch10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSeries_Fetch10.UseVisualStyleBackColor = true;
            this.buttonSeries_Fetch10.Click += new System.EventHandler(this.buttonSeries_Fetch10_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 47);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 13);
            this.label16.TabIndex = 13;
            this.label16.Text = "Series Synopsis";
            // 
            // textBoxSeries_Synopsis
            // 
            this.textBoxSeries_Synopsis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSeries_Synopsis.Location = new System.Drawing.Point(16, 63);
            this.textBoxSeries_Synopsis.Multiline = true;
            this.textBoxSeries_Synopsis.Name = "textBoxSeries_Synopsis";
            this.textBoxSeries_Synopsis.ReadOnly = true;
            this.textBoxSeries_Synopsis.Size = new System.Drawing.Size(690, 91);
            this.textBoxSeries_Synopsis.TabIndex = 12;
            // 
            // textBoxSeries_TotalEpisodes
            // 
            this.textBoxSeries_TotalEpisodes.Location = new System.Drawing.Point(631, 15);
            this.textBoxSeries_TotalEpisodes.Name = "textBoxSeries_TotalEpisodes";
            this.textBoxSeries_TotalEpisodes.ReadOnly = true;
            this.textBoxSeries_TotalEpisodes.Size = new System.Drawing.Size(75, 20);
            this.textBoxSeries_TotalEpisodes.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(545, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "Total Episodes:";
            // 
            // textBoxSeries_Name
            // 
            this.textBoxSeries_Name.Location = new System.Drawing.Point(201, 15);
            this.textBoxSeries_Name.Name = "textBoxSeries_Name";
            this.textBoxSeries_Name.ReadOnly = true;
            this.textBoxSeries_Name.Size = new System.Drawing.Size(100, 20);
            this.textBoxSeries_Name.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(157, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "Name:";
            // 
            // textBoxSeries_ID
            // 
            this.textBoxSeries_ID.Location = new System.Drawing.Point(40, 15);
            this.textBoxSeries_ID.Name = "textBoxSeries_ID";
            this.textBoxSeries_ID.ReadOnly = true;
            this.textBoxSeries_ID.Size = new System.Drawing.Size(77, 20);
            this.textBoxSeries_ID.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "ID:";
            // 
            // listViewSeries_FetchResults
            // 
            this.listViewSeries_FetchResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewSeries_FetchResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader6,
            this.columnHeader7});
            this.listViewSeries_FetchResults.FullRowSelect = true;
            this.listViewSeries_FetchResults.GridLines = true;
            this.listViewSeries_FetchResults.HideSelection = false;
            this.listViewSeries_FetchResults.Location = new System.Drawing.Point(16, 203);
            this.listViewSeries_FetchResults.MultiSelect = false;
            this.listViewSeries_FetchResults.Name = "listViewSeries_FetchResults";
            this.listViewSeries_FetchResults.Size = new System.Drawing.Size(690, 178);
            this.listViewSeries_FetchResults.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewSeries_FetchResults.TabIndex = 5;
            this.listViewSeries_FetchResults.UseCompatibleStateImageBehavior = false;
            this.listViewSeries_FetchResults.View = System.Windows.Forms.View.Details;
            this.listViewSeries_FetchResults.DoubleClick += new System.EventHandler(this.listViewSeries_FetchResults_DoubleClick);
            this.listViewSeries_FetchResults.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listViewSeries_FetchResults_KeyPress);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Episode #";
            this.columnHeader8.Width = 62;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ID";
            this.columnHeader6.Width = 65;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Description";
            this.columnHeader7.Width = 506;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 172);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Start:";
            // 
            // tabPageEpisode
            // 
            this.tabPageEpisode.Controls.Add(this.textBoxEpisode_Predm3u8);
            this.tabPageEpisode.Controls.Add(this.label10);
            this.tabPageEpisode.Controls.Add(this.textBoxEpisode_EntryId);
            this.tabPageEpisode.Controls.Add(this.label9);
            this.tabPageEpisode.Controls.Add(this.textBoxEpisode_Number);
            this.tabPageEpisode.Controls.Add(this.label7);
            this.tabPageEpisode.Controls.Add(this.buttonFetch);
            this.tabPageEpisode.Controls.Add(this.listViewEpisode_Links);
            this.tabPageEpisode.Controls.Add(this.textBoxEpisode_URL);
            this.tabPageEpisode.Controls.Add(this.label5);
            this.tabPageEpisode.Controls.Add(this.textBoxEpisode_MainTitle);
            this.tabPageEpisode.Controls.Add(this.label4);
            this.tabPageEpisode.Controls.Add(this.textBoxEpisode_ID);
            this.tabPageEpisode.Controls.Add(this.label3);
            this.tabPageEpisode.Controls.Add(this.textBoxEpisode_Synopsis);
            this.tabPageEpisode.Controls.Add(this.label2);
            this.tabPageEpisode.Controls.Add(this.textBoxEpisode_Name);
            this.tabPageEpisode.Controls.Add(this.label1);
            this.tabPageEpisode.ImageIndex = 2;
            this.tabPageEpisode.Location = new System.Drawing.Point(4, 23);
            this.tabPageEpisode.Name = "tabPageEpisode";
            this.tabPageEpisode.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEpisode.Size = new System.Drawing.Size(719, 394);
            this.tabPageEpisode.TabIndex = 1;
            this.tabPageEpisode.Text = "Episode";
            this.tabPageEpisode.UseVisualStyleBackColor = true;
            // 
            // textBoxEpisode_Predm3u8
            // 
            this.textBoxEpisode_Predm3u8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEpisode_Predm3u8.Location = new System.Drawing.Point(83, 220);
            this.textBoxEpisode_Predm3u8.Name = "textBoxEpisode_Predm3u8";
            this.textBoxEpisode_Predm3u8.ReadOnly = true;
            this.textBoxEpisode_Predm3u8.Size = new System.Drawing.Size(620, 20);
            this.textBoxEpisode_Predm3u8.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 223);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Pred m3u8:";
            // 
            // textBoxEpisode_EntryId
            // 
            this.textBoxEpisode_EntryId.Location = new System.Drawing.Point(336, 16);
            this.textBoxEpisode_EntryId.Name = "textBoxEpisode_EntryId";
            this.textBoxEpisode_EntryId.ReadOnly = true;
            this.textBoxEpisode_EntryId.Size = new System.Drawing.Size(91, 20);
            this.textBoxEpisode_EntryId.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(284, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Entry Id:";
            // 
            // textBoxEpisode_Number
            // 
            this.textBoxEpisode_Number.Location = new System.Drawing.Point(182, 16);
            this.textBoxEpisode_Number.Name = "textBoxEpisode_Number";
            this.textBoxEpisode_Number.ReadOnly = true;
            this.textBoxEpisode_Number.Size = new System.Drawing.Size(80, 20);
            this.textBoxEpisode_Number.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(149, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "No.:";
            // 
            // buttonFetch
            // 
            this.buttonFetch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFetch.Image = global::ColorsDesktop.Properties.Resources.transmit;
            this.buttonFetch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonFetch.Location = new System.Drawing.Point(628, 249);
            this.buttonFetch.Name = "buttonFetch";
            this.buttonFetch.Size = new System.Drawing.Size(75, 20);
            this.buttonFetch.TabIndex = 13;
            this.buttonFetch.Text = "Fetch";
            this.buttonFetch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonFetch.UseVisualStyleBackColor = true;
            this.buttonFetch.Click += new System.EventHandler(this.buttonFetch_Click);
            // 
            // listViewEpisode_Links
            // 
            this.listViewEpisode_Links.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewEpisode_Links.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader4});
            this.listViewEpisode_Links.FullRowSelect = true;
            this.listViewEpisode_Links.GridLines = true;
            this.listViewEpisode_Links.HideSelection = false;
            this.listViewEpisode_Links.Location = new System.Drawing.Point(18, 275);
            this.listViewEpisode_Links.MultiSelect = false;
            this.listViewEpisode_Links.Name = "listViewEpisode_Links";
            this.listViewEpisode_Links.Size = new System.Drawing.Size(685, 113);
            this.listViewEpisode_Links.TabIndex = 6;
            this.listViewEpisode_Links.UseCompatibleStateImageBehavior = false;
            this.listViewEpisode_Links.View = System.Windows.Forms.View.Details;
            this.listViewEpisode_Links.DoubleClick += new System.EventHandler(this.listViewEpisode_Links_DoubleClick);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Format";
            this.columnHeader5.Width = 61;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Direct Links";
            this.columnHeader4.Width = 585;
            // 
            // textBoxEpisode_URL
            // 
            this.textBoxEpisode_URL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEpisode_URL.Location = new System.Drawing.Point(83, 249);
            this.textBoxEpisode_URL.Name = "textBoxEpisode_URL";
            this.textBoxEpisode_URL.ReadOnly = true;
            this.textBoxEpisode_URL.Size = new System.Drawing.Size(535, 20);
            this.textBoxEpisode_URL.TabIndex = 5;
            this.textBoxEpisode_URL.Click += new System.EventHandler(this.textBoxEpisode_URL_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Web URL:";
            // 
            // textBoxEpisode_MainTitle
            // 
            this.textBoxEpisode_MainTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEpisode_MainTitle.Location = new System.Drawing.Point(507, 16);
            this.textBoxEpisode_MainTitle.Name = "textBoxEpisode_MainTitle";
            this.textBoxEpisode_MainTitle.ReadOnly = true;
            this.textBoxEpisode_MainTitle.Size = new System.Drawing.Size(196, 20);
            this.textBoxEpisode_MainTitle.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(445, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Main Title:";
            // 
            // textBoxEpisode_ID
            // 
            this.textBoxEpisode_ID.Location = new System.Drawing.Point(59, 16);
            this.textBoxEpisode_ID.Name = "textBoxEpisode_ID";
            this.textBoxEpisode_ID.ReadOnly = true;
            this.textBoxEpisode_ID.Size = new System.Drawing.Size(71, 20);
            this.textBoxEpisode_ID.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID:";
            // 
            // textBoxEpisode_Synopsis
            // 
            this.textBoxEpisode_Synopsis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEpisode_Synopsis.Location = new System.Drawing.Point(18, 115);
            this.textBoxEpisode_Synopsis.Multiline = true;
            this.textBoxEpisode_Synopsis.Name = "textBoxEpisode_Synopsis";
            this.textBoxEpisode_Synopsis.ReadOnly = true;
            this.textBoxEpisode_Synopsis.Size = new System.Drawing.Size(685, 89);
            this.textBoxEpisode_Synopsis.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Content Synopsis";
            // 
            // textBoxEpisode_Name
            // 
            this.textBoxEpisode_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEpisode_Name.Location = new System.Drawing.Point(59, 58);
            this.textBoxEpisode_Name.Name = "textBoxEpisode_Name";
            this.textBoxEpisode_Name.ReadOnly = true;
            this.textBoxEpisode_Name.Size = new System.Drawing.Size(644, 20);
            this.textBoxEpisode_Name.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // tabPageOptions
            // 
            this.tabPageOptions.Controls.Add(this.buttonOptions_ClearSettings);
            this.tabPageOptions.Controls.Add(this.buttonOptions_SaveSettings);
            this.tabPageOptions.Controls.Add(this.groupBox1);
            this.tabPageOptions.ImageIndex = 4;
            this.tabPageOptions.Location = new System.Drawing.Point(4, 23);
            this.tabPageOptions.Name = "tabPageOptions";
            this.tabPageOptions.Size = new System.Drawing.Size(719, 394);
            this.tabPageOptions.TabIndex = 4;
            this.tabPageOptions.Text = "Options";
            this.tabPageOptions.UseVisualStyleBackColor = true;
            // 
            // buttonOptions_ClearSettings
            // 
            this.buttonOptions_ClearSettings.Location = new System.Drawing.Point(149, 199);
            this.buttonOptions_ClearSettings.Name = "buttonOptions_ClearSettings";
            this.buttonOptions_ClearSettings.Size = new System.Drawing.Size(100, 23);
            this.buttonOptions_ClearSettings.TabIndex = 7;
            this.buttonOptions_ClearSettings.Text = "Clear Settings";
            this.buttonOptions_ClearSettings.UseVisualStyleBackColor = true;
            this.buttonOptions_ClearSettings.Click += new System.EventHandler(this.buttonOptions_ClearSettings_Click);
            // 
            // buttonOptions_SaveSettings
            // 
            this.buttonOptions_SaveSettings.Location = new System.Drawing.Point(20, 199);
            this.buttonOptions_SaveSettings.Name = "buttonOptions_SaveSettings";
            this.buttonOptions_SaveSettings.Size = new System.Drawing.Size(108, 23);
            this.buttonOptions_SaveSettings.TabIndex = 6;
            this.buttonOptions_SaveSettings.Text = "Save Settings ";
            this.buttonOptions_SaveSettings.UseVisualStyleBackColor = true;
            this.buttonOptions_SaveSettings.Click += new System.EventHandler(this.buttonOptions_SaveSettings_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxOptions_ProxyAddr);
            this.groupBox1.Controls.Add(this.numericUpDownOptions_ProxyPort);
            this.groupBox1.Controls.Add(this.radioButtonOptions_ProxyCustom);
            this.groupBox1.Controls.Add(this.radioButtonOptions_ProxySystem);
            this.groupBox1.Controls.Add(this.radioButtonOptions_ProxyNone);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(20, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(676, 154);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proxy settings";
            // 
            // textBoxOptions_ProxyAddr
            // 
            this.textBoxOptions_ProxyAddr.Enabled = false;
            this.textBoxOptions_ProxyAddr.Location = new System.Drawing.Point(235, 109);
            this.textBoxOptions_ProxyAddr.Name = "textBoxOptions_ProxyAddr";
            this.textBoxOptions_ProxyAddr.Size = new System.Drawing.Size(116, 20);
            this.textBoxOptions_ProxyAddr.TabIndex = 4;
            // 
            // numericUpDownOptions_ProxyPort
            // 
            this.numericUpDownOptions_ProxyPort.Enabled = false;
            this.numericUpDownOptions_ProxyPort.Location = new System.Drawing.Point(456, 109);
            this.numericUpDownOptions_ProxyPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownOptions_ProxyPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownOptions_ProxyPort.Name = "numericUpDownOptions_ProxyPort";
            this.numericUpDownOptions_ProxyPort.Size = new System.Drawing.Size(85, 20);
            this.numericUpDownOptions_ProxyPort.TabIndex = 5;
            this.numericUpDownOptions_ProxyPort.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // radioButtonOptions_ProxyCustom
            // 
            this.radioButtonOptions_ProxyCustom.AutoSize = true;
            this.radioButtonOptions_ProxyCustom.Location = new System.Drawing.Point(23, 109);
            this.radioButtonOptions_ProxyCustom.Name = "radioButtonOptions_ProxyCustom";
            this.radioButtonOptions_ProxyCustom.Size = new System.Drawing.Size(109, 17);
            this.radioButtonOptions_ProxyCustom.TabIndex = 3;
            this.radioButtonOptions_ProxyCustom.Text = "Use custom proxy";
            this.radioButtonOptions_ProxyCustom.UseVisualStyleBackColor = true;
            this.radioButtonOptions_ProxyCustom.CheckedChanged += new System.EventHandler(this.radioButtonOptions_ProxyCustom_CheckedChanged);
            // 
            // radioButtonOptions_ProxySystem
            // 
            this.radioButtonOptions_ProxySystem.AutoSize = true;
            this.radioButtonOptions_ProxySystem.Checked = true;
            this.radioButtonOptions_ProxySystem.Location = new System.Drawing.Point(23, 71);
            this.radioButtonOptions_ProxySystem.Name = "radioButtonOptions_ProxySystem";
            this.radioButtonOptions_ProxySystem.Size = new System.Drawing.Size(107, 17);
            this.radioButtonOptions_ProxySystem.TabIndex = 2;
            this.radioButtonOptions_ProxySystem.TabStop = true;
            this.radioButtonOptions_ProxySystem.Text = "Use system proxy";
            this.radioButtonOptions_ProxySystem.UseVisualStyleBackColor = true;
            // 
            // radioButtonOptions_ProxyNone
            // 
            this.radioButtonOptions_ProxyNone.AutoSize = true;
            this.radioButtonOptions_ProxyNone.Location = new System.Drawing.Point(23, 35);
            this.radioButtonOptions_ProxyNone.Name = "radioButtonOptions_ProxyNone";
            this.radioButtonOptions_ProxyNone.Size = new System.Drawing.Size(67, 17);
            this.radioButtonOptions_ProxyNone.TabIndex = 1;
            this.radioButtonOptions_ProxyNone.Text = "No proxy";
            this.radioButtonOptions_ProxyNone.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(420, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Port:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(181, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Address:";
            // 
            // tabPageAbout
            // 
            this.tabPageAbout.Controls.Add(pictureBox1);
            this.tabPageAbout.ImageIndex = 5;
            this.tabPageAbout.Location = new System.Drawing.Point(4, 23);
            this.tabPageAbout.Name = "tabPageAbout";
            this.tabPageAbout.Size = new System.Drawing.Size(719, 394);
            this.tabPageAbout.TabIndex = 5;
            this.tabPageAbout.Text = "About";
            this.tabPageAbout.UseVisualStyleBackColor = true;
            // 
            // tabPageLog
            // 
            this.tabPageLog.Controls.Add(this.textBoxLog);
            this.tabPageLog.ImageIndex = 1;
            this.tabPageLog.Location = new System.Drawing.Point(4, 23);
            this.tabPageLog.Name = "tabPageLog";
            this.tabPageLog.Size = new System.Drawing.Size(719, 394);
            this.tabPageLog.TabIndex = 3;
            this.tabPageLog.Text = "Log";
            this.tabPageLog.UseVisualStyleBackColor = true;
            // 
            // textBoxLog
            // 
            this.textBoxLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLog.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBoxLog.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLog.ForeColor = System.Drawing.Color.Lime;
            this.textBoxLog.Location = new System.Drawing.Point(4, 4);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ReadOnly = true;
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxLog.Size = new System.Drawing.Size(711, 413);
            this.textBoxLog.TabIndex = 0;
            this.textBoxLog.WordWrap = false;
            // 
            // imageListTabs
            // 
            this.imageListTabs.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTabs.ImageStream")));
            this.imageListTabs.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListTabs.Images.SetKeyName(0, "tabsearch.png");
            this.imageListTabs.Images.SetKeyName(1, "application_xp_terminal.png");
            this.imageListTabs.Images.SetKeyName(2, "television.png");
            this.imageListTabs.Images.SetKeyName(3, "film.png");
            this.imageListTabs.Images.SetKeyName(4, "wrench.png");
            this.imageListTabs.Images.SetKeyName(5, "information.png");
            // 
            // backgroundWorkerSearch
            // 
            this.backgroundWorkerSearch.WorkerSupportsCancellation = true;
            this.backgroundWorkerSearch.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerSearch_DoWork);
            this.backgroundWorkerSearch.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerSearch_RunWorkerCompleted);
            // 
            // backgroundWorkerFetch
            // 
            this.backgroundWorkerFetch.WorkerSupportsCancellation = true;
            this.backgroundWorkerFetch.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerFetch_DoWork);
            this.backgroundWorkerFetch.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerFetch_RunWorkerCompleted);
            // 
            // backgroundWorkerSeries
            // 
            this.backgroundWorkerSeries.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerSeries_DoWork);
            this.backgroundWorkerSeries.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerSeries_RunWorkerCompleted);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(719, 394);
            this.tabPage1.TabIndex = 6;
            this.tabPage1.Text = "M3U8 streaming";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(600, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(627, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.listView1.Location = new System.Drawing.Point(21, 109);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(681, 267);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Resolution";
            this.columnHeader9.Width = 70;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Bitrate";
            this.columnHeader10.Width = 75;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Link";
            this.columnHeader11.Width = 465;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(21, 15);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(558, 52);
            this.label18.TabIndex = 4;
            this.label18.Text = resources.GetString("label18.Text");
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(751, 458);
            this.Controls.Add(statusStrip);
            this.Controls.Add(this.tabControlMainTab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colors Desktop";
            this.Activated += new System.EventHandler(this.MainWindow_Activated);
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.tabControlMainTab.ResumeLayout(false);
            this.tabPageSearch.ResumeLayout(false);
            this.tabPageSearch.PerformLayout();
            this.tabPageSeries.ResumeLayout(false);
            this.tabPageSeries.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeries_Start)).EndInit();
            this.tabPageEpisode.ResumeLayout(false);
            this.tabPageEpisode.PerformLayout();
            this.tabPageOptions.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOptions_ProxyPort)).EndInit();
            this.tabPageAbout.ResumeLayout(false);
            this.tabPageLog.ResumeLayout(false);
            this.tabPageLog.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMainTab;
        private System.Windows.Forms.TabPage tabPageSearch;
        private System.Windows.Forms.TabPage tabPageEpisode;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ListView listViewSearchResults;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TabPage tabPageSeries;
        private System.Windows.Forms.TabPage tabPageLog;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        internal System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.ImageList imageListTabs;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusIcon;
        private System.ComponentModel.BackgroundWorker backgroundWorkerSearch;
        private System.Windows.Forms.ListView listViewEpisode_Links;
        private System.Windows.Forms.TextBox textBoxEpisode_URL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxEpisode_MainTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxEpisode_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxEpisode_Synopsis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEpisode_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEpisode_Number;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonFetch;
        private System.ComponentModel.BackgroundWorker backgroundWorkerFetch;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TabPage tabPageOptions;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPageAbout;
        private System.Windows.Forms.RadioButton radioButtonOptions_ProxyCustom;
        private System.Windows.Forms.RadioButton radioButtonOptions_ProxySystem;
        private System.Windows.Forms.RadioButton radioButtonOptions_ProxyNone;
        private System.Windows.Forms.TextBox textBoxEpisode_EntryId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxEpisode_Predm3u8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxSeries_ID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListView listViewSeries_FetchResults;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxSeries_Title;
        private System.Windows.Forms.Button buttonSeries_Clear;
        private System.Windows.Forms.Button buttonSeries_Fetch10;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxSeries_Synopsis;
        private System.Windows.Forms.TextBox textBoxSeries_TotalEpisodes;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxSeries_Name;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.NumericUpDown numericUpDownSeries_Start;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.ComponentModel.BackgroundWorker backgroundWorkerSeries;
        private System.Windows.Forms.NumericUpDown numericUpDownOptions_ProxyPort;
        private System.Windows.Forms.Button buttonOptions_SaveSettings;
        private System.Windows.Forms.TextBox textBoxOptions_ProxyAddr;
        private System.Windows.Forms.Button buttonOptions_ClearSettings;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Label label18;
    }
}

