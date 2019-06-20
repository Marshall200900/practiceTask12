using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task12
{
    class Node
    {
         
        public Node Left { get; set; }
        public Node Right { get; set; }
        public int Value;
        public Node(int val)
        {
            Value = val;
        }
    }
    class TreeSort
    {
        public int Comparisons { get; private set; } = 0;
        public int Moves { get; private set; } = 0;
        private List<Node> NodeArray = new List<Node>();
        public Node Root { get; set; }
        public TreeSort(int[] array)
        {
            
            if (array.Length == 0) return;
            Root = new Node(array[0]);
            Node pointer = Root;
            for (int i = 1; i < array.Length; i++)
            {
                while (pointer != null)
                {
                    Comparisons+=2;
                    if (array[i] < pointer.Value)
                    {
                        Comparisons--;
                        if (pointer.Left != null)
                            pointer = pointer.Left;
                        else
                        {
                            pointer.Left = new Node(array[i]);
                            pointer = Root;
                            break;
                        }
                    }
                    else if (array[i] >= pointer.Value)
                    {
                        if (pointer.Right != null)
                            pointer = pointer.Right;
                        else
                        {
                            pointer.Right = new Node(array[i]);
                            pointer = Root;
                            break;
                        }
                    }
                        
                }
                
            }
            Run(Root);
        }
        private void Run(Node pointer)
        {
            if (pointer.Left != null)
            {
                Run(pointer.Left);
            }
            NodeArray.Add(pointer);
            if (pointer.Right != null)
                Run(pointer.Right);
            

        }
        public override string ToString()
        {
            string output = "";
            foreach(Node n in NodeArray)
            {
                output += n.Value + " ";
            }
            return output;
        }
    }
}
