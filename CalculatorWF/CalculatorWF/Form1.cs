using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWF
{
    public partial class CalculatorForm : Form
    {

        decimal Number1;
        decimal Number2;
        decimal Answer;


        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            Number1 = Convert.ToDecimal(txt1.Text);
            Number2 = Convert.ToDecimal(txt2.Text);
            Answer = Number1 + Number2;
            txtAnswer.Text = Answer.ToString();
        }

        private void BtnTimes_Click(object sender, EventArgs e)
        {
            Number1 = Convert.ToDecimal(txt1.Text);
            Number2 = Convert.ToDecimal(txt2.Text);
            Answer = Number1 * Number2;
            txtAnswer.Text = Answer.ToString();

        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            Number1 = Convert.ToDecimal(txt1.Text);
            Number2 = Convert.ToDecimal(txt2.Text);
            Answer = Number1 / Number2;
            txtAnswer.Text = Answer.ToString();
        }

        private void BtnSubtract_Click(object sender, EventArgs e)
        {
            Number1 = Convert.ToDecimal(txt1.Text);
            Number2 = Convert.ToDecimal(txt2.Text);
            Answer = Number1 - Number2;
            txtAnswer.Text = Answer.ToString();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txt1.Clear();
            txt2.Clear();
            txtAnswer.Clear();
        }
    }
}
