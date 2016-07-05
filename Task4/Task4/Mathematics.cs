using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Task4
{
    public class Mathematics
    {
        public BigInteger ProdTree(int l, int r)
        {
            if (l > r)
                return 1;
            if (l == r)
                return l;
            if (r - l == 1)
                return (BigInteger)l * r;
            int m = (l + r) / 2;
            return ProdTree(l, m) * ProdTree(m + 1, r);
        }

        public BigInteger? Factorial(int n)
        {
            if (n < 0)
                return null;
            if (n == 0)
                return 1;
            if (n == 1 || n == 2)
                return n;
            return ProdTree(2, n);
        }

        //public static BigInteger Fibonacci(int n) // work only for n > 0
        //{
        //    BigInteger a = BigInteger.Zero;
        //    BigInteger b = BigInteger.One;
        //    for (int i = 31; i >= 0; i--)
        //    {
        //        BigInteger d = a * (b * 2 - a);
        //        BigInteger e = a * a + b * b;
        //        a = d;
        //        b = e;
        //        if ((((uint)n >> i) & 1) != 0)
        //        {
        //            BigInteger c = a + b;
        //            a = b;
        //            b = c;
        //        }
        //    }
        //    return a;
        //}

        public double Fibonacci(int n)
        {
            double fi = (1 + Math.Sqrt(5)) / 2;
            double fiN = Math.Pow(fi, n);
            return (1 / Math.Sqrt(5)) * (fiN - Math.Cos(Math.PI * n) / fiN);
        }
    }
}
