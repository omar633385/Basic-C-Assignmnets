namespace session_4_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            //Console.WriteLine("Enter number");
            //int input;
            //int.TryParse(Console.ReadLine(),out input);
            //for (int i = 1; i <=input ; i++)
            //{
            //    Console.WriteLine(i);
            //    
            //}
            #endregion

            #region 2- Write a program that allows the user to insert an integer then  print a multiplication table up to 12.
            //Console.WriteLine("Enter number");
            //int input;
            //int.TryParse(Console.ReadLine(), out input);
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine(i*input);

            //}

            #endregion

            #region 3- Write a program that allows to user to insert number then print all even numbers between 1 to this number
            //Console.WriteLine("Enter number");
            //int input;
            //int.TryParse(Console.ReadLine(), out input);
            //for (int i = 1; i <= input; i++)
            //{
            //    if(i%2==0)
            //        Console.WriteLine(i);

            //}

            #endregion

            #region 4- Write a program that takes two integers then prints the power.

            //Console.WriteLine("Enter two numbers");
            //int number1;
            //int.TryParse(Console.ReadLine(), out number1);
            //int number2;
            //int.TryParse(Console.ReadLine(), out number2);

            //Console.WriteLine($"{number1}^{number2}={ Math.Pow(number1, number2)}");


            #endregion

            #region 5- Write a program to enter marks of five subjects and calculate total, average and percentage.

            //Console.WriteLine("Enter Marks of five subjects");
            //int[] Marks=new int[5];
            //int sum = 0;


            //for (int i = 0; i < Marks.Length; i++)
            //{
            //   if(int.TryParse(Console.ReadLine(),out Marks[i]))
            //    {

            //    }
            //    else {
            //        Console.WriteLine("Invalid input. Please enter an integer.");
            //        i--;
            //    }
            //   sum += Marks[i];

            //}
            //Console.WriteLine($"Sum Of Marks={sum}\nAverage Of Marks={sum / Marks.Length}\nPercentage Of Marks={((double)sum/(Marks.Length))} ");


            #endregion

            #region 6- Write a program to input the month number and print the number of days in that month.

            int MonthNumber;
            Console.WriteLine("Enter Month Number");
            int.TryParse(Console.ReadLine(), out MonthNumber);
            switch (MonthNumber) {

                case 1:
                    Console.WriteLine("Days in Month :31");break;
                    case 2:
                    Console.WriteLine("Days in Month :28"); break;
                    case 3:
                    Console.WriteLine("Days in Month :31");break ;
                    case 4:
                    Console.WriteLine("Days in Month :30"); break ;
                    case 5:
                    Console.WriteLine("Days in Month :31"); break;
                case 6:
                    Console.WriteLine("Days in Month :30"); break;
                    case 7:
                    Console.WriteLine("Days in Month :31"); break;
                    case 8:
                    Console.WriteLine("Days in Month :31"); break;
                    case 9:
                    Console.WriteLine("Days in Month :30"); break;
                    case 10:
                    Console.WriteLine("Days in Month : 31"); break;
                    case 11:
                    Console.WriteLine("Days in Month :30"); break;
                    case 12:
                    Console.WriteLine("Days in Month :31"); break;
                default:
                    Console.WriteLine("Invalid Input Month Number is in range (1-12)");
                    break;


            }

            #endregion
        }
    }
}
