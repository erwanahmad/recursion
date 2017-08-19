using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1234;
            int a = n;
            Console.WriteLine(CountBits(n));
            Console.WriteLine(CountBits(a));
        }
        public static int CountBits(int n )
        {
            return Convert.ToString(n, 2).Count(x => x == '1');

        } 
    }
    
}
//static void Main(string[] args)
//{
//    for (int i = 1; i <= 20; i++)
//    {
//        Console.Write(fibonacci(i) + " ");
//    }
//}
//public static int fibonacci(int angka)
//{
//    if (angka <= 1)
//    {
//        return angka;
//    }
//    else
//    {
//        return (fibonacci(angka - 1) + fibonacci(angka - 2));
//    }
//}

//public static int Fibonacci(int n)
//    {
//        int a = 1;
//        int b = 1;
//        for (int i = 0; i < n; i++)
//        {
//            int temp = a;
//            a = b;
//            b = temp + b;
//        }
//        return a;
//    }

//    static void Main()
//    {
//        for (int i = 0; i < 15; i++)
//        {
//            Console.Write(Fibonacci(i) + " ");
//        }
//    }

//static void Main(string[] args)
//{
//    int[] angka = { 1, 3, 5, 7 };
//    Console.WriteLine(angka);
//}
//public static int jumlah(int angka)
//{
//    if (angka <= 1)
//    {
//        return angka;
//    }
//    else
//    {
//        return (angka + (angka + 1));
//    }

//}

//static void Main(string[] args)
//{
//    int[] angka = { 1, 3, 5, 7 };
//    Console.WriteLine(hitung(angka, 0));
//}
//public static int hitung(int[] angka, int counter)
//{
//    if (counter == angka.Length)
//    {
//        return 0;
//    }
//    else
//    {
//        return angka[counter] + hitung(angka, counter + 1);
//    }
//}