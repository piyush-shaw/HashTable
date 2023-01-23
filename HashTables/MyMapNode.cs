﻿using System;
namespace HashTables
{
	//creating the MapNode to add keyvalue pair to linkedlist at position given by hash
	public class MyMapNode<K,V>
	{
		private readonly int size;
		private readonly LinkedList<KeyValue<K, V>>[] items;

        public MyMapNode(int size)
        {
			this.size = size;
			this.items = new LinkedList<KeyValue<K, V>>[size];
        }

		//Method to get the index number
		protected int GetArrayPosition(K key)
		{
			int position = key.GetHashCode() % size;
			return Math.Abs(position);
		}

		//Method to return the value at given key 
		public V Get(K key)
		{
			int position = GetArrayPosition(key);
			LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
			foreach(KeyValue<K,V> item in linkedList)
			{
				if (item.Key.Equals(key))
				{
					return item.Value;
				}
			}
			return default(V);
		}

		//Method for adding the key and value in the linkedlist 
		public void Add(K key,V value)
		{
			int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
			KeyValue<K, V> item = new KeyValue<K, V>() { Key = key, Value = value };
			linkedList.AddLast(item);
        }

		//Method to get array position i.e 0,1 etc and linkedlist
		protected LinkedList<KeyValue<K,V>> GetLinkedList(int position)
		{
			LinkedList<KeyValue<K, V>> linkedList = items[position];
			if (linkedList == null)
			{
				linkedList = new LinkedList<KeyValue<K, V>>();
				items[position] = linkedList;
			}
			return linkedList;
		}
    }

	public struct KeyValue<k, v>
	{
		public k Key { get; set; }
		public v Value { get; set; }
	}
	
}
