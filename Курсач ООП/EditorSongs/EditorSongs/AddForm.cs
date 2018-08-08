using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorSongs
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
            bntAddNew.Enabled = false;
        }

        public string newName;
        public string newAuthor;
        public string newText;



        private void bntAddNew_Click(object sender, EventArgs e)
        {
            string str;
            Form1.myForm.rtbLastString.Clear();
            newName = tbNewName.Text;
            newAuthor = tbNewAuthor.Text;
            newText = rtbNewText.Text;
            int numberVerse = 0;
            for(int i=0;i < rtbNewText.Lines.Length;i++)
            {
                if(rtbNewText.Lines[i]=="")
                {
                    numberVerse++;
                }
            }
            numberVerse++;
            
            Form1 main = this.Owner as Form1;
            if (main != null)//Додавання в таблицю
            {
                main.dgvInformation[0, 0].Value = newAuthor;
                main.dgvInformation[1, 0].Value = newName;
                main.dgvInformation[2, 0].Value = numberVerse.ToString();

                str = newName+"\n";
                str += "\n";
                
                str += newText+"\n"; 
                
                str += "\n";
                str += newAuthor;
                main.song.numberOfVerses = numberVerse;

                main.song.Add(str);
                main.song.IsSonnet();
                //===================================================================================
                //Оновлена версія програми
                main.song.NewValue(newAuthor, newName, numberVerse, str);
                main.song.InitializationVerses();
                main.song.InitializationLinesOnVerses();
                main.song.IsSonnet();

                Form1.myForm.nudChange1.Maximum = main.song.numberOfVerses;
                Form1.myForm.nudChange2.Maximum = main.song.numberOfVerses;
                Form1.myForm.nudSearch.Maximum = main.song.numberOfVerses;
                Form1.myForm.nudSubstitute1.Maximum = main.song.numberOfVerses;

                int countLines = 0;
                for(int i=0;i<main.song.verses.Length;i++)
                {
                    countLines += main.song.verses[i].LinesOfVerse.Length;
                }
                int countWord = 0;
                int countLetter = 0;
                string[] temp = newText.Split('\n');
                for (int i=0;i<temp.Length;i++)
                {
                    if(temp[i]!="")
                    {
                        string[] st = temp[i].Split(' ');
                        countWord += st.Length;
                        for(int k=0;k<st.Length;k++)
                        {
                            countLetter += st[k].Length;
                        }
                    }
                    
                }
                
                MessageBox.Show("Ви додаєте пісню з назвою: " + main.song.name+"\nАвтор цієї пісні: "+main.song.author+"\n"+"Кількість рядків: "+countLines.ToString()+"\nКількість слів: "+countWord.ToString()+"\nКількість букв: "+countLetter.ToString(), "Редактор пісень");
                //=====================================================================================================================================================
                this.Close();
            }
        }
        
        private void tbNewName_TextChanged(object sender, EventArgs e)
        {
            
            if (tbNewName.Text.Length < 1 || tbNewAuthor.Text.Length < 1 || rtbNewText.Text.Length < 1)
                bntAddNew.Enabled = false;
            else bntAddNew.Enabled = true;
        }
        
        private void tbNewAuthor_TextChanged(object sender, EventArgs e)
        {
            if (tbNewName.Text.Length < 1 || tbNewAuthor.Text.Length < 1 || rtbNewText.Text.Length < 1)
                bntAddNew.Enabled = false;
            else bntAddNew.Enabled = true;
        }

        private void rtbNewText_TextChanged(object sender, EventArgs e)
        {
            if (tbNewName.Text.Length < 1 || tbNewAuthor.Text.Length < 1 || rtbNewText.Text.Length < 1)
                bntAddNew.Enabled = false;
            else bntAddNew.Enabled = true;
        }



    }
}
