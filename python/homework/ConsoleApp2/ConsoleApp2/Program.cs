using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Show(int[] x)
        {
            for (int i = 0; i < x.Length; i++)
                Console.Write(x[i] + "  ");
            Console.WriteLine();
        }
        static bool IsSort(int[] x)
        {

        }
        static void Main(string[] args)
        {
            int[] a = new int[5] { 5121, 28795, 73, 49, 12345 };
            //                      9      31   10  13    15
            Show(a);

            Show(a);
        }
    }
}
