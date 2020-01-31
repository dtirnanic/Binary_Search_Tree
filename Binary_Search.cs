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



        public int Search(int newData)
        {
            Node currentNode = rootNode;

            while (true)
            {
                if (newData > currentNode.data)
                {
                    if (newData > currentNode.rightChild.data)
                    {
                        rootNode = currentNode.rightChild;
                    }
                    else
                    {
                        currentNode = currentNode.rightChild;
                    }
                }

                else if (newData < currentNode.data)
                {
                    if (newData < currentNode.leftChild.data)
                    {
                        rootNode = currentNode.leftChild;  
                    }
                    else
                    {
                        currentNode = currentNode.leftChild;
                    }

                }

                else if (newData == currentNode.data)
                {
                    return currentNode.data;
                }

                else
                {

                }
            }

        }


    
    


        public void Add(int newData)
        {
            if (rootNode == null)
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

                else if (newData < currentNode.data)
                {
                    if(currentNode.leftChild == null)
                    {
                        currentNode.leftChild = new Node(newData);
                        return;
                    }
                    else
                    {
                        currentNode = currentNode.leftChild;
                    }

                }

            }


        }
    }
}
