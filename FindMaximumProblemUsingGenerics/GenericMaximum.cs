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
    public class GenericMaximum<T> where T : IComparable
    {
        // defining variable generic type
        public T [] inputValues;
        /// <summary>
        /// Create parameterized constructor 
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <param name="thirdNumber"></param>
        public GenericMaximum(T [] inputValues)
        {
            this.inputValues = inputValues;
        }
        /// <summary>
        /// using generic mthod find out maximum number among three number
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <param name="thirdNumber"></param>
        /// <returns></returns>
        public static T MaximumAmongThree(T firstNumber , T secondNumber , T thirdNumber)
        {
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
        /// using sorting the array and returning max number
        /// </summary>
        /// <param name="inputValues"></param>
        /// <returns></returns>
        public static T SortingNumber(T [] inputValues)
        {
            Array.Sort(inputValues);
            return inputValues[inputValues.Length - 1];
        }
        /// used to pass the values from parametrized constructor to MaxAmongThree static method
        /// static method can not be directly called using object
        public T PrintMethod()
        {
            T max = SortingNumber(inputValues);
            return max;
        }

    }
}
