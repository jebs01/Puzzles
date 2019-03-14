using System;
using NUnit.Framework;
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
}

}
