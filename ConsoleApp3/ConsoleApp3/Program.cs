using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime BirthDay = new DateTime(04 / 02 / 2004);
            Person Ali = new Person("Ali", "Ravar", 321009945, BirthDay);
            Console.WriteLine(Ali.BirthDay);
        }
    }
}
