using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float num1, num3;
        long num2;
        bool isNum1;
        byte amal;

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || isNum1 == true)
            {
                textBox1.Clear();
            }
            if (isNum1)
            {
                textBox1.Text = "0";
                isNum1 = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
          
        }

   

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (textBox1.Text == "0" || isNum1 == true)
            {
                textBox1.Clear();
            }
            if (isNum1)
            {
                textBox1.Text = btn.Text;
                isNum1 = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + btn.Text;
            }
           
        }
       
        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {                   
                num1 = float.Parse(textBox1.Text);
                isNum1 = true;
                amal = 1;                         
        }

        private void button12_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            isNum1 = true;
            amal = 2;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            isNum1 = true;
            amal = 3;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            isNum1 = true;
            amal = 4;         
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (num1 != 0)
            {
                num3 = float.Parse(textBox1.Text);
            }
            else
            {
                num1 = num3;
            }
           
            if (amal == 1)
            {
                textBox1.Text = (num1 - float.Parse(textBox1.Text)).ToString();
               
                
            }
            if (amal == 2)
            {
                textBox1.Text = (num1 + float.Parse(textBox1.Text)).ToString();
                
            }
            if (amal == 3)
            {
                textBox1.Text = (num1 * float.Parse(textBox1.Text)).ToString();
               
            }
            if (amal == 4)
            {
                textBox1.Text = (num1 / float.Parse(textBox1.Text)).ToString();
               
            }
            if (amal == 5)
            {
                textBox1.Text = (Math.Pow(num1,float.Parse(textBox1.Text)).ToString());
               
            }
            if (amal == 6)
            {
                textBox1.Text = (Math.Sqrt(num1).ToString());
                
            }
            if (amal == 7)
            {
                num2 = 1;
                for (long i = 1; i < long.Parse(textBox1.Text); i++)
                {


                    num2  = num2*(i + 1);
                    
                }
                textBox1.Text = num2.ToString();
            }
            isNum1 = true; num1 = 0;
         
        }
        
        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || isNum1 == true)
            {
                textBox1.Clear();
            }
            if (textBox1.Text.Length == 0)
            {
                textBox1.Text = "0";
                isNum1 = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "00";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            isNum1 = true;
            amal = 5;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            isNum1 = true;
            amal = 6;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0" && textBox1.Text.Length > 0)
            {
                if (textBox1.Text.Substring(0, 1) == "-") 
                {
                    textBox1.Text = textBox1.Text.Substring(1);
                }
                else 
                {
                    textBox1.Text = "-" + textBox1.Text;
                }
            }
           
        }

        private void button23_Click(object sender, EventArgs e)
        {
            num1 = long.Parse(textBox1.Text);
            isNum1 = true;
            amal = 7;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void historyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (amal != 0)
            {
               textBox1.Text = num1.ToString() + amal + float.Parse(textBox1.Text );
            }
        }

       

       
    }
}
