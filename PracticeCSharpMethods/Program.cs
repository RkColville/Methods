using System;

namespace PracticeCSharpMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Console.WriteLine("Give me a number to add");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to add to the first one");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"The sum is: {sum}");

            Console.WriteLine("Give me a number");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to multiply to the first one");
            num2 = int.Parse(Console.ReadLine());

            int product = Multiply(num1, num2);
            Console.WriteLine($"The product is: {product}");
        }

        public static int Sum(params int[] list)       

        {

            int sum = 0;
            for(int i = 0; i < list.Length; i++)
            {
                sum = sum + list[i];
            }
            return sum;
            
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        public static int Divide(int devi1, int devi2)
        {
            return devi1 / devi2;
        }

    }
}
