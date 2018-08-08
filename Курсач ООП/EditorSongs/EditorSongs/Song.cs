using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Drawing;


namespace EditorSongs
{


    class Error:Exception
    {
        private string errorMessage;//повідемлення про те яка помилка сталася

        public Error(string error)//конструктор який приймає 1 аргумент: повідомлення про помилку
        {
            errorMessage = error;
        }
        public string what()//метод який виводить повертає повідомлення про помилку
        {
            return errorMessage;
        }
    }



    class Song:Verse
    {

        public string author;//автор
        public string name;//ім'я
        public int numberOfVerses;//кількість куплетів

        public string allSong;


        public Verse[] verses;

        public Song()//конструктор
        {
            author = "";
            name = "";
            numberOfVerses = 0;
            allSong = "";
        }


        //=========================================================
        //========Метод оновлення всіх даних при додаванні нових===
        //========================================================= 
        public void NewValue(string a,string n,int nov,string all)
        {
            author = a;
            name = n;
            numberOfVerses = nov;
            allSong = all;
        }




        public void ReadFromFile()//зчитування з файлу
        {
            OpenFileDialog openDialog = new OpenFileDialog();

            openDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";//для відкриття файлів з форматом .txt

            Stream mystr = null;
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                if ((mystr = openDialog.OpenFile()) != null)
                {
                    StreamReader myread = new StreamReader(mystr, Encoding.GetEncoding("windows-1251"));
                    int num = 0;
                    try
                    {

                        string[] str1 = myread.ReadToEnd().Split('\n');

                        if (str1.Count()<5)
                        {
                            throw new Error("Перевірте вмістимість файлу! Файл повинен містити Назву автора і хоча б один куплет!!!");
                            return;
                        }

                        if (String.IsNullOrWhiteSpace(str1[0]))
                        {
                            throw new Error("Перевірте вмістимість файлу! Не вказано назву пісні!");
                            return;
                        }
                        if (str1[1].Length!=1)
                        {
                            throw new Error("Перевірте вмістимість файлу! Після назви пісні потрібно поставити пропуск!");
                            return;
                        }
                        if (str1[str1.Length - 2].Length!=1)
                        {
                            throw new Error("Перевірте вмістимість файлу! Після останнього куплета потрібно зробити пропуск!");
                            return;
                        }
                        if (String.IsNullOrWhiteSpace(str1[str1.Length-1]))
                        {
                            throw new Error("Перевірте вмістимість файлу! Ви не вказали автора або поставили зайвий перехід на новий рядок!");
                            return;
                        }
                        for(int i=0;i<str1.Count();i++)
                        {
                            if(i<str1.Count()-1)
                            {
                                if (str1[i].Length == 1 && String.IsNullOrWhiteSpace(str1[i + 1]))
                                {
                                    throw new Error("Перевірте вмістимість файлу! Потрібно робити один пропуск після куплетів!");
                                    return;
                                }
                            }
                            
                        }
                        
                        

                        num = str1.Count();//кількість рядків

                        author = str1[num - 1];//ініціалізації поля автор
                        Form1.myForm.dgvInformation[0, 0].Value = author;//додавання в таблицю автора

                        name = str1[0];//ініціалізація поля назва
                        Form1.myForm.dgvInformation[1, 0].Value = name;//додавання в таблицю назви

                        for (int i = 0; i < num; i++)
                        {
                            Form1.myForm.rtbAllSong.Text += str1[i];
                        }

                        int numVerse = 0;
                        for (int i = 0; i < Form1.myForm.rtbAllSong.Lines.Length; i++)
                        {
                            if (Form1.myForm.rtbAllSong.Lines[i] == "")
                            {
                                numVerse++;
                            }
                        }
                        numVerse--;
                        numberOfVerses = numVerse;
                        Form1.myForm.dgvInformation[2, 0].Value = numberOfVerses.ToString();

                        

                    }
                    catch (Error ex)//помилки які передбаченні
                    {
                        MessageBox.Show(ex.what(), "Довідник доріг");
                    }
                    catch (Exception ex)//непередбачувані помилки
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        myread.Close();
                    }

                }
            }

            

            
        }

        public void InitializationVerses()
        {
            int currentVerse = 0;
            verses = new Verse[numberOfVerses];

            for (int i = 0; i < numberOfVerses; i++)
            {
                verses[i] = new Verse();
                verses[i].serialNumberOfVerse = i+1;
            }
           
            for (int i = 2; i < Form1.myForm.rtbAllSong.Lines.Length-2; i++)
            {
                if(Form1.myForm.rtbAllSong.Lines[i]!="")
                {
                    verses[currentVerse].allVerse += Form1.myForm.rtbAllSong.Lines[i];

                    if (Form1.myForm.rtbAllSong.Lines[i + 1] == "")
                    {
                        currentVerse++;
                    }



                    if (Form1.myForm.rtbAllSong.Lines[i + 1] != "")
                    {
                        verses[currentVerse].allVerse += "\n";
                    }
                }
                
            }
        }
        public void Add(string str)
        {
            Form1.myForm.rtbAllSong.Text = str;
            InitializationVerses();
            InitializationLinesOnVerses();
        }

        public void InitializationLinesOnVerses()
        {
            for (int i = 0; i < numberOfVerses; i++)
            {
                verses[i].LinesOfVerse = verses[i].allVerse.Split('\n');
            }
        }

        public void SaveFileAs()//Збереження файлу як...(в інше місце)
        {
            Stream myStream;
            SaveFileDialog saveDialog = new SaveFileDialog();

            saveDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";//для збереження файлу з форматом .txt

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveDialog.OpenFile()) != null)
                {
                    StreamWriter myWritet = new StreamWriter(myStream, Encoding.GetEncoding("windows-1251"));
                    try
                    {
                        for(int i=0;i<Form1.myForm.rtbAllSong.Lines.Length;i++)
                        {
                            myWritet.Write(Form1.myForm.rtbAllSong.Lines[i]);

                            if(i!= Form1.myForm.rtbAllSong.Lines.Length-1)
                                myWritet.WriteLine();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        myWritet.Close();
                    }
                    myStream.Close();

                }
            }
        }
        
        
        public void ShowLastString()
        {
            for(int i=0;i<verses.Length;i++)
            {
                int index = verses[i].LinesOfVerse.Length - 1;
                Form1.myForm.rtbLastString.Text += verses[i].LinesOfVerse[index]+"\n";
            }
        }

        private void Set_AllSong()
        {
            for(int i=0;i<verses.Length;i++)
            {
                allSong += verses[i].allVerse;
            }
        }
        

        public void SearchAll(string str)
        {
            int i;
            
            int linesLenght = Form1.myForm.rtbAllSong.Lines.Length;

            string[] WordName = Form1.myForm.rtbAllSong.Lines[0].Split(' ');
            string[] WordAuthor = Form1.myForm.rtbAllSong.Lines[linesLenght-1].Split(' ');

            
            int start = Form1.myForm.rtbAllSong.Lines[0].Length;
            start += WordName.Length-1;
            i = start;
            int stop= Form1.myForm.rtbAllSong.Text.Length-Form1.myForm.rtbAllSong.Lines[linesLenght-1].Length;
            stop -= WordAuthor.Length;

          

            while (i <= stop - str.Length)
            {
                i = Form1.myForm.rtbAllSong.Text.IndexOf(str, i);

                if (i < 0)
                    break;
                if(i<stop && i>start)
                {
                    Form1.myForm.rtbAllSong.SelectionStart = i;
                    Form1.myForm.rtbAllSong.SelectionLength = str.Length;
                    Form1.myForm.rtbAllSong.SelectionColor = Color.Red;
                }
                
                i += str.Length;
            }

           
        }

        public void SearchVerse(int index,string str)
        {
            for(int i=0;i<verses.Length;i++)
            {
                if(i==index)
                {
                    for(int j=0;j<verses[i].LinesOfVerse.Length;j++)
                    {
                        string[] world = verses[i].LinesOfVerse[j].Split(' ');
                        for(int k=0;k<world.Length;k++)
                        {
                            if(world[k]==str)
                            {
                                Form1.myForm.dgvFind.Rows.Add((i+1).ToString(), (j+1).ToString(), (k+1).ToString());
                                i = Form1.myForm.rtbAllSong.Text.IndexOf(str, i);
                                Form1.myForm.rtbAllSong.SelectionStart = i ;
                                Form1.myForm.rtbAllSong.SelectionLength = str.Length;
                                Form1.myForm.rtbAllSong.SelectionColor = Color.Red;
                            }
                        }
                    }
                }
            }

        }
        public void UpdateText()
        {
            Form1.myForm.rtbAllSong.Clear();
            Form1.myForm.rtbAllSong.Text += name+"\n" ;
            Form1.myForm.rtbAllSong.Text += "\n";
            for(int i=0;i<verses.Length;i++)
            {
                Form1.myForm.rtbAllSong.Text += verses[i].allVerse + "\n\n";
            }
            Form1.myForm.rtbAllSong.Text += "\n";
            Form1.myForm.rtbAllSong.Text += author;

        }
        public void ChangeVerses(int first,int second)
        {
            string temp = verses[first].allVerse;
            verses[first].allVerse = verses[second].allVerse;
            verses[second].allVerse = temp;

            UpdateText();
        }

        public void ChangeLanes(int verse,int line,string value)
        {
            verses[verse].LinesOfVerse[line] = value;
            verses[verse].allVerse = "";
            for (int i=0;i < verses[verse].LinesOfVerse.Length;i++)
            {
                verses[verse].allVerse += verses[verse].LinesOfVerse[i];
                if(i!= verses[verse].LinesOfVerse.Length-1)
                    verses[verse].allVerse +="\n";
            }
            
            UpdateText();
        }

        public void IsSonnet()
        {
            int numberLanes = 0;
            for(int i=0;i<verses.Length;i++)
            {
                numberLanes += verses[i].LinesOfVerse.Length;
            }

            if(numberLanes==14)
            {
                Form1.myForm.dgvInformation[3, 0].Value="Tak";
                Form1.myForm.dgvInformation[4, 0].Value = "Normal";
            }
            else
            {
                Form1.myForm.dgvInformation[3, 0].Value = "Ні";
                Form1.myForm.dgvInformation[4, 0].Value = "---";
            }
        }
    }
}
