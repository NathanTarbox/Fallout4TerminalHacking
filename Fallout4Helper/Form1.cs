using Fallout4TerminalHacking;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fallout4Helper
{
    public partial class Form1 : Form
    {
        List<WordPair> pairs = new List<WordPair>();
        List<string> words = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void AddNewWord(string p)
        {
            if (pairs.Count == 2 && pairs[0].first.Equals(pairs[0].second))
                pairs.Clear();
            foreach (string item in words)
            {
                pairs.AddRange(WordPair.generatePairs(item, p));
            }
            if (pairs.Count == 0)
                pairs.AddRange(WordPair.generatePairs(p, p));
            words.Add(p);
            FindAndDisplayMax();
        }

        private void FindAndDisplayMax()
        {
            Dictionary<string, int> pows = WordHelper.getPowerNumbers(pairs);
            int max = 0;
            string maxWord = "";
            foreach (var item in pows)
            {
                if (item.Value > max)
                {
                    max = item.Value;
                    maxWord = item.Key;
                }
            }
            txtOutput.Text = maxWord;
            txtPower.Text = max.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                Add();
            }
        }

        private void Add()
        {
            string tmp = txtInput.Text.Trim();
            if (words.Count > 0 && words[0].Length != tmp.Length)
            {
                MessageBox.Show("Bad length");
            }
            else
            {
                AddNewWord(tmp.ToUpper());
                txtInput.Clear();
            }
            txtInput.Focus();
        }

        private void Chosen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                Reduce();
            }
        }

        private void Reduce()
        {
            //words = WordHelper.reduceList(words, txtChosen.Text, int.Parse(txtLikeness.Text));
            if (txtChosen.Text.Trim().Equals(string.Empty))
                txtChosen.Text = txtOutput.Text;
            pairs = WordHelper.reduceList(pairs, txtChosen.Text.ToUpper(), int.Parse(txtLikeness.Text));
            FindAndDisplayMax();
            txtLikeness.Clear();
            txtChosen.Clear();
            txtChosen.Focus();
        }

        private void btnReduce_Click(object sender, EventArgs e)
        {
            Reduce();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            words.Clear();
            pairs.Clear();
            txtOutput.Clear();
            txtPower.Clear();
            txtInput.Focus();
        }
    }
}
