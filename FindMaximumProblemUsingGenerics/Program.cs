// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressBook.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Dheer Singh Meena"/>
// --------------------------------------------------------------------------------------------------------------------
using System;

namespace FindMaximumProblemUsingGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            //UC1 Finds max among the given three integer numbers
            try
            {
                Console.WriteLine(FindMaximum.FindMaximumAmongThreeInteger(1230, 1223, 1200));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            //UC2 Finds max among the given three float number numbers
            try
            {
                Console.WriteLine(FindMaximum.FindMaximumAmongThreeFloatNumber(1223.1, 1258.3, 1500.3));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            Console.ReadLine();
        }
    }
}
