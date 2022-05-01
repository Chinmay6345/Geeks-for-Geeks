using System;
using System.Collections.Generic;
using System.Linq;

namespace Bottom_View_of_Binary_Tree
{
    /*
     
     Given a binary tree, print the bottom view from left to right.
A node is included in bottom view if it can be seen when we look at the tree from bottom.

                      20
                    /    \
                  8       22
                /   \        \
              5      3       25
                    /   \      
                  10    14

For the above tree, the bottom view is 5 10 3 14 25.
If there are multiple bottom-most nodes for a horizontal distance from root, then print the later one in level traversal. For example, in the below diagram, 3 and 4 are both the bottommost nodes at horizontal distance 0, we need to print 4.

                      20
                    /    \
                  8       22
                /   \     /   \
              5      3 4     25
                     /    \      
                 10       14

For the above tree the output should be 5 10 4 14 25.
     
     */

    class Node
    {
        public int data;
        public Node left;
        public Node right;

        public Node(int key)
        {
            this.data = key;
            this.left = null;
            this.right = null;
        }
    }

    class Solution
    {

        //Function to return a list containing the bottom view of the given tree.
        public List<int> bottomView(Node root)
        {
            Queue<(Node, int)> q = new Queue<(Node, int)>();
            SortedDictionary<int, int> map = new SortedDictionary<int, int>();
            q.Enqueue((root, 0));
            while (q.Count() != 0)
            {
                var p = q.Dequeue();
                var curr = p.Item1;
                int hd = p.Item2;
                if (!map.ContainsKey(hd))
                {
                    map.Add(hd, curr.data);
                }
                else
                {
                    map[hd] = curr.data;
                }
                if (curr.left != null)
                {
                    q.Enqueue((curr.left, hd - 1));
                }
                if (curr.right != null)
                {
                    q.Enqueue((curr.right, hd + 1));
                }
            }
            var values = map.Values.ToList();
            return values;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
