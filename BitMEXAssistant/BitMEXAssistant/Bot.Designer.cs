﻿namespace BitMEXAssistant
{
    partial class Bot
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
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.lblBalance = new System.Windows.Forms.ToolStripStatusLabel();
            this.ddlCandleTimes = new System.Windows.Forms.ComboBox();
            this.ddlSymbol = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Heartbeat = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSpread = new System.Windows.Forms.TabPage();
            this.chkSpreadCancelWhileOrdering = new System.Windows.Forms.CheckBox();
            this.btnSpreadCloseAllOpenOrders = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkSpreadSellPostOnly = new System.Windows.Forms.CheckBox();
            this.chkSpreadSellExecute = new System.Windows.Forms.CheckBox();
            this.nudSpreadSellOrderCount = new System.Windows.Forms.NumericUpDown();
            this.chkSpreadSellReduceOnly = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.nudSpreadSellValueApart = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.nudSpreadSellContractsEach = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkSpreadyBuyPostOnly = new System.Windows.Forms.CheckBox();
            this.chkSpreadBuyExecute = new System.Windows.Forms.CheckBox();
            this.nudSpreadBuyOrderCount = new System.Windows.Forms.NumericUpDown();
            this.chkSpreadBuyReduceOnly = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nudSpreadBuyValueApart = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nudSpreadBuyContractsEach = new System.Windows.Forms.NumericUpDown();
            this.btnSpreadPlaceOrders = new System.Windows.Forms.Button();
            this.tabDCA = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkDCAExecuteImmediately = new System.Windows.Forms.CheckBox();
            this.chkDCAReduceOnly = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nudDCAContracts = new System.Windows.Forms.NumericUpDown();
            this.lblalskdj = new System.Windows.Forms.Label();
            this.nudDCAHours = new System.Windows.Forms.NumericUpDown();
            this.nudDCASeconds = new System.Windows.Forms.NumericUpDown();
            this.nudDCATimes = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudDCAMinutes = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.pgbDCA = new System.Windows.Forms.ProgressBar();
            this.btnDCAStop = new System.Windows.Forms.Button();
            this.lblDCASummary = new System.Windows.Forms.Label();
            this.btnDCASell = new System.Windows.Forms.Button();
            this.btnDCABuy = new System.Windows.Forms.Button();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.btnExportCandles = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.nudSettingsRetryWaitTime = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.chkSettingOverloadRetry = new System.Windows.Forms.CheckBox();
            this.nudSettingsOverloadRetryAttempts = new System.Windows.Forms.NumericUpDown();
            this.tmrDCA = new System.Windows.Forms.Timer(this.components);
            this.gbxPosition = new System.Windows.Forms.GroupBox();
            this.nudPositionLimitPrice = new System.Windows.Forms.NumericUpDown();
            this.btnPositionMarketClose = new System.Windows.Forms.Button();
            this.btnPositionLimitClose = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.txtPositionLiquidation = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.txtPositionUnrealizedPnLPercent = new System.Windows.Forms.TextBox();
            this.txtPositionUnrealizedPnL = new System.Windows.Forms.TextBox();
            this.txtPositionMargin = new System.Windows.Forms.TextBox();
            this.txtPositionMarkPrice = new System.Windows.Forms.TextBox();
            this.txtPositionEntryPrice = new System.Windows.Forms.TextBox();
            this.txtPositionSize = new System.Windows.Forms.TextBox();
            this.lblTimeUTC = new System.Windows.Forms.Label();
            this.StatusStrip.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabSpread.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpreadSellOrderCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpreadSellValueApart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpreadSellContractsEach)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpreadBuyOrderCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpreadBuyValueApart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpreadBuyContractsEach)).BeginInit();
            this.tabDCA.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDCAContracts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDCAHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDCASeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDCATimes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDCAMinutes)).BeginInit();
            this.tabSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSettingsRetryWaitTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSettingsOverloadRetryAttempts)).BeginInit();
            this.gbxPosition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPositionLimitPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblBalance});
            this.StatusStrip.Location = new System.Drawing.Point(0, 274);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(662, 22);
            this.StatusStrip.TabIndex = 0;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // lblBalance
            // 
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(61, 17);
            this.lblBalance.Text = "lblBalance";
            // 
            // ddlCandleTimes
            // 
            this.ddlCandleTimes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlCandleTimes.FormattingEnabled = true;
            this.ddlCandleTimes.Items.AddRange(new object[] {
            "1m",
            "5m",
            "1h",
            "1d"});
            this.ddlCandleTimes.Location = new System.Drawing.Point(91, 23);
            this.ddlCandleTimes.Name = "ddlCandleTimes";
            this.ddlCandleTimes.Size = new System.Drawing.Size(46, 21);
            this.ddlCandleTimes.TabIndex = 10;
            this.ddlCandleTimes.SelectedIndexChanged += new System.EventHandler(this.ddlCandleTimes_SelectedIndexChanged);
            // 
            // ddlSymbol
            // 
            this.ddlSymbol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSymbol.FormattingEnabled = true;
            this.ddlSymbol.Location = new System.Drawing.Point(12, 23);
            this.ddlSymbol.Name = "ddlSymbol";
            this.ddlSymbol.Size = new System.Drawing.Size(73, 21);
            this.ddlSymbol.TabIndex = 11;
            this.ddlSymbol.SelectedIndexChanged += new System.EventHandler(this.ddlSymbol_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Symbol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Time";
            // 
            // Heartbeat
            // 
            this.Heartbeat.Interval = 1000;
            this.Heartbeat.Tick += new System.EventHandler(this.Heartbeat_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSpread);
            this.tabControl1.Controls.Add(this.tabDCA);
            this.tabControl1.Controls.Add(this.tabSettings);
            this.tabControl1.Location = new System.Drawing.Point(12, 69);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(638, 202);
            this.tabControl1.TabIndex = 14;
            // 
            // tabSpread
            // 
            this.tabSpread.Controls.Add(this.chkSpreadCancelWhileOrdering);
            this.tabSpread.Controls.Add(this.btnSpreadCloseAllOpenOrders);
            this.tabSpread.Controls.Add(this.groupBox3);
            this.tabSpread.Controls.Add(this.groupBox2);
            this.tabSpread.Controls.Add(this.btnSpreadPlaceOrders);
            this.tabSpread.Location = new System.Drawing.Point(4, 22);
            this.tabSpread.Name = "tabSpread";
            this.tabSpread.Size = new System.Drawing.Size(630, 176);
            this.tabSpread.TabIndex = 2;
            this.tabSpread.Text = "Spread";
            this.tabSpread.UseVisualStyleBackColor = true;
            // 
            // chkSpreadCancelWhileOrdering
            // 
            this.chkSpreadCancelWhileOrdering.AutoSize = true;
            this.chkSpreadCancelWhileOrdering.Checked = true;
            this.chkSpreadCancelWhileOrdering.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSpreadCancelWhileOrdering.Location = new System.Drawing.Point(379, 47);
            this.chkSpreadCancelWhileOrdering.Name = "chkSpreadCancelWhileOrdering";
            this.chkSpreadCancelWhileOrdering.Size = new System.Drawing.Size(208, 17);
            this.chkSpreadCancelWhileOrdering.TabIndex = 12;
            this.chkSpreadCancelWhileOrdering.Text = "Cancel All Open Orders Before Placing";
            this.chkSpreadCancelWhileOrdering.UseVisualStyleBackColor = true;
            this.chkSpreadCancelWhileOrdering.CheckedChanged += new System.EventHandler(this.chkSpreadCancelWhileOrdering_CheckedChanged);
            // 
            // btnSpreadCloseAllOpenOrders
            // 
            this.btnSpreadCloseAllOpenOrders.Location = new System.Drawing.Point(485, 147);
            this.btnSpreadCloseAllOpenOrders.Name = "btnSpreadCloseAllOpenOrders";
            this.btnSpreadCloseAllOpenOrders.Size = new System.Drawing.Size(139, 23);
            this.btnSpreadCloseAllOpenOrders.TabIndex = 11;
            this.btnSpreadCloseAllOpenOrders.Text = "Close All Open Orders";
            this.btnSpreadCloseAllOpenOrders.UseVisualStyleBackColor = true;
            this.btnSpreadCloseAllOpenOrders.Click += new System.EventHandler(this.btnSpreadCloseAllOpenOrders_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkSpreadSellPostOnly);
            this.groupBox3.Controls.Add(this.chkSpreadSellExecute);
            this.groupBox3.Controls.Add(this.nudSpreadSellOrderCount);
            this.groupBox3.Controls.Add(this.chkSpreadSellReduceOnly);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.nudSpreadSellValueApart);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.nudSpreadSellContractsEach);
            this.groupBox3.Location = new System.Drawing.Point(196, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(176, 160);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sell";
            // 
            // chkSpreadSellPostOnly
            // 
            this.chkSpreadSellPostOnly.AutoSize = true;
            this.chkSpreadSellPostOnly.Checked = true;
            this.chkSpreadSellPostOnly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSpreadSellPostOnly.Location = new System.Drawing.Point(76, 113);
            this.chkSpreadSellPostOnly.Name = "chkSpreadSellPostOnly";
            this.chkSpreadSellPostOnly.Size = new System.Drawing.Size(71, 17);
            this.chkSpreadSellPostOnly.TabIndex = 10;
            this.chkSpreadSellPostOnly.Text = "Post Only";
            this.chkSpreadSellPostOnly.UseVisualStyleBackColor = true;
            this.chkSpreadSellPostOnly.CheckedChanged += new System.EventHandler(this.chkSpreadSellPostOnly_CheckedChanged);
            // 
            // chkSpreadSellExecute
            // 
            this.chkSpreadSellExecute.AutoSize = true;
            this.chkSpreadSellExecute.Checked = true;
            this.chkSpreadSellExecute.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSpreadSellExecute.Location = new System.Drawing.Point(76, 132);
            this.chkSpreadSellExecute.Name = "chkSpreadSellExecute";
            this.chkSpreadSellExecute.Size = new System.Drawing.Size(65, 17);
            this.chkSpreadSellExecute.TabIndex = 8;
            this.chkSpreadSellExecute.Text = "Execute";
            this.chkSpreadSellExecute.UseVisualStyleBackColor = true;
            this.chkSpreadSellExecute.CheckedChanged += new System.EventHandler(this.chkSpreadSellExecute_CheckedChanged);
            // 
            // nudSpreadSellOrderCount
            // 
            this.nudSpreadSellOrderCount.Location = new System.Drawing.Point(44, 17);
            this.nudSpreadSellOrderCount.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudSpreadSellOrderCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSpreadSellOrderCount.Name = "nudSpreadSellOrderCount";
            this.nudSpreadSellOrderCount.Size = new System.Drawing.Size(46, 20);
            this.nudSpreadSellOrderCount.TabIndex = 0;
            this.nudSpreadSellOrderCount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudSpreadSellOrderCount.ValueChanged += new System.EventHandler(this.nudSpreadSellOrderCount_ValueChanged);
            // 
            // chkSpreadSellReduceOnly
            // 
            this.chkSpreadSellReduceOnly.AutoSize = true;
            this.chkSpreadSellReduceOnly.Location = new System.Drawing.Point(76, 95);
            this.chkSpreadSellReduceOnly.Name = "chkSpreadSellReduceOnly";
            this.chkSpreadSellReduceOnly.Size = new System.Drawing.Size(88, 17);
            this.chkSpreadSellReduceOnly.TabIndex = 7;
            this.chkSpreadSellReduceOnly.Text = "Reduce Only";
            this.chkSpreadSellReduceOnly.UseVisualStyleBackColor = true;
            this.chkSpreadSellReduceOnly.CheckedChanged += new System.EventHandler(this.chkSpreadSellReduceOnly_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(92, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Orders";
            // 
            // nudSpreadSellValueApart
            // 
            this.nudSpreadSellValueApart.DecimalPlaces = 1;
            this.nudSpreadSellValueApart.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudSpreadSellValueApart.Location = new System.Drawing.Point(9, 43);
            this.nudSpreadSellValueApart.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudSpreadSellValueApart.Name = "nudSpreadSellValueApart";
            this.nudSpreadSellValueApart.Size = new System.Drawing.Size(81, 20);
            this.nudSpreadSellValueApart.TabIndex = 2;
            this.nudSpreadSellValueApart.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudSpreadSellValueApart.ValueChanged += new System.EventHandler(this.nudSpreadSellValueApart_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(92, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Contracts Each";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(92, 47);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Apart";
            // 
            // nudSpreadSellContractsEach
            // 
            this.nudSpreadSellContractsEach.Location = new System.Drawing.Point(9, 69);
            this.nudSpreadSellContractsEach.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudSpreadSellContractsEach.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSpreadSellContractsEach.Name = "nudSpreadSellContractsEach";
            this.nudSpreadSellContractsEach.Size = new System.Drawing.Size(81, 20);
            this.nudSpreadSellContractsEach.TabIndex = 4;
            this.nudSpreadSellContractsEach.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudSpreadSellContractsEach.ValueChanged += new System.EventHandler(this.nudSpreadSellContractsEach_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkSpreadyBuyPostOnly);
            this.groupBox2.Controls.Add(this.chkSpreadBuyExecute);
            this.groupBox2.Controls.Add(this.nudSpreadBuyOrderCount);
            this.groupBox2.Controls.Add(this.chkSpreadBuyReduceOnly);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.nudSpreadBuyValueApart);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.nudSpreadBuyContractsEach);
            this.groupBox2.Location = new System.Drawing.Point(14, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(176, 160);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buy";
            // 
            // chkSpreadyBuyPostOnly
            // 
            this.chkSpreadyBuyPostOnly.AutoSize = true;
            this.chkSpreadyBuyPostOnly.Checked = true;
            this.chkSpreadyBuyPostOnly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSpreadyBuyPostOnly.Location = new System.Drawing.Point(76, 114);
            this.chkSpreadyBuyPostOnly.Name = "chkSpreadyBuyPostOnly";
            this.chkSpreadyBuyPostOnly.Size = new System.Drawing.Size(71, 17);
            this.chkSpreadyBuyPostOnly.TabIndex = 9;
            this.chkSpreadyBuyPostOnly.Text = "Post Only";
            this.chkSpreadyBuyPostOnly.UseVisualStyleBackColor = true;
            this.chkSpreadyBuyPostOnly.CheckedChanged += new System.EventHandler(this.chkSpreadyBuyPostOnly_CheckedChanged);
            // 
            // chkSpreadBuyExecute
            // 
            this.chkSpreadBuyExecute.AutoSize = true;
            this.chkSpreadBuyExecute.Checked = true;
            this.chkSpreadBuyExecute.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSpreadBuyExecute.Location = new System.Drawing.Point(76, 133);
            this.chkSpreadBuyExecute.Name = "chkSpreadBuyExecute";
            this.chkSpreadBuyExecute.Size = new System.Drawing.Size(65, 17);
            this.chkSpreadBuyExecute.TabIndex = 8;
            this.chkSpreadBuyExecute.Text = "Execute";
            this.chkSpreadBuyExecute.UseVisualStyleBackColor = true;
            this.chkSpreadBuyExecute.CheckedChanged += new System.EventHandler(this.chkSpreadBuyExecute_CheckedChanged);
            // 
            // nudSpreadBuyOrderCount
            // 
            this.nudSpreadBuyOrderCount.Location = new System.Drawing.Point(44, 17);
            this.nudSpreadBuyOrderCount.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudSpreadBuyOrderCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSpreadBuyOrderCount.Name = "nudSpreadBuyOrderCount";
            this.nudSpreadBuyOrderCount.Size = new System.Drawing.Size(46, 20);
            this.nudSpreadBuyOrderCount.TabIndex = 0;
            this.nudSpreadBuyOrderCount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudSpreadBuyOrderCount.ValueChanged += new System.EventHandler(this.nudSpreadBuyOrderCount_ValueChanged);
            // 
            // chkSpreadBuyReduceOnly
            // 
            this.chkSpreadBuyReduceOnly.AutoSize = true;
            this.chkSpreadBuyReduceOnly.Location = new System.Drawing.Point(76, 95);
            this.chkSpreadBuyReduceOnly.Name = "chkSpreadBuyReduceOnly";
            this.chkSpreadBuyReduceOnly.Size = new System.Drawing.Size(88, 17);
            this.chkSpreadBuyReduceOnly.TabIndex = 7;
            this.chkSpreadBuyReduceOnly.Text = "Reduce Only";
            this.chkSpreadBuyReduceOnly.UseVisualStyleBackColor = true;
            this.chkSpreadBuyReduceOnly.CheckedChanged += new System.EventHandler(this.chkSpreadBuyReduceOnly_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(92, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Orders";
            // 
            // nudSpreadBuyValueApart
            // 
            this.nudSpreadBuyValueApart.DecimalPlaces = 1;
            this.nudSpreadBuyValueApart.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudSpreadBuyValueApart.Location = new System.Drawing.Point(9, 43);
            this.nudSpreadBuyValueApart.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudSpreadBuyValueApart.Name = "nudSpreadBuyValueApart";
            this.nudSpreadBuyValueApart.Size = new System.Drawing.Size(81, 20);
            this.nudSpreadBuyValueApart.TabIndex = 2;
            this.nudSpreadBuyValueApart.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudSpreadBuyValueApart.ValueChanged += new System.EventHandler(this.nudSpreadBuyValueApart_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(92, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Contracts Each";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(92, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Apart";
            // 
            // nudSpreadBuyContractsEach
            // 
            this.nudSpreadBuyContractsEach.Location = new System.Drawing.Point(9, 69);
            this.nudSpreadBuyContractsEach.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudSpreadBuyContractsEach.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSpreadBuyContractsEach.Name = "nudSpreadBuyContractsEach";
            this.nudSpreadBuyContractsEach.Size = new System.Drawing.Size(81, 20);
            this.nudSpreadBuyContractsEach.TabIndex = 4;
            this.nudSpreadBuyContractsEach.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudSpreadBuyContractsEach.ValueChanged += new System.EventHandler(this.nudSpreadBuyContractsEach_ValueChanged);
            // 
            // btnSpreadPlaceOrders
            // 
            this.btnSpreadPlaceOrders.Location = new System.Drawing.Point(378, 18);
            this.btnSpreadPlaceOrders.Name = "btnSpreadPlaceOrders";
            this.btnSpreadPlaceOrders.Size = new System.Drawing.Size(139, 23);
            this.btnSpreadPlaceOrders.TabIndex = 6;
            this.btnSpreadPlaceOrders.Text = "Place Spread Orders";
            this.btnSpreadPlaceOrders.UseVisualStyleBackColor = true;
            this.btnSpreadPlaceOrders.Click += new System.EventHandler(this.btnSpreadPlaceOrders_Click);
            // 
            // tabDCA
            // 
            this.tabDCA.Controls.Add(this.groupBox1);
            this.tabDCA.Controls.Add(this.pgbDCA);
            this.tabDCA.Controls.Add(this.btnDCAStop);
            this.tabDCA.Controls.Add(this.lblDCASummary);
            this.tabDCA.Controls.Add(this.btnDCASell);
            this.tabDCA.Controls.Add(this.btnDCABuy);
            this.tabDCA.Location = new System.Drawing.Point(4, 22);
            this.tabDCA.Name = "tabDCA";
            this.tabDCA.Padding = new System.Windows.Forms.Padding(3);
            this.tabDCA.Size = new System.Drawing.Size(630, 176);
            this.tabDCA.TabIndex = 0;
            this.tabDCA.Text = "DCA";
            this.tabDCA.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.chkDCAExecuteImmediately);
            this.groupBox1.Controls.Add(this.chkDCAReduceOnly);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nudDCAContracts);
            this.groupBox1.Controls.Add(this.lblalskdj);
            this.groupBox1.Controls.Add(this.nudDCAHours);
            this.groupBox1.Controls.Add(this.nudDCASeconds);
            this.groupBox1.Controls.Add(this.nudDCATimes);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nudDCAMinutes);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(343, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 146);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DCA Settings";
            // 
            // chkDCAExecuteImmediately
            // 
            this.chkDCAExecuteImmediately.AutoSize = true;
            this.chkDCAExecuteImmediately.Checked = true;
            this.chkDCAExecuteImmediately.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDCAExecuteImmediately.Location = new System.Drawing.Point(156, 102);
            this.chkDCAExecuteImmediately.Name = "chkDCAExecuteImmediately";
            this.chkDCAExecuteImmediately.Size = new System.Drawing.Size(123, 17);
            this.chkDCAExecuteImmediately.TabIndex = 49;
            this.chkDCAExecuteImmediately.Text = "Execute Immediately";
            this.chkDCAExecuteImmediately.UseVisualStyleBackColor = true;
            this.chkDCAExecuteImmediately.CheckedChanged += new System.EventHandler(this.chkDCAExecuteImmediately_CheckedChanged);
            // 
            // chkDCAReduceOnly
            // 
            this.chkDCAReduceOnly.AutoSize = true;
            this.chkDCAReduceOnly.Location = new System.Drawing.Point(156, 78);
            this.chkDCAReduceOnly.Name = "chkDCAReduceOnly";
            this.chkDCAReduceOnly.Size = new System.Drawing.Size(88, 17);
            this.chkDCAReduceOnly.TabIndex = 48;
            this.chkDCAReduceOnly.Text = "Reduce Only";
            this.chkDCAReduceOnly.UseVisualStyleBackColor = true;
            this.chkDCAReduceOnly.CheckedChanged += new System.EventHandler(this.chkDCAReduceOnly_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Contracts Per";
            // 
            // nudDCAContracts
            // 
            this.nudDCAContracts.Location = new System.Drawing.Point(9, 37);
            this.nudDCAContracts.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudDCAContracts.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDCAContracts.Name = "nudDCAContracts";
            this.nudDCAContracts.Size = new System.Drawing.Size(67, 20);
            this.nudDCAContracts.TabIndex = 36;
            this.nudDCAContracts.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudDCAContracts.ValueChanged += new System.EventHandler(this.nudDCAContracts_ValueChanged);
            // 
            // lblalskdj
            // 
            this.lblalskdj.AutoSize = true;
            this.lblalskdj.Location = new System.Drawing.Point(91, 102);
            this.lblalskdj.Name = "lblalskdj";
            this.lblalskdj.Size = new System.Drawing.Size(49, 13);
            this.lblalskdj.TabIndex = 45;
            this.lblalskdj.Text = "Seconds";
            // 
            // nudDCAHours
            // 
            this.nudDCAHours.Location = new System.Drawing.Point(93, 37);
            this.nudDCAHours.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudDCAHours.Name = "nudDCAHours";
            this.nudDCAHours.Size = new System.Drawing.Size(47, 20);
            this.nudDCAHours.TabIndex = 37;
            this.nudDCAHours.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudDCAHours.ValueChanged += new System.EventHandler(this.nudDCAHours_ValueChanged);
            // 
            // nudDCASeconds
            // 
            this.nudDCASeconds.Location = new System.Drawing.Point(93, 118);
            this.nudDCASeconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudDCASeconds.Name = "nudDCASeconds";
            this.nudDCASeconds.Size = new System.Drawing.Size(47, 20);
            this.nudDCASeconds.TabIndex = 44;
            this.nudDCASeconds.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudDCASeconds.ValueChanged += new System.EventHandler(this.nudDCASeconds_ValueChanged);
            // 
            // nudDCATimes
            // 
            this.nudDCATimes.Location = new System.Drawing.Point(156, 37);
            this.nudDCATimes.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudDCATimes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDCATimes.Name = "nudDCATimes";
            this.nudDCATimes.Size = new System.Drawing.Size(47, 20);
            this.nudDCATimes.TabIndex = 38;
            this.nudDCATimes.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudDCATimes.ValueChanged += new System.EventHandler(this.nudDCATimes_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Minutes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Hours";
            // 
            // nudDCAMinutes
            // 
            this.nudDCAMinutes.Location = new System.Drawing.Point(93, 78);
            this.nudDCAMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudDCAMinutes.Name = "nudDCAMinutes";
            this.nudDCAMinutes.Size = new System.Drawing.Size(47, 20);
            this.nudDCAMinutes.TabIndex = 42;
            this.nudDCAMinutes.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudDCAMinutes.ValueChanged += new System.EventHandler(this.nudDCAMinutes_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(158, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "X Times";
            // 
            // pgbDCA
            // 
            this.pgbDCA.Location = new System.Drawing.Point(14, 14);
            this.pgbDCA.Name = "pgbDCA";
            this.pgbDCA.Size = new System.Drawing.Size(323, 23);
            this.pgbDCA.TabIndex = 46;
            this.pgbDCA.Visible = false;
            // 
            // btnDCAStop
            // 
            this.btnDCAStop.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnDCAStop.Location = new System.Drawing.Point(240, 43);
            this.btnDCAStop.Name = "btnDCAStop";
            this.btnDCAStop.Size = new System.Drawing.Size(97, 61);
            this.btnDCAStop.TabIndex = 41;
            this.btnDCAStop.Text = "Stop";
            this.btnDCAStop.UseVisualStyleBackColor = false;
            this.btnDCAStop.Visible = false;
            this.btnDCAStop.Click += new System.EventHandler(this.btnDCAStop_Click);
            // 
            // lblDCASummary
            // 
            this.lblDCASummary.AutoSize = true;
            this.lblDCASummary.Location = new System.Drawing.Point(6, 159);
            this.lblDCASummary.Name = "lblDCASummary";
            this.lblDCASummary.Size = new System.Drawing.Size(75, 13);
            this.lblDCASummary.TabIndex = 32;
            this.lblDCASummary.Text = "DCA Summary";
            // 
            // btnDCASell
            // 
            this.btnDCASell.BackColor = System.Drawing.Color.LightCoral;
            this.btnDCASell.Location = new System.Drawing.Point(127, 43);
            this.btnDCASell.Name = "btnDCASell";
            this.btnDCASell.Size = new System.Drawing.Size(107, 61);
            this.btnDCASell.TabIndex = 35;
            this.btnDCASell.Text = "Sell";
            this.btnDCASell.UseVisualStyleBackColor = false;
            this.btnDCASell.Click += new System.EventHandler(this.btnDCASell_Click);
            // 
            // btnDCABuy
            // 
            this.btnDCABuy.BackColor = System.Drawing.Color.LightGreen;
            this.btnDCABuy.Location = new System.Drawing.Point(14, 43);
            this.btnDCABuy.Name = "btnDCABuy";
            this.btnDCABuy.Size = new System.Drawing.Size(107, 61);
            this.btnDCABuy.TabIndex = 34;
            this.btnDCABuy.Text = "Buy";
            this.btnDCABuy.UseVisualStyleBackColor = false;
            this.btnDCABuy.Click += new System.EventHandler(this.btnDCABuy_Click);
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.btnExportCandles);
            this.tabSettings.Controls.Add(this.label8);
            this.tabSettings.Controls.Add(this.nudSettingsRetryWaitTime);
            this.tabSettings.Controls.Add(this.label7);
            this.tabSettings.Controls.Add(this.chkSettingOverloadRetry);
            this.tabSettings.Controls.Add(this.nudSettingsOverloadRetryAttempts);
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(630, 176);
            this.tabSettings.TabIndex = 1;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // btnExportCandles
            // 
            this.btnExportCandles.Location = new System.Drawing.Point(523, 6);
            this.btnExportCandles.Name = "btnExportCandles";
            this.btnExportCandles.Size = new System.Drawing.Size(101, 23);
            this.btnExportCandles.TabIndex = 5;
            this.btnExportCandles.Text = "Export Candles";
            this.btnExportCandles.UseVisualStyleBackColor = true;
            this.btnExportCandles.Click += new System.EventHandler(this.btnExportCandles_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(112, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Retry Wait Time (ms)";
            // 
            // nudSettingsRetryWaitTime
            // 
            this.nudSettingsRetryWaitTime.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudSettingsRetryWaitTime.Location = new System.Drawing.Point(6, 55);
            this.nudSettingsRetryWaitTime.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.nudSettingsRetryWaitTime.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudSettingsRetryWaitTime.Name = "nudSettingsRetryWaitTime";
            this.nudSettingsRetryWaitTime.Size = new System.Drawing.Size(100, 20);
            this.nudSettingsRetryWaitTime.TabIndex = 3;
            this.nudSettingsRetryWaitTime.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudSettingsRetryWaitTime.ValueChanged += new System.EventHandler(this.nudSettingsRetryWaitTime_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Attempts";
            // 
            // chkSettingOverloadRetry
            // 
            this.chkSettingOverloadRetry.AutoSize = true;
            this.chkSettingOverloadRetry.Location = new System.Drawing.Point(6, 6);
            this.chkSettingOverloadRetry.Name = "chkSettingOverloadRetry";
            this.chkSettingOverloadRetry.Size = new System.Drawing.Size(118, 17);
            this.chkSettingOverloadRetry.TabIndex = 1;
            this.chkSettingOverloadRetry.Text = "Retry on Overload?";
            this.chkSettingOverloadRetry.UseVisualStyleBackColor = true;
            this.chkSettingOverloadRetry.CheckedChanged += new System.EventHandler(this.chkSettingOverloadRetry_CheckedChanged);
            // 
            // nudSettingsOverloadRetryAttempts
            // 
            this.nudSettingsOverloadRetryAttempts.Location = new System.Drawing.Point(6, 29);
            this.nudSettingsOverloadRetryAttempts.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudSettingsOverloadRetryAttempts.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSettingsOverloadRetryAttempts.Name = "nudSettingsOverloadRetryAttempts";
            this.nudSettingsOverloadRetryAttempts.Size = new System.Drawing.Size(45, 20);
            this.nudSettingsOverloadRetryAttempts.TabIndex = 0;
            this.nudSettingsOverloadRetryAttempts.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSettingsOverloadRetryAttempts.ValueChanged += new System.EventHandler(this.nudSettingsOverloadRetryAttempts_ValueChanged);
            // 
            // tmrDCA
            // 
            this.tmrDCA.Tick += new System.EventHandler(this.tmrDCA_Tick);
            // 
            // gbxPosition
            // 
            this.gbxPosition.Controls.Add(this.nudPositionLimitPrice);
            this.gbxPosition.Controls.Add(this.btnPositionMarketClose);
            this.gbxPosition.Controls.Add(this.btnPositionLimitClose);
            this.gbxPosition.Controls.Add(this.textBox8);
            this.gbxPosition.Controls.Add(this.txtPositionLiquidation);
            this.gbxPosition.Controls.Add(this.textBox1);
            this.gbxPosition.Controls.Add(this.textBox2);
            this.gbxPosition.Controls.Add(this.textBox3);
            this.gbxPosition.Controls.Add(this.textBox4);
            this.gbxPosition.Controls.Add(this.textBox5);
            this.gbxPosition.Controls.Add(this.textBox7);
            this.gbxPosition.Controls.Add(this.txtPositionUnrealizedPnLPercent);
            this.gbxPosition.Controls.Add(this.txtPositionUnrealizedPnL);
            this.gbxPosition.Controls.Add(this.txtPositionMargin);
            this.gbxPosition.Controls.Add(this.txtPositionMarkPrice);
            this.gbxPosition.Controls.Add(this.txtPositionEntryPrice);
            this.gbxPosition.Controls.Add(this.txtPositionSize);
            this.gbxPosition.Location = new System.Drawing.Point(143, 7);
            this.gbxPosition.Name = "gbxPosition";
            this.gbxPosition.Size = new System.Drawing.Size(507, 59);
            this.gbxPosition.TabIndex = 15;
            this.gbxPosition.TabStop = false;
            this.gbxPosition.Text = "Position";
            this.gbxPosition.Visible = false;
            // 
            // nudPositionLimitPrice
            // 
            this.nudPositionLimitPrice.DecimalPlaces = 1;
            this.nudPositionLimitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPositionLimitPrice.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudPositionLimitPrice.Location = new System.Drawing.Point(386, 31);
            this.nudPositionLimitPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudPositionLimitPrice.Name = "nudPositionLimitPrice";
            this.nudPositionLimitPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nudPositionLimitPrice.Size = new System.Drawing.Size(61, 18);
            this.nudPositionLimitPrice.TabIndex = 19;
            // 
            // btnPositionMarketClose
            // 
            this.btnPositionMarketClose.BackColor = System.Drawing.Color.Red;
            this.btnPositionMarketClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPositionMarketClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPositionMarketClose.Location = new System.Drawing.Point(445, 13);
            this.btnPositionMarketClose.Name = "btnPositionMarketClose";
            this.btnPositionMarketClose.Size = new System.Drawing.Size(57, 37);
            this.btnPositionMarketClose.TabIndex = 18;
            this.btnPositionMarketClose.Text = "Market";
            this.btnPositionMarketClose.UseVisualStyleBackColor = false;
            this.btnPositionMarketClose.Click += new System.EventHandler(this.btnPositionMarketClose_Click);
            // 
            // btnPositionLimitClose
            // 
            this.btnPositionLimitClose.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPositionLimitClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPositionLimitClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPositionLimitClose.Location = new System.Drawing.Point(386, 13);
            this.btnPositionLimitClose.Name = "btnPositionLimitClose";
            this.btnPositionLimitClose.Size = new System.Drawing.Size(61, 18);
            this.btnPositionLimitClose.TabIndex = 17;
            this.btnPositionLimitClose.Text = "Limit";
            this.btnPositionLimitClose.UseVisualStyleBackColor = false;
            this.btnPositionLimitClose.Click += new System.EventHandler(this.btnPositionLimitClose_Click);
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(169, 14);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(55, 18);
            this.textBox8.TabIndex = 15;
            this.textBox8.Text = "Liquidation";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPositionLiquidation
            // 
            this.txtPositionLiquidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPositionLiquidation.Location = new System.Drawing.Point(169, 31);
            this.txtPositionLiquidation.Name = "txtPositionLiquidation";
            this.txtPositionLiquidation.ReadOnly = true;
            this.txtPositionLiquidation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPositionLiquidation.Size = new System.Drawing.Size(55, 18);
            this.txtPositionLiquidation.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(331, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(55, 18);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "UnrlPnL %";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(277, 14);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(55, 18);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = "UnrealPnL";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(223, 14);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(55, 18);
            this.textBox3.TabIndex = 11;
            this.textBox3.Text = "Margin";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(115, 14);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(55, 18);
            this.textBox4.TabIndex = 10;
            this.textBox4.Text = "Mark";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(61, 14);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(55, 18);
            this.textBox5.TabIndex = 9;
            this.textBox5.Text = "Entry";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(7, 14);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(55, 18);
            this.textBox7.TabIndex = 7;
            this.textBox7.Text = "Size";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPositionUnrealizedPnLPercent
            // 
            this.txtPositionUnrealizedPnLPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPositionUnrealizedPnLPercent.Location = new System.Drawing.Point(331, 31);
            this.txtPositionUnrealizedPnLPercent.Name = "txtPositionUnrealizedPnLPercent";
            this.txtPositionUnrealizedPnLPercent.ReadOnly = true;
            this.txtPositionUnrealizedPnLPercent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPositionUnrealizedPnLPercent.Size = new System.Drawing.Size(55, 18);
            this.txtPositionUnrealizedPnLPercent.TabIndex = 6;
            // 
            // txtPositionUnrealizedPnL
            // 
            this.txtPositionUnrealizedPnL.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPositionUnrealizedPnL.Location = new System.Drawing.Point(277, 31);
            this.txtPositionUnrealizedPnL.Name = "txtPositionUnrealizedPnL";
            this.txtPositionUnrealizedPnL.ReadOnly = true;
            this.txtPositionUnrealizedPnL.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPositionUnrealizedPnL.Size = new System.Drawing.Size(55, 18);
            this.txtPositionUnrealizedPnL.TabIndex = 5;
            // 
            // txtPositionMargin
            // 
            this.txtPositionMargin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPositionMargin.Location = new System.Drawing.Point(223, 31);
            this.txtPositionMargin.Name = "txtPositionMargin";
            this.txtPositionMargin.ReadOnly = true;
            this.txtPositionMargin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPositionMargin.Size = new System.Drawing.Size(55, 18);
            this.txtPositionMargin.TabIndex = 4;
            // 
            // txtPositionMarkPrice
            // 
            this.txtPositionMarkPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPositionMarkPrice.Location = new System.Drawing.Point(115, 31);
            this.txtPositionMarkPrice.Name = "txtPositionMarkPrice";
            this.txtPositionMarkPrice.ReadOnly = true;
            this.txtPositionMarkPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPositionMarkPrice.Size = new System.Drawing.Size(55, 18);
            this.txtPositionMarkPrice.TabIndex = 3;
            // 
            // txtPositionEntryPrice
            // 
            this.txtPositionEntryPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPositionEntryPrice.Location = new System.Drawing.Point(61, 31);
            this.txtPositionEntryPrice.Name = "txtPositionEntryPrice";
            this.txtPositionEntryPrice.ReadOnly = true;
            this.txtPositionEntryPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPositionEntryPrice.Size = new System.Drawing.Size(55, 18);
            this.txtPositionEntryPrice.TabIndex = 2;
            // 
            // txtPositionSize
            // 
            this.txtPositionSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPositionSize.Location = new System.Drawing.Point(7, 31);
            this.txtPositionSize.Name = "txtPositionSize";
            this.txtPositionSize.ReadOnly = true;
            this.txtPositionSize.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPositionSize.Size = new System.Drawing.Size(55, 18);
            this.txtPositionSize.TabIndex = 0;
            // 
            // lblTimeUTC
            // 
            this.lblTimeUTC.AutoSize = true;
            this.lblTimeUTC.Location = new System.Drawing.Point(9, 51);
            this.lblTimeUTC.Name = "lblTimeUTC";
            this.lblTimeUTC.Size = new System.Drawing.Size(52, 13);
            this.lblTimeUTC.TabIndex = 16;
            this.lblTimeUTC.Text = "UTCTime";
            // 
            // Bot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 296);
            this.Controls.Add(this.lblTimeUTC);
            this.Controls.Add(this.gbxPosition);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ddlSymbol);
            this.Controls.Add(this.ddlCandleTimes);
            this.Controls.Add(this.StatusStrip);
            this.Name = "Bot";
            this.Text = "Bot";
            this.Load += new System.EventHandler(this.Bot_Load);
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabSpread.ResumeLayout(false);
            this.tabSpread.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpreadSellOrderCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpreadSellValueApart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpreadSellContractsEach)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpreadBuyOrderCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpreadBuyValueApart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpreadBuyContractsEach)).EndInit();
            this.tabDCA.ResumeLayout(false);
            this.tabDCA.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDCAContracts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDCAHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDCASeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDCATimes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDCAMinutes)).EndInit();
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSettingsRetryWaitTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSettingsOverloadRetryAttempts)).EndInit();
            this.gbxPosition.ResumeLayout(false);
            this.gbxPosition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPositionLimitPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblBalance;
        private System.Windows.Forms.ComboBox ddlCandleTimes;
        private System.Windows.Forms.ComboBox ddlSymbol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer Heartbeat;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDCA;
        private System.Windows.Forms.Label lblalskdj;
        private System.Windows.Forms.NumericUpDown nudDCASeconds;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudDCAMinutes;
        private System.Windows.Forms.Button btnDCAStop;
        private System.Windows.Forms.Label lblDCASummary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudDCATimes;
        private System.Windows.Forms.NumericUpDown nudDCAHours;
        private System.Windows.Forms.NumericUpDown nudDCAContracts;
        private System.Windows.Forms.Button btnDCASell;
        private System.Windows.Forms.Button btnDCABuy;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.Timer tmrDCA;
        private System.Windows.Forms.ProgressBar pgbDCA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkDCAReduceOnly;
        private System.Windows.Forms.CheckBox chkDCAExecuteImmediately;
        private System.Windows.Forms.GroupBox gbxPosition;
        private System.Windows.Forms.Label lblTimeUTC;
        private System.Windows.Forms.Button btnPositionMarketClose;
        private System.Windows.Forms.Button btnPositionLimitClose;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox txtPositionLiquidation;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox txtPositionUnrealizedPnLPercent;
        private System.Windows.Forms.TextBox txtPositionUnrealizedPnL;
        private System.Windows.Forms.TextBox txtPositionMargin;
        private System.Windows.Forms.TextBox txtPositionMarkPrice;
        private System.Windows.Forms.TextBox txtPositionEntryPrice;
        private System.Windows.Forms.TextBox txtPositionSize;
        private System.Windows.Forms.NumericUpDown nudPositionLimitPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudSettingsRetryWaitTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkSettingOverloadRetry;
        private System.Windows.Forms.NumericUpDown nudSettingsOverloadRetryAttempts;
        private System.Windows.Forms.TabPage tabSpread;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudSpreadBuyValueApart;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudSpreadBuyOrderCount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nudSpreadBuyContractsEach;
        private System.Windows.Forms.Button btnSpreadPlaceOrders;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkSpreadSellExecute;
        private System.Windows.Forms.NumericUpDown nudSpreadSellOrderCount;
        private System.Windows.Forms.CheckBox chkSpreadSellReduceOnly;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nudSpreadSellValueApart;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown nudSpreadSellContractsEach;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkSpreadBuyExecute;
        private System.Windows.Forms.CheckBox chkSpreadBuyReduceOnly;
        private System.Windows.Forms.Button btnSpreadCloseAllOpenOrders;
        private System.Windows.Forms.CheckBox chkSpreadCancelWhileOrdering;
        private System.Windows.Forms.CheckBox chkSpreadSellPostOnly;
        private System.Windows.Forms.CheckBox chkSpreadyBuyPostOnly;
        private System.Windows.Forms.Button btnExportCandles;
    }
}