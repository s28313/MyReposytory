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

        public static double average(int[] a)
        {
            double result = 0.0;

            for (int i = 0; i < a.Length; i++)
            {
                result += a[i];
            }
            result /= a.Length;
            
            return result;
        }
    }
}