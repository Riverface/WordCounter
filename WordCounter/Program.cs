using System;
using WordCounter.Models;
namespace WordCounter
{
    public class Program
    {
        public static void Main()
        {
        Counter testcounter = new Counter("yeah", "yeah, yeah");
            testcounter.Dissect();
            testcounter.Count("word-in-sentence");
        }
    }
}