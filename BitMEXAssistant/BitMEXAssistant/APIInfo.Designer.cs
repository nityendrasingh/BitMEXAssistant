namespace BitMEXAssistant
{
    partial class APIInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(APIInfo));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtSecret = new System.Windows.Forms.TextBox();
            this.btnValidate = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblAPIStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbNetworkTest = new System.Windows.Forms.RadioButton();
            this.rbNetworkReal = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.chkConsent = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Key:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Secret:";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(59, 12);
            this.txtKey.Name = "txtKey";
            this.txtKey.PasswordChar = '*';
            this.txtKey.Size = new System.Drawing.Size(391, 20);
            this.txtKey.TabIndex = 2;
            this.txtKey.Text = "AKL23@LWLJCMQPQIOSCU3829";
            this.txtKey.TextChanged += new System.EventHandler(this.txtKey_TextChanged);
            // 
            // txtSecret
            // 
            this.txtSecret.Location = new System.Drawing.Point(59, 37);
            this.txtSecret.Name = "txtSecret";
            this.txtSecret.PasswordChar = '*';
            this.txtSecret.Size = new System.Drawing.Size(391, 20);
            this.txtSecret.TabIndex = 3;
            this.txtSecret.Text = "AKL23@LWLJCMQPQIOSCU3829";
            this.txtSecret.TextChanged += new System.EventHandler(this.txtSecret_TextChanged);
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(454, 10);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(63, 50);
            this.btnValidate.TabIndex = 4;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblAPIStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 152);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(523, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblAPIStatus
            // 
            this.lblAPIStatus.Name = "lblAPIStatus";
            this.lblAPIStatus.Size = new System.Drawing.Size(199, 17);
            this.lblAPIStatus.Text = "Please enter your API key and secret.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbNetworkTest);
            this.groupBox1.Controls.Add(this.rbNetworkReal);
            this.groupBox1.Location = new System.Drawing.Point(455, 63);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(61, 83);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Network";
            // 
            // rbNetworkTest
            // 
            this.rbNetworkTest.AutoSize = true;
            this.rbNetworkTest.Location = new System.Drawing.Point(8, 39);
            this.rbNetworkTest.Name = "rbNetworkTest";
            this.rbNetworkTest.Size = new System.Drawing.Size(46, 17);
            this.rbNetworkTest.TabIndex = 1;
            this.rbNetworkTest.Text = "Test";
            this.rbNetworkTest.UseVisualStyleBackColor = true;
            this.rbNetworkTest.CheckedChanged += new System.EventHandler(this.rbNetworkTest_CheckedChanged);
            // 
            // rbNetworkReal
            // 
            this.rbNetworkReal.AutoSize = true;
            this.rbNetworkReal.Checked = true;
            this.rbNetworkReal.Location = new System.Drawing.Point(8, 16);
            this.rbNetworkReal.Name = "rbNetworkReal";
            this.rbNetworkReal.Size = new System.Drawing.Size(47, 17);
            this.rbNetworkReal.TabIndex = 0;
            this.rbNetworkReal.TabStop = true;
            this.rbNetworkReal.Text = "Real";
            this.rbNetworkReal.UseVisualStyleBackColor = true;
            this.rbNetworkReal.CheckedChanged += new System.EventHandler(this.rbNetworkReal_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(427, 60);
            this.label3.TabIndex = 8;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // chkConsent
            // 
            this.chkConsent.AutoSize = true;
            this.chkConsent.Location = new System.Drawing.Point(109, 54);
            this.chkConsent.Name = "chkConsent";
            this.chkConsent.Size = new System.Drawing.Size(85, 17);
            this.chkConsent.TabIndex = 9;
            this.chkConsent.Text = "I understand";
            this.chkConsent.UseVisualStyleBackColor = true;
            this.chkConsent.CheckedChanged += new System.EventHandler(this.chkConsent_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkConsent);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(13, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(439, 83);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // APIInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 174);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.txtSecret);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "APIInfo";
            this.Text = "API Information";
            this.Load += new System.EventHandler(this.APIInfo_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TextBox txtSecret;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblAPIStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNetworkTest;
        private System.Windows.Forms.RadioButton rbNetworkReal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkConsent;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

