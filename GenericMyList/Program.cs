﻿using System;
using System.Collections.Generic;

namespace GenericMyList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Antalya");
            sehirler.Add("İzmir");
            sehirler.Add("Konya");

            Console.WriteLine(sehirler.Count);
            

            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Antalya");
            sehirler2.Add("İzmir");
            sehirler2.Add("Ankara");
            sehirler2.Add("Konya");

            Console.WriteLine(sehirler2.Count2);
        }
    }

    class MyList<T>
    {
        T[] _array;
        T[] _tempArray;

        public MyList()
        {
            _array = new T[0];
        }

        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];

            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }

            _array[_array.Length - 1] = item;
        }

        private int _count;

        public int Count2
        {
            get { return _array.Length; }
        }

    }
}
