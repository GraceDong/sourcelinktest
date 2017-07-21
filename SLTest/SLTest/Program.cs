using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SLTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int para = 1;
            while (true)
            {
                para++;
                Console.WriteLine(para);
                Thread.Sleep(500);
            }

        }
    }
}
