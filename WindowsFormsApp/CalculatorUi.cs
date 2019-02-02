using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
    {
    public partial class CalculatorUi : Form
        {
        public CalculatorUi ( )
            {
            InitializeComponent ( );
            double firstNumber, secondNumber;
            firstNumber = Convert.ToDouble ( firstNumberTextBox.Text );
            secondNumber = Convert.ToDouble ( secondNumberTextBox.Text );
            string sum = Convert.ToString ( firstNumber + secondNumber );
            string substract = Convert.ToString ( firstNumber - secondNumber );
            string division = Convert.ToString ( firstNumber / secondNumber );
            string multiply = Convert.ToString ( firstNumber * secondNumber );

            if ( resultTextBox.Text == AdditionButton.Text )
                {
                MessageBox.Show ( sum );
                }
            else if ( resultTextBox.Text==SubtractionButton.Text)
                {
                MessageBox.Show ( substract);
                }
            }



        /* private void AdditionButton_Click(object sender, EventArgs e)
         {
             double firstNumber, secondNumber;
        
             firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
             secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
             resultTextBox.Text = Convert.ToString(firstNumber + secondNumber);

         }

         private void SubtractionButton_Click(object sender, EventArgs e)
         {
             double firstNumber, secondNumber;
             firstNumber =Convert.ToDouble(firstNumberTextBox.Text);
             secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
             resultTextBox.Text = Convert.ToString(firstNumber-secondNumber);
         }

         private void MultiplyButton_Click(object sender, EventArgs e)
         {
             double firstNumber, secondNumber;
             firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
             secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
             resultTextBox.Text =Convert.ToString(firstNumber * secondNumber);
         }

         private void DivisionButton_Click(object sender, EventArgs e)
         {
             double firstNumber, secondNumber;
             firstNumber =Convert.ToDouble( firstNumberTextBox.Text);
             secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
             resultTextBox.Text = Convert.ToString(firstNumber/secondNumber);
         }*/



        }
    }
