using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace video1.BinarySearchTree
{
    public class BinarySearchTree
    {
        public int Key { get; set; }

        public string String { get; set; }

        public TreeNode LeftChild { get; set; }

        public TreeNode RightChild { get; set; }
        public TreeNode(int key, string value)
        {
            this.Key = key;
            this.Value = value;

        }
    }
}
