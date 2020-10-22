// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressBook.cs" company="Bridgelabz">
//   Copyright © 2018 Company
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
    }
}
