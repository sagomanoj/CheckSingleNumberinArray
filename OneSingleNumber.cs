using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class OneSingleNumber
    {
        //Given an Array of elements, all the elements in the array are repeated twice except an element. Find the single number.

        public int SingleNumber(int[] array)
        {
            int result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                result = array[i] ^ result;
            }

            return result;
        }
    }
}
