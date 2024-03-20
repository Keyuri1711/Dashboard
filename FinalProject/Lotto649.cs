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

namespace FinalProject
// keyuri dhorajiya

{
    public partial class Lotto649 : Form
    {
        public Lotto649()
        {
            InitializeComponent();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit this application ?", "Exit ?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void generate_Click(object sender, EventArgs e)
        {
            String savenumber ="";
            String bonus ="";
            output.Text = "";

            Random random = new Random();
            for (int i = 0; i < 6; i++)
            {
                int randomNumber = random.Next(1, 49);
                savenumber = savenumber + Convert.ToString(randomNumber) +", " ;
                output.Text += randomNumber.ToString() + "\r\n";
            }
            
            for (int i = 0; i < 1; i++)
            {
                int randomNumber = random.Next(1, 49);
                bonus = bonus + Convert.ToString(randomNumber)  ;
                output.Text += randomNumber.ToString() + "\r\n";
            }
            try
            {
                using (StreamWriter sw = new StreamWriter("LottoNbrs.txt", true))
                {
                    sw.WriteLine("649,  " + DateTime.Now + ",\t" +  savenumber + "  Bonus "  +  bonus +  "\n");
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

        private void Lotto649_Load(object sender, EventArgs e)
        {

        }

        private void output_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
