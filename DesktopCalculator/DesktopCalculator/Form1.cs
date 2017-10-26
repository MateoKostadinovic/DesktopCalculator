using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopCalculator
{
    public partial class Form1 : Form
    {

        public float fA;
        public float fB;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fA = Convert.ToSingle(inptFirstNumber.Value);
            fB = Convert.ToSingle(inptSecondNumber.Value);
            inptResult.Text = Convert.ToString(fA + fB);
        }

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            fA = Convert.ToSingle(inptFirstNumber.Value);
            fB = Convert.ToSingle(inptSecondNumber.Value);
            inptResult.Text = Convert.ToString(fA - fB);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            fA = Convert.ToSingle(inptFirstNumber.Value);
            fB = Convert.ToSingle(inptSecondNumber.Value);
            inptResult.Text = Convert.ToString(fA * fB);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            fA = Convert.ToSingle(inptFirstNumber.Value);
            fB = Convert.ToSingle(inptSecondNumber.Value);
            inptResult.Text = Convert.ToString(fA / fB);
        }
    }
}
