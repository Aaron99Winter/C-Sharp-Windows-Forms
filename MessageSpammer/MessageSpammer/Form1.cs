using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageSpammer
{
    public partial class Form1 : Form
    {
        string Username = "admin";
        string EnteredUsername;
        string Password = "password";
        string EnteredPassword;

        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            EnteredUsername = txtUsername.Text;
            EnteredPassword = txtPassword.Text;

            if ((EnteredUsername == Username) && (EnteredPassword == Password))
            {
                frmMainMenu mainMenu = new frmMainMenu();
                mainMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Details incorrect");
            }
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
