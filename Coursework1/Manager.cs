using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework1
{
    public class Manager
    {
        public Writer writer;
        public SuffixTree dictionary = new SuffixTree();
        public Reader reader;
        public Manager() { }
        public Manager(string directory)
        {
            reader = new Reader(directory);
        }
        public void Run()
        {
            reader.ToTree(dictionary);
        }
        public void Clean()
        {
            reader?.Clean();
        }
    }
}
