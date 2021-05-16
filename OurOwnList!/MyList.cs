using System;
using System.Collections.Generic;
using System.Text;

namespace OurOwnList_
{

    class MyList<T> where T : IComparable<T>
    {
        public int Count { get; private set; } = 0;
        //fortesting
     
        T[] thelist = new T[10];
        public int fulllength
        {
            get
            {
                return thelist.Length;
            }
        }
        public T this[int index]
        {
            get
            {
                return thelist[index];
            }
            set
            {
                thelist[index] = value; 
            }
        }

        public MyList()
        {

        }

        public void Addtolist(T thingadding)
        {
            thelist[Count] = thingadding;
            Count += 1;
            if (Count == thelist.Length)
            {
                //addtothelistnewindexes

                T[] temp = new T[thelist.Length+10];
                for(int i = 0;i < thelist.Length; i++)
                {
                    temp[i] = thelist[i];
                }
                thelist = temp;


            }
        }

        public void removefromlist(T thingremoved)
        {
            int hasithit = 0;
            T[] temp = new T[thelist.Length];
            for (int i = 0; i < Count; i++)
            {
                int x = 30;
                int y = 20;

                int comparison = x.CompareTo(y);
                if (thelist[i].CompareTo(thingremoved) == 0)
                {
                    hasithit += 1;
                }
                else
                {
                    temp[i - hasithit] = thelist[i];
                }
            }
            thelist = temp;
        }

        public void removeindex(int index)
        {
            int hasithit = 0;
            T[] temp = new T[thelist.Length];
            for (int i = 0; i < Count; i++)
            {
                if (i == index)
                {
                    hasithit += 1;
                }
                else
                {
                    temp[i-hasithit] = thelist[i];
                }
            }
            thelist = temp;
        }
    }
}
