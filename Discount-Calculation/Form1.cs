using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discount_Calculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numberOfBooks;
            double total;
            numberOfBooks = Convert.ToInt16(textBox1.Text);
            if(numberOfBooks >= 5 && numberOfBooks < 15) {
                total = (numberOfBooks * 5) - (numberOfBooks * 5 *0.25);
                textBox2.Text = total.ToString() + " USD";
                label4.Text = "25% Discount Applied";
            }
            if(numberOfBooks >= 15 && numberOfBooks < 30)
            {
                total = (numberOfBooks * 5) - (numberOfBooks * 5 * 0.45);
                textBox2.Text = total.ToString() + " USD";
                label4.Text = "45% Discount Applied";
            }
            if( numberOfBooks >= 30)
            {
                total = (numberOfBooks * 5) - (numberOfBooks * 5 * 0.65);
                    textBox2.Text = total.ToString() + " USD";
                label4.Text = "65% Discount Applied";
            }
            

            if(numberOfBooks < 5)
            {
                label3.Visible = true;
                label3.Text = "You must purchase the minimum number of books \n or more to take advantage of the discount.";
                total = numberOfBooks * 5;
                textBox2.Text = total + " USD";
                label4.Text = "00% Discount Applied";
            }
            else
            {
                label3.Visible = false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
