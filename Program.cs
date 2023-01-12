using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 10;
            int time = 20;
            Console.WriteLine(age);
            Console.WriteLine(time);
            int temporaryAge = age;
            age = temporaryAge;
            temporaryAge = time;
            Console.WriteLine(time);
            Console.WriteLine(age);
        }
    }
}
