using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiPoliOcoder
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = Properties.Settings.Default.LangIndex;
            checkBoxStatInfo.Checked = Properties.Settings.Default.chBoxStatInfo;
            checkBoxIndicators.Checked = Properties.Settings.Default.chBoxIndicators; 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
             
        }

        private void OKbutton_Click (object sender, EventArgs e)
        {
            MainForm main = this.Owner as MainForm;

            Properties.Settings.Default.chBoxIndicators = checkBoxIndicators.Checked;

            if (checkBoxIndicators.Checked == true)
            {
                main.CountIndicatorVisible = true;
                main.AutIndicatorVisible = false;
                main.NotAutIndicatorVisible = true;
            }
            else if (checkBoxIndicators.Checked == false)
            {
                main.CountIndicatorVisible = false;
                main.AutIndicatorVisible = false;
                main.NotAutIndicatorVisible = false;
            }

            Properties.Settings.Default.chBoxStatInfo = checkBoxStatInfo.Checked;
 
            if (comboBox1.SelectedIndex != Properties.Settings.Default.LangIndex)
            {
                DialogResult dialogResult = MessageBox.Show("The application must reboot to change language\nAll entered data will be lost", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Properties.Settings.Default.LangIndex = comboBox1.SelectedIndex;
                    Properties.Settings.Default.Save();
                    Application.Restart();
                }
                else if (dialogResult == DialogResult.No)
                {
                    this.Close();
                }
                
            }

            Properties.Settings.Default.Save();
            this.Close();

        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
