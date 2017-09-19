// All sorting methods, functions and algorithms should go here,
// This class also can be used as the logic layer

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubble_sort
{
    class cls_bubbleSort_logic
    {

        // 20170918 : YRM : Bubble sort function
        // - Requires an int array as input
        // - Returns bubble sorted int[] output

        //// input array to sort
        //int[] sort_array_me = { 8, 1, 5, 7, 6, 7, 2, 9 };

        public static int[] BubbleSort(int[] sort_array)
        {
            int length = sort_array.Length;

            int temp = sort_array[0];

            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (sort_array[i] > sort_array[j])
                    {
                        temp = sort_array[i];

                        sort_array[i] = sort_array[j];

                        sort_array[j] = temp;
                    }
                }
            }

            // Return bubble sorted array
            return sort_array;
        }

        
    }

}
