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
            bool[] usedLink = new bool[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                if (usedLink[i])
                {
                    continue;
                }

                int counter = 1;
                int link = array[i];
                usedLink[link] = true;

                do
                {
                    link = array[link];
                    usedLink[link] = true;
                    counter++;

                } while (i != link);

                maximumLenght = counter > maximumLenght ? counter : maximumLenght;
            }

            return maximumLenght;
        }
    }
}
