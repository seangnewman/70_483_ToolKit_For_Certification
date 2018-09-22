using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeNode
{
    class TreeNode:IEnumerable<TreeNode>
    {
        public int Depth = 0;
        public string Text = "";
        public List<TreeNode> Children = new List<TreeNode>();

        public TreeNode(string text)
        {
            Text = text;
        }

        // Add and create children
        public TreeNode AddChild(string text)
        {
            TreeNode child = new TreeNode(text);
            child.Depth = Depth + 1;
            Children.Add(child);
            return child;
        }

        public IEnumerator<TreeNode> GetEnumerator()
        {
            return new TreeEnumerator(this);

        }

        // Return the tree's nodes in an preorder traversal
        public List<TreeNode> PreOrder()
        {
            // make the result list
            List<TreeNode> nodes = new List<TreeNode>();

            // Traverse this node's dubtree
            TraversePreorder(nodes);

            // return the result
            return nodes;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new TreeEnumerator(this);
        }

        private void TraversePreorder( List<TreeNode> nodes)
        {
            // Traverse this node
            nodes.Add(this);

            // Traverse the children
            foreach (TreeNode child in Children)
            {
                child.TraversePreorder(nodes);
            }
            
        }


    }
}
