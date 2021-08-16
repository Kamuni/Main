using Microsoft.VisualStudio.TestTools.UnitTesting;
using Space_Counter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Counter.Tests1
{
    [TestClass()]
    public class Space_countTests
    {
        [TestMethod()]
        public void spacesInStringTest()
        {
            var input = "aa aa aa aa aa";
            var testingObj = new Space_count();
            var result = testingObj.spacesInString(input);
            Assert.IsTrue(result == 4);
        }
        [TestMethod()]
        public void ifInString0words()
        {
            var input = " ";
            var testingObj = new Space_count();
            var result = testingObj.spacesInString(input);
            Assert.IsTrue(result == 1);
        }
        [TestMethod()]
        public void ifInString0Spaces()
        {
            var input = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            var testingObj = new Space_count();
            var result = testingObj.spacesInString(input);
            Assert.IsTrue(result == 0);
        }
    }
}