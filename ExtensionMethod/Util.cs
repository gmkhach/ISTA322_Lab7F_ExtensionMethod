using System;

namespace Extensions
{
    static class Util
    {
        public static int ConvertToBase(this int i, int baseToConvertTo)
        {
            if (baseToConvertTo < 2 || baseToConvertTo > 10)
            {
                throw new ArgumentException("Value cannot be converted to base " +
                baseToConvertTo.ToString());
            }
        }
    }
}