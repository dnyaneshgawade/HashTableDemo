using System;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hash Table !");
            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            hash.Add("0", "To");
            hash.Add("1", "be");
            hash.Add("2", "or");
            hash.Add("3", "not");
            hash.Add("4", "to");
            hash.Add("5", "be");
            string hash5 = hash.Get("5");
            Console.WriteLine("5th index value: "+hash5);
            hash.Remove("1");
            string hash1 = hash.Get("1");
            Console.WriteLine("1st index value: " + hash1);

        }
    }
}
