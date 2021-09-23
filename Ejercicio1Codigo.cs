using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1Ej1319
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        float num = 0;
        int co = 0;
        float[] v = new float[100];
        int cop = 0;
        String[] vop = new String[100];

        void ceros()
        {
            for (int i = 0; i < cop; i++) vop[i] = "";
            for (int i = 0; i < co; i++) v[i] = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            num = num * 10 + float.Parse(((Button)sender).Text.ToString());
            textBox1.Text = num.ToString();
        }

        private void button_Suma(object sender, EventArgs e)
        {
            v[co] = num;
            co++;
            vop[cop] = "+";
            cop++;
            num = 0;
            textBox1.Text = "+";
        }

        private void button_Resta(object sender, EventArgs e)
        {
            v[co] = num;
            co++;
            vop[cop] = "-";
            cop++;
            num = 0;
            textBox1.Text = "-";
        }

        private void button_Mult(object sender, EventArgs e)
        {
            v[co] = num;
            co++;
            vop[cop] = "*";
            cop++;
            num = 0;
            textBox1.Text = "*";
        }

        private void Button_Div(object sender, EventArgs e)
        {
            v[co] = num;
            co++;
            vop[cop] = "/";
            cop++;
            num = 0;
            textBox1.Text = "/";
        }

        private void Button_Igual(object sender, EventArgs e)
        {
            v[co] = num;
            co++; num = 0;
            float res = 0;
            for (int i = 0; i < cop; i++)
            {
                if (vop[i].Equals("*"))
                {
                    v[i] = v[i] * v[i + 1]; v[i+1]=v[i];
                }
                else if (vop[i].Equals("/"))
                {
                    v[i] = v[i] / v[i + 1]; v[i + 1] = v[i];
                }
            }

            res = v[0];

            for (int i = 0; i < cop; i++)
            {
                if (vop[i].Equals("+")) res += v[i + 1];
                else if (vop[i].Equals("-")) res = res - v[i + 1];
            }


            
            
            textBox1.Text = res.ToString();
            res = 0; co = 0; cop = 0; ceros();
        }


    }
}

