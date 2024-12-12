using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16___2
{
    internal class myHelper
    {
        static int small;

        public static int findsmall(int[] arr)
        {
            small = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < small)
                {
                    small = arr[i];
                }
            }
            return small;
        }
        public static int CountUppercaseLetters(string name)
        {
            int count = 0;

            for (int i = 0; i < name.Length; i++)
            {
                if (char.IsUpper(name[i]))
                {
                    count++;

                }
            }
            return count;
        }







    }
}
