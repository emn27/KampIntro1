using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<TKey, TValue>
    {

        TKey[] keys;
        TValue[] values;

        public bool Count { get; internal set; }

        internal void Add(string v)
        {
            throw new NotImplementedException();
        }

        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }
        public void Add(TKey key, TValue value)
        {
            if (IsKeyNull(key))
            {
                System.Console.WriteLine("Key is not null!");
            }
            if (IsKeyContains(key))
            {
                System.Console.WriteLine("Key does exist!");
            }
            AddItem(key, value);

        }
        private void AddItem(TKey key, TValue value)
        {
            TKey[] tempKeys = keys;
            TValue[] tempValues = values;

            keys = new TKey[keys.Length + 1];
            values = new TValue[tempValues.Length + 1];
            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];
            }

            keys[tempKeys.Length - 1] = key;
            values[tempValues.Length - 1] = value;

        }
        //check is key null
        public bool IsKeyNull(TKey key)
        {
            if (key == null)
            {
                return true;
            }
            var type = key.GetType();
            if (type == typeof(string) && string.IsNullOrEmpty(key.ToString()))
            {
                return true;
            }
            return false;
        }
        private bool IsKeyContains(TKey key)
        {
            if (keys.Contains(key))
            {
                return true;
            }
            return false;
        }
        public void GetList()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                System.Console.WriteLine(keys[i] + "-" + values[i]);
            }

        }
    }
}
