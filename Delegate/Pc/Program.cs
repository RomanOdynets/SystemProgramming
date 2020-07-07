using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pc
{
    class Program
    {
        enum StatusRes
        {
            Y,
            N
        }
        static void Main(string[] args)
        {
        start:
            Console.Clear();
            Process[] pc = Process.GetProcesses();
            foreach (var item in pc)
            {
                try
                {
                    if (item.ProcessName == "svchost") continue;
                    Console.WriteLine("{0}\t{1}", item.ProcessName, item.Id);
                }
                catch { continue; }
            }

            while(true)
            {
                string id = Console.ReadLine();
                int pid = -1;
                int.TryParse(id, out pid);
                try
                {
                    Process obj = Process.GetProcessById(pid);
                    StatusRes r = ckeckUser();
                    if(r == StatusRes.Y) obj.Kill();
                }
                catch {  }
                goto start;
            }
        }

        static StatusRes ckeckUser()
        {
            Console.WriteLine("Are you sure for kill this process? [Y\\N]");
            string ans = Console.ReadLine();
            bool res = ans.ToLower() == "y" ? true : false;
            return res ? StatusRes.Y : StatusRes.N;
        }
    }
}
