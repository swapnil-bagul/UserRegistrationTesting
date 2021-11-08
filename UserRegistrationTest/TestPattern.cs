using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationTesting;
using System;

namespace UserRegistrationTest
{
    [TestClass]
    public class TestPattern
    {
        /// <summary>
        /// UC3 Phone Number of User
        /// prefix of No 91 and No must be 10 digit.
        /// </summary>
        [TestMethod]
        public void PhoneNumberTest()
        {
            //arrange
            string message = "91 7410177019";
            //invalid Condition
            //string message = " 7410177019";
            string expected = "valid";

            //act
            UserRegistration userRegistration = new UserRegistration(message);
            string actual=userRegistration.PatternChecking();

            //Assert
            Assert.AreEqual(expected, actual );


        }
    }
}
