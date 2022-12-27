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
            Block b1 = new Block("100");
            Block b2 = new Block("200");

            Chain c1 = new Chain();
            c1.AddBlock(b1);
            c1.AddBlock(b2);

            foreach(Block b in c1.BlockChain)
            {
                Console.WriteLine(b);
            }

            Miner m = new Miner();
            Miner m1 = new Miner();
            int a = m.Mine(b1);
            Console.WriteLine(m1.Validate(b1, a));
            Console.ReadLine();
        }
    }
}
