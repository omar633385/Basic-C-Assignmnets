using System;
using System.ComponentModel;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace session06_assignment
{
    ///=========================================================================================Enums======================================================


    public enum WeekDays:byte
    {
        Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday
    }
    enum Season:byte
    {
        Spring, Summer, Autumn, Winter
    }
    [Flags]
    enum Permissions : byte
    {
        Read=1, write=2, Delete=4, Execute=8
    }

    enum Colors : byte
    {
        Red, Green, Blue
    }
    internal class Program
    {
        public static int SumDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int remainder=number % 10;
                sum += remainder;
                number/=10;
            }

            return sum;
        }
        public static bool isprime(int number) {

            if (number<=1)
            {
                return false;
            }

            for (int i = 2; i < number ; i++)
            {
                if(number%i ==0)
                    return false;
            }

            return true;
        
        }

        public static (int,int) MinMaxArray(ref int[] arr)
        {
            int maximum= arr[0], minimum = arr[0];
            if (arr is not null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] < minimum)
                        minimum = arr[i];
                    if (arr[i] > maximum)
                        maximum = arr[i];
                }
            }
            return (maximum,minimum);

        }

        public static int fact(int number) {
            int result=1;
            if (number ==1 || number==0)
            {
                return result;   
            }

            for (int i = 1; i <=number ; i++)
            {

                result *= i;
            }
            return result;
        }

        public static int SumArray(ref int[] Arr)
        {
            int Sum = 0;
            Arr = new int[]{ 4,5,6};
            Arr[0] = 100;
            for (int i = 0; i < Arr.Length; i++)
                Sum += Arr[i];
            return Sum;
        }

        public static void sumsub(int num1, int num2, out int sum, out int sub) {
        
            sum=num1 + num2;
            sub=num1 - num2;
        }

        public static string ChangeChar(string str, int position, string replace,int length= 1)
        {
            return str.Remove(position, Math.Min(length, str.Length - position))
                    .Insert(position, replace);
        }



        static void Main(string[] args)
        {
            ///====================================part01=============================================================
            #region Part01

            #region 1.	Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.

            //// Console.WriteLine("Passing By Value");
            // int a=10,b=20;
            //// Console.WriteLine($"Before Swapping a={a} b={b}");
            // void swap(ref int a ,ref int b) {

            //     int temp = a;
            //     a = b;
            //     b=temp;
            // }
            // //swap(a , b);
            // //Console.WriteLine($"Passing By Value a={a} b={b}");


            // //Passing by value means it takes copies of values and do the opertion once swap function stack finish
            // //values of a,b don't change.
            // //the change happens in swap stack and it did its job


            // Console.WriteLine("Passing By Reference");
            // Console.WriteLine($"Before Swapping a={a} b={b}");

            // swap(ref a,ref b);
            // Console.WriteLine($"Passing By Value a={a} b={b}");

            // //Passing by Reference here  it takes the variable itselef and change it unlike passing by value  
            // //values of a,b actually change.

            #endregion

            #region 2.	Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number
            //Console.WriteLine("Enter Number");
            //int number;
            //bool flag;
            //do
            //{
            //     flag = int.TryParse(Console.ReadLine(), out number);
            //}
            //while (!flag);
            //Console.WriteLine($"The sum of the digits of the number {number} is: {SumDigits(number)}");

            #endregion

            #region 3.	Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:


            //Console.WriteLine("Enter Number");
            //int number;
            //bool flag;
            //do
            //{
            //    flag = int.TryParse(Console.ReadLine(), out number);
            //}
            //while (!flag);
            //if(isprime(number)==true)
            //    Console.WriteLine($"The number {number} is prime");
            //else
            //    Console.WriteLine($"The number {number} is not prime");



            #endregion

            #region 4.	Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters

            //int[] arr = { 10, 1, 14, 4, 3, 80, 66 };
            //(int max, int min)= MinMaxArray(ref arr);

            //Console.WriteLine($"Maximum Element of Array is {max}\nMinimum Element of Array is {min}");

            #endregion

            #region 5.	Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter

            //Console.WriteLine("Enter Number");
            //int number;
            //bool flag;
            //do
            //{
            //    flag = int.TryParse(Console.ReadLine(), out number);
            //}
            //while (!flag ||number<0);
            //Console.WriteLine($"The Factorial of the number {number} is: {fact(number)}");

            #endregion

            #region 6.	Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example

            #region PassingByValue
            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine(SumArray(Numbers));//111
            //Console.WriteLine(Numbers[0]);//1
            //When a reference type is passed by value, the reference is copied.
            //Any changes to the object inside the method will reflect outside since the reference points to the same object in memory.

            #endregion

            #region PassingByReference

            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine(SumArray(ref Numbers));//111
            //Console.WriteLine(Numbers[0]);//100

            ////The ref keyword allows a reference type to be passed by reference.
            ////Both the object properties and the reference itself can be modified inside the method

            #endregion

            #endregion

            #region 7.	Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers

            //Console.WriteLine("Enter two Number");
            //int num1 ,num2;
            //bool flag1,flag2;
            //do
            //{
            //    flag1 = int.TryParse(Console.ReadLine(), out num1);
            //    flag2 = int.TryParse(Console.ReadLine(), out num2);

            //}
            //while (!(flag1 &&flag2));

            //sumsub(num1, num2, out int sum, out int sub);
            //Console.WriteLine($"{num1}+{num2}={sum}\n{num1}-{num2}={sub}");
            #endregion

            #region 8.	Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter

            //string str;
            //int position;
            //string replace;
            //bool isValid;
            //Console.WriteLine("Enter the string:");
            //str = Console.ReadLine();
            //if (string.IsNullOrEmpty(str))
            //{
            //    Console.WriteLine("String cannot be null or empty.");
            //    return;
            //}

            //do
            //{
            //    Console.WriteLine("Enter the position (integer) to start replacing:");
            //    isValid = int.TryParse(Console.ReadLine(), out position) && position >= 0 && position < str.Length;
            //    if (!isValid) Console.WriteLine("Invalid position. It must be within the bounds of the string.");
            //} while (!isValid);

            //Console.WriteLine("Enter the replacement string:");
            //replace = Console.ReadLine();
            //if (string.IsNullOrEmpty(replace))
            //{
            //    Console.WriteLine("Replacement string cannot be null or empty.");
            //    return;
            //}


            //try
            //{
            //    string result = ChangeChar(str, position, replace, 1);
            //    Console.WriteLine("Modified String: " + result);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}

            #endregion

            #endregion

            ///=========================================================================================Part02======================================================

            #region Part02
            #region 1-	Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.


            //foreach (var item in Enum.GetValues(typeof(DayOfWeek)))
            //{
            //    Console.WriteLine(item);
            //} 

            #endregion

            #region 2.	Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)

            //Console.WriteLine("Enter season (Spring, Summer, Autumn, Winter)");

            //string user_input = Console.ReadLine().ToLower();

            //if (!string.IsNullOrEmpty(user_input))
            //{
            //    if (Enum.TryParse(user_input, true, out Season season)){
            //        switch (season)
            //        {
            //            case Season.Spring:
            //                Console.WriteLine("spring march to may ");
            //                break;
            //            case Season.Summer:
            //                Console.WriteLine("summer june to august ");
            //                break;
            //            case Season.Autumn:
            //                Console.WriteLine("autumn September to November");
            //                break;
            //            case Season.Winter:
            //                Console.WriteLine("winter December to February");
            //                break;
            //            default:
            //                Console.WriteLine("You Entered invalid input");
            //                break;
            //        }
            //    }
            //}

            #endregion

            #region //4- Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum. 
            //●Create Variable from previous Enum to Add and Remove Permission from variable,
            //check if specific Permission is existed inside variable

            //Permissions permission = Permissions.Read;
            //permission |= Permissions.Execute;
            //permission^= Permissions.Execute;

            //if ((permission & Permissions.Execute) == Permissions.Execute) 
            //    Console.WriteLine("Execute Existed");

            //else
            //    Console.WriteLine("Execute not Exist");


            #endregion


            #region 5. Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.

            Console.WriteLine("Enter color (Red, Green, Blue)");

            string user_input = Console.ReadLine().ToLower();

            if (!string.IsNullOrEmpty(user_input))
            {
                if (Enum.TryParse(user_input, true, out Colors color))
                {
                    switch (color)
                    {
                        case Colors.Red:
                            Console.WriteLine("Red is primary color");
                            break;
                        case Colors.Green:
                            Console.WriteLine("Green is not primary color");
                            break;
                        case Colors.Blue:
                            Console.WriteLine("Blue is primary color");
                            break;

                        default:
                            Console.WriteLine("You Entered invalid input color should be(Red, Green, Blue)");
                            break;
                    }
                }
            }


            #endregion
            #endregion

        }



    }
}

        

