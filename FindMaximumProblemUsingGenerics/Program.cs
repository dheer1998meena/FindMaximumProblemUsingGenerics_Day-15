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
            int[] intArray = new int[] { 12, 45, 63 , 52,69};
            GenericMaximum<int> genericInt = new GenericMaximum<int>(intArray);
            int intMax = genericInt.PrintMethod();
            Console.WriteLine("Maximum integer number Among three number:" + intMax);
            // using generics class Max number among three float number
            double[] doubleArray = new double[] { 12.5, 45.7, 63.5,65,65.8 };
            GenericMaximum<double> genericFloat = new GenericMaximum<double>(doubleArray);
            double doubleMax = genericFloat.PrintMethod();
            Console.WriteLine("Maximum float number among three number :" + doubleMax);
            // using generics class Max number among three string number.
            string[] stringArray = new string[] {"16","68","13","56","55"};
            GenericMaximum<string> genericm = new GenericMaximum<string>(stringArray);
            string stringMax = genericm.PrintMethod();
            Console.WriteLine("Maximum string number among three number :" + stringMax);
            GenericMaximum<int> generic = new GenericMaximum<int>(intArray);
            genericInt.printMaxGenericMethod();

            Console.ReadLine();
        }
    }
}
