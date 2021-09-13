using System;
using System.Collections.Generic;
using System.Text;
namespace lesson1
{
    class BinNodeTree<T>
    {
        public BinNodeTree<T> LeftNode { get; set; }
        public BinNodeTree<T> RightNode { get; set; }
        public T value { get; set; }
        public BinNodeTree(T value1, BinNodeTree<T> leftNode1, BinNodeTree<T> RightNode1)
        {
            this.value = value1;
            this.LeftNode = leftNode1;
            this.RightNode = RightNode1;
        }
        //1
        public static int FindN_thNodeOfInorderTraversal(BinNodeTree<int> parent, int num)
        {
            if (parent != null && num > 0)
            {
                num = FindN_thNodeOfInorderTraversal(parent.LeftNode, num);
                num--;
                if (num == 0) Console.WriteLine(parent.value);
                num = FindN_thNodeOfInorderTraversal(parent.RightNode, num);
            }
            return num;
        }
        //2
        public static bool CheckIfAllLeavesAreAtSameLevel(BinNodeTree<int> bnt)
        {
            return (CheckTheLevelOfLeaves(bnt) != -1);
        }
        public static int CheckTheLevelOfLeaves(BinNodeTree<int> bnt)
        {
            if (bnt == null)
                return 0;
            int heightL = CheckTheLevelOfLeaves(bnt.LeftNode);
            if (heightL == -1)
                return -1;
            int heightR = CheckTheLevelOfLeaves(bnt.RightNode);
            if (heightL == 0)
                return heightR + 1;
            if (heightR == 0)
                return heightL + 1;
            if (heightL == heightR)
                return heightL + 1;
            return -1;
        }
    }
}
















