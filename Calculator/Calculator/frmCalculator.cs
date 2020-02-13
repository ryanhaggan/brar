using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class frmCalculator : Form
    {

        //Variables
        decimal NumberOne;
        decimal NumberTwo;
        decimal Answer;

        public frmCalculator()
        {
            InitializeComponent();
        }

        private void LblNumberOne_Click(object sender, EventArgs e)
        {

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtNumberOne.Clear();
            txtNumberTwo.Clear();
            txtAnswer.Clear();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            NumberOne = Convert.ToDecimal(txtNumberOne.Text);
            NumberTwo = Convert.ToDecimal(txtNumberTwo.Text);
            Answer = NumberOne * NumberTwo;
            txtAnswer.Text = Answer.ToString();
        }

        private void FrmCalculator_Load(object sender, EventArgs e)
        {

        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            NumberOne = Convert.ToDecimal(txtNumberOne.Text);
            NumberTwo = Convert.ToDecimal(txtNumberTwo.Text);
            Answer = NumberOne / NumberTwo;
            txtAnswer.Text = Answer.ToString();
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            NumberOne = Convert.ToDecimal(txtNumberOne.Text);
            NumberTwo = Convert.ToDecimal(txtNumberTwo.Text);
            Answer = NumberOne - NumberTwo;
            txtAnswer.Text = Answer.ToString();
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            NumberOne = Convert.ToDecimal(txtNumberOne.Text);
            NumberTwo = Convert.ToDecimal(txtNumberTwo.Text);
            Answer = NumberOne + NumberTwo;
            txtAnswer.Text = Answer.ToString();
        }

        private void TxtNumberOne_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
