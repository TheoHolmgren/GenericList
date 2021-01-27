using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class ListOfObjects<T>
    {
        private T[] theList;
        private int noOfElements = 10;
        private int nextIndex; 

        public ListOfObjects()
        {
            theList = new T[noOfElements];
            nextIndex = 0;
        }

        public void AddObject(T obj)
        {
            if (nextIndex >= theList.Length)
            {
                Console.WriteLine("Array length exceeded");
                return;
            }
            theList[nextIndex] = obj;
            nextIndex++;
        }

            public T GetObject(int index)
            {
                if (index >= theList.Length)
            {
                Console.WriteLine("Array index too high");
                return default(T);

            }
            return theList[index];
            }
        }
        }
    

