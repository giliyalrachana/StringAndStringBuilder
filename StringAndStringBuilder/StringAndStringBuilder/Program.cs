using System;

namespace StringAndStringBuilder
{
    class Program
    {
        // This program demo. how to use String API
        static void Main(string[] args)
        {
            string myString = "This is a test string";
            myString=myString.ToLowerInvariant();
            // myString += "How are you";

            // Access string with indexer
            Console.WriteLine($"char at index 1 is :{myString[1]}");

            // To get count of characters using Length property
            Console.WriteLine($"Length is :{myString.Length}");

            Console.WriteLine(myString.Contains(("test")) ? "test is present" : "test is not present");


            Console.WriteLine(myString.StartsWith("This") ? "it starts with This" : "it not starts with This");

            Console.WriteLine(myString.EndsWith("string") ? "it ends with string" : "it not ends with string");

            string substring = myString.Substring(0, 4);
            Console.WriteLine($"New string:{substring}");

            string myString1 = "This is string";
            int result = String.Compare(myString, myString1);
            Console.WriteLine(result);

            Console.ReadLine();

        }
    }
}
