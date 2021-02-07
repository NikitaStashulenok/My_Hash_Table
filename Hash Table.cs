using System;
using System.Collections.Generic;
using System.Text;

namespace My_Hash_Table
{
    public class Hash_Table<TKey, TValue>
    {
        private List<TValue>[] items;

        public Hash_Table(int size)
        {
            items = new List<TValue>[size];
        }
        public void Add(TKey key, TValue value)
        {
            var k = GetHash(key);
            if (items[k] == null)
            {
                items[k] = new List<TValue>() { value };
            }
            else
            {
                items[k].Add(value);
            }
        }
        public bool Search(TKey key, TValue item)
        {
            var k = GetHash(key);
            return items[k]?.Contains(item) ?? false;
        }
        public int GetHash(TKey key)
        {
            return Convert.ToInt32(key.ToString().Substring(0, 1)); //could be better
        }
    }
}
