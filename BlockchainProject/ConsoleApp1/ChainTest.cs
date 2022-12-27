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
        [TestCase("100")]
        
        public void ProveraDodavanja(string id)
        {
            Block b = new Block(id);
            Chain c = new Chain();

            c.AddBlock(b);

            Assert.AreEqual(c.BlockChain[0].ID, id);
           
        }

        [Test]
        [TestCase("100")]

        public void ProveraBrisanja(string id)
        {
            Block b = new Block(id);
            Chain c = new Chain();

            c.AddBlock(b);
            c.DeleteBlock(id);

            Assert.IsEmpty(c.BlockChain);
        }
    }
}
