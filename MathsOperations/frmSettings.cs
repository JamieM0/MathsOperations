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
    public partial class frmSettings : Form
    {
        string file;
        public frmSettings()
        {
            InitializeComponent();
            txtSeparationCharacter.MaxLength = 1;
            txtSeparationCharacter.Text = frmHome.Data.charseparate;
            file = @"settings.txt";
            CenterToScreen();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {

        }

        private void btnSaveAndReturnHome_Click(object sender, EventArgs e)
        {
            SaveAll();
            ReturnHome();
        }

        private void SaveAll()
        {
            FileStream afile;
            StreamWriter sw;
            afile = new FileStream(file, FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(afile);
            //Format: CharacterSeparation;
            sw.WriteLine($"{txtSeparationCharacter.Text}");
            sw.Close();
            afile.Close();
        }

        private void ReturnHome()
        {
            this.Hide();
            new frmHome().Show();
        }
    }
}
