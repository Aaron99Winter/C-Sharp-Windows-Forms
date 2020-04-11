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
    public partial class frmResults : Form
    {
        public frmResults()
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

            exitConfirm = MessageBox.Show("Are you sure you wish to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (exitConfirm == DialogResult.Yes)
            {
                Application.Exit();
            }
        }//opens YesNo dialogue and exits is yes is chosen

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

        private void frmResults_Load(object sender, EventArgs e)//when form loads, sets score labels with global variables
        {
            //variables//
            double correctAnswers = GlobalVars.intCorrectAnswers;
            double total = GlobalVars.intTotal;
            double percentage;
            /////////////

            percentage = (correctAnswers / total) * 100;

            if (GlobalVars.intTotal >= 1)//allows the message to only appear once at least 1 question has been answered
            {
                if (percentage >= 50)//if percentage is over 50 prints "well done" to OverallScore label
                {
                    lblWellDone.Text = "Well Done!";
                }
                else
                {
                    lblWellDone.Text = "Better luck next time!";
                }
            }
            else
            {
                lblWellDone.Text = " "; //blank text
            }

            lblCorrect1.Text = "Correct Score: " + GlobalVars.intCorrectAnswers;      //total correct answers
            lblIncorrect1.Text = "Incorrect Score: " + GlobalVars.intIncorrectAnswers;//total incorrect answers
            lblTotalQs.Text = "Total Questions answered: " + GlobalVars.intTotal;     //total questions answered
            lblOverallScore.Text = "Overall total: " + GlobalVars.intCorrectAnswers + "/" + GlobalVars.intTotal + " " + percentage + "%";
            //displays the total correct answers out of 12 and percentage

            if (percentage < 1)
            {
                lblOverallScore.Text = "Overall total: " + GlobalVars.intCorrectAnswers + "/" + "0%";
            }
        }
    }
}

