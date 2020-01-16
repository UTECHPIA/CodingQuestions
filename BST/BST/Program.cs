/*
 
Need a working BST to test our algorith

Reference: https://www.csharpstar.com/csharp-program-to-implement-binary-search-tree/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections;
 
namespace BinarySearchTree
{
 
    public class BinarySearchTree
    {
 
        public class Node
        {
            public int Data;
            public Node Left;
            public Node Right;
            public void DisplayNode()
            {
                Console.Write(Data + " ");
            }
        }
        public Node root;
        public BinarySearchTree()
        {
            root = null;
        }
        public void Insert(int i)
        {
            Node newNode = new Node();
            newNode.Data = i;
            if (root == null)
                root = newNode;
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (i < current.Data)
                    {
                        current = current.Left;
                        if (current == null)
                        {
                            parent.Left = newNode;
                            break;
                        }
 
                        else
                        {
                            current = current.Right;
                            if (current == null)
                            {
                                parent.Right = newNode;
                                break;
                            }
                        }
                    }
                }
            }
        }
 
 
        static void Main()
        {
            BinarySearchTree nums = new BinarySearchTree();
            nums.Insert(50);
            nums.Insert(17);
            nums.Insert(23);
            nums.Insert(12);
            nums.Insert(19);
            nums.Insert(54);
            nums.Insert(9);
            nums.Insert(14);
            nums.Insert(67);
            nums.Insert(76);
            nums.Insert(72);
        }
    }
 
}




 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections;

namespace BinarySearchTree
{

    public class BinarySearchTree
    {

        public class Node
        {
            public int Data;
            public Node Left;
            public Node Right;
            public void DisplayNode()
            {
                Console.Write(Data + " ");
            }
        }
        public Node root;
        public BinarySearchTree()
        {
            root = null;
        }
        public void Insert(int i)
        {
            Node newNode = new Node();
            newNode.Data = i;
            if (root == null)
                root = newNode;
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (i < current.Data)
                    {
                        current = current.Left;
                        if (current == null)
                        {
                            parent.Left = newNode;
                            break;
                        }

                        else
                        {
                            current = current.Right;
                            if (current == null)
                            {
                                parent.Right = newNode;
                                break;
                            }
                        }
                    }
                }
            }
        }


        static void Main()
        {
            Console.Write("Hello1");
            BinarySearchTree nums = new BinarySearchTree();
            Console.Write("Hello2");
            nums.Insert(50);
            Console.Write("Hello3");
            nums.Insert(17);
            Console.Write("Hello4");
            nums.Insert(23);
            Console.Write("Hello5");
            nums.Insert(12);
            Console.Write("Hello6");
            nums.Insert(19);
            Console.Write("Hello7");
            nums.Insert(54);
            Console.Write("Hello8");
            nums.Insert(9);
            Console.Write("Hello9");
            nums.Insert(14);
            Console.Write("Hello10");
            nums.Insert(67);
            Console.Write("Hello11");
            nums.Insert(76);
            Console.Write("Hello12");
            nums.Insert(72);
            Console.Write("Hello13");
        }
    }

}
