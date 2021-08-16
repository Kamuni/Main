using System;
using System.Reflection.Metadata;

namespace Space_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            string userString = Console.ReadLine(); 
            var usingClass  = new Space_count();
            int answer = usingClass.spacesInString(userString);
            Console.WriteLine(answer);
        }
    }
}
