using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Id { get; set; }
        public DateTime BirthDay { get; set; }
        public Person(string name, string addres, int id, DateTime birthDay)
        {
            Name = name;
            Address = addres;
            Id = id;
            BirthDay = birthDay;
        }
    }
}
