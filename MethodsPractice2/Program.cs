using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsPractice2
{
    class Program
    {
        public static string SayHello = "hello";
        public static string SayGoodbye = "goodbye";
        public static int SumIt(int firstNumber, int secondNumber, int thirdNumber, int fourthNumber)
        {
            int sum = firstNumber + secondNumber + thirdNumber + fourthNumber;
            return sum;
        }
        public static int DoubleIt(int number)
        {
            int sum = number * 2;
            return sum;
        }
        public static int SumDigits(int firstNumber, int secondNumber, int thirdNumber)
        {
            int sum = firstNumber + secondNumber + thirdNumber;
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(SayHello);
            Console.WriteLine(SayGoodbye);


            Console.WriteLine(SumIt(8, 4, 5, 6));


            Console.WriteLine(DoubleIt(5));


            int[] array = { 1, 3, 5, 7 };
        }
    }
}
