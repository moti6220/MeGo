

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Show(int[] m)
        {
            for (int i = 0; i < m.Length; i++)
                Console.Write(m[i] + "  ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] a = new int[22];
            a[0] = 20;
            a[1] = 50;
            for (int i = 2; i < a.Length; i++)
                a[i] = a[i - 1] + a[i - 2];
            Show(a);
        }
    }
}
/*

*/







//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp3
//{
//    internal class Program
//    {
//        static void Show(int[] m)
//        {
//            for (int i = 0; i < m.Length; i++)
//                Console.Write(m[i] + "  ");
//            Console.WriteLine();
//        }
//        static void Main(string[] args)
//        {
//            int[] a = new int[22];
//            //  0 1 2 3 4  5  6  7
//            //  0 1 3 6 10 15 21 28
//            a[0] = 20;
//            a[1] = 50;
//            for (int i = 2; i < a.Length; i++)
//                a[i] = a[i - 1] + a[i - 2];
//            Show(a);
//        }
//    }
//}
///*

//*/
