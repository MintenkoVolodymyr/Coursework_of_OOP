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


namespace EditorSongs
{
    public partial class Form1 : Form
    {
        
        public static Form1 myForm = null;
        public Form1()
        {
            InitializeComponent();
            myForm = this;
            
            nudChange1.Maximum = 1;
            nudChange2.Maximum = 1;
            nudSearch.Maximum = 1;
            nudSubstitute1.Maximum = 1;
            nudSubstitute2.Maximum = 1;

            btnSearchAll.Enabled = false;
            btnSearchVerse.Enabled = false;
            btnSubstitute.Enabled = false;
            btnChange.Enabled = false;
            btnViewLastString.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        internal Song song = new Song();
        //internal Verse entry = new Verse();
        
        private void btnOpen_Click(object sender, EventArgs e)
        {
            rtbAllSong.Clear();
            rtbLastString.Clear();

            song.ReadFromFile();
            if(rtbAllSong.Text!="")
            {
                song.InitializationVerses();
                song.InitializationLinesOnVerses();
                song.IsSonnet();
                nudChange1.Maximum = song.numberOfVerses;
                nudChange2.Maximum = song.numberOfVerses;
                nudSearch.Maximum = song.numberOfVerses;
                nudSubstitute1.Maximum = song.numberOfVerses;
            }
            
            //=======================================================================================================
            //==============Вивід інформації про пісню==========================================================
            string allson="";
            for(int i=2;i<rtbAllSong.Lines.Length-2;i++)
            {
                allson += rtbAllSong.Lines[i]+"\n";
            }

            int countLines = 0;
            for (int i = 0; i < song.verses.Length; i++)
            {
                countLines += song.verses[i].LinesOfVerse.Length;
            }
            int countWord = 0;
            int countLetter = 0;
            string[] temp = allson.Split('\n');
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] != "")
                {
                    string[] st = temp[i].Split(' ');
                    countWord += st.Length;
                    for (int k = 0; k < st.Length; k++)
                    {
                        countLetter += st[k].Length;
                    }
                }

            }
            MessageBox.Show("Ви додаєте пісню з назвою: " + song.name + "\nАвтор цієї пісні: " + song.author + "\n" + "Кількість рядків: " + countLines.ToString() + "\nКількість слів: " + countWord.ToString() + "\nКількість букв: " + countLetter.ToString(), "Редактор пісень");
            //=================================================================================================================================
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            song.SaveFileAs();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.Owner = this;
            addForm.Show();
        }

        private void btnViewLastString_Click(object sender, EventArgs e)
        {
            song.ShowLastString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearchAll_Click(object sender, EventArgs e)
        {
            string searchWord = tbSearchAll.Text;
            song.SearchAll(searchWord);
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            int first = Convert.ToInt32(nudChange1.Value);
            int second = Convert.ToInt32(nudChange2.Value);
            song.ChangeVerses(first-1,second-1);
        }

        private void btnSubstitute_Click(object sender, EventArgs e)
        {
            int verse = Convert.ToInt32(nudSubstitute1.Value);
            int line = Convert.ToInt32(nudSubstitute2.Value);

            string value = tbStringForSubstitute.Text;

            song.ChangeLanes(verse-1, line-1, value);
        }

        private void btnSearchVerse_Click(object sender, EventArgs e)
        {
            string searchWord = tbSearchVerse.Text;
            int indexVerse = Convert.ToInt32(nudSearch.Value);

            song.SearchVerse(indexVerse-1, searchWord);
        }

        private void nudSubstitute1_ValueChanged(object sender, EventArgs e)
        {
            if(rtbAllSong.Text!="")
                nudSubstitute2.Maximum = song.verses[Convert.ToInt32(nudSubstitute1.Value-1)].LinesOfVerse.Length;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            HelpForm help = new HelpForm();
            help.Show();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.Show();
        }

        private void rtbAllSong_Click(object sender, EventArgs e)
        {
            rtbAllSong.SelectionStart = 0;
            rtbAllSong.SelectionLength = rtbAllSong.Text.Length;
            rtbAllSong.SelectionColor = Color.Black;

            rtbAllSong.SelectionStart = 0;
            rtbAllSong.SelectionLength = 0;

        }

        private void tbSearchAll_TextChanged(object sender, EventArgs e)
        {
            if (tbSearchAll.Text.Length < 1 || rtbAllSong.Text.Length<1)
                btnSearchAll.Enabled = false;
            else btnSearchAll.Enabled = true;
        }

        private void rtbAllSong_TextChanged(object sender, EventArgs e)
        {
            if (tbSearchAll.Text.Length < 1 || rtbAllSong.Text.Length < 1)
                btnSearchAll.Enabled = false;
            else btnSearchAll.Enabled = true;


            if (tbSearchVerse.Text.Length < 1 || rtbAllSong.Text.Length < 1)
                btnSearchVerse.Enabled = false;
            else btnSearchVerse.Enabled = true;


            if (tbStringForSubstitute.Text.Length < 1 || rtbAllSong.Text.Length < 1)
                btnSubstitute.Enabled = false;
            else btnSubstitute.Enabled = true;


            if (rtbAllSong.Text.Length < 1)
            {
                btnViewLastString.Enabled = false;
                btnChange.Enabled = false;
            }
            else
            {
                btnViewLastString.Enabled = true;
                btnChange.Enabled = true;
            }
        }

        private void tbSearchVerse_TextChanged(object sender, EventArgs e)
        {
            
            if (tbSearchVerse.Text.Length < 1 || rtbAllSong.Text.Length < 1)
                btnSearchVerse.Enabled = false;
            else btnSearchVerse.Enabled = true;
        }

        private void tbStringForSubstitute_TextChanged(object sender, EventArgs e)
        {
            if (tbStringForSubstitute.Text.Length < 1 || rtbAllSong.Text.Length < 1)
                btnSubstitute.Enabled = false;
            else btnSubstitute.Enabled = true;
        }
    }
}
