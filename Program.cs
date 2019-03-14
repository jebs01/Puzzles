using System;
using NUnit.Framework;
using System.Linq;
namespace Puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = AddInt(3, 4);
            Console.WriteLine("Result: " + result);
            Console.Read();
        }

        public static int AddInt(int x, int y)
        {
            return x+y;
        }

        public static bool  Anagram(string x, string y)
        {
            var charsA = x.ToLower().ToArray().Where(c => c >= 'a' && c <= 'z');
            var charsB = y.ToLower().ToArray().Where(c => c >= 'a' && c <= 'z');
            return charsA.OrderBy(c => c).SequenceEqual(charsB.OrderBy(c => c));
        }
    }

    [TestFixture]
    class Programtests
    {
        [TestCase(2, 4, 6)]
        [TestCase(1, 0, 1)]
        [TestCase(10, -2, 8)]
    public void TestAddition(int x,int y, int z)
    {
             var Results = Program.AddInt(x,y);
             Assert.AreEqual(z,Results);

    }

        [TestCase("rail safety", "fairy tales", true)]
       
     public void TestAnagram(string x,string y, bool z)
    {
             var Results = Program.Anagram(x,y);
             Assert.AreEqual(z,Results);

    }
}

}
