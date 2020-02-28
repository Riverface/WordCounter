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
        public void RunWordCounter_IgnoresCapitals_True()
        {
            Counter testcounter = new Counter("cat", "Cat");
            testcounter.RunWordCounter();
            Assert.AreEqual(1, testcounter.Amount);
        }

        [TestMethod]
        public void RunWordCounter_IgnoresNumbers_True()
        {
            Counter testcounter = new Counter("cat", "1Cat");
            testcounter.RunWordCounter();
            Assert.AreEqual(1, testcounter.Amount);
        }
        [TestMethod]
        public void RunWordCounter_IgnoresPunctuation_True()
        {
            Counter testcounter = new Counter("cat", "!1Cat");
            testcounter.RunWordCounter();
            Assert.AreEqual(1, testcounter.Amount);
        }

        [TestMethod]
        public void RunWordCounter_NoPartialMatches_True()
        {
            Counter testcounter = new Counter("cat", "!1Cathedral");
            testcounter.RunWordCounter();
            Assert.AreEqual(0, testcounter.Amount);
        }


    }
}