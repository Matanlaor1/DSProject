using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgorithems
{
    internal class Node
    {
        public Node(int data, List<Node> nodes)
        {
            this.data = data;
            Nodes = nodes;
        }

        int data {  get; set; }
        public List<Node> Nodes { get; set; } = new List<Node>();

        public override string ToString()
        {
            return data.ToString();
        }
    }
}
