using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationTesting;
using System;

namespace UserRegistrationTest
{
    [TestClass]
    public class TestPattern
    {
        /// <summary>
        /// UC5 Test password of User
        /// it must contain special char,number,upper and lowercase alpha 
        /// </summary>
        [TestMethod]
        public void PasswordTest()
        {
            //arrange
            string message = "Swapnil#12";
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
