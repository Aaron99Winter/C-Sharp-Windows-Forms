using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class frmMathsQuiz : Form
    {
        public frmMathsQuiz()
        {
            InitializeComponent();
        }
        #region Procedures
        public void Correct() //procedure for whenever questions are answered correctly
        {
            MessageBox.Show("Answer Correct!", "Correct");
            GlobalVars.intComponentsCorrect2++;//increments global correct score variable
            lblCorrectCount.Text = Convert.ToString(GlobalVars.intComponentsCorrect2); //displays correct score on label
            GlobalVars.intTotal++;
            GlobalVars.intCorrectAnswers++; //increments total answers and total correct answers

        }

        public void Incorrect() //procedure for whenever questions are answered incorrectly
        {
            MessageBox.Show("Answer Incorrect!", "Incorrect");
            GlobalVars.intComponentsIncorrect2++;//increments global incorrect score variable
            lblIncorrectCount.Text = Convert.ToString(GlobalVars.intComponentsIncorrect2); //displays incorrect score on label
            GlobalVars.intTotal++;
            GlobalVars.intIncorrectAnswers++; //increments total answers and total incorrect answers
        }
        #endregion

        #region DragDrop
        ////events for whenever the name label is dropped onto the image and calls either the correct() or incorrect() procedures
        private void lbl301_Drop_DragDrop(object sender, DragEventArgs e)
        {
            if (Convert.ToString(e.Data.GetData(DataFormats.Text)) == "30")
            {
                Trace.WriteLine(Convert.ToString(e.Data.GetData(DataFormats.Text)));
                Correct();
                lbl30.Visible = false;
            }
            else
            {
                Trace.WriteLine(Convert.ToString(e.Data.GetData(DataFormats.Text)));
                Incorrect();
            }
        }

        private void lbl161_Drop_DragDrop(object sender, DragEventArgs e)
        {
            if (Convert.ToString(e.Data.GetData(DataFormats.Text)) == "16")
            {
                Trace.WriteLine(Convert.ToString(e.Data.GetData(DataFormats.Text)));
                Correct();
                lbl16.Visible = false;
            }
            else
            {
                Trace.WriteLine(Convert.ToString(e.Data.GetData(DataFormats.Text)));
                Incorrect();
            }
        }

        private void lbl302_Drop_DragDrop(object sender, DragEventArgs e)
        {
            if (Convert.ToString(e.Data.GetData(DataFormats.Text)) == "30")
            {
                Trace.WriteLine(Convert.ToString(e.Data.GetData(DataFormats.Text)));
                Correct();
                lbl30.Visible = false;
            }
            else
            {
                Trace.WriteLine(Convert.ToString(e.Data.GetData(DataFormats.Text)));
                Incorrect();
            }
        }

        private void lbl241_Drop_DragDrop(object sender, DragEventArgs e)
        {
            if (Convert.ToString(e.Data.GetData(DataFormats.Text)) == "24")
            {
                Trace.WriteLine(Convert.ToString(e.Data.GetData(DataFormats.Text)));
                Correct();
                lbl24.Visible = false;
            }
            else
            {
                Trace.WriteLine(Convert.ToString(e.Data.GetData(DataFormats.Text)));
                Incorrect();
            }
        }

        private void lbl242_Drop_DragDrop(object sender, DragEventArgs e)
        {
            if (Convert.ToString(e.Data.GetData(DataFormats.Text)) == "24")
            {
                Trace.WriteLine(Convert.ToString(e.Data.GetData(DataFormats.Text)));
                Correct();
                lbl24.Visible = false;
            }
            else
            {
                Trace.WriteLine(Convert.ToString(e.Data.GetData(DataFormats.Text)));
                Incorrect();
            }
        }

        private void lbl162_Drop_DragDrop(object sender, DragEventArgs e)
        {
            if (Convert.ToString(e.Data.GetData(DataFormats.Text)) == "16")
            {
                Trace.WriteLine(Convert.ToString(e.Data.GetData(DataFormats.Text)));
                Correct();
                lbl16.Visible = false;
            }
            else
            {
                Trace.WriteLine(Convert.ToString(e.Data.GetData(DataFormats.Text)));
                Incorrect();
            }
            #endregion

        }

        #region DragEnter
        //events for whenever the label enters the image
        private void lbl301_Drop_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text)) e.Effect = DragDropEffects.Copy;
        }

        private void lbl161_Drop_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text)) e.Effect = DragDropEffects.Copy;
        }

        private void lbl302_Drop_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text)) e.Effect = DragDropEffects.Copy;
        }

        private void lbl241_Drop_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text)) e.Effect = DragDropEffects.Copy;
        }

        private void lbl242_Drop_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text)) e.Effect = DragDropEffects.Copy;
        }

        private void lbl162_Drop_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text)) e.Effect = DragDropEffects.Copy;
        }
        #endregion

        #region MouseDown
        //Code to handle a mouse click and drag for each of the bottom labels
        private void lbl24_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop(lbl24.Text, DragDropEffects.Copy);
        }

        private void lbl16_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop(lbl16.Text, DragDropEffects.Copy);
        }

        private void lbl30_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop(lbl30.Text, DragDropEffects.Copy);
        }
        #endregion

        #region Buttons
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

        private void btnQuiz_Click(object sender, EventArgs e) //brings user back to quiz form
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

        private void btnStudy_Click(object sender, EventArgs e)//brings user back to study form
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

        private void lbl301_Drop_Click(object sender, EventArgs e)
        {

        }
    }
}
