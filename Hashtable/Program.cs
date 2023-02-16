using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashtable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string paragraph = "To be or not to be";
            CountNumbOfOccurence(paragraph);
            Console.ReadLine(); 
        }
        public static void CountNumbOfOccurence(string paragraph)
        {
            MyMapNode<string, int> hashTabe = new MyMapNode<string, int>(6);

            string[] words = paragraph.Split(' ');

            foreach (string word in words)
            {
                if (hashTabe.Exists(word.ToLower()))
                    hashTabe.Add(word.ToLower(), hashTabe.Get(word.ToLower()) + 1);
                else
                    hashTabe.Add(word.ToLower(), 1); //to,1 
            }
            Console.WriteLine("Displaying after add operation");
            Console.WriteLine("Frequency of words");
            hashTabe.Display();
            string s = "or";
            hashTabe.Remove(s);
            Console.WriteLine("After removed an item {0}", s);
            hashTabe.Display();
        }
    }
}
