// Matthew G. Mershon
// Vending Machine program
//C# , MVS2012

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSPractice
{
    public partial class Form1 : Form
    {
        int colaTotal = 0;
        int lemonTotal = 0;
        int grapeTotal = 0;  //These are initializing the click count for the drinks.
        int rootTotal = 0;
        int waterTotal = 0;

        public Form1()
        {
            InitializeComponent();
        }

        public void checkAndCharge() //Method used for each drink button. 
        {
            decimal money = numericUpDown1.Value; //Pulls value from user input.
            double doubleMoney = decimal.ToDouble(money); //Converts it to double.
            if (doubleMoney < .75) //Each drink is $0.75.
            {
                MessageBox.Show("You have insufficient funds.", "Sorry"); //When the transaction is unsuccessful.
            }
            else
            {
                doubleMoney = doubleMoney - .75; //Subtract the soda cost from user input.
                money = Convert.ToDecimal(doubleMoney); //Returns to Decimal to replace into field.
                numericUpDown1.Value = money; //Setting field to new total.
                MessageBox.Show("Enjoy your beverage!", "Enjoy!"); //When the transaction is successful.
            }
        }

        private void button1_Click(object sender, EventArgs e) //Cola button.
        {
            if (colaTotal > 5)
            {
                MessageBox.Show("There are no more drinks of this type!", "Sorry");
            }
            else
            checkAndCharge();
            colaTotal++;
        }

        private void button2_Click(object sender, EventArgs e) //Lemon button.
        {
            if (lemonTotal > 5)
            {
                MessageBox.Show("There are no more drinks of this type!", "Sorry");
            }
            else
            checkAndCharge();
            lemonTotal++;
        }

        private void button3_Click(object sender, EventArgs e) //Grape button.
        {
            if (grapeTotal > 5)
            {
                MessageBox.Show("There are no more drinks of this type!", "Sorry");
            }
            else
            checkAndCharge();
            grapeTotal++;
        }

        private void button4_Click(object sender, EventArgs e) //Rootbeer button.
        {
            if (rootTotal > 5)
            {
                MessageBox.Show("There are no more drinks of this type!", "Sorry");
            }
            else
            checkAndCharge();
            rootTotal++;
        }

        private void button5_Click(object sender, EventArgs e) //Water bottle button.
        {
            if (waterTotal > 5)
            {
                MessageBox.Show("There are no more drinks of this type!", "Sorry");
            }
            else
            checkAndCharge();
            waterTotal++;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) //Field for money.
        {

        }
    }
}
