using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationTesting;
using System;

namespace UserRegistrationTest
{
    [TestClass]
    public class TestPattern
    {
        /// <summary>
        /// UC2 LastName of User
        /// first letter of name should be capital
        /// </summary>
        [TestMethod]
        public void LastName()
        {
            //arrange
            string message = "Bagul";
            string expected = "valid";

            //act
            UserRegistration userRegistration = new UserRegistration(message);
            string actual=userRegistration.PatternChecking();

            //Assert
            Assert.AreEqual(expected, actual );


        }
    }
}
