using System;
using System.Windows.Forms;

namespace Practical_3_Ex_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            LblLocalTime.Text = "Local Time is : " + DateTime.Now.ToString("dd/MM/yy HH:mm:ss");
            LblUTCTime.Text = "UTC Time is  : " + DateTime.UtcNow.ToString("dd/MM/yy HH:mm:ss");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // tmr
            // 
            tmr = new Timer();
            tmr.Interval = 1000;    //Every 1 second
            tmr.Tick += new System.EventHandler(this.tmr_Tick);
            tmr.Start();
        }


    }
}
