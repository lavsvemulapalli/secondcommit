using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class Class2
    {
        public String Rev(String actual)
        {
            String expected = "";


            if (actual == null)
            {
                return null;
            }

            for (int i = actual.Length - 1; i >= 0; i--)
            {
                expected += actual[i];
            }
           
            return expected;

            
                
            
                

           


        }

       

        [TestCase("abc", "cba")]
        [TestCase("", "")]
        [TestCase("i love auckland", "dnalkcua evol i")]
        [TestCase("Testing", "gnitseT")]
        [TestCase("Happy Test Path", "htaP tseT yppaH")]
        [TestCase(null, null)]
        [TestCase("abc", "CBA", false)]
        [TestCase("testing", "GNITSET", false)]
        public void TestReverseString(string actual, string expected, bool ignoreCase=true)
        {
            actual = Rev(actual);
           
           if (ignoreCase == false)
            {
            StringAssert.AreEqualIgnoringCase(actual, expected);
        }
           else
            {
                Assert.AreEqual(actual, expected);
            }
          

        }

    }
}
