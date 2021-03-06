// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressBook.cs" company="Bridgelabz">
//   Copyright � 2018 Company
// </copyright>
// <creator Name="Dheer Singh Meena"/>
// --------------------------------------------------------------------------------------------------------------------
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindMaximumProblemUsingGenerics;


namespace FindMaximumMsTest
{
    [TestClass]
    public class UnitTest1
    {
        // UC 1.1 : Given the maximum number at first position returns the same number.      
        [TestMethod]
        public void GivenMaxNumberAtFirstPositionReturnTheSameNumber()
        {
            //Arrange
            int expected = 2200;
            //Act
            int actual = FindMaximum.FindMaximumAmongThreeInteger(2200, 100, 100);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        // UC 1.2 : Given the maximum number at second position returns the same number.      
        [TestMethod]
        public void GivenMaxNumberAtSecondPositionReturnTheSameNumber()
        {
            //Arrange
            int expected = 500;
            //Act
            int actual = FindMaximum.FindMaximumAmongThreeInteger(300, 500, 100);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        // UC 1.3 : Given the maximum number at third position returns the same number.      
        [TestMethod]
        public void GivenMaxNumberAtThirdPositionReturnTheSameNumber()
        {
            //Arrange
            int expected = 1000;
            //Act
            int actual = FindMaximum.FindMaximumAmongThreeInteger(300, 500, 1000);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        // UC 2.1 : Given the maximum number at first position returns the same number as a float number.      
        [TestMethod]
        public void GivenMaxNumberAtFirstPositionReturnTheSameNumberWithFloat()
        {
            //Arrange
            double expected = 2200.15;
            //Act
            double actual = FindMaximum.FindMaximumAmongThreeFloatNumber(2200.15, 100.12, 100.15);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        // UC 2.2 : Given the maximum number at secod position returns the same number as float number.      
        [TestMethod]
        public void GivenMaxNumberAtSecondPositionReturnTheSameNumberWithFloat()
        {
            //Arrange
            double expected = 500.53;
            //Act
            double actual = FindMaximum.FindMaximumAmongThreeFloatNumber(100.5, 500.53, 100.15);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        // UC 2.3 : Given the maximum number at third position returns the same number as float number.      
        [TestMethod]
        public void GivenMaxNumberAtThirdPositionReturnTheSameNumberWithFloat()
        {
            //Arrange
            double expected = 1000.56;
            //Act
            double actual = FindMaximum.FindMaximumAmongThreeFloatNumber(220.5, 100.12, 1000.56);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        // UC 3.1 : Given the maximum number at first position returns the same number as a string number.      
        [TestMethod]
        public void GivenMaxNumberAtFirstPositionReturnTheSameNumberWithString()
        {
            //Arrange
            string expected = "Peach";  
            //Act
            string actual = FindMaximum.FindMaximumAmongThreeStringNumber("Peach", "Apple", "Banana");
            //Assert
            Assert.AreEqual(expected, actual);
        }
        // UC 3.2 : Given the maximum number at Second position returns the same number as a string number.      
        [TestMethod]
        public void GivenMaxNumberAtSecondPositionReturnTheSameNumberWithString()
        {
            //Arrange
            string expected = "Peach";
            //Act
            string actual = FindMaximum.FindMaximumAmongThreeStringNumber("Apple", "Peach", "Banana");
            //Assert
            Assert.AreEqual(expected, actual);
        }
        // UC 3.3 : Given the maximum number at third position returns the same number as a string number.      
        [TestMethod]
        public void GivenMaxNumberAtThirdPositionReturnTheSameNumberWithString()
        {
            //Arrange
            string expected = "Peach";
            //Act
            string actual = FindMaximum.FindMaximumAmongThreeStringNumber("Apple", "Banana", "Peach");
            //Assert
            Assert.AreEqual(expected, actual);
        }
        // Test max int number using generic class.
        [TestMethod]
        public void GivenIntMaxNumberReturnTheSameNumberUsingGenerics()
        {
            //Arrange
            int expected = 220;
            //Act
            int actual = GenericMaximum<int>.MaximumAmongThree(220, 101, 100);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        // Test max float number using generic class.
        [TestMethod]
        public void GivenFloatMaxNumberReturnTheSameNumberUsingGenerics()
        {
            //Arrange
            double expected = 300.12;
            //Act
            double actual = GenericMaximum<double>.MaximumAmongThree(220.12, 300.12, 100.12);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        // Test max string number using generic class.
        [TestMethod]
        public void GivenStringMaxNumberReturnTheSameNumberUsingGenerics()
        {
            //Arrange
            string expected = "Peach";
            //Act
            string actual = GenericMaximum<string>.MaximumAmongThree("Apple", "Banana", "Peach");
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
