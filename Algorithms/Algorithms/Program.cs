using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LearnThreads thred1 = new LearnThreads("Qwerty01", 1, 24);
            LearnThreads thred2 = new LearnThreads("Qwerty02", 2, 22);

            thred1.doThread();
            thred2.doThread();

            Console.ReadKey();
        }
    }
}
