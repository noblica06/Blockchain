using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Block
    {
        private string id;
        private string prethodni;


        public Block()
        {
            id = String.Empty;
            prethodni = String.Empty;
        }
        public Block(string id, string prethodni)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(id);
            SHA256Managed hashstring = new SHA256Managed();
            byte[] hash = hashstring.ComputeHash(bytes);
            foreach(byte b in hash)
            {
                ID += String.Format("{0:x2}", b);
            }
            Prethodni = prethodni;
        }
        public string ID
        {
            get { return id; }
            set { id = value;  }
        }

        public string Prethodni
        {
            get { return prethodni;  }
            set { prethodni = value;  }
        }

        public override string ToString()
        {
            return ID + "\n" + "Prethodni: " + Prethodni + "\n";
        }
    }
}
