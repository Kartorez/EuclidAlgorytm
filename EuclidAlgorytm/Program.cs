using System;
using System.Text;

namespace EuclidAlgorytm
{
    internal class Program
    {
        static int EuclidAlgorytm(int r1, int r2) {

            while (r2 !=0) { 
            int temp = r2;
                r2 = r1%r2;
                r1 = temp;
            }

            return r1;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введіть два числа:");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int result = EuclidAlgorytm(num1, num2);

            Console.WriteLine($"НСД чисел {num1} і {num2} дорівнює: {result}");
        }
    }
}
