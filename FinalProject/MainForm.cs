using Final_Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
// keyuri dhorajiya

{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        

        private void lottomax_Click(object sender, EventArgs e)
        {
            LottoMax obj = new LottoMax();
            obj.ShowDialog();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void ipvalidator_Click(object sender, EventArgs e)
        {
            Validator obj = new Validator();
            obj.ShowDialog();
        }

        private void Calculator_Click(object sender, EventArgs e)
        {
            Calculator obj = new Calculator() ;
            obj.ShowDialog();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tempconvert_Click(object sender, EventArgs e)
        {
            tempconv obj = new tempconv();
            obj.ShowDialog();
        }

        private void lotto649_Click(object sender, EventArgs e)
        {
            Lotto649 obj = new Lotto649();
            obj.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void moneyexchange_Click(object sender, EventArgs e)
        {
            MoneyExchange obj = new MoneyExchange();
            obj.ShowDialog();
        }
    }
}
