using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Xml;
using System.Linq;

namespace MathsOperations
{
    public partial class frmAverage : Form
    {
        string characterseparate = frmHome.Data.charseparate;
        public frmAverage()
        {
            InitializeComponent();
            lbTitle.Text = ($"Calculate the Average (mean) of numbers you input. \r\nDoes not take anomalies into account, please use a different program to do this. \r\nSeparate each value / number with a: {characterseparate} when inputting all of\r\nthe numbers below, or your text file, before selecting.");
            lbAverage.Enabled = false;
            lbAverage.Visible = false;
        }
        //""
        private void frmAverage_Load(object sender, EventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmSettings().Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmHome().Show();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //new frmHome().Show();
            string numsin = txtNums.Text;
            string numsintrimmed = numsin.Trim();
            string numsnospace = numsintrimmed.Replace(" ", string.Empty);
            //string numsnospacea = numsnospace.Replace(0x09, string.Empty);
            //Regex.Replace(XML, @"\s+", "");
            //XML.Replace
            //char[] characterseparatea = new char[1];
            ///*char[]*/ characterseparatea = characterseparate.ToCharArray();
            string[] numsina;
            numsina = numsintrimmed.Split(','/*characterseparatea[0]*//*.ToCharArray()*/);
            //if (!numsintrimmed.Contains(" "))
            //{
            //    numsina = numsintrimmed.Split(characterseparatea[0]/*.ToCharArray()*/);
            //}
            //else
            //{
            //    //string[] numsina = numsintrimmed.Split($"");
            //}

            int length = numsina.Length;
            double total = 0;
            for (int i = 0; i < numsina.Length; i++)
            {
                total = total + Convert.ToDouble(numsina[i]);
            }

            double average = total / numsina.Length;
            lbAverage.Enabled = true;
            lbAverage.Visible = true;
            lbAverage.Text = ($"Average: {average}");
        }
    }
}
