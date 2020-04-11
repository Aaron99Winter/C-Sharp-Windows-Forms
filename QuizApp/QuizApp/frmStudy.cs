using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace QuizApp
{
    public partial class frmStudy : Form
    {
        public frmStudy()
        {
            InitializeComponent();
        }
        #region Buttons
        private void btnQuiz_Click(object sender, EventArgs e)
        {
            frmQuiz lvl1 = new frmQuiz(); //opens the quiz from when clicked
            this.Hide();
            lvl1.Show();
        }

        private void btnStudy_Click(object sender, EventArgs e)
        {
            frmStudy stud = new frmStudy(); //opens the study form when clicked
            this.Hide();
            stud.Show();
        }

        private void btnResults_Click(object sender, EventArgs e)
        {
            frmResults res = new frmResults(); //opens the results form when clicked
            this.Hide();
            res.Show();
        }

        private void lnkHelpDoc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                /*
                starts up notepad application and opens help document
                change file path for individual systems
                */
                Process.Start("notepad.exe", @"F:\QuizApp\QuizApp\Resources\Help.txt");
                //change file path for individual systems 
            }
            catch
            {
                MessageBox.Show("Error", "Could not read file!");//error message
            }
        }

        private void mnuExitButton_Click(object sender, EventArgs e)
        {
            DialogResult exitConfirm = new DialogResult();
            //opens YesNo dialogue and exits is yes is chosen
            exitConfirm = MessageBox.Show("Are you sure you wish to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (exitConfirm == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void mnuLogout_Click(object sender, EventArgs e)
        {
            DialogResult logoutConfirm = new DialogResult();

            logoutConfirm = MessageBox.Show("Are you sure you wish to Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (logoutConfirm == DialogResult.Yes)
            {
                frmLogin Login = new frmLogin();

                this.Hide();
                Login.Show();
            } //once log out button is pressed, asks the user to confirm, loads frmLogin if yes
        }
        #endregion
    }
}
