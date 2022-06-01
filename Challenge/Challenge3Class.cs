using System;
using System.Collections.Generic;
using System.Linq;

namespace Challenge
{
    public class Node<T>
    {
        public T Value { get; set; } = default;

        public List<Node<T>> Children { get; set; } = new List<Node<T>>();
    }
    
    public class Challenge3Class
    {
        /// <summary>
        /// Perform a depth first traversal on the tree, favouring the left-most node
        /// </summary>
        /// <param name="root">Root node of the tree</param>
        /// <returns>Nodes visited in the order of visitation</returns>
        public static IEnumerable<Node<int>> Challenge3(Node<int> root)
        {
            var visited = new List<Node<int>>();

            void DFS(Node<int> n)
            {
                visited.Add(n);

                foreach (var nChild in n.Children)
                {
                    if (!visited.Contains(nChild))
                    {
                        DFS(nChild);
                    }
                }
            }
            
            DFS(root);

            return visited;
        }
    }
}