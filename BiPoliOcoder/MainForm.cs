using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.IO;
using System.Security.Cryptography;


namespace BiPoliOcoder
{
    public partial class MainForm : Form
    {
        public bool checkbuttontrueSHfalseDSH;

        public MainForm()
        {

            if (Properties.Settings.Default.LangIndex == 0)
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("");            //this empty value somehow sets default language value
            }
            if (Properties.Settings.Default.LangIndex == 1)
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-ES");
            }
            if (Properties.Settings.Default.LangIndex == 2)
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("de-DE");
            }
            if (Properties.Settings.Default.LangIndex == 3)
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("fr");
            }
            if (Properties.Settings.Default.LangIndex == 4)
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("ru");
            }
            if (Properties.Settings.Default.LangIndex == 5)
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("uk-UA");
            }

            InitializeComponent();

            MainRichTextBox.WordWrap = false;       //gives an order to main textbox don't move text to new lines by yourself

            this.ActiveControl = MainRichTextBox;          //makes the main textbox active right after the form loaded

            if (Properties.Settings.Default.chBoxIndicators == false)
            {
                IndAutPictureBox.Visible = false;
                IndNotAutPictureBox.Visible = false;
                IndCountLabel.Visible = false;
            }

            

            //for right trancperant view of indicators
           /* var poscnt = this.PointToScreen(IndCountLabel.Location);
            poscnt = MainRichTextBox.PointToClient(poscnt);
            IndCountLabel.Parent = MainRichTextBox;
            IndCountLabel.Location = poscnt;

            var posAUT = this.PointToScreen(IndAutPictureBox.Location);
            posAUT = MainRichTextBox.PointToClient(posAUT);
            IndAutPictureBox.Parent = MainRichTextBox;
            IndAutPictureBox.Location = posAUT;

            var posNOTAUT = this.PointToScreen(IndNotAutPictureBox.Location);
            posNOTAUT = MainRichTextBox.PointToClient(posNOTAUT);
            IndNotAutPictureBox.Parent = MainRichTextBox;
            IndNotAutPictureBox.Location = posNOTAUT;   */

            ToolTip toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 500;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;

            toolTip1.SetToolTip(IndAutPictureBox, "Authenticity: Yes");

            toolTip1.SetToolTip(IndNotAutPictureBox, "Authenticity: Undefined");

            toolTip1.SetToolTip(IndCountLabel, "Number of characters");
            
        }

    public string TextBoxValue
        {
            get { return MainRichTextBox.Text; }
            set { MainRichTextBox.Text = value;
            /*this.MainRichTextBox.Refresh();*/ }
        }
        public bool CountIndicatorVisible
        {
            get { return IndCountLabel.Visible; }
            set { IndCountLabel.Visible = value; }
        }
        public bool AutIndicatorVisible
        {
            get { return IndAutPictureBox.Visible;  }
            set { IndAutPictureBox.Visible = value; }
        }
        public bool NotAutIndicatorVisible
        {
            get { return IndNotAutPictureBox.Visible; }
            set { IndNotAutPictureBox.Visible = value; }
        }


        private void Shyfrobutton_Click(object sender, EventArgs e)
        {

            if (Properties.Settings.Default.chBoxStatInfo == true)
            {
                Perevirka_SH();
            }
            else
                try
                {
                    Perevirka_SH();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Unknown error occurred:"+ Environment.NewLine + Ex.ToString(), "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void Deshyfrobutton_Click(object sender, EventArgs e)
        {
            try
            {
                Perevirka_DSH();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Unknown error occurred:" + Environment.NewLine + Ex.ToString(), "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void Perevirka_SH()
        {
            string CodeTypeChoiceString = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            if (comboBox1.Text != String.Empty)
            {
                                                            //here starts if-else branching statements to select the type of encryption
                if (CodeTypeChoiceString.Equals("AES-256"))           
                {
                    checkbuttontrueSHfalseDSH = true;
                    ZashyfruvatyAES();
                }

                else if (CodeTypeChoiceString.Equals("Morse Code"))
                {
                    ZashyfruvatyMorse();
                }

                else if (CodeTypeChoiceString.Equals("Caesar"))
                {
                    checkbuttontrueSHfalseDSH = true;
                    ZashyfruvatyCaesar();
                }
                else if (CodeTypeChoiceString.Equals("PSM-104"))
                {
                    ZashyfruvatyPSM();
                }
            }
            else
                MessageBox.Show("Please select a method", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void Perevirka_DSH()
        {
            string CodeTypeChoiceString = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            if (comboBox1.Text != String.Empty)
            {
                                                            //here starts if-else branching statements to select the type for decryption
                if (CodeTypeChoiceString.Equals("AES-256"))
                {
                    checkbuttontrueSHfalseDSH = false;
                    DeshyfruvatyAES();
                }
                else if (CodeTypeChoiceString.Equals("Morse Code"))
                {
                    DeshyfruvatyMorse();
                }
                else if (CodeTypeChoiceString.Equals("Caesar"))
                {
                    checkbuttontrueSHfalseDSH = false;
                    DeshyfruvatyCaesar();
                }

                else if (CodeTypeChoiceString.Equals("PSM-104"))
                {
                    DeshyfruvatyPSM();
                }
            }
            else
            {
                MessageBox.Show("Please select a method", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }            
        }


        private void ReadTextFromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "TXT files|*.txt|All files|*";
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(OFD.FileName);
                MainRichTextBox.Text = File.ReadAllText(OFD.FileName, Encoding.Default);
            }
        }

        private void WriteTextToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog SFD = new SaveFileDialog();
            SFD.Filter = "TXT file|*.txt|Own format|*";

             
            if (SFD.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(SFD.FileName, MainRichTextBox.Text, Encoding.Default);
                MessageBox.Show(SFD.FileName);
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ExitFromProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm ok = new SettingsForm();
            ok.Owner = this;
            ok.ShowDialog();
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox ok = new AboutBox();
            ok.Owner = this;
            ok.ShowDialog();
        }

        private void ZashyfruvatyPSM()
        {
            string input = MainRichTextBox.Text;
            MainRichTextBox.Clear();
            StringBuilder sb = new StringBuilder();
            foreach (byte b in Encoding.Unicode.GetBytes(input))
                sb.Append(Convert.ToString(b, 2).PadLeft(8, '0')).Append(' ');

            string binaryStr = sb.ToString();

            char[] charArray = binaryStr.ToCharArray();
            Array.Reverse(charArray);

            binaryStr = new string(charArray);
            string charStr = binaryStr.Replace('0', 'a');
            charStr = charStr.Replace('1', 'b');

            /*       char[] arr2 = charStr.ToCharArray();

                    s = s.Replace("a", "b")
                   for (int i = 0; i <= arr2.Length; i++)
                   {

                   } */

            charStr = charStr.Replace("aaaaaaaa", "i");
            charStr = charStr.Replace("aaaaaaa", "h");
            charStr = charStr.Replace("aaaaaa", "g");
            charStr = charStr.Replace("aaaaa", "f");
            charStr = charStr.Replace("aaaa", "e");
            charStr = charStr.Replace("aaa", "d");
            charStr = charStr.Replace("aa", "c");

            charStr = charStr.Replace("bbbbbbbb", "p");
            charStr = charStr.Replace("bbbbbbb", "o");
            charStr = charStr.Replace("bbbbbb", "n");
            charStr = charStr.Replace("bbbbb", "m");
            charStr = charStr.Replace("bbbb", "l");
            charStr = charStr.Replace("bbb", "k");
            charStr = charStr.Replace("bb", "j");

            foreach (int a in charStr)
            {          
                charStr = charStr.Replace(" i ", "z");
            }

            MainRichTextBox.Text = charStr.Trim();

            if (Properties.Settings.Default.chBoxIndicators == true)   //indicators
            {
                IndAutPictureBox.Visible = true;
                IndNotAutPictureBox.Visible = false;
            }
        }

        private void DeshyfruvatyPSM()
        {
            string charStr = MainRichTextBox.Text;

            MainRichTextBox.Clear();

            foreach (Int64 a in charStr)
            {
                charStr = charStr.Replace("z", " i ");
            }

            charStr = charStr.Replace(" ", string.Empty).Trim();

            charStr = charStr.Replace("i", "aaaaaaaa");
            charStr = charStr.Replace("h", "aaaaaaa");
            charStr = charStr.Replace("g", "aaaaaa");
            charStr = charStr.Replace("f", "aaaaa");
            charStr = charStr.Replace("e", "aaaa");
            charStr = charStr.Replace("d", "aaa");
            charStr = charStr.Replace("c", "aa");

            charStr = charStr.Replace("p", "bbbbbbbb");
            charStr = charStr.Replace("o", "bbbbbbb");
            charStr = charStr.Replace("n", "bbbbbb");
            charStr = charStr.Replace("m", "bbbbb");
            charStr = charStr.Replace("l", "bbbb");
            charStr = charStr.Replace("k", "bbb");
            charStr = charStr.Replace("j", "bb");

            string binaryStr = charStr.Replace('a', '0');
            binaryStr = binaryStr.Replace('b', '1');

            char[] charArray = binaryStr.ToCharArray();
            Array.Reverse(charArray);
            binaryStr = new string(charArray);

            int numOfBytes = binaryStr.Length / 8;
            byte[] ba = new byte[numOfBytes];
            for (int i = 0; i < numOfBytes; i++)
            {
                ba[i] = Convert.ToByte(binaryStr.Substring(8 * i, 8), 2);
            } 

            MainRichTextBox.Text = Encoding.Unicode.GetString(ba);
            MainRichTextBox.Refresh();

            if (Properties.Settings.Default.chBoxIndicators == true)   //indicators
            {
                IndAutPictureBox.Visible = true;
                IndNotAutPictureBox.Visible = false;
            }
        }

        private void ZashyfruvatyMorse()
        {
            string s = MainRichTextBox.Text.ToUpper();
            MainRichTextBox.Clear();

            for (int i = 0; i < s.Length; i++)
            {
                if (i > 0)
                MainRichTextBox.Text += (' ');

                char c = s[i];
                if (morse.ContainsKey(c))
                    MainRichTextBox.Text += (morse[c]);
            }

            if (Properties.Settings.Default.chBoxIndicators == true)   //indicators
            {
                IndAutPictureBox.Visible = true;
                IndNotAutPictureBox.Visible = false;
            }
        }

        private void DeshyfruvatyMorse()
        {
            string s = MainRichTextBox.Text.ToUpper();
            MainRichTextBox.Clear();
            var revmorse = morse.ToDictionary(x => x.Value, x => x.Key);

            string[] splitwords = s.Split(new String[] {"  "}, StringSplitOptions.None);

            foreach (string okup in splitwords)
            {
                string[] splitsymbols = okup.Split(new Char[] { ' ' });
                foreach (string ok in splitsymbols)
                {
                    if (revmorse.ContainsKey(ok))
                        MainRichTextBox.Text += (revmorse[ok]);
                }
                MainRichTextBox.Text += (' ');
            }
            MainRichTextBox.Text = MainRichTextBox.Text.Trim();

            if (Properties.Settings.Default.chBoxIndicators == true)   //indicators
            {
                IndAutPictureBox.Visible = true;
                IndNotAutPictureBox.Visible = false;
            }
        }

        Dictionary<char, String> morse = new Dictionary<char, String>()
            {
                {'A' , ".-"},
                {'B' , "-..."},
                {'C' , "-.-."},
                {'D' , "-.."},
                {'E' , "."},
                {'F' , "..-."},
                {'G' , "--."},
                {'H' , "...."},
                {'I' , ".."},
                {'J' , ".---"},
                {'K' , "-.-"},
                {'L' , ".-.."},
                {'M' , "--"},
                {'N' , "-."},
                {'O' , "---"},
                {'P' , ".--."},
                {'Q' , "--.-"},
                {'R' , ".-."},
                {'S' , "..."},
                {'T' , "-"},
                {'U' , "..-"},
                {'V' , "...-"},
                {'W' , ".--"},
                {'X' , "-..-"},
                {'Y' , "-.--"},
                {'Z' , "--.."},
                {'0' , "-----"},
                {'1' , ".----"},
                {'2' , "..---"},
                {'3' , "...--"},
                {'4' , "....-"},
                {'5' , "....."},
                {'6' , "-...."},
                {'7' , "--..."},
                {'8' , "---.."},
                {'9' , "----."},
            };

        private void ZashyfruvatyCaesar()
        {
            CaesarIndexSH_DSH ok = new CaesarIndexSH_DSH();
            ok.Owner = this;
            ok.ShowDialog();
        }

        private void DeshyfruvatyCaesar()
        {
            CaesarIndexSH_DSH ok = new CaesarIndexSH_DSH();
            ok.Owner = this;
            ok.ShowDialog();
        }

        private void ZashyfruvatyAES()
        {
            KeyFormSH_DSH ok = new KeyFormSH_DSH();
            ok.Owner = this;
            ok.ShowDialog();
        }

        private void DeshyfruvatyAES()
        {
            KeyFormSH_DSH ok = new KeyFormSH_DSH();
            ok.Owner = this;
            ok.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string CodeTypeString = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            if (comboBox1.Text != String.Empty)
            {
                //here branches for brief help about encryption types
                
                if (CodeTypeString.Equals("Caesar"))
                {
                    MessageBox.Show("Attention, please use only English alphabet characters!");
                }
                
                else if (CodeTypeString.Equals("Morse Code"))
                {
                    MessageBox.Show("Attention, please use only International Morse Code characters. The resulting code will contain spaces after each character and all your spaces. Also spaces will replace illegal characters.");
                }
            }
        }

        private void MainRichTextBox_TextChanged(object sender, EventArgs e)
        {
            int Ncount = MainRichTextBox.Text.Length;
            IndCountLabel.Text = Ncount.ToString();

            if (Properties.Settings.Default.chBoxIndicators == true)
            {
                IndAutPictureBox.Visible = false;
                IndNotAutPictureBox.Visible = true;
            }
        }

    private void label2_Click(object sender, EventArgs e)
        {

        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void copyToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MainRichTextBox.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainRichTextBox.Paste();
        }
        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            ContextMenuStrip cmnu = (ContextMenuStrip)sender;
            cmnu.Items[1].Enabled = false;
        }
    } 

}