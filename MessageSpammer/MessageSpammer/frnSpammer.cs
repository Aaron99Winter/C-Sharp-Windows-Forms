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
    public partial class frmSpammer : Form
    {
        public frmSpammer()
        {
            InitializeComponent();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtMessage.Clear();
            txtTimes.Clear();
            lstMessage.Items.Clear();

        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void BtnRun_Click(object sender, EventArgs e)
        {
            string Message;
            int RunTime;

            Message = txtMessage.Text;
            RunTime = Convert.ToInt32(txtTimes.Text);

            for (int i = 1; i <= RunTime; i++)
            {
                lstMessage.Items.Add(Message);
            }
        }
    }
}
