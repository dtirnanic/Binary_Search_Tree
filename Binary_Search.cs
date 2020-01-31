using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    class Binary_Search
    {
        Node rootNode { get; set; }



        public void Search(int value)
        {
   

        }

        public void Add(int newData)
        {
            if (rootNode == null) //if rootNode is not yet valued
            {
                rootNode = new Node(newData);
            }
            Node currentNode = rootNode;
            while (true)
            {
                if (newData >= currentNode.data)
                {
                    if (currentNode.rightChild == null)
                    {
                        currentNode.rightChild = new Node(newData);
                        return;
                    }
                    else
                    {
                        currentNode = currentNode.rightChild;
                    }
                }
            }
            while (true)
            {
                if (newData < currentNode.data)
                {

                }


            }


        }
    }
}
