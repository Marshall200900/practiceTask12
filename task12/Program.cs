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
            Random rnd = new Random();
            int[] array = new int[10];
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 20);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            Stopwatch w = new Stopwatch();

            w.Start();
            TreeSort tree = new TreeSort(array);
            w.Stop();
            long timeTree = w.Elapsed.Ticks;
            w.Reset();

            Console.WriteLine("Массив, отсортированный бинарной сортировкой: "+tree);

            ShellSort shell = new ShellSort();
            w.Start();
            shell.Sort(array);
            w.Stop();
            long timeShell = w.Elapsed.Ticks;

            Console.Write("Массив, отсортированный сортировкой Шелла: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.Write("\n");
            Console.WriteLine($"\nБинарная сортировка\nКоличество сравнений: {tree.Comparisons}\n" +
                $"Количество перемещений: {tree.Moves}\nВремя поиска: {timeTree}");
            Console.WriteLine($"\nСортировка Шелла\nКоличество сравнений: {shell.Comparisons}\n" +
                $"Количество перемещений: {shell.Moves}\nВремя поиска: {timeShell}");

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
