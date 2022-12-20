using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    [TestFixture]
    internal class ChainTest
    {
        [Test]
        [TestCase()]

        public void ProveraKonstruktora()
        {
            Chain c = new Chain();
            Assert.AreEqual(c.BlockChain.Count(), 0);
        }

        [Test]
        [TestCase("100", "asd")]
        
        public void ProveraDodavanja(string id, string prethodni)
        {
            Block b = new Block(id, prethodni);
            Chain c = new Chain();

            c.AddBlock(b);

            Assert.AreEqual(c.BlockChain[0].ID, id);
            Assert.AreEqual(c.BlockChain[0].Prethodni, prethodni);
        }

        [Test]
        [TestCase("100", "asd")]

        public void ProveraBrisanja(string id, string prethodni)
        {
            Block b = new Block(id, prethodni);
            Chain c = new Chain();

            c.AddBlock(b);
            c.DeleteBlock(id);

            Assert.IsEmpty(c.BlockChain);
        }
    }
}
