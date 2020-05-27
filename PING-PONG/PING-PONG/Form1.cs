using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PING_PONG
{
    public partial class Form1 : Form
    {
        const int absspeedbally = 4;//скорость по модулю 
        const int xsizeplatform = 60;//размер платформы по х
        const int ysizeplatform = 20;//размер платформы по у
        const int yplatform1=0;//координаты  для платформы
        const int sizeball = 10;// радиус мяча
        const int xspeedplatform = 20;//скорость платформы
        int yplatform2;//координаты  для второй платформы
        bool stage = false;//оператор для понятие включена ли игра
        int xball;//координаты мяча
        int speedbally;//cкорость мяча по у
        int speedballx;//скорость мяча по х
        int yball; //координаты мяча
        int xplatform1 ;// координаты для платофрмы по х
        int xplatform2;// координаты для платфорымы по у
        Bitmap bitmap;
        Graphics graphics;
       
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int key = e.KeyValue;
            if (key == 32 && !stage) 
            {
                Random random = new Random();
                speedbally = absspeedbally;
                speedballx = random.Next(-4, 4);
                if (speedballx == 0)
                {
                    speedballx = 2;
                }
                rule.Visible = false;
                stage = true;
                timer1.Start();
                PL1W.Visible = false;
                PL2W.Visible = false;
            }
            if (key == 65 && stage)
            {
                if  (xplatform1-xspeedplatform>-20)
                {
                    xplatform1 -= xspeedplatform;
                } 
            }
            if (key == 68 && stage)
            {
                if ((xplatform1 + xsizeplatform) + xspeedplatform<box.Width+20)
                {
                    xplatform1 += xspeedplatform;
                }
            }
            if(key == 37 && stage)
            {
                if (xplatform2 + xspeedplatform > 20)
                {
                    xplatform2 -= xspeedplatform;
                }
            }
            if(key == 39 && stage)
            {
                if ((xplatform2 + xsizeplatform) + xspeedplatform < Width)
                {
                    xplatform2 += xspeedplatform;
                }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            bitmap = new Bitmap(box.Width, box.Height);
            
            
            yplatform2 = box.Height - ysizeplatform;
            xplatform1 = box.Width / 2 - xsizeplatform / 2;
            xplatform2 = xplatform1;
            xball = box.Width / 2-sizeball/2;
            yball = box.Height / 2-sizeball/2;
            graphics = Graphics.FromImage(bitmap);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            xball += speedballx;
            yball += speedbally;
            if (xball < 0 || xball+2*sizeball>box.Width)
            {
                speedballx *= -1;
            }
            else if(yball<ysizeplatform && xball+2*sizeball>xplatform1 && xball < xplatform1 + xsizeplatform)
            {
                speedbally *= -1;

            }
            else if(yball+2 * sizeball > box.Height-ysizeplatform && xball+ 2 * sizeball > xplatform2 && xball < xplatform2 + xsizeplatform)
            {
                    speedbally *= -1;

            }
            else if (yball < 0)
            {
                PLAYER2.Text = (int.Parse(PLAYER2.Text) + 1).ToString();
                yplatform2 = box.Height - ysizeplatform;
                xplatform1 = box.Width / 2 - xsizeplatform / 2;
                xplatform2 = xplatform1;
                xball = box.Width / 2 - sizeball / 2;
                yball = box.Height / 2 - sizeball / 2;
                Random random = new Random();
                speedbally = absspeedbally;
                speedballx = random.Next(-4, 4);
                if (speedballx == 0)
                {
                    speedballx = 2;
                }
            }
            else if(yball > box.Height)
            {
                PLAYER1.Text = (int.Parse(PLAYER1.Text) + 1).ToString();
                yplatform2 = box.Height - ysizeplatform;
                xplatform1 = box.Width / 2 - xsizeplatform / 2;
                xplatform2 = xplatform1;
                xball = box.Width / 2 - sizeball / 2;
                yball = box.Height / 2 - sizeball / 2;
                Random random = new Random();
                speedbally = absspeedbally;
                speedballx = random.Next(-4, 4);
                if (speedballx == 0)
                {
                    speedballx = 2;
                }
            }
            if (PLAYER1.Text == "10")
            {
                PLAYER1.Text = "0";
                PLAYER2.Text = "0";
                rule.Visible = true;
                timer1.Stop();
                stage = false;
                PL1W.Visible = true;
            }
            if (PLAYER2.Text == "10")
            {
                PLAYER2.Text = "0";
                PLAYER1.Text = "0";
                rule.Visible = true;
                timer1.Stop();
                stage = false;
                PL2W.Visible = true;
            }

            graphics.Clear(Color.White);
            graphics.FillRectangle(Brushes.Red, xplatform1, yplatform1, xsizeplatform, ysizeplatform);
            graphics.FillRectangle(Brushes.Blue, xplatform2, yplatform2, xsizeplatform, ysizeplatform);
            graphics.FillEllipse(Brushes.YellowGreen,  xball,  yball,  2*sizeball, 2*sizeball);


            box.Image = bitmap;
        }
    }
}
