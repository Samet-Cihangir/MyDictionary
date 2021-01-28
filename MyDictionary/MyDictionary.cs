using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<TKey, TValue>
    {
        public List<TKey> _keys;
        public List<TValue> _values;

        public MyDictionary()
        {
            _keys = new List<TKey>();
            _values = new List<TValue>();
        }

        public void Add(TKey key, TValue value)
        {
            foreach (TKey item in _keys)
            {
                if (item.Equals(key))
                {
                    Console.WriteLine("Hata aldınız , bu key daha önceden girimiştir.");
                    return;
                }

            }
            _keys.Add(key);
            _values.Add(value);
        }


        public TValue GetValue(TKey key)
        {
            int index = _keys.IndexOf(key);
            TValue value = _values[index];
            return value;
        }



    }
}
