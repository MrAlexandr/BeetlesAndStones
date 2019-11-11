using System;
using System.Collections.Generic;
using System.Text;

namespace BeetlesAndStones
{
    class Stone
    {
        public static uint IDs = 0;

        public uint id;

        public Beetle beetle;
        //{
        //    get
        //    {
        //        return beetle;
        //    }
        //    set
        //    {
        //        if (value is Beetle)
        //        {
        //            beetle = value;
        //        }
        //    }
        //}

        public Stone()
        {
            id = IDs;

            IDs += 1;
        }

        public bool BeetleUnderStone()
        {
            if (beetle != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
