using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace testtest
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime[] dt = new DateTime[2];

            dt[0] = DateTime.Now;
            GoThread.del r1 = count1;
            GoThread.del r2 = count2;
            int res1 = GoThread.Execute(r1);
            int res2 = GoThread.Execute(r2);
            dt[1] = DateTime.Now;
            Console.WriteLine("Res 1: {0}\t Res 2: {1}", res1, res2);
            Console.WriteLine(dt[1]-dt[0]);
        }

        static int count1()
        {
            int res = 0;
            for (int i = 0; i < int.MaxValue/2; i++)
            {
                res += i;
            }

            return res;
        }

        static int count2()
        {
            int res = 0;
            for (int i = 0; i < int.MaxValue / 3; i++)
            {
                res += i;
            }

            return res;
        }
    }

    class GoThread
    {
        public delegate int del();

        public static int Execute(del func)
        {
            Task<int> result = MakeThread(func);
            return result.Result;
        }

        public async static Task<int> MakeThread(del func) 
        {
            return await Task.Run(() => func());
        }
    }
}
