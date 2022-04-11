using System;
using System.IO;

namespace simplilearn_projects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string file = @"C:\Users\chara\Documents\student details of rainbow school.txt";
            string[] details = File.ReadAllLines(file);
            foreach (string ln in details)
                Console.WriteLine(ln);
        }
    }
}
