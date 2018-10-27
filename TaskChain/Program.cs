using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskChain
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Chain.GetMaximumLength(new int[] { 1,2,3,4,0,6,7,5}));
            Console.ReadKey();
        }
    }
}
