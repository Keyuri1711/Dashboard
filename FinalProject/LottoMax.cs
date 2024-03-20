using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
// keyuri dhorajiya

{
    public partial class LottoMax : Form
    {
        public LottoMax()
        {
            InitializeComponent();
        }

        private void generate_Click(object sender, EventArgs e)
        {
            
            string savenum = "";
            string svnum = "";
            outputbox.Text = "";

            Random random = new Random();
            for (int i = 0; i < 7; i++)
            {

                int randomNumber = random.Next(1, 50);
                savenum = savenum + randomNumber.ToString() + ", ";
                outputbox.Text += randomNumber.ToString() + "\r\n";
               
            }

            for (int i = 0; i < 1; i++)
            {
                int randomNumber = random.Next(1, 50);
                svnum = svnum + randomNumber.ToString() ;
                outputbox.Text += randomNumber.ToString() + "\r\n";
            }


            try
            {
                using (StreamWriter sw = new StreamWriter("LottoNbrs.txt", true))
                {
                    sw.WriteLine("Max, " + DateTime.Now + ",\t" + savenum + "  Bonus " + svnum + "\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error writing to file: " + ex.Message);
            }
        }

        private void readfile_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader sr = new StreamReader("LottoNbrs.txt"))
                {
                    MessageBox.Show(sr.ReadToEnd());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading file: " + ex.Message);
            }
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit this application ?", "Exit ?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void LottoMax_Load(object sender, EventArgs e)
        {

        }

        private void outputbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
