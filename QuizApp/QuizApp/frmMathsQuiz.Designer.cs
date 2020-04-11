namespace QuizApp
{
    partial class frmMathsQuiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMathsQuiz));
            this.grpLeftSide = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblHelp = new System.Windows.Forms.Label();
            this.btnResults = new System.Windows.Forms.Button();
            this.btnStudy = new System.Windows.Forms.Button();
            this.btnQuiz = new System.Windows.Forms.Button();
            this.lnkHelpDoc = new System.Windows.Forms.LinkLabel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl24 = new System.Windows.Forms.Label();
            this.lbl16 = new System.Windows.Forms.Label();
            this.lbl30 = new System.Windows.Forms.Label();
            this.pnlCorrect = new System.Windows.Forms.Panel();
            this.lblCorrectCount = new System.Windows.Forms.Label();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.pnlIncorrect = new System.Windows.Forms.Panel();
            this.lblIncorrectCount = new System.Windows.Forms.Label();
            this.lblIncorrect = new System.Windows.Forms.Label();
            this.lbl162_Drop = new System.Windows.Forms.Label();
            this.lbl242_Drop = new System.Windows.Forms.Label();
            this.lbl241_Drop = new System.Windows.Forms.Label();
            this.lbl302_Drop = new System.Windows.Forms.Label();
            this.lbl161_Drop = new System.Windows.Forms.Label();
            this.lbl301_Drop = new System.Windows.Forms.Label();
            this.grpLeftSide.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnlCorrect.SuspendLayout();
            this.pnlIncorrect.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpLeftSide
            // 
            this.grpLeftSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(138)))), ((int)(((byte)(57)))));
            this.grpLeftSide.Controls.Add(this.lblName);
            this.grpLeftSide.Controls.Add(this.lblHelp);
            this.grpLeftSide.Controls.Add(this.btnResults);
            this.grpLeftSide.Controls.Add(this.btnStudy);
            this.grpLeftSide.Controls.Add(this.btnQuiz);
            this.grpLeftSide.Controls.Add(this.lnkHelpDoc);
            this.grpLeftSide.Controls.Add(this.lblTitle);
            this.grpLeftSide.Location = new System.Drawing.Point(-22, -43);
            this.grpLeftSide.Name = "grpLeftSide";
            this.grpLeftSide.Size = new System.Drawing.Size(321, 545);
            this.grpLeftSide.TabIndex = 7;
            this.grpLeftSide.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(138)))), ((int)(((byte)(57)))));
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(83, 80);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Name";
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelp.Location = new System.Drawing.Point(30, 424);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(290, 76);
            this.lblHelp.TabIndex = 6;
            this.lblHelp.Text = "If you need help or don\'t know what to do\r\n        then click the blue button bel" +
    "ow\r\n                                  |\r\n                                 \\/\r\n";
            // 
            // btnResults
            // 
            this.btnResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(138)))), ((int)(((byte)(57)))));
            this.btnResults.FlatAppearance.BorderSize = 0;
            this.btnResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResults.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResults.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnResults.Location = new System.Drawing.Point(23, 294);
            this.btnResults.Name = "btnResults";
            this.btnResults.Size = new System.Drawing.Size(294, 70);
            this.btnResults.TabIndex = 5;
            this.btnResults.Text = "Results";
            this.btnResults.UseVisualStyleBackColor = false;
            this.btnResults.Click += new System.EventHandler(this.btnResults_Click);
            // 
            // btnStudy
            // 
            this.btnStudy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(138)))), ((int)(((byte)(57)))));
            this.btnStudy.FlatAppearance.BorderSize = 0;
            this.btnStudy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudy.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStudy.Location = new System.Drawing.Point(23, 218);
            this.btnStudy.Name = "btnStudy";
            this.btnStudy.Size = new System.Drawing.Size(294, 70);
            this.btnStudy.TabIndex = 3;
            this.btnStudy.Text = "Study";
            this.btnStudy.UseVisualStyleBackColor = false;
            this.btnStudy.Click += new System.EventHandler(this.btnStudy_Click);
            // 
            // btnQuiz
            // 
            this.btnQuiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(138)))), ((int)(((byte)(57)))));
            this.btnQuiz.FlatAppearance.BorderSize = 0;
            this.btnQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuiz.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuiz.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnQuiz.Location = new System.Drawing.Point(22, 142);
            this.btnQuiz.Name = "btnQuiz";
            this.btnQuiz.Size = new System.Drawing.Size(294, 70);
            this.btnQuiz.TabIndex = 2;
            this.btnQuiz.Text = "Quiz";
            this.btnQuiz.UseVisualStyleBackColor = false;
            this.btnQuiz.Click += new System.EventHandler(this.btnQuiz_Click);
            // 
            // lnkHelpDoc
            // 
            this.lnkHelpDoc.AutoSize = true;
            this.lnkHelpDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkHelpDoc.Location = new System.Drawing.Point(104, 509);
            this.lnkHelpDoc.Name = "lnkHelpDoc";
            this.lnkHelpDoc.Size = new System.Drawing.Size(130, 25);
            this.lnkHelpDoc.TabIndex = 1;
            this.lnkHelpDoc.TabStop = true;
            this.lnkHelpDoc.Text = "User Guide";
            this.lnkHelpDoc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkHelpDoc_LinkClicked);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 21F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitle.Location = new System.Drawing.Point(22, 100);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(295, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Rathmore Quiz App";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(108)))), ((int)(((byte)(27)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemToolStripMenuItem,
            this.userToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExitButton});
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.systemToolStripMenuItem.Text = "System";
            // 
            // mnuExitButton
            // 
            this.mnuExitButton.Name = "mnuExitButton";
            this.mnuExitButton.Size = new System.Drawing.Size(95, 22);
            this.mnuExitButton.Text = "Exit";
            this.mnuExitButton.Click += new System.EventHandler(this.mnuExitButton_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLogout});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.userToolStripMenuItem.Text = "User";
            // 
            // mnuLogout
            // 
            this.mnuLogout.Name = "mnuLogout";
            this.mnuLogout.Size = new System.Drawing.Size(116, 22);
            this.mnuLogout.Text = "Log out";
            this.mnuLogout.Click += new System.EventHandler(this.mnuLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(685, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // lbl24
            // 
            this.lbl24.AutoSize = true;
            this.lbl24.Font = new System.Drawing.Font("Microsoft YaHei UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl24.Location = new System.Drawing.Point(317, 360);
            this.lbl24.Name = "lbl24";
            this.lbl24.Size = new System.Drawing.Size(115, 86);
            this.lbl24.TabIndex = 54;
            this.lbl24.Text = "24";
            this.lbl24.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl24_MouseDown);
            // 
            // lbl16
            // 
            this.lbl16.AutoSize = true;
            this.lbl16.Font = new System.Drawing.Font("Microsoft YaHei UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl16.Location = new System.Drawing.Point(428, 360);
            this.lbl16.Name = "lbl16";
            this.lbl16.Size = new System.Drawing.Size(115, 86);
            this.lbl16.TabIndex = 55;
            this.lbl16.Text = "16";
            this.lbl16.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl16_MouseDown);
            // 
            // lbl30
            // 
            this.lbl30.AutoSize = true;
            this.lbl30.Font = new System.Drawing.Font("Microsoft YaHei UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl30.Location = new System.Drawing.Point(537, 360);
            this.lbl30.Name = "lbl30";
            this.lbl30.Size = new System.Drawing.Size(115, 86);
            this.lbl30.TabIndex = 56;
            this.lbl30.Text = "30";
            this.lbl30.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl30_MouseDown);
            // 
            // pnlCorrect
            // 
            this.pnlCorrect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(138)))), ((int)(((byte)(57)))));
            this.pnlCorrect.Controls.Add(this.lblCorrectCount);
            this.pnlCorrect.Controls.Add(this.lblCorrect);
            this.pnlCorrect.Location = new System.Drawing.Point(683, 345);
            this.pnlCorrect.Name = "pnlCorrect";
            this.pnlCorrect.Size = new System.Drawing.Size(147, 126);
            this.pnlCorrect.TabIndex = 57;
            // 
            // lblCorrectCount
            // 
            this.lblCorrectCount.AutoSize = true;
            this.lblCorrectCount.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrectCount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCorrectCount.Location = new System.Drawing.Point(54, 51);
            this.lblCorrectCount.Name = "lblCorrectCount";
            this.lblCorrectCount.Size = new System.Drawing.Size(42, 46);
            this.lblCorrectCount.TabIndex = 1;
            this.lblCorrectCount.Text = "0";
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCorrect.Location = new System.Drawing.Point(32, 2);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(82, 26);
            this.lblCorrect.TabIndex = 0;
            this.lblCorrect.Text = "Correct";
            // 
            // pnlIncorrect
            // 
            this.pnlIncorrect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(138)))), ((int)(((byte)(57)))));
            this.pnlIncorrect.Controls.Add(this.lblIncorrectCount);
            this.pnlIncorrect.Controls.Add(this.lblIncorrect);
            this.pnlIncorrect.Location = new System.Drawing.Point(841, 345);
            this.pnlIncorrect.Name = "pnlIncorrect";
            this.pnlIncorrect.Size = new System.Drawing.Size(147, 126);
            this.pnlIncorrect.TabIndex = 58;
            // 
            // lblIncorrectCount
            // 
            this.lblIncorrectCount.AutoSize = true;
            this.lblIncorrectCount.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncorrectCount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIncorrectCount.Location = new System.Drawing.Point(53, 51);
            this.lblIncorrectCount.Name = "lblIncorrectCount";
            this.lblIncorrectCount.Size = new System.Drawing.Size(42, 46);
            this.lblIncorrectCount.TabIndex = 2;
            this.lblIncorrectCount.Text = "0";
            // 
            // lblIncorrect
            // 
            this.lblIncorrect.AutoSize = true;
            this.lblIncorrect.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncorrect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIncorrect.Location = new System.Drawing.Point(24, 2);
            this.lblIncorrect.Name = "lblIncorrect";
            this.lblIncorrect.Size = new System.Drawing.Size(97, 26);
            this.lblIncorrect.TabIndex = 1;
            this.lblIncorrect.Text = "Incorrect";
            // 
            // lbl162_Drop
            // 
            this.lbl162_Drop.AllowDrop = true;
            this.lbl162_Drop.Image = global::QuizApp.Properties.Resources.resized_12_4;
            this.lbl162_Drop.Location = new System.Drawing.Point(770, 175);
            this.lbl162_Drop.Name = "lbl162_Drop";
            this.lbl162_Drop.Size = new System.Drawing.Size(227, 121);
            this.lbl162_Drop.TabIndex = 52;
            this.lbl162_Drop.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbl162_Drop_DragDrop);
            this.lbl162_Drop.DragEnter += new System.Windows.Forms.DragEventHandler(this.lbl162_Drop_DragEnter);
            // 
            // lbl242_Drop
            // 
            this.lbl242_Drop.AllowDrop = true;
            this.lbl242_Drop.Image = global::QuizApp.Properties.Resources.resized_12_12;
            this.lbl242_Drop.Location = new System.Drawing.Point(537, 175);
            this.lbl242_Drop.Name = "lbl242_Drop";
            this.lbl242_Drop.Size = new System.Drawing.Size(227, 121);
            this.lbl242_Drop.TabIndex = 51;
            this.lbl242_Drop.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbl242_Drop_DragDrop);
            this.lbl242_Drop.DragEnter += new System.Windows.Forms.DragEventHandler(this.lbl242_Drop_DragEnter);
            // 
            // lbl241_Drop
            // 
            this.lbl241_Drop.AllowDrop = true;
            this.lbl241_Drop.Image = global::QuizApp.Properties.Resources.resized_18_6;
            this.lbl241_Drop.Location = new System.Drawing.Point(304, 175);
            this.lbl241_Drop.Name = "lbl241_Drop";
            this.lbl241_Drop.Size = new System.Drawing.Size(227, 121);
            this.lbl241_Drop.TabIndex = 50;
            this.lbl241_Drop.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbl241_Drop_DragDrop);
            this.lbl241_Drop.DragEnter += new System.Windows.Forms.DragEventHandler(this.lbl241_Drop_DragEnter);
            // 
            // lbl302_Drop
            // 
            this.lbl302_Drop.AllowDrop = true;
            this.lbl302_Drop.Image = global::QuizApp.Properties.Resources.resized_22_8;
            this.lbl302_Drop.Location = new System.Drawing.Point(770, 32);
            this.lbl302_Drop.Name = "lbl302_Drop";
            this.lbl302_Drop.Size = new System.Drawing.Size(227, 121);
            this.lbl302_Drop.TabIndex = 47;
            this.lbl302_Drop.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbl302_Drop_DragDrop);
            this.lbl302_Drop.DragEnter += new System.Windows.Forms.DragEventHandler(this.lbl302_Drop_DragEnter);
            // 
            // lbl161_Drop
            // 
            this.lbl161_Drop.AllowDrop = true;
            this.lbl161_Drop.Image = global::QuizApp.Properties.Resources.resized_2_14;
            this.lbl161_Drop.Location = new System.Drawing.Point(537, 32);
            this.lbl161_Drop.Name = "lbl161_Drop";
            this.lbl161_Drop.Size = new System.Drawing.Size(227, 121);
            this.lbl161_Drop.TabIndex = 46;
            this.lbl161_Drop.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbl161_Drop_DragDrop);
            this.lbl161_Drop.DragEnter += new System.Windows.Forms.DragEventHandler(this.lbl161_Drop_DragEnter);
            // 
            // lbl301_Drop
            // 
            this.lbl301_Drop.AllowDrop = true;
            this.lbl301_Drop.Image = global::QuizApp.Properties.Resources.resized_18_12;
            this.lbl301_Drop.Location = new System.Drawing.Point(304, 32);
            this.lbl301_Drop.Name = "lbl301_Drop";
            this.lbl301_Drop.Size = new System.Drawing.Size(227, 121);
            this.lbl301_Drop.TabIndex = 45;
            this.lbl301_Drop.Click += new System.EventHandler(this.lbl301_Drop_Click);
            this.lbl301_Drop.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbl301_Drop_DragDrop);
            this.lbl301_Drop.DragEnter += new System.Windows.Forms.DragEventHandler(this.lbl301_Drop_DragEnter);
            // 
            // frmMathsQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.pnlIncorrect);
            this.Controls.Add(this.pnlCorrect);
            this.Controls.Add(this.lbl30);
            this.Controls.Add(this.lbl16);
            this.Controls.Add(this.lbl24);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl162_Drop);
            this.Controls.Add(this.lbl242_Drop);
            this.Controls.Add(this.lbl241_Drop);
            this.Controls.Add(this.lbl302_Drop);
            this.Controls.Add(this.lbl161_Drop);
            this.Controls.Add(this.lbl301_Drop);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.grpLeftSide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMathsQuiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMathsQuiz";
            this.grpLeftSide.ResumeLayout(false);
            this.grpLeftSide.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlCorrect.ResumeLayout(false);
            this.pnlCorrect.PerformLayout();
            this.pnlIncorrect.ResumeLayout(false);
            this.pnlIncorrect.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLeftSide;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.Button btnResults;
        private System.Windows.Forms.Button btnStudy;
        private System.Windows.Forms.Button btnQuiz;
        private System.Windows.Forms.LinkLabel lnkHelpDoc;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuExitButton;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuLogout;
        private System.Windows.Forms.Label lbl301_Drop;
        private System.Windows.Forms.Label lbl161_Drop;
        private System.Windows.Forms.Label lbl302_Drop;
        private System.Windows.Forms.Label lbl162_Drop;
        private System.Windows.Forms.Label lbl242_Drop;
        private System.Windows.Forms.Label lbl241_Drop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl24;
        private System.Windows.Forms.Label lbl16;
        private System.Windows.Forms.Label lbl30;
        private System.Windows.Forms.Panel pnlCorrect;
        private System.Windows.Forms.Label lblCorrectCount;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.Panel pnlIncorrect;
        private System.Windows.Forms.Label lblIncorrectCount;
        private System.Windows.Forms.Label lblIncorrect;
    }
}