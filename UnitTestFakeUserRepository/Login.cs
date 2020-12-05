using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OO_Final;

namespace UnitTestFakeUserRepository
{
    [TestClass]
    public class Login
    {
        [TestMethod]
        public void LoginWithGoodCredsPass()
        {
            // Arrange
            const string name = "Jason";
            const string pass = "Password1!";
            FakeUserRepository UsrRepo = new FakeUserRepository();

            // Act
            bool result = UsrRepo.Login(name, pass);

            // Assert
            Assert.IsTrue(result == true);
        }

        [TestMethod]
        public void LoginWithBadCredsFail()
        {
            // Arrange
            const string name = "Test";
            const string pass = "Test";
            FakeUserRepository UsrRepo = new FakeUserRepository();

            // Act
            bool result = UsrRepo.Login(name, pass);

            // Assert
            Assert.IsTrue(result == false);
        }
    }
}
