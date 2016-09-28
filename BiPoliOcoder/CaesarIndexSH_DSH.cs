using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiPoliOcoder
{
    public partial class CaesarIndexSH_DSH : Form
    {
        public CaesarIndexSH_DSH()
        {
            InitializeComponent();
        }

        private void KeyDownEnterOK(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                OK_button_Click(this, new EventArgs());
            }
        }

        private void OK_button_Click(object sender, EventArgs e)
        {

            /*   MainForm ok = new MainForm();  
               ok.TextBoxValue = "SomeValue";  //такий формат вимагає перезавантаження головної форми (чи, хоча б, текстбоксу)!
             //ok.Show();  // - новий об'єкт, новий потік, нове життя!
               this.Close();   */

            MainForm main = this.Owner as MainForm;
            if (main.checkbuttontrueSHfalseDSH == true)
            {
                SH();

                if (Properties.Settings.Default.chBoxIndicators == true)   //indicators
                {
                    main.AutIndicatorVisible = true;
                    main.NotAutIndicatorVisible = false;
                }
            }
            else
            {
                DSH();

                if (Properties.Settings.Default.chBoxIndicators == true)   //indicators
                {
                    main.AutIndicatorVisible = true;
                    main.NotAutIndicatorVisible = false;
                }
            }

        }

        private void SH()
        {
            MainForm main = this.Owner as MainForm;
            if (main != null)
            {
                int k, n, index;
                string s = main.TextBoxValue.Trim().ToLower();
                index = Convert.ToInt32(numericUpDown1.Value);
                if (index < 26 & index > 0)
                {
                    n = s.Length;
                    main.TextBoxValue = "";
                    for (int i = 0; i < n; i++)
                    {
                        if (s[i] != (' '))
                        {
                            k = (int)s[i];
                            k = k + index;
                            if (k > 122) k = k - 26;
                            main.TextBoxValue = main.TextBoxValue + ((char)(k)).ToString();
                        }
                        else
                            main.TextBoxValue += (' ');

                        
                        
                    }
                }
            }
            this.Close();
        }

        private void DSH()
        {
            MainForm main = this.Owner as MainForm;
            if (main != null)
            {
                int k, n, index;
                string s = main.TextBoxValue.ToLower();
                index = Convert.ToInt32(numericUpDown1.Value);
                if (index < 26 & index > 0)
                   {

                        n = s.Length;
                        main.TextBoxValue = "";
                        for (int i = 0; i < n; i++)
                        {
                            if (s[i] != (' '))
                            {
                                k = (int)s[i];
                                k = k - index;
                                if (k < 97) k = k + 26;
                                main.TextBoxValue = main.TextBoxValue + ((char)(k)).ToString();
                            }
                            else
                            main.TextBoxValue += (' ');

                        }

                    }
                }
                this.Close();
            }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}