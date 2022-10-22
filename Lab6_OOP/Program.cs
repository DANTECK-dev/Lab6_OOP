using System;

namespace Lab6_OOP
{
    public class Program
    {
        static int?[] arr = new int?[100];
        static void Main(string[] _)
        {
            Task1();
            Task2();
        }
        static void Task1()
        {
            Random rand = new Random();
            int? k = null;
            Console.Write("число N ");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                arr[i] = null;
                arr[rand.Next(arr.Length)] = i;
            }
            foreach(var x in arr)
            {
                if(x == null) Console.Write("null ");
                Console.Write(x + " ");
            }
        }
        static void Task2()
        {
            int? p = arr[arr.Length / 2];
            int i = 0;
            int j = arr.Length - 1;
            
        }
        private void quickSort(int?[] massive, int begin, int end)
        {

        }
    }
}