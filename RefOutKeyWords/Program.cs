using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOutKeyWords
{
    class Program
    {
        static void Main(string[] args)
        {
            int reqem1 = 12;
            int reqem2 = 5;
            int reqem3;
            Console.WriteLine("-------REF-------");
            Console.WriteLine(multiply(ref reqem1, reqem2)); //burda ref vermesek asagida ekrana verdiyimiz reqem1=12 olar.
            Console.WriteLine(reqem1);
            Console.WriteLine("-------OUT-------");
            Console.WriteLine(multiply2(out reqem3, reqem2)); // outda refle eynidir sadece tek ferqi reqem3-u tanidan zaman baslangic reqem vermesenizde isliyecek.
            Console.WriteLine(reqem3);
            Console.ReadKey();

        }

        public static int multiply(ref int reqem1, int reqem2)
        {
            reqem1 = 10;
            return reqem1 * reqem2;
        }

        public static int multiply2(out int reqem3, int reqem2)
        {
            reqem3 = 13;
            return reqem3 * reqem2;
        }
    }
}
