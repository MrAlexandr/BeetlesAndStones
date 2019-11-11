using System;
using System.Collections.Generic;
using System.Text;

namespace BeetlesAndStones
{
    class Beetle
    {
        public static uint IDs=0;

        public uint id;

        public Beetle()
        {
            id = IDs;

            IDs += 1;
        }
    }
}
