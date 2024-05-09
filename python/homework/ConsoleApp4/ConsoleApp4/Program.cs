using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void what(int[] arr, int num)
            {
                int left = 0;
                int right = arr.length - 1;
                while (left != right)
                {
                    if (arr[left] < num)
                        left++;
                    else
                    if (arr[right] > num)
                        right--;
                    else
                    {
                        int temp = arr[left];
                        arr[left] = arr[right];
                        arr[right] = temp;
                    }
                }
            }
        }
    }
}
