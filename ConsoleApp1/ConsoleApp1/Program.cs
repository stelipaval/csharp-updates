// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            long bignumber = 8000000000L;
            Console.WriteLine(bignumber);
            Console.WriteLine(long.MaxValue);

            Console.ReadLine();
        }
    }
}