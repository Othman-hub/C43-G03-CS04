using System.Buffers.Text;
using System.ComponentModel;

namespace Assignments4
{
    internal class Program
    {
        #region 1- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order
        static int[] MergeArraysSorted(int[] arr1, int[] arr2)
        {
            int[] result = new int[arr1.Length + arr2.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                result[i] = arr1[i];
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                result[arr1.Length + i] = arr2[i];
            }
            Array.Sort(result);
            return result;
        }
        #endregion
        #region 2- Write a program in C# Sharp to count the frequency of each element of an array.
        #endregion
        #region 3- Write a program in C# Sharp to find maximum and minimum element in an array
        static string FindMaxMin(int[] arr)
        {
            int max = arr[0];
            foreach (int item in arr)
            {
                if (item > max)
                    max = item;
            }
            int min = arr[0];
            foreach (int item in arr)
            {
                if (item < min)
                    min = item;
            }
            return $"Max = {max}\nMin = {min}";
        }
        #endregion
        #region 4- Write a program in C# Sharp to find the second largest element in an array.
        static int FindSecondLargest(int[] arr)
        {
            Array.Sort(arr);
            return arr[arr.Length - 2];
        }
        #endregion
        #region 5-write a program find the longest distance between Two equal cells. In this example. The distance is measured by the number Of cells- for example, the distance between the first and the fourth cell is 2 (cell 2 and cell 3).

        #endregion
        #region 6- Given a list of space separated words, reverse the order of the words

        #endregion
        #region 7- Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.

        static void CreatePrint2DArray(int rows,int columns)
        {
            int[,] arr = new int[rows, columns];
            int[,] arr2 = new int[rows, columns];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1);)
                {
                    Console.Write($"Enter Column Number {j +1} in Row Number {i+1} : ");
                    if (int.TryParse(Console.ReadLine(), out arr[i, j]))
                    j++;
                }
            }
            Console.Clear();
            Array.Copy(arr,arr2,arr.Length);
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1);j++)
                {
                    Console.WriteLine($"Column Number {j + 1} in Row Number {i + 1} = {arr2[i, j]}");

                }
            }
        }

        #endregion


        #region 8- Write a Program to Print One Dimensional Array in Reverse Order
        static void PrintArrayReverse(int[] arr)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
                Console.WriteLine(arr[i]);
        }

        #endregion

        #region 9-Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
        //In passing by value only the value is passed
        //In this case if you pass two variables
        //it will only take the value and will not change the value of the variables
        static void swap(int x, int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        //But in this case if you pass two variables
        //it will take the variables in full and change their values
        static void swap2(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        #endregion


        #region 10-Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.
        static void ShowArray(int[] arr)
        {
            arr = new int[] {1,2,3};
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        static void showArray2(ref int[] arr)
        { 
            arr = new int[] {1,2,3};
            for (int i = 0; i<arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        #endregion


        #region 11-Write a c# function that accepts 4 parameters from user and returns result of summation and subtracting of two numbers
        static void SumSub(int x, int y, out int sum, out int sub)
        {
            sum = x + y;
            sub = x - y;
        }
        #endregion

        #region 12-Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number
        static int OddNumbersCalculation(int number)
        {
            if (number < 0)
            {
                number = -number;
            }
            int result = 0;
            for (int i = 1; i <= number; i++)
            {
                if ((i % 2) != 0)
                    result++;
            }
            return result;
        }

        #endregion
        #region 13-Create a function named “IsPrime”, which receives an integer number and retuns true if it is prime, or false if it is not

        #endregion

        #region 14-Create a function named MinMaxArray, to return the minimum and maximum values ​​stored in an array, using reference parameters
        static void MaxMinArray(int[] arr, ref int max, ref int min)
        {
            max = arr[0];
            foreach (int item in arr)
            {
                if (item > max)
                    max = item;
            }
            min = arr[0];
            foreach (int item in arr)
            {
                if (item < min)
                    min = item;
            }
        }
        #endregion

        #region 15-Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter
        static long CalculateFactorial(int num)
        {
            if (num == 0 || num == 1)
                return 1;

            int result = 1;
            for (int i = 2; i <= num; i++)
            {
                result *= i;
            }
            return result;
        }
        #endregion


        #region 16-Create a function named “ChangeChar” to modify a letter in a certain position(0 based) of a string, replacing it with a different lette

        static string ChangeChar(string s)
        {
            return s.Replace(s[0], 'a');
        } 
        #endregion







        static void Main(string[] args)
        {


            int[] arr = { 1, 2,9, 3,10, 4, 5 ,6};
            //int[] arr2 = { 1, 2, 3, 4, 5 };
            //;
            //for (int i = 0; i < MergeArraysSorted(arr, arr2).Length; i++)
            //{
            //    Console.WriteLine(MergeArraysSorted(arr, arr2)[i]);
            //}
            //Console.WriteLine(FindMaxMin(arr));
            //Console.WriteLine(FindSecondLargest(arr));

            //PrintArrayReverse(arr);
            //Console.WriteLine(OddNumbersCalculation(25));


            Console.WriteLine(ChangeChar("othman"));


        }
    }
}
