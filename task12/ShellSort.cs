using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task12
{
    class ShellSort
    {
        public int Moves { get; private set; } = 0;
        public int Comparisons { get; private set; } = 0;
        public void Sort(int[] array)
        {
            int temp;
            for (int step = array.Length / 2; step > 0; step /= 2)
            {
                for (int i = step; i < array.Length; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Comparisons++;
                        if (array[j] > array[i])
                        {
                            Moves++;
                            temp = array[j];
                            array[j] = array[i];
                            array[i] = temp;
                        }

                    }

                }
            }
        }
    }
}
