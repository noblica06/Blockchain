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
            Block b2 = new Block("200", b1.ID);


            Console.WriteLine(b1);
            Console.WriteLine(b2);
            Console.ReadLine();
        }
    }
}
