using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guessing_the_Number
{
    public partial class Form1 : Form
    {
        int number;
        int high = 100;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getNewNumber();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int guess = 0;
            try
            {
                guess = Int32.Parse(textBox1.Text);
            }catch(FormatException idk)
            {}
            int counter = Int32.Parse(label3.Text);
            counter++;
            if (guess == number)
            {
                label1.Text = "YES!!!";
                if(high > counter)
                    high = counter;
                counter = 0;
                getNewNumber();
            }else if(guess > number)
            {
                label1.Text = "WRONG";
                label2.Text = "lower";
            }
            else
            {
                label1.Text = "WRONG";
                label2.Text = "higher";
            }
            if(high != 100)
            label4.Text = high.ToString();
            label3.Text = counter.ToString();
        }
        private void getNewNumber()
        {
            Random rnd = new Random();
            number = rnd.Next(1000);
        }
        
    }
}
