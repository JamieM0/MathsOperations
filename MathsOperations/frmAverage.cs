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
using System.IO;

namespace MathsOperations
{
    public partial class frmAverage : Form
    {
        string characterseparate = frmHome.Data.charseparate;
        public frmAverage()
        {
            InitializeComponent();
            //lbTitle.Text = ($"Calculate the Average (mean) of numbers you input. \r\nDoes not take anomalies into account, please use a different program to do this. \r\nSeparate each value / number with a: {characterseparate} when inputting all of\r\nthe numbers below, or your text file, before selecting.");
            lbAverage.Enabled = false;
            lbAverage.Visible = false;
            lbPercentageDone.Visible = false;
            lbDone.Visible = false;
            progressBar1.Visible = false;
            CenterToScreen();
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
            if (comboBox1.Text == "Average")
            {
                Average("a");
            }
            else if (comboBox1.Text == "Multiplication")
            {
                //Multiplication();
                Average("b");
            }
            else if (comboBox1.Text == "Addition")
            {
                //Addition();
                Average("c");
            }
            else if (comboBox1.Text == "Subtraction")
            {
                /*Subtraction*//*()*//*;*/
                Average("d");
            }
            else if (comboBox1.Text == "Divison")
            {
                //Division();
                Average("e");
            }
            else
            {
                lbPercentageDone.Text = "Failure! Restart program to proceed. Remember to save your numbers!";
            }
        }

        private void Average(string code)
        {
            lbPercentageDone.Visible = true;
            lbDone.Visible = true;
            int pdone = 0;
            //this.Hide();
            //new frmHome().Show();
            string numsin = txtNums.Text;
            string numsintrimmed = numsin.Trim();
            string numsnospace = numsintrimmed.Replace(" ", string.Empty);
            numsnospace = numsnospace.Replace("\r\n", String.Empty);
            numsnospace = numsnospace.Replace("\r", String.Empty);
            numsnospace = numsnospace.Replace("\t", String.Empty);
            numsnospace = numsnospace.Replace("\v", String.Empty);
            numsnospace = numsnospace.Replace("\n", String.Empty);
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

            if (code == "a" || code == "c"/* || code == "c"*/)
            {
                int length = numsina.Length;
                double total = 0;
                for (int i = 0; i < numsina.Length; i++)
                {
                    total = total + Convert.ToDouble(numsina[i]);
                    pdone = i / numsina.Length * 100;
                    lbDone.Text = pdone.ToString() + "%";
                    //progressBar1.
                    if (pdone <= 25)
                    {
                        lbDone.ForeColor = Color.Red;
                    }
                    else if (pdone > 25 && pdone <= 80)
                    {
                        lbDone.ForeColor = Color.Orange;
                    }
                    else if (pdone < 100)
                    {
                        lbDone.ForeColor = Color.LawnGreen;
                    }
                    else
                    {
                        lbDone.ForeColor = Color.DarkGreen;
                    }
                }
                lbDone.Text = /*pdone.ToString() + */"100%";
                lbDone.ForeColor = Color.DarkGreen;
                switch (code)
                {
                    case "a":
                        double average = total / numsina.Length;
                        lbAverage.Text = ($"Average: {average}");
                        break;
                    case "c":
                        //double average = total / numsina.Length;
                        lbAverage.Text = ($"Total: {total}");
                        break;
                    //case "c":
                        
                    //    break;
                }
            }
            else if (code == "b"/*b*/)
            {
                int length = numsina.Length;
                double product = 1;
                for(int i = 0; i < numsina.Length; i++)
                {
                    product = product * Convert.ToDouble(numsina[i]);
                    pdone = i / numsina.Length * 100;
                    lbDone.Text = pdone.ToString() + "%";
                    //progressBar1.
                    if (pdone <= 25)
                    {
                        lbDone.ForeColor = Color.Red;
                    }
                    else if (pdone > 25 && pdone <= 80)
                    {
                        lbDone.ForeColor = Color.Orange;
                    }
                    else if (pdone < 100)
                    {
                        lbDone.ForeColor = Color.LawnGreen;
                    }
                    else
                    {
                        lbDone.ForeColor = Color.DarkGreen;
                    }
                }
                lbDone.Text = /*pdone.ToString() + */"100%";
                lbDone.ForeColor = Color.DarkGreen;
                lbAverage.Text = ($"Product: {product.ToString()}");
            }
            else
            {

            }
            
            lbAverage.Enabled = true;
            lbAverage.Visible = true;
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            string filePathOpen;
            string fileContentOpen;
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                ofd.RestoreDirectory = true;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of the specified file
                    filePathOpen = ofd.FileName;

                    //Read the contents of this file into a stream
                    var fileStream = ofd.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContentOpen = reader.ReadToEnd();
                    }

                    txtNums.Text = fileContentOpen;
                }
            }
        }
    }
}
