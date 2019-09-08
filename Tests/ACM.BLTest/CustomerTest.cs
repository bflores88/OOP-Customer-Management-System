using System.Reflection;
using ACM.BL;
using NUnit.Framework;

namespace Tests
{
    public class CustomerTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FullNameTestValid()
        {
            // Arrange
            var customer = new Customer
            {
                FirstName = "Bilbo",
                LastName = "Baggins"
            };
            const string expected = "Baggins, Bilbo";

            // Act
            var actual = customer.FullName;
            
            // Assert
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void FullNameFirstNameEmpty()
        {
            // Arrange
            var customer = new Customer
            {
                LastName = "Baggins"
            };
            const string expected = "Baggins";

            // Act
            var actual = customer.FullName;
            
            // Assert
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void FullNameLastNameEmpty()
        {
            // Arrange
            var customer = new Customer
            {
                FirstName = "Bilbo",
            };
            const string expected = "Bilbo";

            // Act
            var actual = customer.FullName;
            
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}