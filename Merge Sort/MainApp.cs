using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithm
{
    class MainApp
    {
        static void Main( string[] args )
        {
            int[] arg = { 1, 2, 7, 16, 9, 3, 8, 2, 30, 24 };
            Print();

            MergeSort.AscendingSort(ref arg);
            Print();

            MergeSort.DescendingSort(ref arg);
            Print();

            void Print()
            {
                foreach( int i in arg )
                {
                    Console.Write($"{i} ");
                }

                Console.WriteLine("\n");
            }
        }
    }
}
