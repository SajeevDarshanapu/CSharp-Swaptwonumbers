using System;
namespace Hey
{
    public class Hola
    {
        public static void Main(string[] args)
        {
            int a = 2, b = 4;
            Console.WriteLine("Before Swapping a={0},b={1}",a, b);

            a = a * b;
            b = a / b;
            a = a / b;

            Console.WriteLine("After Swapping a={0},b={1}", a, b);

        }
    }
}


