using System;
using System.Drawing;
using System.Windows.Forms;

namespace Practical_3_Ex_4
{
    public partial class Form1 : Form
    {

        Timer tmr = new Timer();
        int WIDTH = 300, HEIGHT = 300, secHAND = 140, minHAND = 110, hrHAND = 80;

        // in center  
        int cy, cx;
        Bitmap my_bmp;
        Font my_font;
        Brush my_brush;
        Pen my_pen_for_second_arm, my_pen_for_minute_arm, my_pen_for_hour_arm;
        Graphics cg;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //initialise the drawing materials
            my_font = new Font("Ariel", 12);
            my_brush = Brushes.Black;
            my_pen_for_second_arm = new Pen(Color.Red, 2f);
            my_pen_for_minute_arm = new Pen(Color.BlueViolet, 3f);
            my_pen_for_hour_arm = new Pen(Color.Blue, 4f);
            // create a new bitmap  
            my_bmp = new Bitmap(WIDTH + 1, HEIGHT + 1);
            
            // placing in center  
            cx = WIDTH / 2;
            cy = HEIGHT / 2;
            //backcolor  
            this.BackColor = Color.White;

            //draw the clock
            draw();

            //timer  
            tmr.Interval = 1000; // i.e. tick in milisecond  
            tmr.Tick += new EventHandler(this.tmr_Tick);
            tmr.Start();
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            draw();
        }


        private void draw()
        {
            // create an image  
            cg = Graphics.FromImage(my_bmp);
            //get time  
            int ss = DateTime.Now.Second;
            int mm = DateTime.Now.Minute;
            int hh = DateTime.Now.Hour;
            int[] handCoord = new int[2];
            //clear the content of the bmp 
            cg.Clear(Color.BurlyWood);
            //draw a circle  
            cg.DrawEllipse(new Pen(Color.Black, 6f), 0, 0, WIDTH, HEIGHT);
            //draw clock numbers  
            cg.DrawString("12", my_font, my_brush, new PointF(140, 3));
            cg.DrawString("1", my_font, my_brush, new PointF(218, 22));
            cg.DrawString("2", my_font, my_brush, new PointF(263, 70));
            cg.DrawString("3", my_font, my_brush, new PointF(285, 140));
            cg.DrawString("4", my_font, my_brush, new PointF(263, 212));
            cg.DrawString("5", my_font, my_brush, new PointF(218, 259));
            cg.DrawString("6", my_font, my_brush, new PointF(142, 279));
            cg.DrawString("7", my_font, my_brush, new PointF(70, 259));
            cg.DrawString("8", my_font, my_brush, new PointF(22, 212));
            cg.DrawString("9", my_font, my_brush, new PointF(1, 140));
            cg.DrawString("10", my_font, my_brush, new PointF(22, 70));
            cg.DrawString("11", my_font, my_brush, new PointF(70, 22));

            //draw seconds hand  
            handCoord = msCoord(ss, secHAND);
            cg.DrawLine(my_pen_for_second_arm, new Point(cx, cy), new Point(handCoord[0], handCoord[1]));
            //draw minutes hand  
            handCoord = msCoord(mm, minHAND);
            cg.DrawLine(my_pen_for_minute_arm, new Point(cx, cy), new Point(handCoord[0], handCoord[1]));
            //draw hours hand  
            handCoord = hrCoord(hh % 12, mm, hrHAND);
            cg.DrawLine(my_pen_for_hour_arm, new Point(cx, cy), new Point(handCoord[0], handCoord[1]));

            //load the bitmap image  
            pictureBox1.Image = my_bmp;
            //display time in the heading  
            this.Text = "Analog Clock - " + hh + ":" + mm + ":" + ss;
            cg.Dispose();
        }

        //coord for minute and second  
        private int[] msCoord(int val, int hlen)
        {
            int[] coord = new int[2];
            val *= 6; // note: each minute and seconds make a 6 degree  
            coord[0] = cx + (int)(hlen * Math.Sin(Math.PI * val / 180));
            coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));
            return coord;
        }
        //coord for hour  
        private int[] hrCoord(int hval, int mval, int hlen)
        {
            int[] coord = new int[2];
            //each hour makes 60 degree with min making 0.5 degree  
            int val = (int)((hval * 30) + (mval * 0.5));
            coord[0] = cx + (int)(hlen * Math.Sin(Math.PI * val / 180));
            coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));
            return coord;
        }
    }
}
