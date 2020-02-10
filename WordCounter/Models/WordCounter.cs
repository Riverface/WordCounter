using System;
using System.Collections.Generic;

namespace WordCounter.Models
{

    public class Counter
    {
        public string Word;
        public string Sentence;
        public string[] Dissected;
        public int Amount = 0;
        public Counter(string word, string sentence)
        {
            Word = word.ToLower();
            Sentence = sentence.ToLower();
            Amount = 0;
        }

        public void Dissect()
        {
            char[] TempCharray;
            List<char> stripped = new List<char>();
            Dissected = Sentence.Split(" ");
            Sentence = "";
            for (int o = 0; Dissected.Length > o; o++)
            {
                TempCharray = Dissected[o].ToCharArray();
                for (int i = 0; TempCharray.Length > i; i++)
                {
                    if ( Char.IsLetter(TempCharray[i]))
                    {
                        Sentence += TempCharray[i];
                        
                    }
                }   
                Sentence += " ";
                stripped = new List<char>();

            }
            Console.WriteLine(Sentence);
        }
        public void Count(string mode)
        {
            Amount = 0;
            if (mode == "word-in-word")
            {
                if (Word == Word)
                {
                    Console.WriteLine("Surprisingly, the word is the same word.");
                    Amount++;
                }
            }
            else if (mode == "word-in-sentence")
            {
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



}