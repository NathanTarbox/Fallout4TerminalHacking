using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fallout4TerminalHacking
{
    public class WordHelper
    {

        public static List<string> reduceList(List<string> sourceList, string chosenWord, int likeness)
        {
            List<string> rtn = new List<string>();
            int matches = 0;
            foreach (string src in sourceList)
            {
                matches = WordPair.getLikeness(src, chosenWord);
                if (matches == likeness)
                    rtn.Add(src);
            }

            return rtn;
        }

        public static List<WordPair> genList(List<string> words)
        {
            List<WordPair> rtn = new List<WordPair>();

            for (int i = 0; i < words.Count; i++)
            {
                for (int j = i; j < words.Count; j++)
                {
                    rtn.AddRange(WordPair.generatePairs(words[i], words[j]));
                }
            }

            return rtn;
        }

        public static Dictionary<string, int> getPowerNumbers(List<WordPair> lst)
        {
            
            Dictionary<string, List<int>> accum = new Dictionary<string, List<int>>();
            if (lst.Count > 0)
            {
                List<int> template = new List<int>();
                foreach (char c in lst[0].first.ToArray())
                {
                    template.Add(0);
                }
                template.Add(0); // for perfect matches
                foreach (WordPair wp in lst)
                {
                    if (!accum.ContainsKey(wp.first))
                    {
                        accum.Add(wp.first, new List<int>(template));
                    }
                    accum[wp.first][wp.likeness]++;
                }
            }
            Dictionary<string, int> rtn = new Dictionary<string, int>();
            foreach (KeyValuePair<string, List<int>> kvp in accum)
            {
                int prod = 1;
                foreach (int i in kvp.Value)
                {
                    prod *= (i + 1);
                }
                rtn.Add(kvp.Key, prod);
            }

            return rtn;
        }

        public static List<WordPair> reduceList(List<WordPair> pairs, string chosen, int likeness)
        {
            List<string> words = new List<string>();
            List<WordPair> rtn = new List<WordPair>();
            foreach (var item in pairs)
            {
                if (item.likeness == likeness && item.first.Equals(chosen))
                    words.Add(item.second);
            }            
            rtn = genList(words);//pairs.FindAll(x => words.Contains(x.first) || words.Contains(x.second));
            return rtn;
        }
    }



    public class WordPair
    {
        public string first;
        public string second;
        public int likeness;

        private WordPair()
        { }

        private WordPair(WordPair reverse)
        {
            this.first = reverse.second;
            this.second = reverse.first;
            this.likeness = reverse.likeness;
        }
        public WordPair(string frist, string secund)
        {
            first = frist;
            second = secund;
            likeness = getLikeness(first, second);
        }

        public static int getLikeness(string first, string second)
        {
            int rtn = 0;
            for (int i = 0; i < first.Length; i++)
            {
                if (first[i].Equals(second[i]))
                {
                    rtn++;
                }
            }
            return rtn;
        }

        public static List<WordPair> generatePairs(string first, string second)
        {
            List<WordPair> rtn = new List<WordPair>();
            rtn.Add(new WordPair(first, second));
            rtn.Add(new WordPair(rtn[0]));
            return rtn;
        }

    }
}
