namespace MessageSpammer
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.picMap = new System.Windows.Forms.PictureBox();
            this.rtbInfo = new System.Windows.Forms.RichTextBox();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messageSpammerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMap)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Desktop;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(790, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // picMap
            // 
            this.picMap.Image = ((System.Drawing.Image)(resources.GetObject("picMap.Image")));
            this.picMap.Location = new System.Drawing.Point(12, 65);
            this.picMap.Name = "picMap";
            this.picMap.Size = new System.Drawing.Size(317, 306);
            this.picMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMap.TabIndex = 1;
            this.picMap.TabStop = false;
            // 
            // rtbInfo
            // 
            this.rtbInfo.Location = new System.Drawing.Point(335, 65);
            this.rtbInfo.Name = "rtbInfo";
            this.rtbInfo.Size = new System.Drawing.Size(435, 306);
            this.rtbInfo.TabIndex = 2;
            this.rtbInfo.Text = "SERC Email Address:\ninfo@serc.ac.uk \n\nSERC Contact Number:\n0345-600-7555\n\nBangor " +
    "Campus Address:\nSouth Eastern Regional College, Castle Park Road, Bangor,Co. Dow" +
    "n, BT20 4TD ";
            this.rtbInfo.ZoomFactor = 1.5F;
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.messageSpammerToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.systemToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.systemToolStripMenuItem.Text = "System";
            // 
            // messageSpammerToolStripMenuItem
            // 
            this.messageSpammerToolStripMenuItem.Name = "messageSpammerToolStripMenuItem";
            this.messageSpammerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.messageSpammerToolStripMenuItem.Text = "Message Spammer";
            this.messageSpammerToolStripMenuItem.Click += new System.EventHandler(this.MessageSpammerToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(790, 410);
            this.Controls.Add(this.rtbInfo);
            this.Controls.Add(this.picMap);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Message Spammer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox picMap;
        private System.Windows.Forms.RichTextBox rtbInfo;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem messageSpammerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}