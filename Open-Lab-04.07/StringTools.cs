using System;
using System.Linq;

namespace Open_Lab_04._07
{
    public class StringTools
    {
        public string Reverse(string original)
        {
            char[] reversed = original.ToCharArray();
            Array.Reverse(reversed);
            return new string(reversed);
        }
    }
}
