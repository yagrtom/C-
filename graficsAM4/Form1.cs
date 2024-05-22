using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace graficsAM4
{
    public partial class Form1 : Form
    {
        public double A = 1;
        public double f = 1;
        public double f0 = 5;
        public double[] t = new double[2000];
        public double[] s = new double[2000];
        public double[] sAM = new double[2000];
        public double Tgraf = 8;
        public double tick = 0.01;
        public double delta = 1;
        public int func;
        public bool funcAM = false;



        public void GetCos()
        {
            this.chart1.Series[0].Points.Clear();
            for (int i = 0; i < 2*Tgraf/tick; i++)
            {
                t[i] = -Tgraf + tick * i;
                s[i] = A * Math.Cos(t[i]*f/2);
                this.chart1.Series[0].Points.AddXY(t[i], s[i]);
            }
        }
        public void GetSin()
        {
            this.chart1.Series[0].Points.Clear();
            for (int i = 0; i < 2 * Tgraf / tick; i++)
            {
                t[i] = -Tgraf + tick * i;
                s[i] = A * Math.Sin(t[i] * f/2);
                this.chart1.Series[0].Points.AddXY(t[i], s[i]);
            }
        }
        public void GetImpulsPriam()
        {
            s[0] = 0;
            this.chart1.Series[0].Points.Clear();
            for (int i = 1; i < 2 * Tgraf / tick; i++)
            {
                t[i] = -Tgraf + tick * i;
                if (t[i] % delta == 0)
                {
                    if (s[i-1] == A)
                    {
                        s[i] = 0;
                    }
                    if (s[i-1] == 0)
                    {
                        s[i] = A;
                    }
                }
                else
                {
                    s[i] = s[i-1];
                }
                
                this.chart1.Series[0].Points.AddXY(t[i], s[i]);
            }
        }
        public void GetAMsignal()
        {
            if(funcAM == true)
            {
                this.chart1.Series[1].Points.Clear();
                for (int i = 0; i < 2 * Tgraf / tick; i++)
                {
                    t[i] = -Tgraf + tick * i;
                    sAM[i] = s[i] * Math.Cos(t[i] * f0);
                    this.chart1.Series[1].Points.AddXY(t[i], sAM[i]);
                }
            }
            else
            {
                this.chart1.Series[1].Points.Clear();
            }
        }
        public void GetFunction(int test)
        {
            switch (test)
            {
                case 1:
                    GetCos();
                    break;
                case 2:
                    GetSin(); 
                    break;
                case 3:
                    GetImpulsPriam();
                    break;
            }
            GetAMsignal();
            
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void косинусToolStripMenuItem_Click(object sender, EventArgs e)
        {
            func = 1;
            GetFunction(func);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            A = trackBar1.Value;
            GetFunction(func);
            
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            if ((func == 1) || (func == 2))
            {
                f = trackBar2.Value;
                GetFunction(func);
                
            }
            
        }

        private void стеретьГрафикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.chart1.Series[1].Points.Clear();
            this.chart1.Series[0].Points.Clear();
        }

        private void импульсыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            func = 2;
            GetFunction(func);
        }

        private void прямоугольныеИмпульсыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            func = 3;
            GetFunction(func);
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            delta = trackBar3.Value;
            GetFunction(func);
            //this.chart1.Series[0].Points.Clear();
        }

        private void построитьАМToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(funcAM == true)
            {
                funcAM = false;
            }
            else
            {
                funcAM = true;
            }
            GetAMsignal();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            if (funcAM == true)
            {
                f0 = trackBar4.Value;
                GetFunction(func);
                GetAMsignal();
            }
            
        }

        private void стеретьАМСигналToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.chart1.Series[1].Points.Clear();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
