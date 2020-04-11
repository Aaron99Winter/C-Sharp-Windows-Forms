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
    public partial class frmQuiz : Form
    {
        public frmQuiz()
        {
            InitializeComponent();
        }
        private void frmMainMenu_Load(object sender, EventArgs e)//when form loads, sets the label as the global forename and surname
        {
            string strFullname = GlobalVars.strForname + " " + GlobalVars.strSurname;

            lblName.Text = strFullname;
        } //sets global fullname variable as the label text

        private void btnQuiz_Click(object sender, EventArgs e)
        {
            //does nothing becuase quiz form is already open
        }

        private void btnStudy_Click(object sender, EventArgs e)//opens study form
        {
            frmStudy stud = new frmStudy(); //opens the study form when clicked
            this.Hide();
            stud.Show();
        }

        private void btnResults_Click(object sender, EventArgs e)//opens results form
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

        private void btnQuiz1_Click(object sender, EventArgs e)
        {
            frmGeoQuiz Geo = new frmGeoQuiz();
            this.Hide();
            Geo.Show();
        }

        private void btnQuiz2_Click(object sender, EventArgs e)
        {
            frmMathsQuiz Math = new frmMathsQuiz();
            this.Hide();
            Math.Show();
        }

        private void mnuExitButton_Click(object sender, EventArgs e)//exit button and prompt
        {
            DialogResult exitConfirm = new DialogResult();

            exitConfirm = MessageBox.Show("Are you sure you wish to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (exitConfirm == DialogResult.Yes)
            {
                Application.Exit();
            }
        }//opens YesNo dialogue and exits is yes is chosen

        private void mnuLogout_Click(object sender, EventArgs e)//log out button and prompt
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
    }
}
