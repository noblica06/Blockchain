using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class UI
    {
        static void Main (string[] args)
        {
            Block b1 = new Block("100", null);

            Console.WriteLine(b1);
            Console.ReadLine();
        }
    }
}
