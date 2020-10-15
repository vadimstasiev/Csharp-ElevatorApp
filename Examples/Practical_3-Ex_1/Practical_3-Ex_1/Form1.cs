using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_3_Ex_1
{
    public partial class frmCalculate : Form
    {
       
        protected double firstNo;
        private double secondNo;
        private double answer;

        public frmCalculate()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           //void calculate(string add);
           firstNo = double.Parse(txtFirstNo.Text);
            secondNo = double.Parse(txtSecondNo.Text);
            answer = double.Parse(txtFirstNo.Text) + double.Parse(txtSecondNo.Text);
            answer = firstNo + secondNo;
             lblAnswer.Text = answer.ToString();
        }

       private void btnSubtract_Click(object sender, EventArgs e)
       {
           firstNo = double.Parse(txtFirstNo.Text);
           secondNo = double.Parse(txtSecondNo.Text);
           answer = double.Parse(txtFirstNo.Text) + double.Parse(txtSecondNo.Text);
           answer = firstNo - secondNo;
           lblAnswer.Text = answer.ToString();
       }

       private  void btnMultiply_Click(object sender, EventArgs e)
       {
           firstNo = double.Parse(txtFirstNo.Text);
           secondNo = double.Parse(txtSecondNo.Text);
           answer = double.Parse(txtFirstNo.Text) + double.Parse(txtSecondNo.Text);
           answer = firstNo * secondNo;
           lblAnswer.Text = answer.ToString();
       }

       private void txtFirstNo_TextChanged(object sender, EventArgs e)
       {
           string input;
           double firstNo;
           input = txtFirstNo.Text;
           if (!double.TryParse(input, out firstNo))
           {
               string message = "Enter a decimal number";
               string caption = "Error Detected in Input";
               MessageBoxButtons buttons = MessageBoxButtons.OK;
               DialogResult result;

               // Displays the MessageBox.

               result = MessageBox.Show(message, caption, buttons);
               //txtFirstNo.Clear();
               txtFirstNo.Focus();
           }
           else
           {
               txtSecondNo.Focus();
           }
       }

       private void button1_Click(object sender, EventArgs e)
       {
           this.Close();
       }
              
          
    }
}
