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
        int colaTotal = 1;
        int lemonTotal = 1;
        int grapeTotal = 1;  //These are initializing the click count for the drinks.
        int rootTotal = 1;
        int waterTotal = 1;

        public Form1()
        {
            InitializeComponent();
        }

        public bool checkAndCharge() //Method used for each drink button. 
        {
            decimal money = numericUpDown1.Value; //Pulls value from user input.
            double doubleMoney = decimal.ToDouble(money); //Converts it to double.
            if (doubleMoney < .75) //Each drink is $0.75.
            {
                MessageBox.Show("You have insufficient funds.", "Sorry"); //When the transaction is unsuccessful.
                return false; //Wont subtract a "soda" from the total.
            }
            else
            {
                doubleMoney = doubleMoney - .75; //Subtract the soda cost from user input.
                money = Convert.ToDecimal(doubleMoney); //Returns to Decimal to replace into field.
                numericUpDown1.Value = money; //Setting field to new total.
                MessageBox.Show("Enjoy your beverage!", "Enjoy!"); //When the transaction is successful.
                return true; //Will subtract a soda from total.
            } 
        }

        private void button1_Click(object sender, EventArgs e) //Cola button.
        {
            if (colaTotal > 5)
            {
                MessageBox.Show("There are no more drinks of this type!", "Sorry");
            }
            else if (checkAndCharge() == true)
            {
            colaTotal++; //Add to count.
            }
            else
            {
                
            }
        }

        private void button2_Click(object sender, EventArgs e) //Lemon button.
        {
            if (lemonTotal > 5)
            {
                MessageBox.Show("There are no more drinks of this type!", "Sorry");
            }
            else if (checkAndCharge() == true)
            {
                lemonTotal++; //Add to count.
            }
            else
            {

            }
        }

        private void button3_Click(object sender, EventArgs e) //Grape button.
        {
            if (grapeTotal > 5)
            {
                MessageBox.Show("There are no more drinks of this type!", "Sorry");
            }
            else if (checkAndCharge() == true)
            {
                grapeTotal++; //Add to count.
            }
            else
            {

            }
        }

        private void button4_Click(object sender, EventArgs e) //Rootbeer button.
        {
            if (rootTotal > 5)
            {
                MessageBox.Show("There are no more drinks of this type!", "Sorry");
            }
            else if (checkAndCharge() == true)
            {
                rootTotal++; //Add to count.
            }
            else
            {

            }
        }

        private void button5_Click(object sender, EventArgs e) //Water bottle button.
        {
            if (waterTotal > 5)
            {
                MessageBox.Show("There are no more drinks of this type!", "Sorry");
            }
            else if (checkAndCharge() == true)
            {
                waterTotal++; //Add to count.
            }
            else
            {

            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) //Field for money.
        {

        }
    }
}
