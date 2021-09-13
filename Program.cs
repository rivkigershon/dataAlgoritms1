using System;
using System.Collections.Generic;
using System.Collections;
namespace lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            //FindTopThreeRepeatedInArray(arr);
            //int[] arr = { 3, 4, 2, 3, 16, 3, 15, 16, 15, 15, 16, 2, 3 };//{ 2, 4, 23, 1, 55, 245, 33 };
            //int[] arr1 = { 3, 4, 3, 16, 3, 15, 16, 15, 15,4, 16, 2, 3 };//{ 2, 4, 23, 1, 55, 245, 33 };
            //Console.WriteLine(CheckIfTwoArraysAreEqualOrNot(arr, arr1));
            //Console.WriteLine(CheckIfTwoArraysAreEqualOrNot(arr, arr));
            //int[] arr2 = { 1, 1, 1 };
            //Console.WriteLine("{ 1, 1, 1 }");
            //CountOfIndexPairsWithEqualElementsInInArray(arr2);
            //int[] arr3 = { 1, 1, 9, 9, 9 };
            //Console.WriteLine("{ 1, 1, 9, 9, 9 }");
            //CountOfIndexPairsWithEqualElementsInInArray(arr3);
            //-----------------------------------------------------
            BinNodeTree<int> root = new BinNodeTree<int>(4,
                 new BinNodeTree<int>(3,
                     new BinNodeTree<int>(2, null, null),
                     new BinNodeTree<int>(2, null, null)),
                 new BinNodeTree<int>(3,
                     new BinNodeTree<int>(2, null, null),
                     new BinNodeTree<int>(2, null, null)));
            Console.WriteLine(CheckIfAllLeavesAreAtSameLevel(root));
            root = new BinNodeTree<int>(4,
                new BinNodeTree<int>(3,
                    new BinNodeTree<int>(2, null, null),
                    null),
                new BinNodeTree<int>(3,
                    new BinNodeTree<int>(2, null, null),
                    new BinNodeTree<int>(2, null, null)));
            Console.WriteLine(CheckIfAllLeavesAreAtSameLevel(root));
            root = new BinNodeTree<int>(4,
                new BinNodeTree<int>(3,
                    new BinNodeTree<int>(2, null, null),
                    null),
                new BinNodeTree<int>(3,
                    new BinNodeTree<int>(2,
                        new BinNodeTree<int>(1, null, null),
                        new BinNodeTree<int>(1, null, null)),
                    new BinNodeTree<int>(2, null, null)));
            Console.WriteLine(CheckIfAllLeavesAreAtSameLevel(root));
            Console.WriteLine("Hello World!");
            //-----------------------------------------------------
            FindN_thNodeOfInorderTraversal(root,6);
            //-----------------------------------------------------
            Console.WriteLine("stepping number");
            steppingNumber(0, 100);
            Console.WriteLine("stepping number");
            steppingNumber(0, 21);
            Console.WriteLine("stepping number");
            steppingNumber(10, 15);
            //-----------------------------------------------------
            Edge[] edges1 = { new Edge(0, 1), new Edge(0, 2), new Edge(3, 4) };
            Console.WriteLine(CountNumberOfTreesInAForest(edges1)+" edge1");

            Edge[] edges2 = { new Edge(0, 1), new Edge(0, 2), new Edge(3, 4), new Edge(2, 3) };
            Console.WriteLine(CountNumberOfTreesInAForest(edges2) + " edge2");

            Edge[] edges3 = { new Edge(0, 1), new Edge(0, 2), new Edge(3, 4), new Edge(5, 6) };
            Console.WriteLine(CountNumberOfTreesInAForest(edges3) + " edge3");
            //-----------------------------------------------------
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}

