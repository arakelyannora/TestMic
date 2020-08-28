using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    class Program
    {
        static Random rand = new Random();
        
        static bool EndWithZero(int n) => n % 10 == 0;
       
        static string newNumber()
        {
            string NewNumber=null;
            double n = 0;
            int r = rand.Next();
            for (int i = 0; i < 6; i++)
            {
                r = rand.Next();
                while (EndWithZero(r))
                    r = rand.Next();
                n += (r % 10) * Math.Pow(10, i);
            }
            NewNumber = n.ToString();
            return NewNumber;
        }
        static void fcn(string[] numbers, string code)
        {
            string format = "+374 - ";
            for (int i = 0; i < numbers.Length; i++)
            {
                string newnumber = newNumber();
                numbers[i] = format + code + newnumber;
            }

        }
        static void print(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);
        }
        static void Main(string[] args)
        {
          
            Console.Write("Enter count of numbers ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter code: 93,91,55,95,41");
            string code = Console.ReadLine();          
            string[] numbers = new string[n];
    
            switch (code)
            {
                case "93":
                    fcn(numbers, code);
                    print(numbers);
                    break;
                case "91":
                    fcn(numbers, code);
                    print(numbers);
                    break;
                case "55":
                    fcn(numbers, code);
                    print(numbers);
                    break;
                case "95":
                    fcn(numbers, code);
                    print(numbers);
                    break;
                case "41":
                    fcn(numbers, code);
                    print(numbers);
                    break;
                default:
                    Console.WriteLine("There's no such a code!");
                    break;
            }
           
        }
    }
}
