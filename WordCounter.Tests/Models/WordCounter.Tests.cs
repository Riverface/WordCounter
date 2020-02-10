using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Numerics;
using WordCounter.Models;
namespace WordCounter.Tests
{
    [TestClass]
    public class WordCounterTests
    {
        [TestMethod]
        public void Word_Counts_Word()
        {
            Counter testcounter = new Counter("yeah", "yeah");
            testcounter.Dissect();
            testcounter.Count("word-in-word");
            Assert.AreEqual(1, testcounter.Amount);
        }
        [TestMethod]
        public void Word_Counts_Sentence()
        {
            Counter testcounter = new Counter("yeah", "yeah, I like to dance, yeah");
            testcounter.Dissect();
            testcounter.Count("word-in-sentence");
            Assert.AreEqual(2, testcounter.Amount);
        }

    }
}