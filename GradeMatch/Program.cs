using System;
using System.Linq;

namespace GradeMatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 16;

            var list = Enumerable.Range(1, 100).Where(n => n % 2 == 0);

            Console.WriteLine("Hello World!");
            

        }
    }
}
