using System;
using System.Collections.Generic;

namespace GenericsExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Chris!");
            PrintQueue(CreateQueue());
            PrintStack(CreateStack());
            PrintLinkedList(CreateLinkedList());
            PrintDictionary(CreateDictionary());
            PrintList(CreateList());
            PrintSortedList(CreateSortedList());
            PrintHash(CreateHashTables());

        }
        //Queue
        public static Queue<int> CreateQueue()
        {
            Queue<int> genericEx = new Queue<int>();
            foreach (int number in new int[] { 12, 222, -34, 27, 82 })
            {
                genericEx.Enqueue(number);
            }
            return genericEx;
        }
        public static void PrintQueue(Queue<int> input)
        {
            //Printing queue
            Console.WriteLine("Queue example:");
            foreach (var x in input)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("\n");
        }
        //Stack
        public static Stack<string> CreateStack()
        {
            Stack<string> genericEx = new Stack<string>();
            foreach (string phrase in new string[] { "Chris", "Xavier", "Larry", "Spongebob", "Patrick" })
            {
                genericEx.Push(phrase);
            }
            return genericEx;
        }
        public static void PrintStack(Stack<string> input)
        {
            Console.WriteLine("Stack example");
            foreach (var x in input)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("\n");
        }
        //List
        public static List<char> CreateList()
        {
            List<char> genericEx = new List<char>();
            foreach (char character in "generics")
            {
                genericEx.Add(character);
            }
            return genericEx;
        }
        public static void PrintList(List<char> input)
        {
            Console.WriteLine("Char list example:");
            foreach (var x in input)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("\n");
        }
        //LinkedList
        public static LinkedList<double> CreateLinkedList()
        {
            LinkedList<double> genericEx = new LinkedList<double>();
            foreach (double number in new double[] { 987.52, Math.Abs(2342.12), .0087, -3.14156 * Math.PI})
            {
                genericEx.AddFirst(number);
            }
            return genericEx;
        }
        public static void PrintLinkedList(LinkedList<double> input)
        {
            Console.WriteLine("LinkedList example");
            foreach (var x in input)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("\n");
        }
        public static Dictionary<string, char> CreateDictionary()
        {
            Dictionary<string, char> keyValuePairs = new Dictionary<string, char>()
            {
                ["Rick"] = 'a',
                ["Morty"] = 'b',
                ["Summer"] = 'c',
                ["Beth"] = 'd',
                ["Jerry"] = 'e'
            };
            return keyValuePairs;
        }
        public static void PrintDictionary(Dictionary<string, char> keyValuePairs)
        {
            Console.WriteLine("Dictionary with a string key and a char value");
            foreach (KeyValuePair<string, char> element in keyValuePairs)
            {
                Console.WriteLine($"Key is {element.Key} and Value is {element.Value}");
            }
            Console.WriteLine("\n");
        }
        public static SortedList<double, string> CreateSortedList()
        {
            SortedList<double, string> keyValuePairs = new SortedList<double, string>()
            {
                {17, "coolest" },
                {22.3, "person" },
                {0, "Chris" },
                {3, "the" },
                {2.12, "is" }
            };
            return keyValuePairs;
        }
        public static void PrintSortedList(SortedList<double, string> keyValuePairs)
        {
            Console.WriteLine("Sorted list with double key and a string value");
            foreach (KeyValuePair<double, string> element in keyValuePairs)
            {
                Console.WriteLine($"Key is {element.Key} and Value is:'{element.Value}'");
            }
            Console.WriteLine("\n");
        }
        public static HashSet<string> CreateHashTables()
        {
            HashSet<string> wordsThatStartWithLetterR = new HashSet<string>(new string[]
            {
                "Run", "Rampage", "Rain", "Rice", "Revel", "Reconsider", "Reenlist"
            });
            HashSet<string> wordsThatContainLetterE = new HashSet<string>(new string[]
            {
                "Reconsider", "Enchiladas", "Reenlist", "Sike", "Rebel", "Reach", "Chimp"
            });
            //I wanted to return the line of code below this but the result of that
            //code is a void. What this line of code does is just alter my first hash set
            wordsThatStartWithLetterR.IntersectWith(wordsThatContainLetterE);
            return wordsThatStartWithLetterR;
        }
        public static void PrintHash(HashSet<string> genericEx)
        {
            Console.WriteLine("Hash set populated with strings intersected with another hash set");
            foreach (var x in genericEx)
            {
                Console.WriteLine(x);
            }
        }
    }
}
