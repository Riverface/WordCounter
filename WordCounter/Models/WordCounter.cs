using System;
using System.Collections;

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
            char[] Stripped;
            Dissected = Sentence.Split(" ");
            for (int o = 0; Dissected.Length > o; o++)
            {
                Stripped = Dissected[o].ToCharArray();
                for (int i = 0; Stripped.Length > i; i++)
                {
                    if (Stripped[i] == '!' || Stripped[i] == '.' || Stripped[i] == ',')
                    {
                        Stripped[i] = ' ';
                        Console.WriteLine(Stripped);
                    }
                Console.WriteLine(Stripped);
                }
                Dissected[o] = String.Join(' ', Stripped.ToString());;
            }
            
            Sentence = String.Join(' ', Dissected.ToString());
            String.Join(' ', Sentence);
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