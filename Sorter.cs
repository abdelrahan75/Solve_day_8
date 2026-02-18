using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solve_task_8
{
    class Sorter
    {
        public static void SelectionSort(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int minIdx = i;
                for (int j = i + 1; j < numbers.Length; j++)
                    if (numbers[j] < numbers[minIdx]) minIdx = j;

                int temp = numbers[minIdx];
                numbers[minIdx] = numbers[i];
                numbers[i] = temp;
            }
        }
    }
    }
