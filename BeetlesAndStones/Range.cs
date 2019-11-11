using System;
using System.Collections.Generic;
using System.Text;

namespace BeetlesAndStones
{
    static class Range
    {
        public static long len = -1;
        public static uint center = 0;
        public static uint hmax, lmin;


        public static void range(Stone[] stonesArr)
        {
            len = -1;
            center = 0;
            hmax = 0;
            lmin = 0;

            uint high = 0;
            uint low = 0;
            double lenght = 0;
            uint maxi = 0;
            uint cent=0;

            while (maxi < stonesArr.Length)
            {
                for (uint i = maxi; i <= stonesArr.Length; i++)
                {
                    //Console.WriteLine(i);
                    if (stonesArr[i].beetle == null || i >= stonesArr.Length)
                    {
                        low = i;
                        break;                        
                    }
                    //Console.WriteLine(i);
                }

                for (uint i = low; i <= stonesArr.Length; i++)
                {
                    //Console.WriteLine(i);
                    if (stonesArr[i].beetle != null)
                    {
                        high = i - 1;
                        maxi = high + 2;
                        break;
                    }

                    if (i >= stonesArr.Length - 1)
                    {
                        high = Convert.ToUInt32(stonesArr.Length)-1;
                        maxi = high + 2;
                        break;
                    }
                    //Console.WriteLine(stonesArr[i].beetle);
                }

           

                lenght = high - low;

                cent = Convert.ToUInt32(low + Math.Floor(lenght / 2));

                if (lenght > len)
                {
                    len = Convert.ToUInt32(lenght);
                    hmax = high;
                    lmin = low;
                    center = cent;
                }

                
            }
        }
    }
}
