using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeMe
{
    class Program
    {
        static void Main(string[] args)
        {
            var johndoe = new User()
            {
                Name = "John",
                LastName = "Doe",
            };
            Console.WriteLine($"My name is {johndoe.FullName}");
            Console.ReadLine();
        }
    }
}
