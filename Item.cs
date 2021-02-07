using System;
using System.Collections.Generic;
using System.Text;

namespace My_Hash_Table
{
    class Item<T>
    {
        public int Key { get; set; }
        public List<T> Nodes { get; set; }
        public Item(int key)
        {            
            Key = key;
            Nodes = new List<T>();
        }
    }
}
