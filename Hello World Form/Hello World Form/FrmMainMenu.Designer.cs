namespace Hello_World_Form
{
    partial class FrmMainMenu
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClickme = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(208, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(145, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HelloWorld - By Aaron Winter";
            this.lblTitle.Click += new System.EventHandler(this.Label1_Click);
            // 
            // btnClickme
            // 
            this.btnClickme.Location = new System.Drawing.Point(154, 169);
            this.btnClickme.Name = "btnClickme";
            this.btnClickme.Size = new System.Drawing.Size(256, 49);
            this.btnClickme.TabIndex = 1;
            this.btnClickme.Text = "Click Me";
            this.btnClickme.UseVisualStyleBackColor = true;
            this.btnClickme.Click += new System.EventHandler(this.BtnClickme_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(466, 380);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(87, 29);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 421);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClickme);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hello World";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClickme;
        private System.Windows.Forms.Button btnClose;
    }
}

