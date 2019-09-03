using System.Collections;

namespace EnumeratorDemo
{
    public class People : IEnumerable
    {
        Person[] _person;
        public People(Person[] peopleArray)
        {
            _person = new Person[peopleArray.Length];

            for(int i = 0; i < peopleArray.Length; i++)
            {
                _person[i] = peopleArray[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public PeopleEnum GetEnumerator()
        {
            return new PeopleEnum(_person);
        }
    }
}
