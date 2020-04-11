namespace QuizApp
{
    partial class frmGeoQuiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGeoQuiz));
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
            this.lblSpain_Drop = new System.Windows.Forms.Label();
            this.lblRussia_Drop = new System.Windows.Forms.Label();
            this.lblUK_Drop = new System.Windows.Forms.Label();
            this.lblGermany_Drop = new System.Windows.Forms.Label();
            this.lbIItaly_Drop = new System.Windows.Forms.Label();
            this.lblFrance_Drop = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblGermany = new System.Windows.Forms.Label();
            this.lblUK = new System.Windows.Forms.Label();
            this.lblItaly = new System.Windows.Forms.Label();
            this.lblSpain = new System.Windows.Forms.Label();
            this.lblRussia = new System.Windows.Forms.Label();
            this.lblFrance = new System.Windows.Forms.Label();
            this.pnlCorrect = new System.Windows.Forms.Panel();
            this.lblCorrectCount = new System.Windows.Forms.Label();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.pnlIncorrect = new System.Windows.Forms.Panel();
            this.lblIncorrectCount = new System.Windows.Forms.Label();
            this.lblIncorrect = new System.Windows.Forms.Label();
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
            this.mnuExitButton.Size = new System.Drawing.Size(180, 22);
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
            this.mnuLogout.Size = new System.Drawing.Size(180, 22);
            this.mnuLogout.Text = "Log out";
            this.mnuLogout.Click += new System.EventHandler(this.mnuLogout_Click);
            // 
            // lblSpain_Drop
            // 
            this.lblSpain_Drop.AllowDrop = true;
            this.lblSpain_Drop.Image = global::QuizApp.Properties.Resources.Spain_Resized;
            this.lblSpain_Drop.Location = new System.Drawing.Point(755, 206);
            this.lblSpain_Drop.Name = "lblSpain_Drop";
            this.lblSpain_Drop.Size = new System.Drawing.Size(150, 150);
            this.lblSpain_Drop.TabIndex = 23;
            this.lblSpain_Drop.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblSpain_Drop_DragDrop);
            this.lblSpain_Drop.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblSpain_Drop_DragEnter);
            // 
            // lblRussia_Drop
            // 
            this.lblRussia_Drop.AllowDrop = true;
            this.lblRussia_Drop.Image = global::QuizApp.Properties.Resources.Russia_Resized;
            this.lblRussia_Drop.Location = new System.Drawing.Point(535, 206);
            this.lblRussia_Drop.Name = "lblRussia_Drop";
            this.lblRussia_Drop.Size = new System.Drawing.Size(150, 150);
            this.lblRussia_Drop.TabIndex = 22;
            this.lblRussia_Drop.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblRussia_Drop_DragDrop);
            this.lblRussia_Drop.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblRussia_Drop_DragEnter);
            // 
            // lblUK_Drop
            // 
            this.lblUK_Drop.AllowDrop = true;
            this.lblUK_Drop.Image = global::QuizApp.Properties.Resources.UK_Resized;
            this.lblUK_Drop.Location = new System.Drawing.Point(319, 206);
            this.lblUK_Drop.Name = "lblUK_Drop";
            this.lblUK_Drop.Size = new System.Drawing.Size(150, 150);
            this.lblUK_Drop.TabIndex = 21;
            this.lblUK_Drop.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblUK_Drop_DragDrop);
            this.lblUK_Drop.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblUK_Drop_DragEnter);
            // 
            // lblGermany_Drop
            // 
            this.lblGermany_Drop.AllowDrop = true;
            this.lblGermany_Drop.Image = global::QuizApp.Properties.Resources.Germany_Resized;
            this.lblGermany_Drop.Location = new System.Drawing.Point(755, 37);
            this.lblGermany_Drop.Name = "lblGermany_Drop";
            this.lblGermany_Drop.Size = new System.Drawing.Size(150, 150);
            this.lblGermany_Drop.TabIndex = 20;
            this.lblGermany_Drop.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblGermany_Drop_DragDrop);
            this.lblGermany_Drop.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblGermany_Drop_DragEnter);
            // 
            // lbIItaly_Drop
            // 
            this.lbIItaly_Drop.AllowDrop = true;
            this.lbIItaly_Drop.Image = global::QuizApp.Properties.Resources.Italy_Resized;
            this.lbIItaly_Drop.Location = new System.Drawing.Point(535, 37);
            this.lbIItaly_Drop.Name = "lbIItaly_Drop";
            this.lbIItaly_Drop.Size = new System.Drawing.Size(150, 150);
            this.lbIItaly_Drop.TabIndex = 19;
            this.lbIItaly_Drop.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbIItaly_Drop_DragDrop);
            this.lbIItaly_Drop.DragEnter += new System.Windows.Forms.DragEventHandler(this.lbIItaly_Drop_DragEnter);
            // 
            // lblFrance_Drop
            // 
            this.lblFrance_Drop.AllowDrop = true;
            this.lblFrance_Drop.Image = global::QuizApp.Properties.Resources.France_Resized;
            this.lblFrance_Drop.Location = new System.Drawing.Point(319, 37);
            this.lblFrance_Drop.Name = "lblFrance_Drop";
            this.lblFrance_Drop.Size = new System.Drawing.Size(150, 150);
            this.lblFrance_Drop.TabIndex = 18;
            this.lblFrance_Drop.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblFrance_Drop_DragDrop);
            this.lblFrance_Drop.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblFrance_Drop_DragEnter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(305, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(685, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = resources.GetString("label6.Text");
            // 
            // lblGermany
            // 
            this.lblGermany.AutoSize = true;
            this.lblGermany.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGermany.Location = new System.Drawing.Point(315, 381);
            this.lblGermany.Name = "lblGermany";
            this.lblGermany.Size = new System.Drawing.Size(163, 42);
            this.lblGermany.TabIndex = 55;
            this.lblGermany.Text = "Germany";
            this.lblGermany.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblGermany_MouseDown);
            // 
            // lblUK
            // 
            this.lblUK.AutoSize = true;
            this.lblUK.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUK.Location = new System.Drawing.Point(315, 434);
            this.lblUK.Name = "lblUK";
            this.lblUK.Size = new System.Drawing.Size(65, 42);
            this.lblUK.TabIndex = 56;
            this.lblUK.Text = "UK";
            this.lblUK.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblUK_MouseDown);
            // 
            // lblItaly
            // 
            this.lblItaly.AutoSize = true;
            this.lblItaly.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItaly.Location = new System.Drawing.Point(484, 434);
            this.lblItaly.Name = "lblItaly";
            this.lblItaly.Size = new System.Drawing.Size(87, 42);
            this.lblItaly.TabIndex = 58;
            this.lblItaly.Text = "Italy";
            this.lblItaly.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblItaly_MouseDown);
            // 
            // lblSpain
            // 
            this.lblSpain.AutoSize = true;
            this.lblSpain.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpain.Location = new System.Drawing.Point(484, 381);
            this.lblSpain.Name = "lblSpain";
            this.lblSpain.Size = new System.Drawing.Size(106, 42);
            this.lblSpain.TabIndex = 57;
            this.lblSpain.Text = "Spain";
            this.lblSpain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblSpain_MouseDown);
            // 
            // lblRussia
            // 
            this.lblRussia.AutoSize = true;
            this.lblRussia.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRussia.Location = new System.Drawing.Point(596, 434);
            this.lblRussia.Name = "lblRussia";
            this.lblRussia.Size = new System.Drawing.Size(120, 42);
            this.lblRussia.TabIndex = 60;
            this.lblRussia.Text = "Russia";
            this.lblRussia.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblRussia_MouseDown);
            // 
            // lblFrance
            // 
            this.lblFrance.AutoSize = true;
            this.lblFrance.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrance.Location = new System.Drawing.Point(596, 381);
            this.lblFrance.Name = "lblFrance";
            this.lblFrance.Size = new System.Drawing.Size(125, 42);
            this.lblFrance.TabIndex = 59;
            this.lblFrance.Text = "France";
            this.lblFrance.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblFrance_MouseDown);
            // 
            // pnlCorrect
            // 
            this.pnlCorrect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(138)))), ((int)(((byte)(57)))));
            this.pnlCorrect.Controls.Add(this.lblCorrectCount);
            this.pnlCorrect.Controls.Add(this.lblCorrect);
            this.pnlCorrect.Location = new System.Drawing.Point(727, 384);
            this.pnlCorrect.Name = "pnlCorrect";
            this.pnlCorrect.Size = new System.Drawing.Size(126, 112);
            this.pnlCorrect.TabIndex = 61;
            // 
            // lblCorrectCount
            // 
            this.lblCorrectCount.AutoSize = true;
            this.lblCorrectCount.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrectCount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCorrectCount.Location = new System.Drawing.Point(43, 40);
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
            this.lblCorrect.Location = new System.Drawing.Point(21, 2);
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
            this.pnlIncorrect.Location = new System.Drawing.Point(859, 384);
            this.pnlIncorrect.Name = "pnlIncorrect";
            this.pnlIncorrect.Size = new System.Drawing.Size(126, 112);
            this.pnlIncorrect.TabIndex = 62;
            // 
            // lblIncorrectCount
            // 
            this.lblIncorrectCount.AutoSize = true;
            this.lblIncorrectCount.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncorrectCount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIncorrectCount.Location = new System.Drawing.Point(44, 40);
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
            this.lblIncorrect.Location = new System.Drawing.Point(16, 2);
            this.lblIncorrect.Name = "lblIncorrect";
            this.lblIncorrect.Size = new System.Drawing.Size(97, 26);
            this.lblIncorrect.TabIndex = 1;
            this.lblIncorrect.Text = "Incorrect";
            // 
            // frmGeoQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.pnlIncorrect);
            this.Controls.Add(this.pnlCorrect);
            this.Controls.Add(this.lblRussia);
            this.Controls.Add(this.lblFrance);
            this.Controls.Add(this.lblItaly);
            this.Controls.Add(this.lblSpain);
            this.Controls.Add(this.lblUK);
            this.Controls.Add(this.lblGermany);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblSpain_Drop);
            this.Controls.Add(this.lblRussia_Drop);
            this.Controls.Add(this.lblUK_Drop);
            this.Controls.Add(this.lblGermany_Drop);
            this.Controls.Add(this.lbIItaly_Drop);
            this.Controls.Add(this.lblFrance_Drop);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.grpLeftSide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGeoQuiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGeoQuiz";
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
        private System.Windows.Forms.Label lblFrance_Drop;
        private System.Windows.Forms.Label lbIItaly_Drop;
        private System.Windows.Forms.Label lblGermany_Drop;
        private System.Windows.Forms.Label lblUK_Drop;
        private System.Windows.Forms.Label lblRussia_Drop;
        private System.Windows.Forms.Label lblSpain_Drop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblGermany;
        private System.Windows.Forms.Label lblUK;
        private System.Windows.Forms.Label lblItaly;
        private System.Windows.Forms.Label lblSpain;
        private System.Windows.Forms.Label lblRussia;
        private System.Windows.Forms.Label lblFrance;
        private System.Windows.Forms.Panel pnlCorrect;
        private System.Windows.Forms.Label lblCorrectCount;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.Panel pnlIncorrect;
        private System.Windows.Forms.Label lblIncorrectCount;
        private System.Windows.Forms.Label lblIncorrect;
    }
}