using System;

namespace BinarySearch
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] array = {1, 2, 3, 5, 6, 8, 9};
            BinarySearch binarySearch = new BinarySearch(array);

            try
            {
                int index = binarySearch.Search(4);
                Console.WriteLine(array[index]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}