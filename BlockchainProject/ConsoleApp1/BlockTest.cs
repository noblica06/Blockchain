using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    [TestFixture]
    internal class BlockTest
    {
        [Test]
        [TestCase("100", "a")]
        public void DobriParamteri(string id, string prethodni)
        {
            Block b = new Block(id, prethodni);
            Assert.AreEqual(b.ID, id);
            Assert.AreEqual(b.Prethodni, prethodni);

        }

        [Test]
        [TestCase(null, "1000")]
        public void TestPada(string id, string prethodni)
        {

            Assert.Throws<ArgumentNullException>(
                () =>
                {
                    Block b = new Block(id, prethodni);
                });
        }
    }
}
