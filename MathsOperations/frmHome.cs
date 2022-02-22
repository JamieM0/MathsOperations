using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MathsOperations
{
    public partial class frmHome : Form
    {
        string file = @"settings.txt";
        public static classData Data = new classData();
        public frmHome()
        {
            InitializeComponent();
            FileStream aFile;
            StreamWriter sw;
            if (!File.Exists(file))
            {
                aFile = new FileStream(file, FileMode.Create, FileAccess.Write);
                sw = new StreamWriter(aFile);
                sw.WriteLine(",");
                frmHome.Data.charseparate = (",");
            }
            else
            {

            }
        }

        private void frmHome_Load(object sender, EventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmSettings().Show();
        }

        private void btnGoToAverage_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmAverage().Show();
        }
    }
}
