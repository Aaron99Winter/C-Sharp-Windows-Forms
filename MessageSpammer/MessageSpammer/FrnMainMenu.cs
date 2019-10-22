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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void MessageSpammerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSpammer Spammer = new frmSpammer();
            Spammer.Show();
            this.Hide();
        }
    }
}
