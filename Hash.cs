using System;
using System.Collections.Generic;
using System.Text;

namespace lesson1
{
    class Hash
    {
        public static Dictionary<int, int> fillInCountingDictionary(int[] arr)
        {
            Dictionary<int, int> d = new Dictionary<int, int>();
            foreach (int p in arr)
            {
                if (d.ContainsKey(p))
                    d[p]++;
                else
                    d.Add(p, 1);
            }
            return d;
        }
        //1
        public static void FindTopThreeRepeatedInArray(int[] arr)
        {
            KeyValuePair<int, int> a, b, c;
            a = new KeyValuePair<int, int>(int.MinValue, int.MinValue);
            b = new KeyValuePair<int, int>(int.MinValue, int.MinValue);
            c = new KeyValuePair<int, int>(int.MinValue, int.MinValue);
            Dictionary<int, int> d = fillInCountingDictionary(arr);
            foreach (var p in d.Keys)
            {
                if (d.ContainsKey(p) && d[p] > a.Value)
                {
                    c = b;
                    b = a;
                    a = new KeyValuePair<int, int>(p, d[p]);
                }
                else if (d.ContainsKey(p) && d[p] > b.Value)
                {
                    c = b;
                    b = new KeyValuePair<int, int>(p, d[p]);
                }
                else if (d.ContainsKey(p) && d[p] > c.Value)
                {
                    c = new KeyValuePair<int, int>(p, d[p]);
                }
            }
            Console.WriteLine(" a: " + a.Key + " " + a.Value + " b: " + b.Key + " " + b.Value + " c: " + c.Key + " " + c.Value);
        }
        //2
        public static bool CheckIfTwoArraysAreEqualOrNot(int[] a, int[] b)
        {
            Dictionary<int, int> aDict = fillInCountingDictionary(a);
            foreach (var item in b)
            {
                if (aDict.ContainsKey(item))
                    aDict[item]--;
                else
                    return false;
            }
            foreach (var item in aDict)
            {
                if (item.Value != 0)
                    return false;
            }
            return true;
        }
        //3
        //תרגיל מהמם וחכם!
        public static int SumOfAllPairsInArrayMeetTheCondition(int[] arr)
        {
            Dictionary<int, int> d = new Dictionary<int, int>();
            int ans = 0;
            int preSum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                ans += arr[i] * i - preSum;
                preSum += arr[i];

                if (d.ContainsKey(arr[i] - 1))
                    ans -= d[arr[i] - 1];

                if (d.ContainsKey(arr[i] + 1))
                    ans += d[arr[i] + 1];

                if (d.ContainsKey(arr[i]))
                    d[arr[i]]++;
                else
                    d[arr[i]] = 1;
            }
            return ans;
        }
        //4
        public static Dictionary<int, List<int>> fillInListIndexesDictionary(int[] arr)
        {
            Dictionary<int, List<int>> d = new Dictionary<int, List<int>>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (!d.ContainsKey(arr[i]))
                    d.Add(arr[i], new List<int>());
                d[arr[i]].Add(i);
            }
            return d;
        }
        public static void printAllEqualIndexes(List<int> l)
        {
            int[] arr = l.ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    Console.WriteLine(@"( {0}, {1} )", arr[i], arr[j]);
                }
            }
        }
        public static void CountOfIndexPairsWithEqualElementsInInArray(int[] arr)
        {
            Dictionary<int, List<int>> d = fillInListIndexesDictionary(arr);
            foreach (var item in d)
            {
                if (item.Value.Count > 1)
                    printAllEqualIndexes(item.Value);
            }
        }
    }
}
