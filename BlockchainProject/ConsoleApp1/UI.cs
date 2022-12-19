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

            Chain c1 = new Chain();
            c1.AddBlock(b1);
            c1.AddBlock(b2);

            foreach(Block b in c1.BlockChain)
            {
                Console.WriteLine(b);
            }
            Console.WriteLine("Cao brate!");
            Console.ReadLine();
        }
    }
}
