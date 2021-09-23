using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projwithclass
{
    class Comparator
    {
       public int findMax (int first, int second)
        {
            int result;
            if( first>second)
                {
                result = first;
                }
            else
            {
                result = second;
            }
            return result;

        }
    }
}
