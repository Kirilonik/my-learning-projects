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
        }
        private void print_Statistics(int countWords_s, int numUniqueWords, string proc_str,
            string biggest_words, string frequent_string)
        {
            total_words_lable.Text = countWords_s.ToString();
            total_unique_words_lable.Text = numUniqueWords.ToString();
            percentageBox.Text = proc_str;
            longBox.Text = biggest_words;
            frequentBox.Text = frequent_string;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string mainString = textBox1.Text.ToLower();
            char[] separators = " \r\n,.()[]{}\"'&^$!/\\><=-+|`~@#%*;:".ToArray();
            string[] arr_main_sring = mainString.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            // Counting the number of words in the text
            int countWords = arr_main_sring.Length;

            // Countiong unique words
            string[] words_unique = (from string word in arr_main_sring orderby word select word).Distinct().ToArray();
            int countUniqueWords = words_unique.Count();

            // top 10 most bigger words
            string long_words = mostBiggerWords(arr_main_sring);

            // Most frequent words
            string frequent_string = frequentWords(countUniqueWords, words_unique, arr_main_sring);

            // Char percentage here
            string proc_str = charPercentage(arr_main_sring);

            print_Statistics(countWords, countUniqueWords, proc_str, long_words, frequent_string);
        }
        private string mostBiggerWords(string[] arr_main_sring)
        {
            Array.Sort(arr_main_sring, (x, y) => -x.Length.CompareTo(y.Length));
            string long_words = "";
            for (int i = 0; i < arr_main_sring.Length && i < 10; i++)
                long_words += $"{arr_main_sring[i]} \r\n";
            return long_words;
        }
        private string frequentWords(int countUniqueWords, string[] words_unique, string [] arr_main_sring)
        {
            Dictionary<string, int> frequent = new Dictionary<string, int>(countUniqueWords);
            foreach (string word in words_unique)
                frequent.Add(word, 0);
            foreach (string word in arr_main_sring)
                frequent[word] += 1;
            frequent = frequent.OrderBy(pair => -pair.Value).ToDictionary(pair => pair.Key, pair => pair.Value);
            string frequent_string = "";
            int t = 0;
            foreach (KeyValuePair<string, int> word in frequent)
            {
                if (t < 10)
                    frequent_string += $"{word.Key.ToString()}: {word.Value.ToString()} \r\n";
                t++;
            }
            return frequent_string;
        }
        private string charPercentage( string[] arr_main_sring)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyzабвгдеёжзийклмнопрстуфхцчшщъыьэюя1234567890";
            Dictionary<char, double> chars = new Dictionary<char, double>(59);
            foreach (char p in alphabet)
                chars.Add(p, 0.0);

            int q = 0; // count of chars all
            for (int i = 0; i < arr_main_sring.Length; i++)
                foreach (char j in arr_main_sring[i])
                {
                    q++;
                    chars[j] += 1;
                }

            chars = chars.OrderBy(pair => -pair.Value).ToDictionary(pair => pair.Key, pair => pair.Value);
            string proc_str = "";
            foreach (KeyValuePair<char, double> p in chars)
                if (p.Value != 0.0)
                    proc_str += $"{p.Key.ToString()}: {(Math.Round(p.Value / q * 100, 1)).ToString()}%\r\n";
            return proc_str;
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
