using System;
using System.Collections;

namespace EnumeratorDemo
{
    public class PeopleEnum : IEnumerator
    {
        public Person[] _people;
        public PeopleEnum(Person[] list)
        {
            _people = list;
        }
        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }
        public Person Current
        {
            get
            {
                try
                {
                    return _people[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
        int position = -1;
        public bool MoveNext()
        {
            position++;
            return (position < _people.Length);
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
