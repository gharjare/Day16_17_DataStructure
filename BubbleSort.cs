using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStrucureAlgorithm
{
    public class BubbleSort
    {
        public  void Display()
        {
            int[] arr = { 78, 56, 45, 98, 13 };
            int temp;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            Console.WriteLine("sorted Array: ");
            foreach (int p in arr)
            {
                Console.WriteLine(p + " ");
            }
        }
    }
}
