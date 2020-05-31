using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm.Tests
{
    public class Node
    {
        public char letter { get; }
        public int Index { get; set; }
        public Node NextNode { get; set; }
        public Node ChildNode { get; set; } 

        public Node(char item, int index)
        {
            Index = index;
            letter = item;
         
        }
    }
    public class Trie
    {
        Dictionary<char, Node> ParentNode = new Dictionary<char, Node>();
        public void AddItem(char item)
        {
            if(ParentNode.Any(a => a.Key == item))
            ParentNode.Add(item,new Node(item, 0));
        }
    }
}
