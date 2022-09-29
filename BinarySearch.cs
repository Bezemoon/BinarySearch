using System;

namespace BinarySearch
{
    public class BinarySearch
    {
        private int[] _array;

        public BinarySearch(int[] array)
        {
            _array = array;
        }

        public int Search(int value)
        {
            int low = 0;
            int high = _array.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                int guess = _array[mid];

                if (value == guess)
                    return mid;

                if (value < guess)
                    high = mid - 1;
                else
                    low = mid + 1;
            }

            throw new Exception("value wasn't found");
        }
    }
}