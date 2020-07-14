using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PW_02_1
{
    class Program
    {
        static Thread[] threads;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter num from: ");
            string n1 = Console.ReadLine();
            Console.WriteLine("Enter num to: ");
            string n2 = Console.ReadLine();
            Console.WriteLine("Enter threads count: ");
            string n3 = Console.ReadLine();

            int num1, num2, threadsCounts;

            bool r1 = int.TryParse(n1, out num1);
            bool r2 = int.TryParse(n2, out num2);
            bool r3 = int.TryParse(n3, out threadsCounts);

            if (!r1 || !r2 || !r3)
            {
                Console.WriteLine("Something wrong...");
                return;
            }

            threads = new Thread[threadsCounts];

            Thread t = new Thread(new ParameterizedThreadStart(counter));
            t.Start(num1+"."+num2);
        }

        private static void counter(object nums)
        {
            string s = nums.ToString();

            string[] res = s.Split('.');

            int n1 = int.Parse(res[0]);
            int n2 = int.Parse(res[1]);

            for (int i = n1; i < n2; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
