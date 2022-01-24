using net.zemberek.erisim;
using net.zemberek.tr.yapi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WORDLE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void disabledwrite(TextBox txt1,TextBox txt2,TextBox txt3,TextBox txt4,TextBox txt5)
        {
            txt1.ReadOnly = true;
            txt2.ReadOnly = true;
            txt3.ReadOnly = true;
            txt4.ReadOnly = true;
            txt5.ReadOnly = true;
            int gettexid = Convert.ToInt32(((TextBox)txt5).Name.ToString().Split('t')[2]);
            foreach (Control texts in this.Controls)
            {
                if (texts is TextBox)
                {
                    int gettexid2 = Convert.ToInt32(((TextBox)texts).Name.ToString().Split('t')[2]);
                    if (gettexid2 > gettexid && gettexid2 <= gettexid + 5)
                        ((TextBox)texts).Enabled = true;
                }
            }

        }
        private void checktextcolor(TextBox txt1, TextBox txt2, TextBox txt3, TextBox txt4, TextBox txt5)
        {
            if (word.Substring(0, 1) == txt1.Text)
                txt1.BackColor = Color.Green;
            else if (word.Contains(txt1.Text) == true)
                txt1.BackColor = Color.Khaki;

            if (word.Substring(1, 1) == txt2.Text)
                txt2.BackColor = Color.Green;
            else if (word.Contains(txt2.Text) == true)
            {
                if (txt1.Text != txt2.Text)
                txt2.BackColor = Color.Khaki;
            }

            if (word.Substring(2, 1) == txt3.Text)
                txt3.BackColor = Color.Green;
            else if (word.Contains(txt3.Text) == true)
            {
                if (txt1.Text != txt3.Text && txt2.Text != txt3.Text)
                txt3.BackColor = Color.Khaki;
            }

            if (word.Substring(3, 1) == txt4.Text)
                txt4.BackColor = Color.Green;
            else if (word.Contains(txt4.Text) == true)
            {
                if (txt1.Text != txt4.Text && txt2.Text != txt4.Text&& txt3.Text != txt4.Text)
                    txt4.BackColor = Color.Khaki;
            }

            if (word.Substring(4, 1) == txt5.Text)
                txt5.BackColor = Color.Green;
            else if (word.Contains(txt5.Text) == true)
            {
                if (txt1.Text != txt5.Text && txt2.Text != txt5.Text && txt3.Text != txt5.Text&& txt4.Text != txt5.Text)
                    txt5.BackColor = Color.Khaki;
            }

        }

        string word = "";
        private void checktext(TextBox txt1, TextBox txt2, TextBox txt3, TextBox txt4, TextBox txt5)
        {
            word = word.ToUpper();
            string getword = (txt1.Text + txt2.Text + txt3.Text + txt4.Text + txt5.Text).ToUpper();
            if (getword != word)
            {
                bool kontrol = wordscheck(getword);
                if (kontrol == true)
                {
                    checktextcolor(txt1, txt2, txt3, txt4, txt5);
                    disabledwrite(txt1, txt2, txt3, txt4, txt5);
                }
                else
                {
                    txt1.Text = "";
                    txt2.Text = "";
                    txt3.Text = "";
                    txt4.Text = "";
                    txt5.Text = "";
                    MessageBox.Show("Kelime veritabanında bulunamadı. Lütfen kelimenizi değiştirin", "@kodzamani.tk");
                }
            }
            else
            {
                checktextcolor(txt1, txt2, txt3, txt4, txt5);
                losecontrol.Enabled = false;
                MessageBox.Show("Tebrikler Oyunu kazandınız. Kelime : " + word + " Yeni kelime üretildi.", "@kodzamani.tk");
                playnewgame();
                lvlcounter.Text = "LEVEL " + (Convert.ToInt32(lvlcounter.Text.Split(' ')[1].Split('/')[0]) + 1).ToString() + "/5395";
                losecontrol.Enabled = true;
            }
        }
        private bool wordscheck(string word)
        {
            var words = new Zemberek(new TurkiyeTurkcesi());
            return  words.kelimeDenetle(word);
        }
        List<string> wordlist = new List<string>();
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string dosya_yolu = @"Settings.exe";
                FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);
                StreamReader sw = new StreamReader(fs);
                string yazi = sw.ReadLine();
                while (yazi != null)
                {
                    wordlist.Add(yazi.ToUpper());
                    yazi = sw.ReadLine();
                }
                sw.Close();
                fs.Close();
                lvlcounter.Text = "LEVEL " + (5396-wordlist.Count).ToString() + "/5395";
                playnewgame();
            }
            catch
            {
                MessageBox.Show("Settings.exe bulunamadı. Programı tekrar indirmeyi deneyin.","@kodzamani.tk");
                Process.Start("https://kodzamani.weebly.com");
            }
        }
        Random rnd = new Random();
        private void playnewgame()
        {
            foreach (Control texts in this.Controls)
            {
                if (texts is TextBox)
                {
                    ((TextBox)texts).BackColor = Color.DimGray;
                    ((TextBox)texts).Enabled = false;
                    ((TextBox)texts).Text = "";
                    ((TextBox)texts).ReadOnly = false;
                }
            }
            txt1.Enabled = true;
            txt2.Enabled = true;
            txt3.Enabled = true;
            txt4.Enabled = true;
            txt5.Enabled = true;
            wordlist.Remove(word);
            word = wordlist[rnd.Next(wordlist.Count)];
            losecontrol.Enabled = true;
            txt1.Focus();
        }

        private void Texts(object sender, EventArgs e)
        {
            TextBox gettext = sender as TextBox;
            gettext.Text = gettext.Text.ToUpper();
            int gettextid = Convert.ToInt32(gettext.Name.ToString().Split('t')[2]);

            if (gettextid <= 5)
                if (txt1.Text != "" && txt2.Text != "" && txt3.Text != "" && txt4.Text != "" && txt5.Text != "")
                    checktext(txt1, txt2, txt3, txt4, txt5);
            if (gettextid > 5 && gettextid <= 10)
                if (txt6.Text != "" && txt7.Text != "" && txt8.Text != "" && txt9.Text != "" && txt10.Text != "")
                    checktext(txt6, txt7, txt8, txt9, txt10);
            if (gettextid > 10 && gettextid <= 15)
                if (txt11.Text != "" && txt12.Text != "" && txt13.Text != "" && txt14.Text != "" && txt15.Text != "")
                    checktext(txt11, txt12, txt13, txt14, txt15);
            if (gettextid > 15 && gettextid <= 20)
                if (txt16.Text != "" && txt17.Text != "" && txt18.Text != "" && txt19.Text != "" && txt20.Text != "")
                    checktext(txt16, txt17, txt18, txt19, txt20);
            if (gettextid > 20 && gettextid <= 25)
                if (txt21.Text != "" && txt22.Text != "" && txt23.Text != "" && txt24.Text != "" && txt25.Text != "")
                    checktext(txt21, txt22, txt23, txt24, txt25);
            if (gettextid > 25 && gettextid <= 30)
                if (txt26.Text != "" && txt27.Text != "" && txt28.Text != "" && txt29.Text != "" && txt30.Text != "")
                    checktext(txt26, txt27, txt28, txt29, txt30);
        }

        private void TextsControl(object sender, KeyEventArgs e)
        {
            TextBox gettext = sender as TextBox;
            gettext.Text = gettext.Text.ToUpper();
            int gettextid = Convert.ToInt32(gettext.Name.ToString().Split('t')[2]);


            if (e.KeyCode==Keys.Left||e.KeyCode==Keys.Right||e.KeyCode==Keys.Up||e.KeyCode==Keys.Down||e.KeyCode==Keys.Back||e.KeyCode==Keys.Tab)
            {
                foreach (Control texts in this.Controls)
                {
                    if (texts is TextBox)
                    {
                        int gettexid2 = Convert.ToInt32(((TextBox)texts).Name.ToString().Split('t')[2]);
                        if (e.KeyCode == Keys.Left  && gettexid2 == gettextid - 1 || e.KeyCode == Keys.Back&& gettexid2 == gettextid - 1)
                        {
                            ((TextBox)texts).Focus();
                            break;
                        }
                        if (e.KeyCode == Keys.Right && gettexid2 == gettextid + 1||e.KeyCode==Keys.Tab&& gettexid2 == gettextid + 1)
                        {
                            ((TextBox)texts).Focus();
                            break;
                        }
                        if (e.KeyCode == Keys.Up&& gettexid2 == gettextid - 5)
                        {
                            ((TextBox)texts).Focus();
                            break;
                        }
                        if (e.KeyCode == Keys.Down && gettexid2 == gettextid + 5)
                        {
                            ((TextBox)texts).Focus();
                            break;
                        }
                    }
                }
            }
            else
            {
                foreach (Control texts in this.Controls)
                    if (texts is TextBox && Convert.ToInt32(((TextBox)texts).Name.ToString().Split('t')[2]) == gettextid + 1)
                    {
                        ((TextBox)texts).Focus();
                        break;
                    }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Process.Start("https://kodzamani.weebly.com");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void losecontrol_Tick(object sender, EventArgs e)
        {
            bool kontrol = false;
            foreach (Control texts in this.Controls)
            {
                if (texts is TextBox && ((TextBox)texts).Text == "")
                {
                    kontrol = true;
                    break;
                }
            }
            if (kontrol == false)
            {
                losecontrol.Enabled = false;
                MessageBox.Show("Kaybettiniz yeni kelime üretildi önceki kelime : " + word);
                playnewgame();
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Move = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }
        int Move;
        int Mouse_X;
        int Mouse_Y;
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            Move = 0;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            string dosya_yolu = @"Settings.exe";
            FileStream fs = new FileStream(dosya_yolu, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            for (int i=0;i<wordlist.Count;i++)
            sw.WriteLine(wordlist[i]);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
    }
}
