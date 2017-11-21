using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class ToIntConverter
    {
        IntegerValueChecker valueChecker;

        public ToIntConverter(IntegerValueChecker valueChecker)
        {
            this.valueChecker = valueChecker;
        }

        public int ConvertToInt()
        {
            if (!valueChecker.IsNumberInteger())
            {
                throw new ArgumentException();
            }
            string numberString = valueChecker.Number;
            int number = 0;
            int index = 0, multiplier = 1;
            if ( valueChecker.IsSignNegative )
            {
                index = 1;
            }
            for ( int i = numberString.Length - 1; i >= index; i--)
            {
                if ( numberString[i] == ',')
                {
                    continue;
                }
                number += (numberString[i] - 48) * multiplier;
                multiplier *= 10;
            }
            if ( valueChecker.IsSignNegative)
            {
                number = -number;
            }
            return number;
        }
    }
}
