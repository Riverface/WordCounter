using System;
using System.Collections.Generic;

namespace WordCounter.Models
{

    public class Counter
    {
        public string Word { get; set; }
        public string Sentence { get; set; }
        public string[] Dissected { get; set; }
        public int Amount { get; set; }

        public Counter(string word, string sentence)
        {
            Word = word.ToLower();
            Sentence = sentence.ToLower();
            Amount = 0;
        }

        public string Dissect(string input)
        {
            char[] TempCharray;
            List<char> stripped = new List<char>();
            Dissected = input.Split(" ");
            input = "";
            for (int o = 0; Dissected.Length > o; o++)
            {
                TempCharray = Dissected[o].ToCharArray();
                for (int i = 0; TempCharray.Length > i; i++)
                {
                    if (Char.IsLetter(TempCharray[i]))
                    {
                        input += TempCharray[i];
                    }

                }
                if (Dissected.Length != 1)
                {
                    input += " ";
                }

                stripped = new List<char>();
            }
            string output = input;
            return output;
        }

        public void RunWordCounter()
        {
            Word = Dissect(Word.ToLower());
            Sentence = Dissect(Sentence.ToLower());
            Count();
        }

        public void Count()
        {
            Amount = 0;
            Dissected = Sentence.Split(" ");
            foreach (string part in Dissected)
            {
                if (part == Word)
                {
                    Amount++;
                }
            }
        }
    }

}



