using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        Calculator calcul= new Calculator();
        
        public Form1()
        {
            
            InitializeComponent();
            
        }

        public void buttonValues(Button buton)
        {

            for (int i = 0; i < 10; i++)
            {
                String confirmInput = Convert.ToString(i);
                if (buton.Text.Equals(confirmInput))
                {
                    calcul.SetNumber(buton.Text);
                }
            }
            this.shownResult.Text += buton.Text;
           /* shownResult.setText(this.shownResult.getText() + buton.getText()); */
        }

        public void buttonValues(string numberResult)
        {

            calcul.SetNumber(numberResult);
        }

        private void shownResult_Click(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            shownResult.Text="";
            calcul.ClearValues();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            buttonValues(four);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            buttonValues(seven);
        }

        private void three_Click(object sender, EventArgs e)
        {
            buttonValues(three);
        }

        private void six_Click(object sender, EventArgs e)
        {
            buttonValues(six);
        }

        private void one_Click(object sender, EventArgs e)
        {
            buttonValues(one);
        }

        private void zero_Click(object sender, EventArgs e)
        {
            buttonValues(zero);
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            int results = calcul.Operation();
            String resultsText = Convert.ToString(results);
            shownResult.Text= resultsText;
            calcul.ClearValues();
            buttonValues(resultsText);
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            buttonValues(Divide);
            calcul.AddToArrayList(Divide.Text);
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            buttonValues(Multiply);
            calcul.AddToArrayList(Multiply.Text);
        }

        private void Rest_Click(object sender, EventArgs e)
        {
            buttonValues(Rest);
            calcul.AddToArrayList(Rest.Text);
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            buttonValues(Plus);
            calcul.AddToArrayList(Plus.Text);
        }

        private void eight_Click(object sender, EventArgs e)
        {
            buttonValues(eight);
        }

        private void nine_Click(object sender, EventArgs e)
        {
            buttonValues(nine);
        }

        private void five_Click(object sender, EventArgs e)
        {
            buttonValues(five);
        }

        private void two_Click(object sender, EventArgs e)
        {
            buttonValues(two);
        }

        private void point_Click(object sender, EventArgs e)
        {
            buttonValues(point);
        }
    }
}
