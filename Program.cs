using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var collection = new LargeDataCollection(1000))
            {
                collection.AddElement(42);
                collection.AddElement(15);
                collection.AddElement(7);

                collection.DisplayCollection();

                collection.RemoveElement(15);

                collection.DisplayCollection();

            }
            Console.ReadKey();
        }
    }
}