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
            Console.WriteLine("Enter number : ");
            int number;
            int.TryParse(Console.ReadLine(), out number);
            if (number >0)
                Console.WriteLine("Postive");
            else
                Console.WriteLine("Negative");



            #endregion
        }
    }
}
