using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STRING_KATA_WEDNEDAY_27_02_2019
{
    [TestFixture]
    public class StringCalculatorTest
    {

        [Test]
        public void Add_GivenAnEmptyString_ShouldReturnZero()
        {
            // Act
            var calcultor = new StringCalculator();
            // Arrange
            var sum = calcultor.Add("");
            // Assert
            Assert.AreEqual(0, sum);
        }

        [Test]
        public void Add_GivenAStringWithASingleNumber_ShouldReturnThatNumber()
        {
            // Act
            var calcultor = new StringCalculator();
            // Arrange
            var sum = calcultor.Add("1");
            // Assert
            Assert.AreEqual(1, sum);
        }

        [Test]
        public void Add_GivenTwoCharacterNumber_ShouldReturnSum()
        {
            // Act 
            var calcultor = new StringCalculator();
            // Arrange
            var sum = calcultor.Add("1,2");
            // Assert
            Assert.AreEqual(3, sum);
        }

        [Test]
        public void Add_GivenManyCommaSeparatedNumbers_ShouldReturnSum()
        {
            // Act 
            var calcultor = new StringCalculator();
            // Arrange
            var sum = calcultor.Add("1,2,3");
            // Assert
            Assert.AreEqual(6, sum);
        }

        [Test]
        public void Add_GivenNewLineAsDelimeter_ShouldReturnSum()
        {
            // Act  
            var calcultor = new StringCalculator();
            // Arrange
            var sum = calcultor.Add("1\n2,3");
            // Assert
            Assert.AreEqual(6, sum);
        }

        [Test]
        public void Add_GivenNewLineAndCustomDelimeters_ShouldReturnSum()
        {
            // Act   
            var calcultor = new StringCalculator();
            // Arrange
            var sum = calcultor.Add("//;\n1;2");
            // Assert
            Assert.AreEqual(3, sum);
        }

        [Test]
        public void Add_GivenANegativeNumber_ShouldThrowException()
        {
            // Act   
            var calcultor = new StringCalculator();
            // Arrange
            var exception = Assert.Throws<NegativeNotSupported>(() => calcultor.Add("-2"));
            // Assert
            Assert.AreEqual(exception.Message, "Negatives numbers are not allowed: -2");
        }

        [Test]
        public void Add_GivenMultipleNegativeNumbers_ShouldThrowException()
        {
            // Act   
            var calcultor = new StringCalculator();
            // Arrange
            var exception = Assert.Throws<NegativeNotSupported>(() => calcultor.Add("-2,-4,-5,-8"));
            // Assert
            Assert.AreEqual(exception.Message, "Negatives numbers are not allowed: -2,-4,-5,-8");
        }

        [Test]
        public void Add_GivenNumberBiggerThen1000_ShouldIgnore()
        {
            // Act   
            var calcultor = new StringCalculator();
            // Arrange
            var sum = calcultor.Add("//;\n1;1001");
            // Assert
            Assert.AreEqual(1, sum);
        }

        [Test]
        public void Add_GivenNumberEqualOrLessentThen1000_ShouldReturnSum()
        {
            // Act   
            var calcultor = new StringCalculator();
            // Arrange
            var sum = calcultor.Add("//;\n1;1000,2");
            // Assert
            Assert.AreEqual(1003, sum);
        }

        [Test]
        public void Add_GivenDelimetersWithAnyLength_ShouldReturnSum()
        {
            // Act    
            var calcultor = new StringCalculator();
            // Arrange
            var sum = calcultor.Add("//[***]\n1***2***3");
            // Assert
            Assert.AreEqual(6, sum);
        }

        [Test]
        public void Add_GivenMutipleCustomDelimeters_ShouldReturnSum()
        {
            // Act    
            var calcultor = new StringCalculator();
            // Arrange
            var sum = calcultor.Add("//[***][&]\n1***3&");
            // Assert
            Assert.AreEqual(4, sum);
        }
    }
}
