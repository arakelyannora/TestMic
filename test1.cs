using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static bool IsPrime(int number)
        {
            if (number == 0 || number == 1)
                return false;
            bool prime = true;
            for (int j = 2; j <= number / 2; j++)
            {
                if (number % j == 0)
                    prime = false;
            }
            return prime;
        }
        static int maxMember(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            return max;
        }
        static int PrimeCount(int[] arr)
        {
            int primeCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (IsPrime(arr[i]))
                    primeCount++;
            }
            return primeCount;
        }
        static int[] PrimeArray(int[] arr, int length)
        {
            int[] primeArray = new int[length];
            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (IsPrime(arr[i]))
                {
                    primeArray[j++] = arr[i];
                }
            }
            return primeArray;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter the size of array.");
                int n;
                bool result = int.TryParse(Console.ReadLine(), out n);

                if (!result)
                    Console.WriteLine("Please enter only integer.");
                else
                {
                    int[] array = new int[n];
                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.Write($"array[{i}] = ");
                        array[i] = int.Parse(Console.ReadLine());
                    }

                    int primeCount = PrimeCount(array);
                    int[] primeArray = PrimeArray(array, primeCount);

                    Console.WriteLine("Prime Array:");
                    for (int i = 0; i < primeArray.Length; i++)
                        Console.WriteLine(primeArray[i] + " ");
                    Console.WriteLine();

                    if (primeCount == 0)
                        Console.WriteLine($"Maximum element is {maxMember(array)} ");
                    else
                    {
                        Console.WriteLine($"Maximum prime element is {maxMember(primeArray)} ");
                    }


                }


            }
        }
    }
}

