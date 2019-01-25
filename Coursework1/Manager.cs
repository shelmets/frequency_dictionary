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
        public Manager(string directory)
        {
            reader = new Reader(directory);
        }
        public async Task<Dictionary<string, uint>> Run()
        {
            await Task.Run(() => reader.ToTree(dictionary));
            return await Task.Run(() => dictionary.Export());
        }
        public void Clean()
        {
            reader?.Clean();
        }
    }
}
