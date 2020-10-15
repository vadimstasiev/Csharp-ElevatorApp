using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_3_Ex_2
{
    public partial class frmListBox_Exercise : Form
    {
        public frmListBox_Exercise()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddLetter_Click(object sender, EventArgs e)
        {
            lstLetter.Items.Add(txtAddLetter.Text);

        }
        private void btnAddNumber_Click(object sender, EventArgs e)
        {
            lstNumber.Items.Add(txtAddNumber.Text);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            lstNumber.Sorted = true;
        }

        private void btnSortLetters_Click(object sender, EventArgs e)
        {
            lstLetter.Sorted = true;
        }
       private void label1_Click(object sender, EventArgs e)
        {

        }
         private void btnRightShift_Click(object sender, EventArgs e)
        {
            if (lstLetter.SelectedIndex > -1)
            {
                lstNumber.Items.Add(lstLetter.SelectedItem);
                lstLetter.Items.Remove(lstLetter.SelectedItem);
            }
            else
            {
                string message = "Please select an item to move";
                string caption = "Error in Item Selection";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
            }
        }
        private void btnLeftShift_Click(object sender, EventArgs e)
        {
            if (lstNumber.SelectedIndex > -1)
            {
                  lstLetter.Items.Add(lstNumber.SelectedItem);
                  lstNumber.Items.Remove(lstNumber.SelectedItem);            }
            }

        private void frmListBox_Exercise_Load(object sender, EventArgs e)
        {

        }




        /*else
        {
            string message = "Please select an item to move";
            string caption = "Error in Item Selection";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;
            //result = MessageBox.Show(message, caption, buttons);
        }*/
    }
       

        

}
    



