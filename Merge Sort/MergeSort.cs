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
            //1.배열을 반으로 쪼갠다
            //2.반으로 쪼갠 크기가 2보다 크면 또 쪼갠다
            //3.쪼개진 배열 요소를 차례로 비교해 나가면서 합친다

            int[][] half = Split(arg);


            for( int i = 0; i < 2; i++ )
            {
                //분할된 크기가 1이 될때까지 반복적으로 분할 한다
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
