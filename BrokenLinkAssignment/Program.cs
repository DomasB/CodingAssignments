using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures;
using static System.Linq.Enumerable;

namespace BrokenLinkAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Congratulations, you need to implement our empty datastructure but not change the contracts and you cannot use already existing LinkedList class in .NET
            // make sure all tests are green (do not edit tests)
            // find and fix any bugs you encounter
            // create a list here 
            // add 100 random members to it
            // print all 100 members to console

            var list = new SpecialLinkedList<int>();
            var emptyList = new SpecialLinkedList<int>();

            Random rnd = new Random();

            foreach (var index in Range(1, 100))
            {
                // list.Add(rnd.Next(1,10000));
                list.Add(index);
            }
            Console.WriteLine(list[99]);
            Console.WriteLine(emptyList.ToString());
            Console.WriteLine(list.ToString());

        }
    }
}
