using System;
using System.Collections.Generic;

namespace EnumeratorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string[] daysOfWeeks =
            {
                "Sunday",
                "Monday",
                "Tuesday",
                "Wedensday",
                "Thursday",
                "Friday",
                "Saturday"
            };

            EnumeratorPlayground.DisplayItems(daysOfWeeks);

            EnumeratorPlayground.DisplayItemsUsingForeach(daysOfWeeks);
            Console.ReadKey(true);
        }
    }

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
