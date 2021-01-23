using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<TKey,TValue>
    {
        TKey[] keys;
        TKey[] tempKeys;
        TValue[] values;
        TValue[] tempValues;
        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }
        public void Add(TKey key, TValue value)
        {
            tempKeys = keys;
            tempValues = values;

            for (int i = 0; i < tempKeys.Length; i++)
            {
                if (key == null)
                {
                    throw new ArgumentNullException("Key null olamaz!");
                }
                else if (tempKeys[i].Equals(key))
                {
                    throw new ArgumentException("Bu Key'e sahip değer mevcut.");
                }
            }

            keys = new TKey[keys.Length + 1];
            values = new TValue[values.Length + 1];
            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];
            }
            keys[keys.Length - 1] = key;
            values[keys.Length - 1] = value;
        }

        public void ListAll()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine("Key: "+keys[i] + " Value: " +values[i]);
            }
        }
    }
}
