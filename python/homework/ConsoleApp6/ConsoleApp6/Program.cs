//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp6
//{
//    internal class Program
//    {
//        static void show(int[] x)
//        {
//            for (int i = 0; i < x.Length; i++)
//                Console.Write(x[i] + " ");
//            Console.WriteLine();
//        }
//        static int[] F(int[] a, int[] b)
//        {
//            int[] c = new int[a.Length + b.Length];
//            for (int i = 0; i < a.Length; i++)
//            {
//                c[i * 2] = a[i];
//                c[i * 2 + 1] = b[i];
//            }
//            return c;
//        }
//         static void Main(string[] args)
//         {
//            // a 1 2 3 4 5
//            // b 99 88 77 66 55
//            // c 1 99 2 88 3 77 4 66 5 55
//            int[] a = new int[5] { 1, 2, 3, 4, 5 };
//            show(a);
//            int[] b = new int[5] { 99, 88, 77, 66, 55 };
//            show(b);
//            int[] r = F(a, b);
//            show(r);
//        }
//    }
//}









//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp6
//{
//    internal class Program
//    {
//        static void show(int[] x)
//        {
//            for (int i = 0; i < x.Length; i++)
//                Console.Write(x[i] + " ");
//            Console.WriteLine();
//        }
//        static void Main(string[] args)
//        {
//            // a 1 2 3 4 5
//            // b 99 88 77 66 55
//            // c 1 99 2 88 3 77 4 66 5 55
//            int[] a = new int[5] { 1, 2, 3, 4, 5 };
//            show(a);
//            int[] b = new int[5] { 99, 88, 77, 66, 55 };
//            show(b);
//            int[] c = new int[a.Length + b.Length];
//            for (int i = 0; i < a.Length; i++)
//            {
//                c[i*2] = a[i];
//                c[i*2+1] = b[i];
//            }
//            show(c);
//        }
//    }
//}












//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp6
//{
//    internal class Program
//    {
//        static void show(int[] x)
//        {
//            for (int i = 0; i < x.Length; i++)
//                Console.Write(x[i] + " ");
//            Console.WriteLine();
//        }
//        static void Main(string[] args)
//        {
//            // a 1 2 3 4 5
//            // b 99 88 77 66 55
//            // c 1 2 3 4 5 55 66 77 88 99
//            int[] a = new int[5] { 1, 2, 3, 4, 5 };
//            show(a);
//            int[] b = new int[5] { 99, 88, 77, 66, 55 };
//            show(b);
//            int[] c = new int[a.Length + b.Length];
//            for (int i = 0; i < a.Length; i++)
//            {
//                c[i] = a[i];
//                c[i + a.Length] = b[a.Length - 1 - i];
//                c[c.Length - 1 - i] = b[i];
//            }
//            show(c);
//        }
//    }
//}











//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp6
//{
//    internal class Program
//    {
//        static void show(int[] x)
//        {
//            for (int i = 0; i < x.Length; i++)
//                Console.Write(x[i] + " ");
//            Console.WriteLine();
//        }
//        static void Main(string[] args)
//        {
//            // a 1 2 3 4 5
//            // b 99 88 77 66 55
//            // c 1 2 3 4 5 99 88 77 66 55
//            int[] a = new int[5] { 1, 2, 3, 4, 5 };
//            show(a);
//            int[] b = new int[5] { 99, 88, 77, 66, 55 };
//            show(b);
//            int[] c = new int[a.Length + b.Length];
//            for (int i = 0; i < a.Length; i++)
//            {
//                c[i] = a[i];
//                c[i + a.Length] = b[i];
//            }
//            show(c);
//        }
//    }
//}










//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp6
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int x = 66;
//            while (x > 22)
//            {
//                Console.WriteLine(x);
//                x = x - 20;
//            }
//            Console.WriteLine(x);
//        }
//    }
//}









//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp6
//{
//    internal class Program
//    {
//        static void show(int[] x)
//        {
//            for (int i = 0; i < x.Length; i++)
//                Console.Write(x[i] + " ");
//            Console.WriteLine();
//        }

//        static void Main(string[] args)
//        {
//            // a 1 2 3 4 5
//            // b 99 88 77 66 55
//            // c 1 2 3 4 5 55 66 77 88 99
//            int[] a = new int[5] { 1, 2, 3, 4, 5 };
//            show(a);
//            int[] b = new int[5] { 99, 88, 77, 66, 55 };
//            show(b);
//            int[] c = new int[a.Length + b.Length];
//            for (int i = 0; i < a.Length; i++)
//            {
//                c[i] = a[i];
//                c[i + a.Length] = b[i];
//                c[c.Length - 1 - i] = b[i];
//            }
//            show(c);
//        }
//    }
//}








//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp6
//{     
//    internal class Program
//    {
//    static void show(int[] x)
//    {
//        for (int i= 0; i < x.Length; i++)
//            Console.Write(x[i] + " ");
//        Console.WriteLine();
//    }
//        static void Main(string[] args)
//        {
//            // a 1 2 3 4 5
//            // b 99 88 77 66 55
//            // c 1 2 3 4 5 55 66 77 88 99
//            int[] a = new int[5] { 1, 2, 3, 4, 5};
//            show(a);
//            int[] b = new int[5] { 99, 88, 77, 66, 55 };
//            show(b);
//            int[] c = new int[a.Length + b.Length];
//            for (int i = 0; i < a.Length; i++)
//            {
//                c[i] = a[i];
//                c[i + a.Length] = b[a.Length - 1 - i];
//                c[c.Length - 1 - i] = b[i];
//            }
//            show(c);
//        }
//    }
//}
