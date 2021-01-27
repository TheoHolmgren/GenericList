using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            ListOfObjects<object> myListOfObjects = new ListOfObjects<object>();
            myListOfObjects.AddObject(42);
            myListOfObjects.AddObject("Mr Fantastic");
            myListOfObjects.AddObject(true);
            myListOfObjects.AddObject(47.11);
            myListOfObjects.AddObject("test5");
            myListOfObjects.AddObject("test6");
            myListOfObjects.AddObject("test7");
            myListOfObjects.AddObject("test8");
            myListOfObjects.AddObject("test9");
            myListOfObjects.AddObject("test10");
            myListOfObjects.AddObject("test11");
            Console.WriteLine(myListOfObjects.GetObject(3));
            Console.WriteLine(myListOfObjects.GetObject(10));
            Console.WriteLine(myListOfObjects.GetObject(5));
            Console.WriteLine(myListOfObjects.GetObject(11));
            Console.ReadKey();
        }
    }
}
