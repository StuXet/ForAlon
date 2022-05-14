using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Stage_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrintReverseArray();
            //ReturnReverseArray();
            //ReturnReverseArraySimple();
            Fibonacci();
        }

        //1.1
        public static void PrintReverseArray()
        {
            int[] inputArray = new int[10];
            Console.WriteLine("\n\nPlease Input 10 elements of an array that you want to print:");
            Console.WriteLine("-----------------------------------------");

            for (int i = 0; i < 10; i++)
            {
                Console.Write("element - {0} : ", i);
                inputArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nElements in array are: ");

            int[] reverse = Enumerable.Reverse(inputArray).ToArray();
            Console.WriteLine(String.Join(",", reverse));
        }

        //1.2
        private static void swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
        public static int[] ReturnReverseArray()
        {
            int[] inputArray = new int[10];
            Console.WriteLine("\n\nPlease Input 10 elements of an array that you want to print:");
            Console.WriteLine("-----------------------------------------");

            for (int i = 0; i < 10; i++)
            {
                Console.Write("element - {0} : ", i);
                inputArray[i] = int.Parse(Console.ReadLine());
            }

            int n = inputArray.Length;
            for (int j = 0; j < n/2; j++)
            {
                swap(inputArray, j, n - j - 1);
            }

            return inputArray;
        }



        //1.3
        

        //1.4
        public static int[] ReturnReverseArraySimple()
        {
            int[] inputArray = new int[10];

            Console.WriteLine("\n\nPlease Input 10 elements of an array that you want to print:");
            Console.WriteLine("-----------------------------------------");

            for (int i = 0; i < 10; i++)
            {
                Console.Write("element - {0} : ", i);
                inputArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Reverse(inputArray);
            return inputArray;
        }
        

        // 6
        //Some black magic @_@
        public static void Fibonacci()
        {
            int a = 0, b = 1, c = 0, len;

            Console.WriteLine("Enter Range: ");
            len = int.Parse(Console.ReadLine());

            Console.Write("{0} {1}", a, b);
            for (int i = 2; i < len; i++)
            {
                c = a + b;
                Console.Write(" {0}", c);
                a = b;
                b = c;
            }
            Console.WriteLine();
        }

    }
}
