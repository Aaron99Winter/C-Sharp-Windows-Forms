namespace MessageSpammer
{
    partial class frmSpammer
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
            this.grpEnterDetails = new System.Windows.Forms.GroupBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lblRun = new System.Windows.Forms.Label();
            this.txtTimes = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lstMessage = new System.Windows.Forms.ListBox();
            this.grpEnterDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpEnterDetails
            // 
            this.grpEnterDetails.BackColor = System.Drawing.Color.Crimson;
            this.grpEnterDetails.Controls.Add(this.lstMessage);
            this.grpEnterDetails.Controls.Add(this.btnLogout);
            this.grpEnterDetails.Controls.Add(this.btnRun);
            this.grpEnterDetails.Controls.Add(this.btnClear);
            this.grpEnterDetails.Controls.Add(this.txtTimes);
            this.grpEnterDetails.Controls.Add(this.lblRun);
            this.grpEnterDetails.Controls.Add(this.txtMessage);
            this.grpEnterDetails.Controls.Add(this.lblMessage);
            this.grpEnterDetails.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpEnterDetails.Location = new System.Drawing.Point(13, 13);
            this.grpEnterDetails.Name = "grpEnterDetails";
            this.grpEnterDetails.Size = new System.Drawing.Size(494, 228);
            this.grpEnterDetails.TabIndex = 0;
            this.grpEnterDetails.TabStop = false;
            this.grpEnterDetails.Text = "Danger Zone";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(6, 28);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(78, 13);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "Enter Message";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(9, 44);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(159, 20);
            this.txtMessage.TabIndex = 1;
            // 
            // lblRun
            // 
            this.lblRun.AutoSize = true;
            this.lblRun.Location = new System.Drawing.Point(6, 67);
            this.lblRun.Name = "lblRun";
            this.lblRun.Size = new System.Drawing.Size(84, 13);
            this.lblRun.TabIndex = 2;
            this.lblRun.Text = "How many times";
            // 
            // txtTimes
            // 
            this.txtTimes.Location = new System.Drawing.Point(9, 83);
            this.txtTimes.Name = "txtTimes";
            this.txtTimes.Size = new System.Drawing.Size(81, 20);
            this.txtTimes.TabIndex = 3;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(9, 138);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 24);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(96, 138);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(76, 24);
            this.btnRun.TabIndex = 5;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.BtnRun_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(9, 168);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(163, 24);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // lstMessage
            // 
            this.lstMessage.FormattingEnabled = true;
            this.lstMessage.Location = new System.Drawing.Point(236, 44);
            this.lstMessage.Name = "lstMessage";
            this.lstMessage.Size = new System.Drawing.Size(239, 147);
            this.lstMessage.TabIndex = 7;
            // 
            // frmSpammer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpEnterDetails);
            this.Name = "frmSpammer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frnSpammer";
            this.grpEnterDetails.ResumeLayout(false);
            this.grpEnterDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEnterDetails;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.ListBox lstMessage;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtTimes;
        private System.Windows.Forms.Label lblRun;
        private System.Windows.Forms.TextBox txtMessage;
    }
}