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
    public partial class FrmAddBooks : FrmTemplate
    {

        string[] Author = new string[6];
        string[] Title = new string[6];
        string[] ISBN = new string[6];
        string[] Price = new string[6];

        int ArrayCounter = 0;

        public FrmAddBooks()
        {
            InitializeComponent();
        }

        private void FrmAddBooks_Load(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            txtAuthor.Text = null;
            txtISBN.Text = null;
            txtPrice.Text = null;
            txtTitle.Text = null;
        }

        private void Disable()
        {
            txtAuthor.Enabled = false;
            txtISBN.Enabled = false;
            txtPrice.Enabled = false;
            txtTitle.Enabled = false;

            btnSave.Enabled = false;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Author[ArrayCounter] = txtAuthor.Text;
                Title[ArrayCounter] = txtTitle.Text;
                ISBN[ArrayCounter] = txtISBN.Text;
                Price[ArrayCounter] = txtPrice.Text;

                ArrayCounter++;
                MessageBox.Show("Record Saved", "Saved");
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Max books entered", "Error");
                Disable();
                Clear();
            }
        }

        private void BtnViewBooks_Click(object sender, EventArgs e)
        {
            lstBooks.Items.Clear();

            for (int i = 0; i < ArrayCounter; i++)
            {
                lstBooks.Items.Add(Author[i]);
                lstBooks.Items.Add(Title[i]);
                lstBooks.Items.Add(ISBN[i]);
                lstBooks.Items.Add("£" + Price[i]);
                lstBooks.Items.Add("\n");
            }
        }
    }
}
