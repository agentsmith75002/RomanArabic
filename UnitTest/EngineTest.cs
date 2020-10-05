using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Logic.Tests
{
    [TestClass()]
    public class EngineTest
    {
        [TestMethod()]
        public void ComputeRomanToDecimalTest()
        {
            Engine engine = new Engine();
            string roman = "MCMIV";
            Assert.AreEqual(1904, engine.ComputeRomanToDecimal(roman));
        }

        [DataTestMethod()]
        [DataRow("I", 1)]
        [DataRow("II", 2)]
        [DataRow("III", 3)]
        [DataRow("IV", 4)]
        [DataRow("V", 5)]
        [DataRow("VI", 6)]
        [DataRow("VII", 7)]
        [DataRow("VIII", 8)]
        [DataRow("IX", 9)]
        [DataRow("X", 10)]
        [DataRow("XXI", 21)]
        [DataRow("LII", 52)]
        [DataRow("D", 500)]
        [DataRow("CMLIV", 954)]
        [DataRow("M", 1000)]
        [DataRow("MCMLIV", 1954)]
        [DataRow("MCMXC", 1990)]
        [DataRow("MMVIII", 2008)]
        [DataRow("MMXIV", 2014)]
        public void ComputeRomanToDecimalDataTest(string roman, int arabic)
        {
            Engine engine = new Engine();
            Assert.AreEqual(arabic, engine.ComputeRomanToDecimal(roman));
        }
    }
}
