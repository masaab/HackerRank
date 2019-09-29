using System;
using System.Text;

namespace Algorithm
{
    public class SumVSXOR 
    {
        public long GetCountForMatchingOutput(long input)
        {
            int unset_bits = 0;
            while (input > 0)
            {
                if ((input & 1) == 0)
                {
                    unset_bits++;
                }
                input /= 2;
                //same as above
                //input >>= 1;
            }
            return (long)Math.Pow(2, unset_bits);
            
            //return 1 << unset_bits;
         
        }
    }
}
