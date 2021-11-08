using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationTesting;
using System;

namespace UserRegistrationTest
{
    [TestClass]
    public class TestPattern
    {
        /// <summary>
        /// UC1 FirstName of User
        /// first letter of name should be capital
        /// </summary>
        [TestMethod]
        public void FirstName()
        {
            //arrange
            string message = "Swapnil";
            string expected = "valid";

            //act
            UserRegistration userRegistration = new UserRegistration(message);
            string actual=userRegistration.PatternChecking();

            //Assert
            Assert.AreEqual(expected, actual );


        }
    }
}
