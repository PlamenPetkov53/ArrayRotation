using System;
using System.Linq;

namespace arrRot
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] arr = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            
            int numberOfReverses = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfReverses; i++)
            {
                int firstNumber = arr[0];
                for (int j = 0; j < arr.Length-1; j++)
                {
                    arr[j] = arr[j + 1];

                }
                arr[arr.Length - 1] = firstNumber;

                
            }
            Console.WriteLine(String.Join(" ", arr));
            


        }
        
    }
}
