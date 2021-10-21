﻿using System;
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
        private void print_Statistics(string countWords_s, string numUniqueWords)
        {
            string result = "";
            result += "Number of words: " + countWords_s + '\n';
            result += "Number of unique words: " + numUniqueWords + '\n';
            textBox2.Text = result;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string mainString = textBox1.Text; //.Replace(".", " ").Replace(",", " ").Replace(":", " ").Replace(";", " ");
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

            print_Statistics(countWords_s, numUniqueWords);
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