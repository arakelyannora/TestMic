using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test3
{
    class Program
    {
        static void print(int[,] array)
        {
            Console.WriteLine("Array");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                
                    Console.Write(array[i, j] + " ");               
                    Console.WriteLine();
            }
        }
        static int maxIndex(int[,] array,ref int row,ref int column)
        {           
            int max = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                        row = i;
                        column = j;
                    }
                }
            }
            return max;  
        }

        static void Main(string[] args)
        {
            while (true)
            {
                int rows, columns;
                Random rand = new Random();
                Console.Write("Rows: ");
                bool result = int.TryParse(Console.ReadLine(), out rows);
                Console.Write("Columns: ");
                bool result1 = int.TryParse(Console.ReadLine(), out columns);
                if (!result || !result1)
                {
                    Console.WriteLine("Enter only numbers!");
                }
                else
                {
                    int[,] array = new int[rows, columns];
                    for (int i = 0; i < array.GetLength(0); i++)
                    {
                        for (int j = 0; j < array.GetLength(1); j++)
                            array[i, j] = rand.Next() % 100;
                    }

                    int maxI = 0, maxJ = 0;
                    print(array);
                    int max = maxIndex(array, ref maxI, ref maxJ);
                    Console.WriteLine($"Max = {max}, Maxi ={maxI}, MaxJ = {maxJ}");
                    array[maxI, maxJ] = array[0, 0];
                    Console.Write("Changed ");
                    print(array);

                }
            }
        }
    }
}
