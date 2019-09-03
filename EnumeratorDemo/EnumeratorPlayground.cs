using System;
using System.Collections.Generic;

namespace EnumeratorDemo
{
    public class EnumeratorPlayground
    {
        public static void DisplayItems<T>(IEnumerable<T> collection)
        {
            using (IEnumerator<T> enumerator = collection.GetEnumerator())
            {
                bool hasMoreItems = enumerator.MoveNext();
                while(hasMoreItems)
                {
                    T item = enumerator.Current;
                    Console.WriteLine(item);
                    hasMoreItems = enumerator.MoveNext();
                }
            }
        }

        public static void DisplayItemsUsingForeach<T>(IEnumerable<T> collection)
        {
            foreach(T item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
