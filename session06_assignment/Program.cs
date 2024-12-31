using System.Security.Cryptography.X509Certificates;

namespace session06_assignment
{
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

        public static void sumsub(int num1, int num2, out int sum, out int sub) {
        
            sum=num1 + num2;
            sub=num1 - num2;
        }
        static void Main(string[] args)
        {

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


        }



    }
}

        

