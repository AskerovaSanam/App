using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            string b = "";
            if (a>0)
            {
                b = "musbet";
            }
            else if (a<0)
            {
                b = "menfi";
            }
            else
            {
                b = "sifir";
            }
            label1.Text = b;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            string b = "";
            if (a % 3 == 0 || a%4 == 0)
            {
                b = "bolunur";
            }
            else
            {
                b = "bolunmur";
            }
            label1.Text = b;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double alish = Convert.ToDouble(textBox1.Text);
            double endirim = 0;
            double netice = 0;
            if (alish > 0 && alish <= 300)
            {
                endirim = alish * 0.05;
            }
            else if (alish > 300 && alish <= 500)
            {
                endirim = alish * 0.1;
            }
            else if (alish > 500 && alish <= 700)
            {
                endirim = alish * 0.15;
            }
            else
            {
                endirim = 0;
            }
            netice = alish - endirim;
            label1.Text = netice.ToString();





        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            switch (a)
            {
                case 1:
                    MessageBox.Show("Bazar ertesi");
                    break;

                case 2:
                    MessageBox.Show("Chershembe axshami");
                    break;
                case 3:
                    MessageBox.Show("Chershembe");
                    break;
                default:
                    MessageBox.Show("kish burdan");
                    break;


            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int cutcem = 0;
            int tekcem = 0;

          
            for (int i = a; i <= b ; i++)
            {
                if (i%2==0)
                {
                    cutcem = cutcem + i;
                }

                else
                {
                    tekcem += i;
                }

            }
            label1.Text = cutcem.ToString();
            label2.Text = tekcem.ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = 1;

            for (int i =1 ; i <=a; i++)
            {
                b *= i;
            }
            label1.Text = b.ToString();



        }
    }
}
