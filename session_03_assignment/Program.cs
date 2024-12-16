namespace session_03_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1- Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            //Console.WriteLine("Enter number : ");
            //int number;
            //int.TryParse(Console.ReadLine(),out number);
            //if (number%3==0 && number%4==0)
            //    Console.WriteLine("Yes");
            //else
            //    Console.WriteLine("NO");



            #endregion

            #region 2- Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            //Console.WriteLine("Enter number : ");
            //int number;
            //int.TryParse(Console.ReadLine(), out number);
            //if (number >0)
            //    Console.WriteLine("Postive");
            //else
            //    Console.WriteLine("Negative");



            #endregion

            #region 3- Write a program that takes 3 integers from the user then prints the max element and the min element.
            //Console.WriteLine("Enter 1st number : ");
            //int number1;
            //int.TryParse(Console.ReadLine(), out number1);

            //Console.WriteLine("Enter 2nd number : ");
            //int number2;
            //int.TryParse(Console.ReadLine(), out number2);

            //Console.WriteLine("Enter 3rd number : ");
            //int number3;
            //int.TryParse(Console.ReadLine(), out number3);

            //if (number1 > number2 && number1 > number3)
            //    Console.WriteLine($"max element = {number1}");

            //else if (number2 > number1 && number2 > number3)
            //        Console.WriteLine($"max element = {number2}");
            //else if (number3 > number1 && number3 > number2)
            //    Console.WriteLine($"max element = {number3}");

            //if (number1 < number2 && number1 < number3)
            //    Console.WriteLine($"min element = {number1}");

            //else if (number2 < number1 && number2 < number3)
            //    Console.WriteLine($"min element = {number2}");
            //else if (number3 < number1 && number3 < number2)
            //    Console.WriteLine($"min element = {number3}");




            {

            }


            #endregion

            #region 4- Write a program that allows the user to insert an integer number then check If a number is even or odd.
            //Console.WriteLine("Enter number : ");
            //int number;
            //int.TryParse(Console.ReadLine(), out number);
            //if (number %2== 0)
            //    Console.WriteLine("Even");
            //else
            //    Console.WriteLine("ODD");

            #endregion

            #region 5- Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).

            //Console.WriteLine("Enter char : ");
            //char character;
            //char.TryParse(Console.ReadLine().ToLower(), out character);
            //if (character =='a'|| character =='e' || character == 'i' || character == 'o' || character == 'u' )
            //    Console.WriteLine("Vowel");
            //else
            //    Console.WriteLine("constant");



            #endregion


            #region 7- Write a program that allows the user to insert an integer then print a multiplication table up to 12.

            //Console.WriteLine("Enter number : ");
            //int number;
            //int.TryParse(Console.ReadLine(), out number);
            //Console.WriteLine("===================");
            //for (int i = 1; i <=12; i++)
            //{
            //    Console.WriteLine(i*number);
            //}


            #endregion

            #region 8- Write a program that allows to user to insert number then print all even numbers between 1 to this number

            //Console.WriteLine("Enter number : ");
            //int number;
            //int.TryParse(Console.ReadLine(), out number);
            //Console.WriteLine("===================");
            //for (int i = 1; i <= number; i++)
            //{
            //    if (i%2==0)
            //        Console.WriteLine(i);
            //}
            #endregion

            #region 9- Write a program that takes two integers then prints the power.
            Console.WriteLine("Enter 1st number : ");
            int number1;
            int.TryParse(Console.ReadLine(), out number1);
            Console.WriteLine("Enter 2nd number : ");
            int number2;
            int.TryParse(Console.ReadLine(), out number2);

            Console.WriteLine($"result of {number1}^{number2} = {Math.Pow(number1,number2)}");

            #endregion
        }
    }
}

