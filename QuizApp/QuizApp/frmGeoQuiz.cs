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
    public partial class frmGeoQuiz : Form
    {
        public frmGeoQuiz()
        {
            InitializeComponent();
        }

        #region Procedures
        public void Correct() //procedure for whenever questions are answered correctly
        {
            MessageBox.Show("Answer Correct!", "Correct");
            GlobalVars.intComponentsCorrect1++;//increments global correct score variable
            lblCorrectCount.Text = Convert.ToString(GlobalVars.intComponentsCorrect1); //displays correct score on label
            GlobalVars.intTotal++;
            GlobalVars.intCorrectAnswers++; //increments total answers and total correct answers

        }

        public void Incorrect() //procedure for whenever questions are answered incorrectly
        {
            MessageBox.Show("Answer Incorrect!", "Incorrect");
            GlobalVars.intComponentsIncorrect1++;//increments global incorrect score variable
            lblIncorrectCount.Text = Convert.ToString(GlobalVars.intComponentsIncorrect1); //displays incorrect score on label
            GlobalVars.intTotal++;
            GlobalVars.intIncorrectAnswers++; //increments total answers and total incorrect answers
        }
        #endregion

        #region Buttons
        private void btnQuiz_Click(object sender, EventArgs e)
        {
            DialogResult exitConfirm = new DialogResult();

            exitConfirm = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (exitConfirm == DialogResult.Yes)
            {
                frmQuiz ma = new frmQuiz();
                this.Hide();
                ma.Show();
            }
        }

        private void btnStudy_Click(object sender, EventArgs e)
        {
            DialogResult exitConfirm = new DialogResult();
            //confirmation dialogue
            exitConfirm = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (exitConfirm == DialogResult.Yes)
            {
                frmStudy main = new frmStudy();
                this.Hide();
                main.Show();
            }
            
        }

        private void btnResults_Click(object sender, EventArgs e)
        {
            DialogResult exitConfirm = new DialogResult();
            //confirmation dialogue
            exitConfirm = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (exitConfirm == DialogResult.Yes)
            {
                frmResults main = new frmResults();
                this.Hide();
                main.Show();
            }
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
            //confirmation dialogue
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
      
        #region DragDrop
        private void lblFrance_Drop_DragDrop(object sender, DragEventArgs e)
        {
            if (Convert.ToString(e.Data.GetData(DataFormats.Text)) == "France")
            {
                Trace.WriteLine(Convert.ToString(e.Data.GetData(DataFormats.Text)));
                Correct();
                lblFrance.Visible = false;
            }
            else
            {
                Trace.WriteLine(Convert.ToString(e.Data.GetData(DataFormats.Text)));
                Incorrect();
            }
        }

        private void lbIItaly_Drop_DragDrop(object sender, DragEventArgs e)
        {
            if (Convert.ToString(e.Data.GetData(DataFormats.Text)) == "Italy")
            {
                Trace.WriteLine(Convert.ToString(e.Data.GetData(DataFormats.Text)));
                Correct();
                lblItaly.Visible = false;
            }
            else
            {
                Trace.WriteLine(Convert.ToString(e.Data.GetData(DataFormats.Text)));
                Incorrect();
            }
        }

        private void lblGermany_Drop_DragDrop(object sender, DragEventArgs e)
        {
            if (Convert.ToString(e.Data.GetData(DataFormats.Text)) == "Germany")
            {
                Trace.WriteLine(Convert.ToString(e.Data.GetData(DataFormats.Text)));
                Correct();
                lblGermany.Visible = false;
            }
            else
            {
                Trace.WriteLine(Convert.ToString(e.Data.GetData(DataFormats.Text)));
                Incorrect();
            }
        }

        private void lblUK_Drop_DragDrop(object sender, DragEventArgs e)
        {
            if (Convert.ToString(e.Data.GetData(DataFormats.Text)) == "UK")
            {
                Trace.WriteLine(Convert.ToString(e.Data.GetData(DataFormats.Text)));
                Correct();
                lblUK.Visible = false;
            }
            else
            {
                Trace.WriteLine(Convert.ToString(e.Data.GetData(DataFormats.Text)));
                Incorrect();
            }
        }

        private void lblRussia_Drop_DragDrop(object sender, DragEventArgs e)
        {
            if (Convert.ToString(e.Data.GetData(DataFormats.Text)) == "Russia")
            {
                Trace.WriteLine(Convert.ToString(e.Data.GetData(DataFormats.Text)));
                Correct();
                lblRussia.Visible = false;
            }
            else
            {
                Trace.WriteLine(Convert.ToString(e.Data.GetData(DataFormats.Text)));
                Incorrect();
            }
        }
        private void lblSpain_Drop_DragDrop(object sender, DragEventArgs e)
        {
            if (Convert.ToString(e.Data.GetData(DataFormats.Text)) == "Spain")
            {
                Trace.WriteLine(Convert.ToString(e.Data.GetData(DataFormats.Text)));
                Correct();
                lblSpain.Visible = false;
            }
            else
            {
                Trace.WriteLine(Convert.ToString(e.Data.GetData(DataFormats.Text)));
                Incorrect();
            }
        }

        #endregion

        #region DragEnter
        private void lblFrance_Drop_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text)) e.Effect = DragDropEffects.Copy;
        }

        private void lbIItaly_Drop_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text)) e.Effect = DragDropEffects.Copy;
        }

        private void lblGermany_Drop_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text)) e.Effect = DragDropEffects.Copy;
        }

        private void lblUK_Drop_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text)) e.Effect = DragDropEffects.Copy;
        }

        private void lblRussia_Drop_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text)) e.Effect = DragDropEffects.Copy;
        }

        private void lblSpain_Drop_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text)) e.Effect = DragDropEffects.Copy;
        }

        #endregion

        #region MouseDown
        private void lblGermany_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop(lblGermany.Text, DragDropEffects.Copy);
        }

        private void lblSpain_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop(lblSpain.Text, DragDropEffects.Copy);
        }

        private void lblFrance_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop(lblFrance.Text, DragDropEffects.Copy);
        }

        private void lblUK_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop(lblUK.Text, DragDropEffects.Copy);
        }

        private void lblItaly_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop(lblItaly.Text, DragDropEffects.Copy);
        }

        private void lblRussia_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop(lblRussia.Text, DragDropEffects.Copy);
        }
        #endregion
    }
}
