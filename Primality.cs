using System;

namespace Primality
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < p; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                if (IsPrime(n))
                    Console.WriteLine("Prime");
                else Console.WriteLine("Not prime");
            }
        }
        public static bool IsPrime(int a)
        {
            if (a == 2)
                return true;
            int sqrt = (int)Math.Sqrt(a);
            for (int i = 2; i < sqrt + 1; i++)
            {
                if (a % i == 0 || a == 1)
                    return false;
            }
            return true;
        }
    }
}
