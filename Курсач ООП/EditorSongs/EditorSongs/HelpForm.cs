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
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void treeView1_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            switch (e.Node.Name)
            {
                case "Node0":
                    richTextBox1.Text = "Визначення кількості букв в тексті; Визначення кількості слів в тексті; Визначення кількості речень в тексті; Переставляння куплетів місцями; Замінна стрічки;  Показати останні стрічки куплетів;  Пошук по всій пісні;Пошук у куплеті. Додавання нової пісні.";

                    break;
                case "Node1":
                    richTextBox1.Text = "Дана програма не потребує додаткового встановлення, достатньо просто запустити виконавчий файл.";
                    break;
                case "Node2":
                    richTextBox1.Text = "Програма потребує додаткових налаштувань. ";
                    break;
                case "Node3":
                    richTextBox1.Text = "N1 – Завантаження даних з файлу; N2 – Опрацювання вхідних даних; N3 – Збереження даних у файл; N4 – Переставляння куплетів місцями; N5 – Показати останні стрічки куплетів;  N6 – Замінна стрічки; N7 – Пошук по всій пісні; N8 – Пошук у куплеті. N9 – Додавання нової пісні.";

                    break;

            }
        }
    }
}
