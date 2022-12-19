using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Chain
    {
        private List<Block> blockchain;


        public Chain()
        {
            blockchain = new List<Block>();

        }

        public List<Block> BlockChain
        {
            get { return blockchain;  }
        }
        public void AddBlock(Block b)
        {
            blockchain.Add(b);
        }

        public bool DeleteBlock(string id)
        {
            Block toBeDeleted = new Block(); ;
            foreach(Block b in blockchain)
            {
                if(b.ID == id)
                {
                    toBeDeleted = b;
                    break;
                }
            }
            if(toBeDeleted != null)
            {
                blockchain.Remove(toBeDeleted);
                return true;
            }

            return false;
        }
    }
}
