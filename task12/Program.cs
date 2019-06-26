using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task12
{
    class Program
    {   
        static void Main(string[] args)
        {
            Console.WriteLine("Задача №12. (10, 5)\n" +
                "Сравнить сортировку Шелла с сортировкой двоичным деревом\n");

            Random rnd = new Random();
            int[] array = new int[50];
            int[] arraySorted = new int[50];
            int[] arrayReverseSorted = new int[50];
            int[] array2 = new int[50];
            int[] arraySorted2 = new int[50];
            int[] arrayReverseSorted2 = new int[50];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 20);
                arraySorted[i] = array[i];
                arrayReverseSorted[i] = array[i];
                array2[i] = array[i];
                arraySorted2[i] = array[i];
                arrayReverseSorted2[i] = array[i];
                Console.Write(array[i] + " ");
            }


            Console.WriteLine();
            Array.Sort(arraySorted);
            Array.Sort(arrayReverseSorted);
            arrayReverseSorted.Reverse();

            Array.Sort(arraySorted2);
            Array.Sort(arrayReverseSorted2);
            arrayReverseSorted2.Reverse();
            Stopwatch w = new Stopwatch();

            //Первое создание обьекта для корректной работы подсчета времени
            w.Start();
            TreeSort sorter = new TreeSort(new int[10]); 
            w.Stop();
            w.Reset();


            w.Start();
            TreeSort tree = new TreeSort(array);
            w.Stop();
            long timeTree = w.Elapsed.Ticks;
            w.Reset();
        
            w.Start();
            TreeSort tree2 = new TreeSort(arraySorted);
            w.Stop();
            long timeTree2 = w.Elapsed.Ticks;
            w.Reset();

            w.Start();
            TreeSort tree3 = new TreeSort(arrayReverseSorted);
            w.Stop();
            long timeTree3 = w.Elapsed.Ticks;
            w.Reset();



            ShellSort shell = new ShellSort();

            //Первое создание обьекта для корректной работы подсчета времени
            w.Start();
            shell.Sort(new int[10]);
            w.Stop();
            w.Reset();


            w.Start();
            shell.Sort(array2);
            w.Stop();
            long timeShell = w.Elapsed.Ticks;
            w.Reset();

            ShellSort shell2 = new ShellSort();
            w.Start();
            shell.Sort(arraySorted2);
            w.Stop();
            long timeShell2 = w.Elapsed.Ticks;
            w.Reset();

            ShellSort shell3 = new ShellSort();
            w.Start();
            shell.Sort(arrayReverseSorted2);
            w.Stop();
            long timeShell3 = w.Elapsed.Ticks;
            w.Reset();


            Console.WriteLine("Массив, отсортированный бинарной сортировкой: " + tree);
            Console.Write("Массив, отсортированный сортировкой Шелла:    ");
            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write(array2[i] + " ");
            }
            Console.Write("\n");
            Console.WriteLine($"\nБинарная сортировка обычного массива \nКоличество сравнений: {tree.Comparisons}\n" +
                $"Количество перемещений: {tree.Moves}\nВремя поиска: {timeTree}");
            Console.WriteLine($"\nБинарная сортировка отсортированного массива \nКоличество сравнений: {tree.Comparisons}\n" +
                $"Количество перемещений: {tree.Moves}\nВремя поиска: {timeTree2}");
            Console.WriteLine($"\nБинарная сортировка отсортированного в обратном порядке массива\nКоличество сравнений: {tree.Comparisons}\n" +
                 $"Количество перемещений: {tree.Moves}\nВремя поиска: {timeTree3}");

            Console.WriteLine($"\nСортировка Шелла обычного массива\nКоличество сравнений: {shell.Comparisons}\n" +
                $"Количество перемещений: {shell.Moves}\nВремя поиска: {timeShell}");
            Console.WriteLine($"\nСортировка Шелла отсортированного массива\nКоличество сравнений: {shell.Comparisons}\n" +
                $"Количество перемещений: {shell.Moves}\nВремя поиска: {timeShell2}");
            Console.WriteLine($"\nСортировка Шелла отсортированного в обратном порядке массива\nКоличество сравнений: {shell.Comparisons}\n" +
                $"Количество перемещений: {shell.Moves}\nВремя поиска: {timeShell3}");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
