﻿using System.ComponentModel;

namespace Session05_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1- . Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.
            //Console.WriteLine("Enter Size of Array");
            //int n;
            //bool flag=int.TryParse(Console.ReadLine(), out n);

            //while (!flag|| n<=0) {

            //    Console.WriteLine("You entered invalid input it should be int");
            //    flag=int.TryParse(Console.ReadLine(), out n);
            //}
            //int[,] arr =new int[n,n];
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (i == j)
            //        {
            //            arr[i,j] = 1;
            //        }

            //    }

            //}

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write(arr[i,j]+ "");

            //    }
            //    Console.WriteLine();

            //}
            #endregion

            #region 2-Write a program in C# Sharp to find the sum of all elements of the array.

            //int[] arr = {1,2,3,4,5};
            //int sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    sum+= arr[i];
            //}
            //Console.Write($"Sum of All Elemnts is :{sum}");
            #endregion

            #region 3- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order

            //int[] arr1 = { 1, 2, 3 };
            //int[] arr2 = { 4, 5, 6 };
            //Array.Sort(arr1);
            //Array.Sort(arr2);
            //int[] mergedArray = new int[arr1.Length + arr2.Length];
            //Array.Copy(arr1, 0, mergedArray, 0, arr1.Length);
            //Array.Copy(arr2, 0, mergedArray, arr1.Length, arr2.Length);

            //foreach (var item in mergedArray)
            //{
            //    Console.Write(item+" , ");
            //}

            #endregion

            #region 4- Write a program in C# Sharp to count the frequency of each element of an array.

            #endregion

            #region 5-Write a program in C# Sharp to find maximum and minimum element in an array
            int[] arr = { 1, 2, 3, 4, 5 };
            Array.Sort(arr);
            int MaxValue = arr[arr.Length-1];
            int MinValue = arr[0];
            Console.WriteLine($"Maximum Value is :{MaxValue}\nMinimum Value is :{MinValue}");
            

            #endregion
        }
    }
}
