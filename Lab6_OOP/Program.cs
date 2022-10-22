using System;
using MyList;

namespace Lab6_OOP
{
    public class Program
    {
        static readonly int?[] arr = new int?[100];
        static void Main(string[] _)
        {
            Task1();
            Task2();
            Indiv();
        }
        static void Task1()
        {
            Console.Write("число N ");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                arr[i] = null;
                arr[new Random().Next(arr.Length)] = i;
            }
            Print(arr);
        }
        static void Task2()
        {
            QuickSort(arr, 0, arr.Length - 1);
            Array.Reverse(arr);
            Print(arr);
            Console.WriteLine();
        }
        static private void QuickSort(int?[] arr, int begin, int end)
        {
            if (end < 0)
                end = arr.Length - 1;
            if (begin >= end)
                return;
            int middleIndex = (end - begin) / 2 + begin, currentIndex = begin;
            Swap(arr, begin, middleIndex);
            for (int i = begin + 1; i <= end; ++i)
            {
                if (arr[i] <= arr[begin] || arr[i] == null)
                {
                    currentIndex++;
                    Swap(arr, currentIndex, i);
                }
            }
            Swap(arr, begin, currentIndex);
            QuickSort(arr, begin, currentIndex - 1);
            QuickSort(arr, currentIndex + 1, end);
        }
        static private void Swap(int?[] arr, int i, int j)
        {
            (arr[j], arr[i]) = (arr[i], arr[j]);
        }
        static private void Print(int?[] arr)
        {
            for(int i = 0; i < arr.Length; ++i)
            {
                if (i % 10 == 0) Console.WriteLine();
                if (arr[i] == null) Console.Write("null ");
                else Console.Write(String.Format("{0,-5:D}",arr[i]));
            }
            Console.WriteLine();
        }
        static private void Indiv()
        {
            ListQueue listQueue = new();
            listQueue.Add(new Person("Андреев", "Алексей", "Даниилович"));
            listQueue.Add(new Person("Степанов", "Иван", "Павлович"));
            listQueue.Add(new Person("Платонова", "Марьям", "Максимовна"));
            listQueue.Add(new Person("Федоров", "Всеволод", "Кириллович"));
            listQueue.Add(new Person("Муравьев", "Роман", "Сергеевич"));
            listQueue.Add(new Person("Макаров", "Мирослав", "Артемьевич"));
            listQueue.Add(new Person("Фомина", "Серафима", "Германовна"));
            listQueue.Add(new Person("Казаков", "Иван", "Кириллович"));
            listQueue.Add(new Person("Цветков", "Билал", "Михайлович"));
            listQueue.Add(new Person("Попова", "Александра", "Фёдоровна"));
            listQueue.Add(new Person("Вдовина", "Екатерина", "Семёновна"));
            listQueue.Add(new Person("Петрова", "Диана", "Ивановна"));
            listQueue.Add(new Person("Федоров", "Всеволод", "Кириллович"));
            listQueue.Add(new Person("Копылова", "Ева", "Юрьевна"));

            listQueue.GetMassive();

            listQueue.Null(3);
            listQueue.Null(5);
            listQueue.Null(6);
            listQueue.Null(2);
            listQueue.Null(7);
            listQueue.Null(20);
            listQueue.Get(20);

            listQueue.Print();

            listQueue.Add(new Person("dfg", "zxcv", "dsf"));
            listQueue.Add(new Person("dfg", "zxcv", "dsf"));
            listQueue.Add(new Person("dfg", "zxcv", "dsf"));
            listQueue.Add(new Person("dfg", "zxcv", "dsf"));
            listQueue.Add(new Person("dfg", "zxcv", "dsf"));
            listQueue.Add(new Person("dfg", "zxcv", "dsf"));
            listQueue.Add(new Person("dfg", "zxcv", "dsf"));

            listQueue.Print();

            Console.ReadKey();
            Console.Clear();
        }
    }
}