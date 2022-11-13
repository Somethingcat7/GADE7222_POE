using System;
using System.Collections;
using System.Collections.Generic;

namespace MyHashMap {
    public class Hashmap<Tkey, Tvalue>
    {
        private LinkList<KeyValuePair<Tkey, Tvalue>>[] buckets;
        private int Size;
        public int Count { get; private set; }

        public Hashmap(int startSize)
        {
            Size = startSize;
            buckets = new LinkList<KeyValuePair<Tkey, Tvalue>>[Size];

            for (int i = 0; i < buckets.Length; i++)
            {
                buckets[i] = new LinkList<KeyValuePair<Tkey, Tvalue>>();
            }
        }

        public void Add(Tkey tkey, Tvalue tvalue)
        {
            var index = Math.Abs(tkey.GetHashCode() % buckets.Length);

            var newpair = new KeyValuePair<Tkey, Tvalue>(tkey, tvalue);

            if (buckets[index].Head != null)
            {
                if (buckets[index].Head.Data.Key.Equals(tkey))
                {
                    return;
                }
            }
            else
            {
                buckets[index].AddTailNode(newpair);
                Count++;
            }
        }

        public Tvalue this[Tkey tkey]
        {
            get
            {
                var index = Math.Abs(tkey.GetHashCode() % buckets.Length);
                var head = buckets[index].Head;

                while (head != null)
                {
                    if (head.Data.Key.Equals(tkey))
                    {
                        return head.Data.Value;

                    }

                    head = head.Next;

                }

                return default(Tvalue);
            }

            set
            {
                var index = Math.Abs(tkey.GetHashCode() % buckets.Length);
                var head = buckets[index].Head;

                while (head != null)
                {
                    if (head.Data.Key.Equals(tkey))
                    {
                        head.Data = new KeyValuePair<Tkey, Tvalue>(tkey, value);
                        break;
                    }

                    head = head.Next;

                }
            }
        }

       
    }
};
