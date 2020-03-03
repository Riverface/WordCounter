using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Numerics;
using WordCounter.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class WordCounterTests
    {
        [TestMethod]
        public void Count_AreWordsIdenticalMatches_True()
        {
            Counter testcounter = new Counter("yeah", "yeah");
            testcounter.Count();
            Assert.AreEqual(1, testcounter.Amount);
        }
        
        [TestMethod]
        public void Count_IgnoresCapitals_True()
        {
            Counter testcounter = new Counter("cat", "Cat");
            testcounter.Count();
            Assert.AreEqual(1, testcounter.Amount);
        }

        [TestMethod]
        public void Dissect_IgnoresNumbers_True()
        {
            Counter testcounter = new Counter("cat", "1Cat");
            testcounter.RunWordCounter();
            Assert.AreEqual(1, testcounter.Amount);
        }

        [TestMethod]
        public void Dissect_IgnoresPunctuation_True()
        {
            Counter testcounter = new Counter("cat", "!1Cat");
            testcounter.RunWordCounter();
            Assert.AreEqual(1, testcounter.Amount);
        }

        [TestMethod]
        public void Count_NoPartialMatches_True()
        {
            Counter testcounter = new Counter("cat", "!1Cathedral");
            testcounter.RunWordCounter();
            Assert.AreEqual(0, testcounter.Amount);
        }

        [TestMethod]
        public void RunWordCounter_MultipleMatchesInSentence_Two()
        {
            Counter testcounter = new Counter("cat", "!1Cathedral cat cat");
            testcounter.RunWordCounter();
            Assert.AreEqual(2, testcounter.Amount);
        }
    }
}