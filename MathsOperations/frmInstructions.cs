using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathsOperations
{
    public partial class frmInstructions : Form
    {
        public frmInstructions()
        {
            InitializeComponent();
            CenterToScreen();
            string characterseparate = frmHome.Data.charseparate;
            lbTitle.Text = ($"Calculate the Average (mean) of numbers you input. \r\nDoes not take anomalies into account, please use a different program to do this. \r\nSeparate each value / number with a: {characterseparate} when inputting all of\r\nthe numbers below, or your text file, before selecting.");
        }

        private void frmInstructions_Load(object sender, EventArgs e)
        {

        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmAverage().Show();
        }
    }
}
