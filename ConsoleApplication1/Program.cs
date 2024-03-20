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

        public static double max(int[] arr)
        {
            int result = 0;
            
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > result) result = arr[i];
            }
            
            return result;
        }
    }
}