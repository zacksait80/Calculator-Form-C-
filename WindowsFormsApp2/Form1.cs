using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String opPerfomed = " ";
        bool isPorfomed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void n_click(object sender, EventArgs e)
        {
            if ((textBox.Text == "0") || (isPorfomed))
                textBox.Clear();

            isPorfomed = false;

            Button n = (Button)sender;
            if (n.Text == ".")
            {
                if (!textBox.Text.Contains("."))
                    textBox.Text = textBox.Text + n.Text;

            }
            else 
            textBox.Text = textBox.Text + n.Text;
            

        }

        private void op_click(object sender, EventArgs e)
        {
            Button n = (Button) sender;
            if(resultValue != 0)
            {
                button8.PerformClick();
                opPerfomed = n.Text;
                resultValue = Double.Parse(textBox.Text);
                isPorfomed = true;

            }
            else {
                opPerfomed = n.Text;
                resultValue = Double.Parse(textBox.Text);
                isPorfomed = true;
            }
         
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
            resultValue = 0;
        }

        private void button8_Click(object sender, EventArgs e)
        {
           
            switch(opPerfomed)
            {
                case "+":
                    textBox.Text = (resultValue + Double.Parse(textBox.Text)).ToString();
                    break;
                case "-":
                    textBox.Text = (resultValue - Double.Parse(textBox.Text)).ToString();
                    break;
                case "*":
                    textBox.Text = (resultValue * Double.Parse(textBox.Text)).ToString();
                    break;
                case "/":
                    textBox.Text = (resultValue / Double.Parse(textBox.Text)).ToString();
                    break;

            }
            resultValue = 0;
             
            
        }
    }
}
