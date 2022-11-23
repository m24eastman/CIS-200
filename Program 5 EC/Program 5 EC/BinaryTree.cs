// 5272456
// program 5 ec
// 12/9/21
// cis 200-59
// contains the classes treenode and tree

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_5_EC
{
    // declaring class TreeNode
    public class TreeNode<T> where T : IComparable<T>
    {
        // pre condition is that the class must be generic
        // post condition is that it will be implemented
        public TreeNode<T> left { get; set; }




        // pre condition is that the class must be generic
        // post condition is that it will be implemented
        public IComparable data { get; private set; }





        // pre condition is that the class must be generic
        // post condition is that it will be implemented
        public TreeNode<T> right { get; set; }





        // initialize data field
        public TreeNode(IComparable node)
        {
            data = node;
        }





        // this will ignore duplication variables and insert treenode into the tree
        public void Add(IComparable insert)
        {
            //insert into left 
            if (insert.CompareTo(data) < 0) 
            {
                //new node
                if (left == null)
                {
                    left = new TreeNode<T>(insert);
                }
                else 
                {
                    left.Add(insert);
                }
            }
            //insert into right
            else if (insert.CompareTo(data) > 0) 
            {
                // insert new node
                if (right == null)
                {
                    right = new TreeNode<T>(insert);
                }
                else
                {
                    right.Add(insert);
                }
            }
        }
    }




    // declaring tree class
    public class Tree<T> where T : IComparable<T>
    {
        private TreeNode<T> root;

        //inserting a new node, if the tree root is null create node there, or call insert method
        public void NewNode(IComparable insert)
        {
            if (root == null)
            {
                root = new TreeNode<T>(insert);
            }
            else
            {
                root.Add(insert);
            }
        }






        // inorder transversal part
        public void inordertransversal()
        {
            helper(root);
        }

        // method to perform inorder transversal
        private void helper(TreeNode<T> node)
        {
            if (node != null)
            {
                // left subtree
                helper(node.left);

                // display data
                Console.Write($"{node.data} ");

                // right subtree
                helper(node.right);
            }
        }
    }
}