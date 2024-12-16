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
            //Console.WriteLine("Enter 1st number : ");
            //int number1;
            //int.TryParse(Console.ReadLine(), out number1);
            //Console.WriteLine("Enter 2nd number : ");
            //int number2;
            //int.TryParse(Console.ReadLine(), out number2);

            //Console.WriteLine($"result of {number1}^{number2} = {Math.Pow(number1,number2)}");

            #endregion

            #region 11- Write a program to input the month number and print the number of days in that month.
            //Console.WriteLine("Enter Month number : ");
            //int MonthNumber;
            //int.TryParse(Console.ReadLine(), out MonthNumber);

            //switch (MonthNumber) {

            //    case 1:
            //        Console.WriteLine("Days in Month: 31");
            //        break;
            //    case 2:
            //        Console.WriteLine("Days in Month: 28");
            //        break;
            //    case 3:
            //        Console.WriteLine("Days in Month: 31");
            //        break;
            //    case 4:
            //        Console.WriteLine("Days in Month: 30");
            //        break;
            //    case 5:
            //        Console.WriteLine("Days in Month: 31");
            //        break;

            //    case 6:
            //        Console.WriteLine("Days in Month: 30");
            //        break;
            //    case 7:
            //        Console.WriteLine("Days in Month: 31");
            //        break;
            //    case 8:
            //        Console.WriteLine("Days in Month: 31");
            //        break;

            //    case 9:
            //        Console.WriteLine("Days in Month: 30");
            //        break;

            //    case 10:
            //        Console.WriteLine("Days in Month: 31");
            //        break;
            //    case 11:
            //        Console.WriteLine("Days in Month: 30");
            //        break;
            //    case 12:
            //        Console.WriteLine("Days in Month: 31");
            //        break;
            //    default:
            //        Console.WriteLine("You Entered Invalid Month Number =>Month Numbers in Range 1-12");
            //        break;

            //}


            #endregion

            #region ///            "18- Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task. A worker's efficiency level is determined as follows: 
            ///            -If the worker completes the job within 2 to 3 hours, they are considered highly efficient.
            ///            - If the worker takes 3 to 4 hours, they are instructed to increase their speed.
            ///            - If the worker takes 4 to 5 hours, they are provided with training to enhance their speed.
            ///            - If the worker takes more than 5 hours, they are required to leave the company.
            ///To calculate the efficiency of a worker, the time taken for the task is obtained via user input from the keyboard."
            ///

            Console.WriteLine("Enter duration : ");
            double timeTaken;
            double.TryParse(Console.ReadLine(), out timeTaken);
            switch (timeTaken) {

                case >=2 and <= 3: Console.WriteLine("The worker is considered highly efficient."); break;
                case > 3 and <= 4: Console.WriteLine("The worker is instructed to increase their speed."); break;
                case >4 and <= 5: Console.WriteLine("The worker is provided with training to enhance their speed.");break;
                case > 5: Console.WriteLine("The worker is required to leave the company."); break;
                default: Console.WriteLine("Invalid input. Time taken should be numeric and  greater than 2 ."); break;


            }




            #endregion
        }
    }
}

