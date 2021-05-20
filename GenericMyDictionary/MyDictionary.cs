using System;
using System.Collections.Generic;
using System.Text;

namespace GenericMyDictionary
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] _arrayK;
        TKey[] _tempArrayK;

        TValue[] _arrayV;
        TValue[] _tempArrayV;

        public MyDictionary()
        {
            _arrayK = new TKey[0];
            _arrayV = new TValue[0];
        }

        public void Add(TKey Plaque, TValue City)
        {
            _tempArrayK = _arrayK;
            _tempArrayV = _arrayV;

            _arrayK = new TKey[_arrayK.Length + 1];
            _arrayV = new TValue[_arrayV.Length + 1];

            for (int i = 0; i < _tempArrayK.Length; i++)
            {
                _arrayK[i] = _tempArrayK[i];
                _arrayV[i] = _tempArrayV[i];
            }

            _arrayK[_arrayK.Length - 1] = Plaque;
            _arrayV[_arrayV.Length - 1] = City;
        }

        private int _count;

        public int Count2
        {
            get { return _arrayK.Length; }
        }

        public TValue this[TKey plaque]
        {
            get
            {
                return _arrayV[Array.IndexOf(_arrayK, plaque)];
            }
        }
    }
}

