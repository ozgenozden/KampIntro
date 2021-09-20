using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryExample
{
    class MyDictionary<K, T>
    {
        K[] key;
        T[] value;

        K[] tempKey;
        T[] tempValue;

        public MyDictionary()
        {
            key = new K[0];
            value = new T[0];
        }

        public void Add(K keyy, T valuee)
        {
            tempKey = key;
            tempValue = value;

            key = new K[key.Length + 1];
            value = new T[value.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                key[i] = tempKey[i];
                value[i] = tempValue[i];
            }

            key[key.Length - 1] = keyy;
            value[value.Length - 1] = valuee;
            

        }

        public T ContainsKey(K ke){

           int index= Array.IndexOf(key, ke);

            return value[index];


            }
    }
}
