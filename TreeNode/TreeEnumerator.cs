using System;
using System.Collections;
using System.Collections.Generic;

namespace TreeNode
{
    internal class TreeEnumerator : IEnumerator<TreeNode>
    {
        // The tree node's in the proper order
        private List<TreeNode> Nodes;

        // The index of the current node
        private int CurrentIndex;

        public TreeEnumerator(TreeNode root)
        {
            Nodes = root.PreOrder();
            Reset();
        }

        public TreeNode Current
        {
            get { return GetCurrent(); }
        }

        object IEnumerator.Current
        {
            get { return GetCurrent(); }
        }

        private TreeNode GetCurrent()
        {
            if(CurrentIndex < 0)
            {
                throw new InvalidOperationException();
            }

            if (CurrentIndex >=  Nodes.Count)
            {
                throw new InvalidOperationException();
            }

            return Nodes[CurrentIndex];
        }
        public void Dispose()
        {
             
        }

        public bool MoveNext()
        {
            CurrentIndex++;
            return (CurrentIndex < Nodes.Count);
        }

        public void Reset()
        {
            CurrentIndex = -1;
        }
    }
}