using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
// keyuri dhorajiya

{
    public partial class Validator : Form
    {
        public DateTime strtime;



        public Validator()
        {
            InitializeComponent();
        }

        private void datetime_TextChanged(object sender, EventArgs e)
        {

        }

        private void IP4_Validator_Load(object sender, EventArgs e)
        {
            label2.Text = "Today : " + DateTime.Now;
            strtime = DateTime.Now;
    }

        private void validateip_Click(object sender, EventArgs e)
        {
            string ip = inputbox.Text.Trim();
            if (IsValidIP(ip))
            {
                try
                {
                    using (FileStream fileStream = new FileStream("ip_addresses.bin", FileMode.Append))
                    {
                        using (BinaryWriter writer = new BinaryWriter(fileStream))
                        {
                            writer.Write(ip);
                            writer.Write(DateTime.Now.ToLongDateString());
                        }
                    }
                    MessageBox.Show(inputbox.Text + "\nThe IP is correct");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error writing to file: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show(inputbox.Text + "\nThe IP must have 4 bytes \n Integer number between 0 to 255 \n Separated by a dot (255.255.255.255)");
            }
        }
        private bool IsValidIP(string ip)
        {
            Regex pattern = new Regex(@"^(?:[0-9]{1,3}\.){3}[0-9]{1,3}$");
            return pattern.IsMatch(ip);
        }

        private void reset_Click(object sender, EventArgs e)
        {
            inputbox.Text = "";
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            DateTime endtime = DateTime.Now;
            TimeSpan timeDifference = endtime - strtime;

            int seconds = (int)timeDifference.TotalSeconds;
            int minutes = (int)timeDifference.TotalMinutes;

            if (MessageBox.Show("Do you want to quit the application?", "Exit", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                MessageBox.Show("Time spent on this form is  " + minutes + "minutes " + seconds + "seconds" + "\nStart Time: " + strtime + "\nEnd Time: " + endtime);
                this.Close();
            }
        }
    }

}