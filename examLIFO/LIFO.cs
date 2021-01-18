using System;
using System.Collections.Generic;
using System.Text;

namespace examLIFO
{
    public class LIFO
    {
        private int[] _array;
        private int _length;


        public LIFO(int size)
        {
            _array = new int[size];
        }



        public int Length
        {
            get
            {
                return _array.Length;
            }
        }

        public int Count()
        {
            return _length;
        }
        public int Get()
        {
            lock (_array)
            {
                var index = _array.Length - _length;
                var item = _array[index];
                _array[index] = 0;
                _length--;
                return item;
            }
        }

        public void Push(int item)
        {
            lock (_array)
            {
                if (_length == _array.Length)
                    return;
                _array[_array.Length - _length - 1] = item;
                _length++;
            }
        }
    }
}
