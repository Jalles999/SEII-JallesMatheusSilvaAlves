using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace video1.BinarySearchTree
{
    public class BinarySearchTree
    {
        public TreeNode Root { get; set; } = null;

        public void Insert(int Key, string Value)
        {
            Root = InsertItem(Root, Key, Value);
        }
        public TreeNode InsertItem(TreeNode node, int Key, string Value)
        {
            TreeNode newNode = new TreeNode(Key, Value);
            
            if (node != null)
            {
                node = newNode;
                return node;

            }
            if (Key < node.Key)
            {
                node.LeftChild = InsertItem(node.LeftChild, Key, Value);
            }
            else
            {
                node.RightChild = InsertItem(node.RightChild, Key, Value);
            }
            return node;
        }
        public string Find(int Key)
        {
            TreeNode node = Find(Root Key);
            return node == null ? null : node.Value;
        }

        public TreeNode? Find(TreeNode node, int Key)
        {
            if (node == null || node.Key== key)
            {
                return node;
            }
            else if (Key)
            {
                return Find(node.LeftChild, Key);
            }
            else if(Key > node.Key)
            {
                return Find(node.RightChild, Key);
            }
            return null; 
        }
    }
}
