using System;

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
            Console.WriteLine("***************My Implementaion of IEnumerable **************");
            MyEnumerable enumerable = new MyEnumerable();
            enumerable.EnumerableImpl();
            Console.ReadKey(true);
        }
    }
}
