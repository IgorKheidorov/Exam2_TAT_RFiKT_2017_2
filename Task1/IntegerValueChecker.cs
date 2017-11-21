using System;
using System.Globalization;


namespace Task1
{
    class IntegerValueChecker
    {
        public string Number
        {
            get; private set;
        }

        public bool IsSignNegative
        {
            get; private set;
        }

        public IntegerValueChecker(string number)
        {
            this.Number = number;
        }

        /*This method check is number don't go out to the borders of int
         and excute ParseString method to get valid number int string format
         */
        public bool IsNumberInteger()
        {
            
            char[] numberCategories = ParseString();
            string valueBorder = int.MaxValue.ToString();
            bool isNumberInteger = true;
            if (!IsStructOfNumberValid())
            {
                return false;
            }
            if ( numberCategories[0] == '-')
            {
                valueBorder = int.MinValue.ToString();
                IsSignNegative = true;
            }
            
            if ( numberCategories.Length > valueBorder.Length)
            {
                return false;
            }
            else if ( numberCategories.Length == valueBorder.Length)
            {
                for ( int i = 0; i < numberCategories.Length; i++)
                {
                    if ( numberCategories[i] > valueBorder[i])
                    {
                        isNumberInteger = false;
                        break;
                    }
                }
            }
            return isNumberInteger;
        }


        private bool IsStructOfNumberValid()
        {
            bool isValid = true;
            string[] a = Number.Split(',');
            if (a[0].Length > 4 || a[0].Contains("."))
            {
                isValid = false;
            }
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i].Contains(".") && i != a.Length - 1)
                {
                    isValid = false;
                }
                else if (a[i].Length != 3 && i != a.Length - 1 && i != 0)
                {
                    isValid = false;
                }
            }
            string[] b = a[a.Length - 1].Split('.');
            if (b.Length > 2)
            {
                isValid = false;
            }
            else if (b.Length == 2 && a.Length != 1 && b[0].Length != 3)
            {
                isValid = false;
            }
            //else if ( )
            return isValid;
        }

        /*
         Parse string to char array, if one of the symbols is not a digit
         we throw exception
         */
        private char[] ParseString()
        {

            char[] numberCategories = new char[Number.Length];
            if ( Number[0]!= '-' && Number[0] > 57 && Number[0] < 48)
            {
                throw new ArgumentException();
            }
            for (int i = 0; i < Number.Length; i++) {
                {
                    if ( Number[i] < 48 && Number[i] > 58 )
                    {
                        throw new ArgumentException();
                    }
                    numberCategories[i] = Number[i];
                }
            }
            return numberCategories;
        }


    }
}
