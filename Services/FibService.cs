using System;
using System.Collections.Generic;
using System.Linq;
using dotnet.Interfaces;

namespace dotnet.Services
{
    public class FibService : IFibService
    {
        double phi = (1 + Math.Sqrt(5)) / 2; 
        // Slow but uses enumerable so that's cool init
        public long GetFibN(int n)
        {
            var iter = GetFibonacci();
            
            // This looks strange, but the enumerator returns value 1 as value 3 because it
            // starts with fib 1 and 2 pre defined. Such is life!
            return iter.ElementAt(n - 2);
        }

        // Fun maths is fun!
        public long GetFibNFast(int n)
        {
            return (long) Math.Round(Math.Pow(phi, n) / Math.Sqrt(5));
        }

        private IEnumerable<long> GetFibonacci()
        {
            long previousVal1 = 0;
            long previousVal2 = 1;

            while (true)
            {
                long nextVal = previousVal1 + previousVal2;
                previousVal1 = previousVal2;
                previousVal2 = nextVal;
                yield return nextVal;
            }
        }
    }
}