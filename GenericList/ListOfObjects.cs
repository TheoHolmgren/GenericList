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

        // Beskriv vad kontruktorn gör här
        public ListOfObjects()
        {
            theList = new T[noOfElements];
            nextIndex = 0;
        }

        //Beskriv vad metoden AddObject gör här
        //Metoden AddObject skapas med parametrarna T och obj
        //Inom metoden AddObject så finns det en If-sats som säger att om nextIndex är större än eller lika med längden av listan så printas det ut "Array length exceeded"
        //Variabeln obj tilldelas theList med indexet nextIndex
        //nextIndex plussas på och itererar igenom listan
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

        //Beskriv vad metoden GetObject gör här
        //Metoden GetObject  gör...
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
    

