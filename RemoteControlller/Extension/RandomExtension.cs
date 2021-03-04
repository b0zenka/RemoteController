using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlller
{
    static class RandomExtension
    {
        public static bool TrueFalse(this Random rand)
        {
            return rand.Next() % 2 == 0;
        }
    }
}
