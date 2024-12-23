using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Channels;

namespace Session05_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {



            #region 1- . Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.
            //Console.WriteLine("Enter Size of Array");
            //int n;
            //bool flag = int.TryParse(Console.ReadLine(), out n);

            //while (!flag || n <= 0)
            //{

            //    Console.WriteLine("You entered invalid input it should be int");
            //    flag = int.TryParse(Console.ReadLine(), out n);
            //}
            //int[,] arr = new int[n, n];
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (i == j)
            //        {
            //            arr[i, j] = 1;
            //        }

            //    }

            //}

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write(arr[i, j] + "");

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

            int[] arr = {1,2,3,3,1,3,4,5};
            int[] visited = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                if (visited[i] == -1)
                    continue;

                int count = 1;
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        visited[j] = -1;

                    }
                }
                Console.WriteLine(arr[i] + " " + count);

            }

            #endregion

            #region 5-Write a program in C# Sharp to find maximum and minimum element in an array
            //int[] arr = { 1, 2, 3, 4, 5 };
            //Array.Sort(arr);
            //int MaxValue = arr[arr.Length-1];
            //int MinValue = arr[0];
            //Console.WriteLine($"Maximum Value is :{MaxValue}\nMinimum Value is :{MinValue}");


            #endregion

            #region  6-Write a program in C# Sharp to find the second largest element in an array
            //int[] arr = { 1, 2, 3, 4, 5 };
            //Array.Reverse(arr);
            //int MaxValue = arr[0];
            //int? SecondMaxValue=null;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] != MaxValue)
            //    {
            //        if (SecondMaxValue ==null ||arr[i] > SecondMaxValue)
            //        {
            //            SecondMaxValue = arr[i];
            //        }
            //    }
            //}
            //Console.WriteLine($"Second Largest Element is :{SecondMaxValue}");


            #endregion

            #region ///write a program to find the longest distance between Two equal cells. In this example. The distance is measured by the number Of cells- for example, the distance between the first and the fourth cell is 2 (cell 2 and cell 3).In the example above, the longest distance is between the first 7 and the
            ///10th 7, with a distance of 8 cells, i.e.the number of cells between the 1st
            ///And the 10th 7s.
            ///

            ////int[] array = { 7, 0, 0, 0, 0, 5, 6, 7, 5, 0, 7, 5, 3 };
            //int[] array = { 1, 1, 1, 1, 1, 1, 1, 1 };

            //int diff = 0;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    for (int j = i + 1; j < array.Length; j++)
            //    {
            //        if (array[i] == array[j] && (j - i) > diff)
            //        {
            //            diff = j - i;
            //        }
            //    }
            //}
            //Console.WriteLine($"Longest distance is {diff}");







            #endregion

            #region 9-	Given a list of space separated words, reverse the order of the words.

            //string input = "this is a test";

            //string[]splits=input.Split(' ');
            //Array.Reverse(splits);
            //for (int i = 0; i < splits.Length; i++)
            //{
            //    Console.WriteLine(splits[i]);
            //}
            #endregion

            #region 10-	 Write a program to create two multidimensional arrays of same size. Accept values from the user and store them in first array. Now copy all the elements of the first array on second array and print second array.



            #endregion

            #region 11-	Write a Program to Print One Dimensional Array in Reverse Order

            //int[] arr = { 1, 2, 3, 4, 5 };
            //Array.Reverse(arr);

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);

            //}

            #endregion



        }
    }
}

    




    


