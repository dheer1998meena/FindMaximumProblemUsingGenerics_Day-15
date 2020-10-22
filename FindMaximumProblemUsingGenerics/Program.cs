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
            //UC2 Finds max among the given three float numbers
            try
            {
                Console.WriteLine(FindMaximum.FindMaximumAmongThreeFloatNumber(1223.1, 1258.3, 1500.3));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            //UC3 Finds max among the given three string numbers 
            try
            {
                Console.WriteLine(FindMaximum.FindMaximumAmongThreeStringNumber("Apple", "Peach", "Banana"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            //using parameterized constructor
            // using generics class Max number among three integer number
            GenericMaximum<int> generic = new GenericMaximum<int>(12, 45, 63);
            int intMax = generic.PrintMethod();
            Console.WriteLine("Maximum integer number Among three number:" + intMax);
            // using generics class Max number among three float number
            GenericMaximum<double> generics = new GenericMaximum<double>(12.4, 45.5, 63.2);
            double doubleMax = generics.PrintMethod();
            Console.WriteLine("Maximum float number among three number :" + doubleMax);
            // using generics class Max number among three string number.
            GenericMaximum<string> genericm = new GenericMaximum<string>("12","16", "50");
            string stringMax = genericm.PrintMethod();
            Console.WriteLine("Maximum string number among three number :" + stringMax);
            Console.ReadLine();
        }
    }
}
