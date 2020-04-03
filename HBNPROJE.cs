using System;
using System.IO;
using System.Diagnostics;

namespace ConsoleApp1
{
    class HBNPROJE
    {
        static void Main(string[] args)
        {
            ProcessStartInfo ps = new ProcessStartInfo();
            ps.Arguments = "-p 1-1024 127.0.0.1";
            ps.RedirectStandardOutput = true;
            ps.FileName = "nmap";
            Process p = new Process();
            p.StartInfo = ps;
            p.Start();
            StreamReader stdout = p.StandardOutput;
            StreamWriter sw = new StreamWriter("stdout.txt");
            sw.WriteLine(stdout.ReadToEnd());
            p.WaitForExit();
            Console.WriteLine("program bitti");
            Console.ReadKey(true);
        }
    }
}
