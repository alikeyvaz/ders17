using System;

namespace ders17
{
    internal class Program
    {
        public delegate void Chek(string world);

        public static void Main(string[] args)
        {
            Test("asd", GetLength);
            Test( "Asd", GetWord);
        }

        public static void GetLength(string word)
        {
            Console.WriteLine(word.Length);

        }

        public static void GetWord(string word)
        {
            Console.WriteLine(word);

        }

        public static void Test(string word, Chek func)
        {
            func(word);
        }
    }
}