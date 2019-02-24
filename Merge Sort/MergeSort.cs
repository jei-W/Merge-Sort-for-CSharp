using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithm
{
    class MergeSort
    {
        public static void AscendingSort( ref int[] arg )
        {
            int[][] half = Split(arg);


            for( int i = 0; i < 2; i++ )
            {
                if( half[i].Length > 1 )
                {
                    AscendingSort(ref half[i]);
                }
            }

            arg = MergeForAscendingSort(half[0], half[1]);
            

            int[] MergeForAscendingSort( int[] a, int[] b )
            {
                int[] result = new int[a.Length + b.Length];
                int aIndex = 0;
                int bIndex = 0;

                for( int i = 0; i < result.Length; i++ )
                {
                    if( aIndex >= a.Length )
                    {
                        result[i] = b[bIndex];
                        bIndex++;
                    }

                    else if( bIndex >= b.Length )
                    {
                        result[i] = a[aIndex];
                        aIndex++;
                    }

                    else if( a[aIndex] <= b[bIndex] )
                    {
                        result[i] = a[aIndex];
                        aIndex++;
                    }

                    else if( a[aIndex] > b[bIndex] )
                    {
                        result[i] = b[bIndex];
                        bIndex++;
                    }
                }

                return result;
            }
        }

        public static void DescendingSort( ref int[] arg )
        {
            int[][] half = Split(arg);


            for( int i = 0; i < 2; i++ )
            {
                if( half[i].Length > 1 )
                {
                    DescendingSort(ref half[i]);
                }
            }

            arg = MergeForDescendingSort(half[0], half[1]);


            int[] MergeForDescendingSort( int[] a, int[] b )
            {
                int[] result = new int[a.Length + b.Length];
                int aIndex = 0;
                int bIndex = 0;

                for( int i = 0; i < result.Length; i++ )
                {
                    if( aIndex >= a.Length )
                    {
                        result[i] = b[bIndex];
                        bIndex++;
                    }

                    else if( bIndex >= b.Length )
                    {
                        result[i] = a[aIndex];
                        aIndex++;
                    }

                    else if( a[aIndex] >= b[bIndex] )
                    {
                        result[i] = a[aIndex];
                        aIndex++;
                    }

                    else if( a[aIndex] < b[bIndex] )
                    {
                        result[i] = b[bIndex];
                        bIndex++;
                    }
                }

                return result;
            }
        }




        static int[][] Split( int[] arg )
        {
            int ForwardHarfSize = arg.Length / 2;
            int BackwardHalfSizs = arg.Length % 2 == 1 ? ForwardHarfSize + 1 : ForwardHarfSize;

            int[][] result = { new int[ForwardHarfSize], new int[BackwardHalfSizs] };

            for( int i = 0; i < ForwardHarfSize; i++ )
            {
                result[0][i] = arg[i];
            }
          
            for( int j = 0; j < BackwardHalfSizs; j++ )
            {
                result[1][j] = arg[ForwardHarfSize + j];
            }

            return result;
        }
    }
}
