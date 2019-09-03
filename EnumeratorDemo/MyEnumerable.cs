using System;

namespace EnumeratorDemo
{
    public class MyEnumerable
    {
        public void EnumerableImpl()
        {
            Person[] peopleArray = new Person[3]
            {
                new Person("John", "Smith"),
                new Person("Jim", "Johnson"),
                new Person("Sue", "Rabon"),
            };

            People peopleList = new People(peopleArray);

            foreach(var person in peopleList)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName}");
            }
        }
    }
}
