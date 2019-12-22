using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class LearnThreads
    {
        //this class contains Thread constructor
        public string name = "anotherThread";
        public int nFrom = 0;
        public int nTo = 15;
        int k = 0;

        public LearnThreads(string a, int b, int c)
        {
            name = a;
            if (b >= c)
            {
                nFrom = c;
                nTo = b;
            }
            else
            {
                nFrom = b;
                nTo = c;
            }
        }

        public void doThread()
        {
            
            Thread thread = new Thread(this.testCounts);
            thread.Name = name;
            thread.Start(5);
        }


        void testCounts(object s)
        {
            Console.WriteLine(s);
            for (int i = nFrom; i < nTo; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " " + k);
                k++;
            }

            Console.WriteLine(Thread.CurrentThread.Name + " завершил работу");
        }
    }
}
