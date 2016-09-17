using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab8_Batting;

namespace SluggingPercentTest
{
    [TestClass]
    public class PercentTest
    {
        [TestMethod]
        public void TestSluggingPercentage()
        {
            int[] battingSheet = new int[5]; //creates the array
            battingSheet[0] = 0; //sets position in the array and gives the batting outcome or give it a value.
            battingSheet[1] = 0;
            battingSheet[2] = 0;
            battingSheet[3] = 0;
            battingSheet[4] = 0;
            double average = Program.calculateSluggingPercentage(battingSheet);
            Assert.AreEqual(0, average);
        }
        [TestMethod]
        public void TestBattingPercentageIs60()
        {
            int[] battingSheet = new int[5];
            battingSheet[0] = 0; //sets position in the array and gives the batting outcome or give it a value.
            battingSheet[1] = 0;
            battingSheet[2] = 2;
            battingSheet[3] = 4;
            battingSheet[4] = 1;
            double average = Program.calculateSluggingPercentage(battingSheet);
            Assert.AreEqual(1.4, average);
        }
    }
}
