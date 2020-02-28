using System;
using WordCounter.Models;

namespace WordCounter
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter a Word.");
            string word = Console.ReadLine();
            Console.WriteLine("Now enter a sentence.");
            string sentence = Console.ReadLine();
            Counter testcounter = new Counter(word, sentence);
            testcounter.RunWordCounter();
            Console.WriteLine("The word " + word + " shows up in the sentence " + testcounter.Sentence + " " + testcounter.Amount + " times.");
        }
    }
}