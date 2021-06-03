using Dal;
using System;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new SchoolContext();

            context.Initialize();

            foreach (var item in context.People)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}");
            }

        }
    }
}
