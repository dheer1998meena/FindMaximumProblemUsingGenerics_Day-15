// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressBook.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Dheer Singh Meena"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaximumProblemUsingGenerics
{
    public class FindMaximum
    {
        /// <summary>
        /// // UC1: Finds the Maximum among three integers.
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <param name="thirdNumber"></param>
        /// <returns></returns>
        public static int FindMaximumAmongThreeInteger(int firstNumber, int secondNumber, int thirdNumber)
        {
            Console.WriteLine("Print maxuimum integer");
            // Checks if firstNumber is great then both secondNumber and thirdNumber
            if (firstNumber.CompareTo(secondNumber) > 0 && firstNumber.CompareTo(thirdNumber) > 0)
                return firstNumber;
            // Checks if secondNumber is great then both firstNumber and thirdNumber
            else if (secondNumber.CompareTo(firstNumber) > 0 && secondNumber.CompareTo(thirdNumber) > 0)
                return secondNumber;
            // Checks if thirdNumber is great then both secondNumber and firstNumber
            else if (thirdNumber.CompareTo(firstNumber) > 0 && thirdNumber.CompareTo(secondNumber) > 0)
                return thirdNumber;
            else
            {
                throw new Exception("All the three numbers are same ");
            }
        }

        /// <summary>
        /// // UC2: Finds the Maximum among three float number.
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <param name="thirdNumber"></param>
        /// <returns></returns>
        public static double FindMaximumAmongThreeFloatNumber(double firstNumber, double secondNumber, double thirdNumber)
        {
            Console.WriteLine("Print maxuimum float number");
            // Checks if firstNumber is great then both secondNumber and thirdNumber
            if (firstNumber.CompareTo(secondNumber) > 0 && firstNumber.CompareTo(thirdNumber) > 0)
                return firstNumber;
            // Checks if secondNumber is great then both firstNumber and thirdNumber
            else if (secondNumber.CompareTo(firstNumber) > 0 && secondNumber.CompareTo(thirdNumber) > 0)
                return secondNumber;
            // Checks if thirdNumber is great then both secondNumber and firstNumber
            else if (thirdNumber.CompareTo(firstNumber) > 0 && thirdNumber.CompareTo(secondNumber) > 0)
                return thirdNumber;
            else
            {
                throw new Exception("All the three numbers are same ");
            }
        }
        /// <summary>
        /// // UC1: Finds the Maximum among three integers.
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <param name="thirdNumber"></param>
        /// <returns></returns>
        public static string FindMaximumAmongThreeStringNumber(string firstNumber, string secondNumber, string thirdNumber)
        {
            Console.WriteLine("Print maxuimum integer");
            // Checks if firstNumber is great then both secondNumber and thirdNumber
            if (firstNumber.CompareTo(secondNumber) > 0 && firstNumber.CompareTo(thirdNumber) > 0)
                return firstNumber;
            // Checks if secondNumber is great then both firstNumber and thirdNumber
            else if (secondNumber.CompareTo(firstNumber) > 0 && secondNumber.CompareTo(thirdNumber) > 0)
                return secondNumber;
            // Checks if thirdNumber is great then both secondNumber and firstNumber
            else if (thirdNumber.CompareTo(firstNumber) > 0 && thirdNumber.CompareTo(secondNumber) > 0)
                return thirdNumber;
            else
            {
                throw new Exception("All the three numbers are same ");
            }
        }
    }
}
