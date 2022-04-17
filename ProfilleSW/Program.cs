using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ProfilleSW
{

    //public class MyBase
    //{
          
    //}

    //internal class MyClass : MyBase
    //{
          
    //}

    //internal class MyBase
    //{

    //}

    //public class MyClass : MyBase
    //{

    //}


    public class Palindrome
    {
        public static bool IsPalindrome(string word)
        {
            word = word.ToLower();
            bool isPalindrome = false;
            Stack<char> stackOfCharacters = new Stack<char>(word.Length);
            Stack<char> stackOfReversedCharacters = new Stack<char>(word.Length);

            for (int i = 0; i < word.Length; i++)
            {
                stackOfCharacters.Push(word[i]);
                stackOfReversedCharacters.Push(word[word.Length - 1 - i]);
            }

            for (int i = 0; i < word.Length; i++)
            {
                if (!stackOfCharacters.Pop().Equals(stackOfReversedCharacters.Pop()))
                {
                    isPalindrome = false;
                    break;
                }
                else
                {
                    isPalindrome = true;
                }
            }

            return isPalindrome;
        }
        public static void Main(string[] args)
        {
            //Debug.WriteLine(Palindrome.IsPalindrome("Deleveled"));
            //Debug.WriteLine(Palindrome.IsPalindrome("asdfgfdsa"));
            //Debug.WriteLine(Palindrome.IsPalindrome("qwertytrewq"));
            //Debug.WriteLine(Palindrome.IsPalindrome(";@#$%$#@;"));
            //Debug.WriteLine(Palindrome.IsPalindrome("98765456789"));

            //SomeMath someMath = new SomeMath();
            //someMath.TestFindTwoSum();

            //SomeTree someTree = new SomeTree();
            //someTree.TestBinarySearchTree();

            Class1 class1 = new Class1();
            class1.Foo();
        }
    }

    public class Tuple<TFirst, TSecond>
    {
        public TFirst Item1;
        public TSecond Item2;
    }

    public class SomeMath
    {
        public static Tuple<int, int> FindTwoSum(IList<int> list, int sum)
        {
            //you need to add "using System.Linq;" for this to work
            Tuple<int, int> result = new Tuple<int, int>();
            //creates a lookup table where the values become the keys and the keys become the values
            Lookup<int, int> lookUp = (Lookup<int, int>)list.Select((k, v) => new { Key = k, Value = v }).ToLookup(l => l.Key, l => l.Value);

            for (int i = 0; i < list.Count; i++)
            {
                int remaining = sum - list[i];

                if (lookUp.Contains(remaining))
                {
                    result.Item1 = i;
                    result.Item2 = lookUp[remaining].FirstOrDefault(k => k != i); //should not return the wrong index if both values are the same
                    break;
                }
            }
            return result;
        }

        public void TestFindTwoSum()
        {
            Tuple<int, int> indices = FindTwoSum(new List<int>() { 3, 1, 5, 7, 5, 9 }, 10);
            if (indices != null)
            {
                Debug.WriteLine(indices.Item1 + " " + indices.Item2);
            }

            indices = FindTwoSum(new List<int>() { 1, 5, 7, 5, 9 }, 10);
            if (indices != null)
            {
                Debug.WriteLine(indices.Item1 + " " + indices.Item2);
            }

            indices = FindTwoSum(new List<int>() { 5, 7, 5, 9 }, 10);
            if (indices != null)
            {
                Debug.WriteLine(indices.Item1 + " " + indices.Item2);
            }
        }

    }

    public class Node
    {
        public int Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(int value, Node left, Node right)
        {
            Value = value;
            Left = left;
            Right = right;
        }
    }

    public class SomeTree
    {

        public static bool Contains(Node root, int value)
        {
            bool result = false;

            Node currentNode = root;
            while (currentNode != null)
            {
                if (currentNode.Value == value)
                {
                    result = true;
                    break;
                }

                if (currentNode.Value < value)
                {
                    //go right
                    currentNode = currentNode.Right;
                }
                else
                {
                    //go left
                    currentNode = currentNode.Left;
                }
            }
            return result;
        }

        public void TestBinarySearchTree()
        {
            Node n1 = new Node(1, null, null);
            Node n3 = new Node(3, null, null);
            Node n2 = new Node(2, n1, n3);

            Console.WriteLine(Contains(n2, 3));
        }
    }
}
