using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class FrmTemplate : Form
    {
        public FrmTemplate()
        {
            InitializeComponent();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = new DialogResult();

            result = MessageBox.Show("Are you sure you wish to exit?", "Exiting", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnMainMenu_Click(object sender, EventArgs e)
        {
            FrmMainMenu mainMenu = new FrmMainMenu();
            mainMenu.Show();
            this.Hide();

        }

        private void BtnAddBooks_Click(object sender, EventArgs e)
        {
            FrmAddBooks addBooks = new FrmAddBooks();
            addBooks.Show();
            this.Hide();
        }
    }
}
