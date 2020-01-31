using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    class Node
    {
        public int data { get; set; }
        public Node leftChild;
        public Node rightChild;

        public Node(int data)
        {
            this.data = data;
        }
    }
}
