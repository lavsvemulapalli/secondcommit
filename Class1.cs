using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Class1
    {

        //[SetUp]
        //public void intilizing()
        //{

        //}

        [TestCase(1,2,3)]
        [TestCase(11, 22, 33)]
        [TestCase(12, 2, 14)]
        public void test1(int i, int j, int ex)
        {
           
        }
        public int sum (int i, int j, int ex)
        {
           int sum1 = i + j;
            Assert.AreEqual(ex, sum1);

            return sum1;
        }
            


    }
}
