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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtSecret = new System.Windows.Forms.TextBox();
            this.btnValidate = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblAPIStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
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
            this.txtKey.Enabled = false;
            this.txtKey.Location = new System.Drawing.Point(59, 12);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(391, 20);
            this.txtKey.TabIndex = 2;
            this.txtKey.Text = "AKL23@LWLJCMQPQIOSCU3829";
            // 
            // txtSecret
            // 
            this.txtSecret.Location = new System.Drawing.Point(59, 37);
            this.txtSecret.Name = "txtSecret";
            this.txtSecret.Size = new System.Drawing.Size(391, 20);
            this.txtSecret.TabIndex = 3;
            this.txtSecret.Text = "AKL23@LWLJCMQPQIOSCU3829";
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(457, 12);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(63, 45);
            this.btnValidate.TabIndex = 4;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblAPIStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 64);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(523, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblAPIStatus
            // 
            this.lblAPIStatus.Name = "lblAPIStatus";
            this.lblAPIStatus.Size = new System.Drawing.Size(118, 17);
            this.lblAPIStatus.Text = "toolStripStatusLabel1";
            // 
            // APIInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 86);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.txtSecret);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "APIInfo";
            this.Text = "API Information";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
    }
}

