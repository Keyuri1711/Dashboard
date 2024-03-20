using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;

namespace FinalProject
    // keyuri dhorajiya
{
    public partial class Calculator : Form

    {
        private Calculator calculator;


        double FirstNumber=0;
        string Operation="";

        double SecondNumber=0;
        double Result;
        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button_Click(object sender, EventArgs e)
        {
        }

        private void buttonclr_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = "0";

        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (textBoxOutput.Text == "0" && textBoxOutput.Text != null)
            {
                textBoxOutput.Text = "0";
            }
            else
            {
                textBoxOutput.Text = textBoxOutput.Text + "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxOutput.Text == "0" && textBoxOutput.Text != null)
            {
                textBoxOutput.Text = "1";
            }
            else
            {
                textBoxOutput.Text = textBoxOutput.Text + "1";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxOutput.Text == "0" && textBoxOutput.Text != null)
            {
                textBoxOutput.Text = "2";
            }
            else
            {
                textBoxOutput.Text = textBoxOutput.Text + "2";
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBoxOutput.Text == "0" && textBoxOutput.Text != null)
            {
                textBoxOutput.Text = "3";
            }
            else
            {
                textBoxOutput.Text = textBoxOutput.Text + "3";
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBoxOutput.Text == "0" && textBoxOutput.Text != null)
            {
                textBoxOutput.Text = "4";
            }
            else
            {
                textBoxOutput.Text = textBoxOutput.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBoxOutput.Text == "0" && textBoxOutput.Text != null)
            {
                textBoxOutput.Text = "5";
            }
            else
            {
                textBoxOutput.Text = textBoxOutput.Text + "5";
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBoxOutput.Text == "0" && textBoxOutput.Text != null)
            {
                textBoxOutput.Text = "6";
            }
            else
            {
                textBoxOutput.Text = textBoxOutput.Text + "6";
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBoxOutput.Text == "0" && textBoxOutput.Text != null)
            {
                textBoxOutput.Text = "7";
            }
            else
            {
                textBoxOutput.Text = textBoxOutput.Text + "7";
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBoxOutput.Text == "0" && textBoxOutput.Text != null)
            {
                textBoxOutput.Text = "8";
            }
            else
            {
                textBoxOutput.Text = textBoxOutput.Text + "8";
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBoxOutput.Text == "0" && textBoxOutput.Text != null)
            {
                textBoxOutput.Text = "9";
            }
            else
            {
                textBoxOutput.Text = textBoxOutput.Text + "9";
            }

        }

        private void dotbtn_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = textBoxOutput.Text + ".";

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            
            try
            {
                FirstNumber = Convert.ToDouble(textBoxOutput.Text);
                Operation = "+";
                textBoxOutput.Text = "+";
            }
            catch (Exception ex)
            {
                textBoxOutput.Text = "Error: " + ex.Message;
            }


        }

        private void subtractbtn_Click(object sender, EventArgs e)
        {
            
            try
            {
                FirstNumber = Convert.ToDouble(textBoxOutput.Text);
                Operation = "-";
                textBoxOutput.Text = "-";
            }
            catch (Exception ex)
            {
                textBoxOutput.Text = "Error: " + ex.Message;
            }


        }

        private void multiplybtn_Click(object sender, EventArgs e)
        {
           
            try
            {
                FirstNumber = Convert.ToDouble(textBoxOutput.Text);
                Operation = "*";
                textBoxOutput.Text = "*";
            }
            catch (Exception ex)
            {
                textBoxOutput.Text = "Error: " + ex.Message;
            }


        }

        private void divisionbtn_Click(object sender, EventArgs e)
        {
            try
            {
                FirstNumber = Convert.ToDouble(textBoxOutput.Text);
                Operation = "/";
                textBoxOutput.Text = "/";
            }
            catch (Exception ex)
            {
                textBoxOutput.Text = "Error: " + ex.Message;
            }


        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close the App?", "Exit", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                this.Close();
            }
        }

        private void equalbtn_Click(object sender, EventArgs e)
        {


            try
            {
                SecondNumber = Convert.ToDouble(textBoxOutput.Text);

                switch (Operation)
                {
                    case "+":
                        Result = CalculatorOperations.Add(FirstNumber, SecondNumber);
                        break;
                    case "-":
                        Result = CalculatorOperations.Subtract(FirstNumber, SecondNumber);
                        break;
                    case "*":
                        Result = CalculatorOperations.Multiply(FirstNumber, SecondNumber);
                        break;
                    case "/":
                        Result = CalculatorOperations.Divide(FirstNumber, SecondNumber);
                        break;
                }

                textBoxOutput.Text = Convert.ToString(Result);

               

            }
            catch (Exception ex)
            {
                textBoxOutput.Text = "Error: " + ex.Message;
            }



            try
            {
                using (StreamWriter sw = new StreamWriter("Calculator.txt", true))
                {
                    sw.WriteLine(DateTime.Now + ":  " + FirstNumber + Operation + SecondNumber + " = " + Result + "\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error writing to file: " + ex.Message);
            }
        }

        private void history_Click(object sender, EventArgs e)
        {


            try
            {
                using (StreamReader sr = new StreamReader("Calculator.txt"))
                {
                    MessageBox.Show(sr.ReadToEnd());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading file: " + ex.Message);
            }

        }
        public class CalculatorOperations
        {
            double? Result = null;

            public static double Add(double firstNumber, double secondNumber)
            {
                return firstNumber + secondNumber;
            }

            public static double Subtract(double firstNumber, double secondNumber)
            {
                return firstNumber - secondNumber;
            }

            public static double Multiply(double firstNumber, double secondNumber)
            {
                return firstNumber * secondNumber;
            }

            public static double Divide(double firstNumber, double secondNumber)
            {
                
                    if (secondNumber == 0)
                    {
                        MessageBox.Show("Cannont Divide by Zero");
                    }
                      
                
               return firstNumber / secondNumber;
            }

        }
    }
}


