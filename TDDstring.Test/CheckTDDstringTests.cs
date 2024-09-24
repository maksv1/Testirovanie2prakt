using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TDDstring.Test
{
    [TestClass]
    public class CheckTDDstringTests
    {
        [TestMethod]
        public void FindShortest_Naitikorotkoeslovo_returnsи()
        {
            string text = "Солнце светит ярко и тепло";
            string expected = "и";

            CheckTDDstring checkTDDstring = new CheckTDDstring();
            string actual = checkTDDstring.FindShortestWord(text);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CountWords_SkolkoSlov_returns3()
        {
            string input = "Текст для проверки";
            int expected = 3;

            CheckTDDstring checkTDDstring = new CheckTDDstring();
            int result = checkTDDstring.CountWords(input);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestCharacterCount_Skolkosimvol_returns31()
        {
            string input = "Сколько символов в этом предложении";
            int expected = 31;

            CheckTDDstring checkTDDstring = new CheckTDDstring();
            int result = checkTDDstring.CountCharacters(input);
            Assert.IsTrue(result == expected, $"Expected {expected} but got {result}");
        }

        [TestMethod]
        public void TestNinthCharacter_9ogosimvola_returnsя()
        {
            string input = "Текст для нахождения 9-ого символа в строке";
            char expected = 'я';

            CheckTDDstring checkTDDstring = new CheckTDDstring();
            char result = checkTDDstring.FindNinthCharacter(input);
            Assert.IsFalse(result != expected, $"Expected {expected} but got {result}");
        }

        [TestMethod]
        public void TestDigitCount_Kolcifr_returns3()
        {
            string input = "Текст для нахождения количества 123 цифр";
            int expected = 3;

            CheckTDDstring checkTDDstring = new CheckTDDstring();
            int result = checkTDDstring.CountDigits(input);
            Assert.IsNotNull(result);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestLongestDigitSequence_kolcifrpodryd_returns4()
        {
            string input = "Текст для нахождение наибольшего 123 количества идущих 1234 подряд цифр";
            int expected = 4;

            CheckTDDstring checkTDDstring = new CheckTDDstring();
            int result = checkTDDstring.FindLongestDigitSequence(input);
            Assert.IsNotNull(result);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestAmCount_nahodam_returns3()
        {
            string input = "Текст для нахождение количество комбинация 'ам' в строке ам ам";
            int expected = 3;

            CheckTDDstring checkTDDstring = new CheckTDDstring();
            int result = checkTDDstring.CountAm(input);
            Assert.IsTrue(result == expected, $"Expected {expected} but got {result}");
        }
    }
}
