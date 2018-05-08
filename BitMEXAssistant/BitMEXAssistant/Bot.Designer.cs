namespace BitMEXAssistant
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
            this.tabDCA = new System.Windows.Forms.TabPage();
            this.lblalskdj = new System.Windows.Forms.Label();
            this.nudDCASeconds = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudDCAMinutes = new System.Windows.Forms.NumericUpDown();
            this.btnDCAStop = new System.Windows.Forms.Button();
            this.lblDCASummary = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudDCATimes = new System.Windows.Forms.NumericUpDown();
            this.nudDCAHours = new System.Windows.Forms.NumericUpDown();
            this.nudDCAContracts = new System.Windows.Forms.NumericUpDown();
            this.btnDCASell = new System.Windows.Forms.Button();
            this.btnDCABuy = new System.Windows.Forms.Button();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.tmrDCA = new System.Windows.Forms.Timer(this.components);
            this.pgbDCA = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkDCAReduceOnly = new System.Windows.Forms.CheckBox();
            this.chkDCAExecuteImmediately = new System.Windows.Forms.CheckBox();
            this.StatusStrip.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabDCA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDCASeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDCAMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDCATimes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDCAHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDCAContracts)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblBalance});
            this.StatusStrip.Location = new System.Drawing.Point(0, 342);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(593, 22);
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
            this.label2.Location = new System.Drawing.Point(97, 7);
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
            this.tabControl1.Controls.Add(this.tabDCA);
            this.tabControl1.Controls.Add(this.tabSettings);
            this.tabControl1.Location = new System.Drawing.Point(12, 50);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(569, 289);
            this.tabControl1.TabIndex = 14;
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
            this.tabDCA.Size = new System.Drawing.Size(561, 263);
            this.tabDCA.TabIndex = 0;
            this.tabDCA.Text = "DCA";
            this.tabDCA.UseVisualStyleBackColor = true;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Minutes";
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
            this.lblDCASummary.Location = new System.Drawing.Point(11, 205);
            this.lblDCASummary.Name = "lblDCASummary";
            this.lblDCASummary.Size = new System.Drawing.Size(75, 13);
            this.lblDCASummary.TabIndex = 32;
            this.lblDCASummary.Text = "DCA Summary";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Hours";
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
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(561, 263);
            this.tabSettings.TabIndex = 1;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // tmrDCA
            // 
            this.tmrDCA.Tick += new System.EventHandler(this.tmrDCA_Tick);
            // 
            // pgbDCA
            // 
            this.pgbDCA.Location = new System.Drawing.Point(14, 14);
            this.pgbDCA.Name = "pgbDCA";
            this.pgbDCA.Size = new System.Drawing.Size(323, 23);
            this.pgbDCA.TabIndex = 46;
            this.pgbDCA.Visible = false;
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
            this.groupBox1.Size = new System.Drawing.Size(212, 192);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DCA Settings";
            // 
            // chkDCAReduceOnly
            // 
            this.chkDCAReduceOnly.AutoSize = true;
            this.chkDCAReduceOnly.Location = new System.Drawing.Point(6, 144);
            this.chkDCAReduceOnly.Name = "chkDCAReduceOnly";
            this.chkDCAReduceOnly.Size = new System.Drawing.Size(88, 17);
            this.chkDCAReduceOnly.TabIndex = 48;
            this.chkDCAReduceOnly.Text = "Reduce Only";
            this.chkDCAReduceOnly.UseVisualStyleBackColor = true;
            this.chkDCAReduceOnly.CheckedChanged += new System.EventHandler(this.chkDCAReduceOnly_CheckedChanged);
            // 
            // chkDCAExecuteImmediately
            // 
            this.chkDCAExecuteImmediately.AutoSize = true;
            this.chkDCAExecuteImmediately.Checked = true;
            this.chkDCAExecuteImmediately.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDCAExecuteImmediately.Location = new System.Drawing.Point(6, 167);
            this.chkDCAExecuteImmediately.Name = "chkDCAExecuteImmediately";
            this.chkDCAExecuteImmediately.Size = new System.Drawing.Size(123, 17);
            this.chkDCAExecuteImmediately.TabIndex = 49;
            this.chkDCAExecuteImmediately.Text = "Execute Immediately";
            this.chkDCAExecuteImmediately.UseVisualStyleBackColor = true;
            this.chkDCAExecuteImmediately.CheckedChanged += new System.EventHandler(this.chkDCAExecuteImmediately_CheckedChanged);
            // 
            // Bot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 364);
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
            this.tabDCA.ResumeLayout(false);
            this.tabDCA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDCASeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDCAMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDCATimes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDCAHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDCAContracts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}