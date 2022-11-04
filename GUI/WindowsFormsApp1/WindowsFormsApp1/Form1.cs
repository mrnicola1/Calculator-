using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int tryCnt = 0;
        int leave = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tryCnt== 5)
            {
                MessageBox.Show("login error, 5 times");
                this.Close();
            }

            if (textBox1.Text=="Datait2022!")
            {
                groupBox1.Visible= false;   
                groupBox2.Visible= true;
            }
            else
            {
                MessageBox.Show("forkert password");
                textBox1.Text = "";
                tryCnt++;   

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (leave == 0)
                MessageBox.Show("fejl du skal vælge en operand");
            if (leave== 1)
                textBox2.Text = textBox2.Text + "0";
            if (leave == 2)
                textBox3.Text = textBox3.Text + "0";
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            leave = 1;

        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            leave = 2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int A, B, RES;

            A= int.Parse(textBox2.Text);
            B = int.Parse(textBox3.Text);
            RES = A + B;
            textBox4.Text=RES.ToString();   

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (leave == 0)
                MessageBox.Show("fejl du skal vælge en operand");
            if (leave == 1)
                textBox2.Text = textBox2.Text + "1";
            if (leave == 2)
                textBox3.Text = textBox3.Text + "1";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (leave == 0)
                MessageBox.Show("fejl du skal vælge en operand");
            if (leave == 1)
                textBox2.Text = textBox2.Text + "2";
            if (leave == 2)
                textBox3.Text = textBox3.Text + "2";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (leave == 0)
                MessageBox.Show("fejl du skal vælge en operand");
            if (leave == 1)
                textBox2.Text = textBox2.Text + "3";
            if (leave == 2)
                textBox3.Text = textBox3.Text + "3";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (leave == 0)
                MessageBox.Show("fejl du skal vælge en operand");
            if (leave == 1)
                textBox2.Text = textBox2.Text + "4";
            if (leave == 2)
                textBox3.Text = textBox3.Text + "4";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (leave == 0)
                MessageBox.Show("fejl du skal vælge en operand");
            if (leave == 1)
                textBox2.Text = textBox2.Text + "5";
            if (leave == 2)
                textBox3.Text = textBox3.Text + "5";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (leave == 0)
                MessageBox.Show("fejl du skal vælge en operand");
            if (leave == 1)
                textBox2.Text = textBox2.Text + "6";
            if (leave == 2)
                textBox3.Text = textBox3.Text + "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (leave == 0)
                MessageBox.Show("fejl du skal vælge en operand");
            if (leave == 1)
                textBox2.Text = textBox2.Text + "7";
            if (leave == 2)
                textBox3.Text = textBox3.Text + "7";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (leave == 0)
                MessageBox.Show("fejl du skal vælge en operand");
            if (leave == 1)
                textBox2.Text = textBox2.Text + "8";
            if (leave == 2)
                textBox3.Text = textBox3.Text + "8";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (leave == 0)
                MessageBox.Show("fejl du skal vælge en operand");
            if (leave == 1)
                textBox2.Text = textBox2.Text + "9";
            if (leave == 2)
                textBox3.Text = textBox3.Text + "9";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            int A, B;
            A=int.Parse(textBox2.Text);
            B = int.Parse(textBox3.Text);
            int RES = A - B;
            textBox4.Text = RES.ToString();

        }

        private void button15_Click(object sender, EventArgs e)
        {
            int A, B, RES;
            A = int.Parse(textBox2.Text);
            B=int.Parse(textBox3.Text);
            RES = A * B;
            textBox4.Text = RES.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int A, B, RES;
            A = int.Parse(textBox2.Text);
            B = int.Parse(textBox3.Text);
            RES = A / B;
            textBox4.Text = RES.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
