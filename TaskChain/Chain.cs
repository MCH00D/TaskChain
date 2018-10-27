using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskChain
{
    public static class Chain
    {
        public static int GetMaximumLength(int[] array)
        {
            if (array.Length == 0 || array.Length == 1)
            {
                return array.Length;
            }

            int maximumLenght = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int counter = 1;
                int link = array[i];

                do
                {
                    link = array[link];
                    counter++;

                } while (i != link);

                maximumLenght = counter > maximumLenght ? counter : maximumLenght;
            }

            return maximumLenght;
        }
    }
}
