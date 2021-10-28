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
        }
        // узнать про символ переноса строки
        private void print_Statistics(string countWords_s, string numUniqueWords, string proc_str)
        {
            string result = "";
            result += "Number of words: " + countWords_s + '\r' + '\n';
            result += "Number of unique words: " + numUniqueWords + '\r' + '\n';
            result += "Percentage of chars: " + '\r' + '\n' + proc_str;
            textBox2.Text = result;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string mainString = textBox1.Text.ToLower(); //.Replace(".", " ").Replace(",", " ").Replace(":", " ").Replace(";", " ");
            char[] separators = " \r\n,.()[]{}\"'&^$!/\\".ToArray();
            // Counting the number of words in the text
            int countWords = mainString.Split(separators, StringSplitOptions.RemoveEmptyEntries).Length;
            string countWords_s = countWords.ToString();

            // Countiong unique words
            string uniqueString = mainString;
            uniqueString = new Regex("[^а-яА-Яa-zA-Z0-9]").Replace(uniqueString, " ");
            var words = uniqueString.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            var wordQuery = words.Distinct();
            string numUniqueWords = wordQuery.Count().ToString();

            // top 10 most bigger words
            string[] words_array = mainString.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            // TODO here

            // Char percentage here
            // лагать будет жуть пофикси а
            string alphabet = "abcdefghijklmnopqrstuvwxyzабвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            Dictionary<char, double> chars = new Dictionary<char, double>(59);
            foreach(char p in alphabet)
            {
                chars.Add(p, 0.0);
            }
            int q = 0; // count of chars all
            for (int i = 0; i< words_array.Length; i++)
            {
                foreach(char j in words_array[i])
                {
                    q++;
                    chars[j] += 1;
                }
            }
            chars = chars.OrderBy(pair => -pair.Value).ToDictionary(pair => pair.Key, pair => pair.Value);

            string proc_str = "";
            foreach(KeyValuePair<char, double> p in chars)
                    proc_str += p.Key.ToString() + ": " + (Math.Round(p.Value / q * 100, 1)).ToString() + '%' + '\r' + "\n";




            print_Statistics(countWords_s, numUniqueWords, proc_str);
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
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


    }
}
