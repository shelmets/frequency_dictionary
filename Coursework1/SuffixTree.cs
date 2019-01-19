using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework1
{
    public class SuffixTree
    {
        class Node
        {
            public char Char;
            public uint Count;
            public List<Node> Childs { get; }
            public Node(char Ch)
            {
                Char = Ch;
                Childs = new List<Node>();
            }
            public override string ToString()
            {
                return Char + "(" + Childs.Count + ")";
            }
        }
        Node Root = new Node('\0');
        public uint DifferentWords { get; private set; } = 0;
        public uint All { get; private set; } = 0;
        public SuffixTree()
        { }
        public void AddWord(string word)
        {
            All++;
            Node Current = Root;
            var NotInitialized = false;
            for (int i = word.Length - 1; i >= 0; i--)
            {
                if (NotInitialized)
                {
                    var New = new Node(word[i]);
                    Current.Childs.Add(New);
                    Current = New;
                }
                else
                {
                    if (!Current.Childs.Exists(n => n.Char == word[i]))
                    {
                        NotInitialized = true;
                        var New = new Node(word[i]);
                        Current.Childs.Add(New);
                        Current = New;
                    }
                    else
                    {
                        Current = Current.Childs.Find(n => n.Char == word[i]);
                    }
                }
            }
            if (Current.Count == 0)
                DifferentWords++;
            Current.Count++;
        }
        void _Export(Dictionary<string,uint> Result, string Word, Node current)
        {
            Node Current = current;
            foreach (var Child in Current.Childs)
            {
                if (Child.Count > 0)
                    Result.Add(Child.Char + Word, Child.Count);

                if (Child.Childs.Count > 0)
                    _Export(Result, Child.Char + Word, Child);
            }
        }
        public Dictionary<string,uint> Export()
        {
            var Result = new Dictionary<string, uint>();
            _Export(Result, string.Empty, Root);
            return Result;
        }
        public void AddLine(string s)
        {
            string buff = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsLetter(s[i]))
                {
                    buff = buff + s[i];
                    if (i == s.Length - 1)
                    {
                        this.AddWord(buff);
                        break;
                    }
                    continue;
                }
                if (buff != "")
                {
                    this.AddWord(buff);
                }
                buff = "";
            }
        }
    }
}
