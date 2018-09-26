using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TexasHoldEm;
using System.Collections.Generic;
using System.Diagnostics;

namespace PokerTesting
{
    [TestClass]
    public class MainTests
    {
        [TestMethod]
        public void TestPair()
        {
            PokerScore score = new PokerScore(new List<int> { 1, 2, 14, 20, 30 });
            Assert.AreEqual(1, score.score);
            Assert.AreEqual("Pair", score.kind);
        }

        [TestMethod]
        public void TestTwoPair()
        {
            PokerScore score = new PokerScore(new List<int> { 1, 2, 5, 6, 30 });
            Assert.AreEqual(2, score.score);
            Assert.AreEqual("Two Pairs", score.kind);
        }

        [TestMethod]
        public void TestThree()
        {
            PokerScore score = new PokerScore(new List<int> { 1, 2, 3, 6, 30 });
            Assert.AreEqual(3, score.score);
            Assert.AreEqual("Three of a Kind", score.kind);
        }

        [TestMethod]
        public void TestFour()
        {
            PokerScore score = new PokerScore(new List<int> { 5, 6, 7, 8, 30 });
            Assert.AreEqual(7, score.score);
            Assert.AreEqual("Four of a Kind", score.kind);
        }

        [TestMethod]
        public void TestFull()
        {
            PokerScore score = new PokerScore(new List<int> { 5, 6, 7, 1, 2 });
            Assert.AreEqual(6, score.score);
            Assert.AreEqual("Full House", score.kind);
        }

        [TestMethod]
        public void TestStright()
        {
            PokerScore score = new PokerScore(new List<int> { 5, 10, 15, 20, 22 });
            Assert.AreEqual(4, score.score);
            Assert.AreEqual("Straight", score.kind);
        }

        [TestMethod]
        public void TestFlush()
        {
            PokerScore score = new PokerScore(new List<int> { 5, 13, 21, 29, 37 });
            Assert.AreEqual(5, score.score);
            Assert.AreEqual("Flush", score.kind);
        }

        [TestMethod]
        public void TestStrightFlush()
        {
            PokerScore score = new PokerScore(new List<int> { 5, 9, 13, 17, 21 });
            Assert.AreEqual(8, score.score);
            Assert.AreEqual("Straight Flush", score.kind);
        }

        [TestMethod]
        public void Combos()
        {
            int count = 0;
            foreach (List<int> combo in Combinations<int>.Combine(new List<int> { 5, 9, 13, 17, 21, 40, 44 }, 5))
            {
                Debug.WriteLine(string.Join(", ", combo));
                count++;
            }
            Debug.WriteLine($"Number of combos: {count}");
            Assert.AreEqual(21, count);
        }
    }
}
