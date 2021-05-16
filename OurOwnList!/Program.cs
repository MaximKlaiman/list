using System;
using System.Collections.Generic;
using System.IO;

namespace OurOwnList_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MyList<int> listofbools = new MyList<int>();

            for (int i = 0; i <= 25; i++)
            {
                listofbools.Addtolist(i);
            }
            //changed a line
            listofbools.removefromlist(7);
            
            //listofbools.Addtolist();

            for (int i = 0; i < listofbools.Count; i++)
            {
                Console.WriteLine(listofbools[i]);
            }


          
        }
    }
}
