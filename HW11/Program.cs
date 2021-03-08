using System;
using System.Collections.Generic;

namespace HW11
{
    /*
    class Program
    {
        static void Main(string[] args)
        {
            var ls = new List<string> { "A", "B", "C", "D" };
            int k = 3;
            Subsets(ls, k);
        }
        static void Subsets(List<string> ls, int k)
        {
            var results = new List<string>();
            Console.WriteLine("Using Subsets1");
            Subsets1(ls, results, k);
            Console.WriteLine("Using Subsets2");
            Subsets2(ls, results, k);
            Console.WriteLine("Using Subsets3");
            Subsets3(ls, 0, results, k);
            Console.WriteLine("Using Subsets4");
            Subsets4(ls, 0, k);
        }

        static void Subsets1(List<string> ls, List<string> results, int k)
        {
            if (ls.Count == 0 && results.Count == k)
            {
                PrintList(results);
                return;
            } else if (ls.Count == 0)
            {
                return;
            }
            var newList = new List<string>(ls);
            var newResults = new List<string>(results);
            string s = newList[0];
            newList.RemoveAt(0);
            Subsets1(newList, newResults, k);
            newResults.Add(s);
            Subsets1(newList, newResults, k);
        }

        static void Subsets2(List<string> ls, List<string> results, int k)
        {
            if (ls.Count == 0 && results.Count == k)
            {
                PrintList(results);
                return;
            }
            else if (ls.Count == 0)
            {
                return;
            }
            string s = ls[0];
            ls.RemoveAt(0);
            Subsets2(ls, results, k);
            results.Add(s);
            Subsets2(ls, results, k);
            results.RemoveAt(results.Count - 1);
            ls.Insert(0, s);
        }

        static void Subsets3(List<string> ls, int k, List<string> results, int j)
        {
            if (ls.Count == k && results.Count == j)
            {
                PrintList(results);
                return;
            } else if (ls.Count == k)
            {
                return;
            }
            string s = ls[k];
            Subsets3(ls, k + 1, results, j);
            results.Add(s);
            Subsets3(ls, k + 1, results, j);
            results.RemoveAt(results.Count - 1);
        }

        static void Subsets4(List<string> ls, int k, int j)
        {
            if (ls.Count == k && ls.Count == j)
            {
                PrintList(ls);
                return;
            } else if (ls.Count == k)
            {
                return;
            }
            string s = ls[k];
            ls.RemoveAt(k);
            Subsets4(ls, k, j);
            ls.Insert(k, s);
            Subsets4(ls, k + 1, j);
        }

        static void PrintList(List<string> ls)
        {
            Console.Write(" { ");
            foreach (string s in ls)
                Console.Write(s + " ");
            Console.WriteLine("}");
        }
    }

    */


    /********************************/

    /*
    class Program
    {
        static void Main(string[] args)
        {
            var ls = new List<string> { "A", "B", "C" };
            int k = 2;
            Permutations(ls, k);
        }

        static void Permutations(List<string> ls, int k)
        {
            var results = new List<string>();
            Console.WriteLine("Using Permutations1");
            Permutations1(ls, results, k);
            Console.WriteLine("Using Permutations2");
            Permutations2(ls, 0, k);
        }

        static void Permutations1(List<string> ls, List<string> results, int k)
        {
            if (results.Count == k)
            {
                PrintList(results);
                return;
            }
            if (ls.Count == 0)
            {
                return;
            }
            for (int i = 0; i < ls.Count; i++)
            {
                var newList = new List<string>(ls);
                var newResults = new List<string>(results);
                newList.RemoveAt(i);
                newResults.Add(ls[i]);
                Permutations1(newList, newResults, k);
            }
        }
        static void Permutations2(List<string> ls, int k, int j)
        {
            if (k == j)
            {
                var newList = new List<string>(ls);
                newList.RemoveRange(j, newList.Count - j);
                PrintList(newList);
            }
            if (ls.Count == k) return;
            
            for (int i = k; i < ls.Count; i++)
            {
                Swap(ls, i, k);
                Permutations2(ls, k + 1, j);
                Swap(ls, i, k);
            }
        }

        static void Swap(List<string> ls, int i, int j)
        {
            string tmp = ls[i];
            ls[i] = ls[j];
            ls[j] = tmp;
        }

        static void PrintList(List<string> ls)
        {
            Console.Write(" { ");
            foreach (string s in ls)
                Console.Write(s + " ");
            Console.WriteLine("}");
        }

    }
    */

    /****************************/
    class Program
    {
        static void Main(string[] args)
        {
            Per(3);
            Console.WriteLine("");
            Per(4);
        }
        static void Per(int number)
        {
            Per(number, number, "");
        }

        static void Per(int openings, int closings, string result)
        {
            if (openings == 0 )
            {
                for (int i = 0; i < closings; i++)
                {
                    result += ")";
                }
                Console.WriteLine(result);
                return;
            }
            Per(openings - 1, closings, result + "(");
            if (closings > openings)
            {
                Per(openings, closings - 1, result + ")");
            }

        }
        static void PrintList(List<string> ls)
        {
            Console.Write(" { ");
            foreach (string s in ls)
                Console.Write(s + " ");
            Console.WriteLine("}");
        }
    }
}