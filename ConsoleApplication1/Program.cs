using System;
using System.Security.AccessControl;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {   
            Console.WriteLine("Moddyfikacja 3");
            
        }

        public static double average(int[] arr)
        {
            double result = 0.0;

            for (int i = 0; i < arr.Length; i++)
            {
                result += arr[i];
            }
            result /= arr.Length;
            
            return result;
        }
    }
}