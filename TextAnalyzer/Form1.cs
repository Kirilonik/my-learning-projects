using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace TextAnalyzer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            saveFileDialog1.Filter = ("Text file(*.txt)|*.txt");
            textBox1.ScrollBars = ScrollBars.Vertical;
            longBox.ScrollBars = ScrollBars.Vertical;
            percentageBox.ScrollBars = ScrollBars.Vertical;
            frequentBox.ScrollBars = ScrollBars.Vertical;

            // TODO ПЕРЕДЕЛАЙ ВСЕ НАФИГ под статичные окошки
        }
        // узнать про символ переноса строки
        private void print_Statistics(int countWords_s, int numUniqueWords, string proc_str, string biggest_words)
        {
            total_words_lable.Text = countWords_s.ToString();
            total_unique_words_lable.Text = numUniqueWords.ToString();
            percentageBox.Text = proc_str;
            longBox.Text = biggest_words;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string mainString = textBox1.Text.ToLower();
            char[] separators = " \r\n,.()[]{}\"'&^$!/\\><=-+|`~@#%*;:".ToArray();

            // Counting the number of words in the text
            string[] arr_main_sring = mainString.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            int countWords = arr_main_sring.Length;
            mainString = "";
            for(int i = 0; i < countWords; i++)
                mainString += $"{arr_main_sring[i]} ";

            // Countiong unique words
            string uniqueString = mainString;
            uniqueString = new Regex("[^а-яА-Яa-zA-Z0-9]").Replace(uniqueString, " ");
            var words = uniqueString.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            var wordQuery = words.Distinct();
            int countUniqueWords = wordQuery.Count();

            // top 10 most bigger words
            string[] words_array = mainString.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(words_array, (x, y) => -x.Length.CompareTo(y.Length));
            string long_words = "";
            for (int i = 0; i<words_array.Length && i<10; i++)
                long_words += $"{words_array[i]} \r\n";

            // Most frequent words


            // Char percentage here
            // лагать будет жуть пофикси а
            string alphabet = "abcdefghijklmnopqrstuvwxyzабвгдеёжзийклмнопрстуфхцчшщъыьэюя1234567890";
            Dictionary<char, double> chars = new Dictionary<char, double>(59);
            foreach(char p in alphabet)
                chars.Add(p, 0.0);

            int q = 0; // count of chars all
            for (int i = 0; i< words_array.Length; i++)
                foreach(char j in words_array[i])
                {
                    q++;
                    chars[j] += 1;
                }

            chars = chars.OrderBy(pair => -pair.Value).ToDictionary(pair => pair.Key, pair => pair.Value);
            string proc_str = "";
            foreach(KeyValuePair<char, double> p in chars)
                if (p.Value != 0.0)
                    proc_str += p.Key.ToString() + ": " + (Math.Round(p.Value / q * 100, 1)).ToString() + '%' + '\r' + "\n";



            print_Statistics(countWords, countUniqueWords, proc_str, long_words);
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = saveFileDialog1.FileName;
            File.WriteAllText(filename, textBox1.Text);
            MessageBox.Show("Сохранено", "Статус операции");
        }

        private void открытьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = openFileDialog1.FileName;
            string fileText = File.ReadAllText(filename);
            textBox1.Text = fileText;
        }

        private void сбросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
