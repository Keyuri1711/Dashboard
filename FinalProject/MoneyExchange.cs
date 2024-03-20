using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalProject
// keyuri dhorajiya

{
    public partial class MoneyExchange : Form
    {
        public DateTime stime;
       



        private double money;
        public MoneyExchange()
        {
            InitializeComponent();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            DateTime etime = DateTime.Now;
            TimeSpan timeDifference = etime - stime;

            int seconds = (int)timeDifference.TotalSeconds;
            int minutes = (int)timeDifference.TotalMinutes;

            if (MessageBox.Show("Do you want \nto quit the application \nMoney Exchange?", "Exit", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                MessageBox.Show("Time spent on form is  " +minutes + "minutes " + seconds + "seconds" + "\nStart Time: " + stime + "\nEnd Time: "+ etime);
                this.Close();
            }
        }

        private void MoneyExchange_Load(object sender, EventArgs e)
        {
            stime = DateTime.Now;
        }

        public MoneyExchange(double money)
        {
            this.money = money;
        }

        public double MoneyGetSet
        {
            get { return money; }
            set { money = value; }
        }

        string from, to;
        private void converbtn_Click(object sender, EventArgs e)
        {
            double input;

            try
            {
                input = Convert.ToDouble(inputbox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number.");
                return;
            }

           

            if (cadfrom.Checked == true && cadto.Checked == true)
            {
                from = "CAD";
                to = "CAD";
                outputbox.Text = inputbox.Text;
            }
            else if (cadfrom.Checked == true && usdto.Checked == true)
            {
                from = "CAD";
                to = "USD";
                outputbox.Text = Convert.ToString(input * 0.75);
            }
            else if (cadfrom.Checked == true && eurto.Checked == true)
            {
                from = "CAD";
                to = "EUR";
                outputbox.Text = Convert.ToString(input * 0.68);
            }
            else if (cadfrom.Checked == true && gbpto.Checked == true)
            {
                from = "CAD";
                to = "GBP";
                outputbox.Text = Convert.ToString(input * 0.60);

            }
            else if (cadfrom.Checked == true && inrto.Checked == true)
            {
                from = "CAD";
                to = "INDIA";
                outputbox.Text = Convert.ToString(input * 61.33);

            }
            else if (usdfrom.Checked == true && cadto.Checked == true)
            {
                from = "USD";
                to = "CAD";
                outputbox.Text = Convert.ToString(input * 1.34);

            }
            else if (usdfrom.Checked == true && usdto.Checked == true)
            {
                from = "USD";
                to = "USD";
                outputbox.Text = inputbox.Text;

            }
            else if (usdfrom.Checked == true && eurto.Checked == true)
            {

                from = "USD";
                to = "EUR";
                outputbox.Text = Convert.ToString(input * 0.91);

            }
            else if (usdfrom.Checked == true && gbpto.Checked == true)
            {

                from = "USD";
                to = "GBP";
                outputbox.Text = Convert.ToString(input * 0.81);

            }
            else if (usdfrom.Checked == true && inrto.Checked == true)
            {
                from = "USD";
                to = "INDIA";
                outputbox.Text = Convert.ToString(input * 81.99);

            }
            else if (eurfrom.Checked == true && cadto.Checked == true)
            {
                from = "EUR";
                to = "CAD";
                outputbox.Text = Convert.ToString(input * 1.47);

            }
            else if (eurfrom.Checked == true && usdto.Checked == true)
            {
                from = "EUR";
                to = "USD";
                outputbox.Text = Convert.ToString(input * 1.10);

            }
            else if (eurfrom.Checked == true && eurto.Checked == true)
            {
                from = "EUR";
                to = "EUR";
                outputbox.Text = inputbox.Text;
            }
            else if (eurfrom.Checked == true && gbpto.Checked == true)
            {
                from = "EUR";
                to = "GBP";
                outputbox.Text = Convert.ToString(input * 0.88);
                
            }
            else if (eurfrom.Checked == true && inrto.Checked == true)
            {

                from = "EUR";
                to = "INDIA";
                outputbox.Text = Convert.ToString(input * 89.91);

            }
            else if (gbpfrom.Checked == true && cadto.Checked == true)
            {

                from = "GBP";
                to = "CAD";
                outputbox.Text = Convert.ToString(input * 1.66);

            }
            else if (gbpfrom.Checked == true && usdto.Checked == true)
            {
                from = "GBP";
                to = "USD";
                outputbox.Text = Convert.ToString(input * 1.24);

            }
            else if (gbpfrom.Checked == true && eurto.Checked == true)
            {
                from = "GBP";
                to = "EUR";
                outputbox.Text = Convert.ToString(input * 1.13);

            }
            else if (gbpfrom.Checked == true && gbpto.Checked == true)
            {
                from = "GBP";
                to = "GBP";
                outputbox.Text = inputbox.Text;

            }
            else if (gbpfrom.Checked == true && inrto.Checked == true)
            {
                

                from = "GBP";
                to = "INDIA";
                outputbox.Text = Convert.ToString(input * 101.91);

            }
            else if (inrfrom.Checked == true && cadto.Checked == true)
            {
               

                from = "INDIA";
                to = "CAD";
                outputbox.Text = Convert.ToString(input * 0.016);

            }
            else if (inrfrom.Checked == true && usdto.Checked == true)
            {
              

                from = "INDIA";
                to = "USD";
                outputbox.Text = Convert.ToString(input * 0.012);

            }
            else if (inrfrom.Checked == true && eurto.Checked == true)
            {
               

                from = "INDIA";
                to = "EUR";
                outputbox.Text = Convert.ToString(input * 0.011);

            }
            else if (inrfrom.Checked == true && gbpto.Checked == true)
            {
                from = "INDIA";
                to = "GBP";
                outputbox.Text = Convert.ToString(input * 0.0098);

            }
            else if (inrfrom.Checked == true && inrto.Checked == true)
            {

                from = "INDIA";
                to = "INDIA";
                outputbox.Text = inputbox.Text;
            }

            try
            { 

                using (StreamWriter sw = new StreamWriter("MoneyConversions.txt", true))
                {
                    sw.WriteLine(input + from + " = " + outputbox.Text + to + ", " + DateTime.Now);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error writing to file: " + ex.Message);
            }
        }

        private void inrfrom_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void readfile_Click(object sender, EventArgs e)
        {

            try
            {
                using (StreamReader sr = new StreamReader("MoneyConversions.txt"))
                {
                    MessageBox.Show(sr.ReadToEnd());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading file: " + ex.Message);
            }
        }
    }
}
