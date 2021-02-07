using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary1<T>
    {
        T[] _array;
        public MyDictionary1()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            T[] _tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
            _array[_array.Length - 1] = item;
        }
        public int Count
        {
            get { return _array.Length; }
        }

    }
}
