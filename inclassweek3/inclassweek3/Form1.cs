using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inclassweek3
{


    /*
     * 
     * 
     * 
     * 
Retail Price Calculator
Create an application that lets the user enter an item’s wholesale cost and its markup
percentage. It should then display the item’s retail price. For example:
• If an item’s wholesale cost is $5.00 and its markup percentage is 100 percent,
then the item’s retail price is $10.00.
• If an item’s wholesale cost is $5.00 and its markup percentage is 50 percent,
then the item’s retail price is $7.50.
The program should have a method named CalculateRetail that receives the
wholesale cost and the markup percentage as arguments and returns the retail price
of the item.
     * 
     * 
     * joshua voss 
     * 
     * 
     * 
     * */
    public partial class Form1 : Form
    {

        double wholeslae;
        double retail;
        double persent; 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculate();
        }
        private void calculate()
        {
            double db;
            db = Convert.ToDouble(textBox1.Text);
            db = double.Parse(textBox1.Text);

            wholeslae = db; 
            double markup;
            if (comboBox1.Text == "5%")
            {

                persent = .05;
            }
            if (comboBox1.Text == "10%")
            {

                persent = .10;
            }
            if (comboBox1.Text == "15%")
            {

                persent = .15;
            }
            if (comboBox1.Text == "25%")
            {

                persent = .25;
            }
            if (comboBox1.Text == "50%")
            {

                persent = .50;
            }
            if (comboBox1.Text == "100%")
            {

                persent = 1;
            }
            markup = wholeslae * persent;
            retail = wholeslae + markup;
            retail = Math.Round(retail, 2);
            textBox2.Text = retail.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            double result;
            if (double.TryParse(s, out result))
            {
                // The string was a valid integer => use result here
            }
            else
            {
                textBox1.Clear();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
