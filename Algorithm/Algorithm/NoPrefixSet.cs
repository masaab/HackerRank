using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm
{
    public class Node
    {
        public char letter { get; }
        public int Index { get; set; }
        public List<Node> ChildList { get; set; } = new List<Node>();

        public Node(char item, int index)
        {
            Index = index;
            letter = item;
        }
    }       

    public class NoPrefixSet
    {
        public Dictionary<char, Node> ParentNode { get; set; } = new Dictionary<char, Node>();
     
        public string GenerateNodes(string[] inputArray)
        {
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (IsWordPrefix(inputArray[i]))
                {
                    Console.WriteLine("BAD SET");
                    Console.WriteLine(inputArray[i]);
                    return inputArray[i];

                }
            }
            Console.WriteLine("Good Set");
            return "Good Set";
        }

        private void InsertNodeInParent(char item)
            => ParentNode.Add(item, new Node(item, 0));

        private bool IsWordPrefix(string word)
        {
            //Check parent
            Node parentNode = null;
            bool hasNotInserted = false;
            int similarCounter = 0;
            if (!ParentNode.Any(a => a.Key == word[0]))
            {
                InsertNodeInParent(word[0]);
            }
            parentNode = ParentNode.Where(a => a.Key == word[0]).FirstOrDefault().Value;
            
            for (int letterIndex = 0; letterIndex < word.Length; letterIndex++)
            {
                if (!parentNode.ChildList.Any(a => a.letter == word[letterIndex]))
                {
                    parentNode.ChildList.Add(new Node(word[letterIndex], letterIndex));
                }
                else 
                {
                    if (!parentNode.ChildList.Where(a => a.letter == word[letterIndex]).First().ChildList.Any() || word.Length == letterIndex+1)
                    {
                        if (similarCounter == letterIndex)
                            return hasNotInserted = true;
                    }
                    similarCounter++;

                }
                parentNode = parentNode.ChildList.Where(a => a.letter == word[letterIndex] && a.Index == letterIndex).First();
            }
            
            return hasNotInserted;
        }

        public void ReadInput()
        {
            long data = Convert.ToInt64(Console.ReadLine());
            string[] stringArray = new string[data];
            for (long i = 0; i < data; i++)
            {
                stringArray[i] = Console.ReadLine();
            }
            GenerateNodes(stringArray);
        }
    }
}
