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
using System.Text.RegularExpressions;

namespace Final_Project
// keyuri dhorajiya

{
    public partial class tempconv : Form
    {
        string message;
        String from, to;
        string conversionType;

        public tempconv()
        {
            InitializeComponent();
        }

        private void convetbtn_Click(object sender, EventArgs e)
        {
            double inputTemp = Convert.ToDouble(input.Text);
            double outputTemp;


            try
            {
              
                if (fromctof.Checked)
                {
                    from = "C";
                    to = "F";
                    outputTemp = (inputTemp * 9 / 5) + 32;
                    conversionType = "Celsius to Fahrenheit";

                    if (outputTemp <= 212 & outputTemp > 104)
                    {
                        
                        message = "Water boils";
                        messagebox.ForeColor = Color.DarkRed;
                       

                    }
                    else if (outputTemp <= 104 & outputTemp > 98.6)
                    {
                        message = "Hot Bath";
                        messagebox.ForeColor = Color.Red;

                    }
                    else if (outputTemp <= 98.6 & outputTemp > 86)
                    {
                        message = "Body Temperature";
                        messagebox.ForeColor = Color.Yellow;
                    }
                    else if (outputTemp <= 86 & outputTemp > 70)
                    {
                        message = "Beach Weather";
                        messagebox.ForeColor = Color.Yellow;

                    }
                    else if (outputTemp <= 70 & outputTemp > 50)
                    {
                        message = "Room Temperature";
                        messagebox.ForeColor = Color.Green;

                    }
                    else if (outputTemp <= 50 & outputTemp > 32)
                    {
                        message = "Cool Day";
                        messagebox.ForeColor = Color.SkyBlue;

                    }
                    else if (outputTemp <= 32 & outputTemp > 0)
                    {
                        message = "Freezing Point of Water";
                        messagebox.ForeColor = Color.Blue;

                    }
                    else if (outputTemp <= 0 & outputTemp > -40)
                    { 
                        message = "Very Cold Day";
                        messagebox.ForeColor = Color.DarkBlue;

                    }
                    else 
                    {
                        message = "Extremely Cold Day\n( and the same number! )";
                        messagebox.ForeColor = Color.Purple;

                    }
                }

                else
                {
                    from = "F";
                    to = "C";
                    outputTemp = (inputTemp - 32) * 5 / 9;
                    conversionType = "Fahrenheit to Celsius";

                    if (outputTemp <= 100 & outputTemp > 40)
                    {
                        message = "Water boils";
                        messagebox.ForeColor = Color.DarkRed;

                    }
                    else if (outputTemp <= 40 & outputTemp > 37)
                    {
                        message = "Hot Bath";
                        messagebox.ForeColor = Color.Red;

                    }
                    else if (outputTemp <= 37 & outputTemp > 30)
                    {
                        message = "Body Temperature";
                        messagebox.ForeColor = Color.Yellow;

                    }
                    else if (outputTemp <= 30 & outputTemp > 21)
                    {
                        message = "Beach Weather";
                        messagebox.ForeColor = Color.Yellow;

                    }
                    else if (outputTemp <= 21 & outputTemp > 10)
                    {
                        message = "Room Temperature";
                        messagebox.ForeColor = Color.Green;
                    }
                    else if (outputTemp <= 10 & outputTemp > 0)
                    {
                        message = "Cool Day";
                        messagebox.ForeColor = Color.SkyBlue;

                    }
                    else if (outputTemp <= 0 & outputTemp > -18)
                    {
                        message = "Freezing Point of Water";
                        messagebox.ForeColor = Color.Blue;

                    }
                    else if (outputTemp <= -18 & outputTemp > -40)
                    {
                        message = "Very Cold Day";
                        messagebox.ForeColor = Color.DarkBlue;

                    }
                    else 
                    {
                        message = "Extremely Cold Day\n( and the same number! )";
                        messagebox.ForeColor = Color.Purple;

                    }

                }

                output.Text = outputTemp.ToString();
                
                messagebox.Text = message;


                try
                {

                    using (StreamWriter sw = new StreamWriter("TempConversions.txt", true))
                    {
                        sw.WriteLine(inputTemp + from + " = " + outputTemp + to + ",  " + DateTime.Now + "  " + message );
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error writing to file: " + ex.Message);
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void readfile_Click(object sender, EventArgs e)
        {
            try
            {
                string conversions = File.ReadAllText("TempConversions.txt");
                MessageBox.Show($"Temperature Conversions:\n\n{conversions}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Do you want to close the App?", "Exit", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                // MessageBox.Show("You decide to quit.");
                this.Close();
            }

        }

        private void fromctof_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "F";
            label3.Text = "C";
        }

        private void messagebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fromftoc_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "F";
            label2.Text = "C";
        }
    }
}
