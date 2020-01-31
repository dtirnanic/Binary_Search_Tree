using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    class Program
    {
        static void Main(string[] args)
        {
            Binary_Search bs = new Binary_Search();

            bs.Add(24);
            bs.Add(30);
            bs.Add(20);
            bs.Add(14);
            bs.Add(15);
            bs.Add(27);
            bs.Add(28);
            bs.Search(14);
            bs.Search(28);

            Console.WriteLine();



        }
    }
}
