namespace session06_assignment
{
    internal class Program
    {
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




        }



    }
}

        

