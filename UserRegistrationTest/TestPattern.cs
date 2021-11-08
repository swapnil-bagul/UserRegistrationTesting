using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationTesting;
using System;

namespace UserRegistrationTest
{
    [TestClass]
    public class TestPattern
    {
        /// <summary>
        /// UC3 Test Email Id of User
        /// it must contain @gmail.com 
        /// </summary>
        [TestMethod]
        public void PhoneNumberTest()
        {
            //arrange
            string message = "bagulswapnilp@gmail.com";
            //invalid Condition
           //string message = "xyz@gmail";
            string expected = "valid";

            //act
            UserRegistration userRegistration = new UserRegistration(message);
            string actual=userRegistration.PatternChecking();

            //Assert
            Assert.AreEqual(expected, actual );


        }
    }
}
