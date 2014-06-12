using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace google.test.Utilities
{
    class CustomAsserts
    {
        public static void AssertTrue(bool condition, string errorMessage)
        {
            Assert.True(condition, errorMessage);
        }

        public static void VerifyTrue(bool condition, string errorMessage)
        {
            try
            {
                AssertTrue(condition,errorMessage);
            }
            catch (AssertionException assertionException)
            {

                
            }
        }
    }
}
