namespace test2_task1
{
    public class StringWorker
    {
        public bool IsValid(char[] splitString)
        {
            return IsLengthValid(splitString) && IsSymbolsValid(splitString);
        }

        private bool IsLengthValid(char[] splitString)
        {
            bool validation = false;
            if(splitString.Length > 0 || (splitString[0] == '-' && splitString.Length > 1))
            {
                validation = true;
            }
            return validation;
        }

        private bool IsNegative(char[] splitString)
        {
            bool negative = false;
            if (splitString[0] == '-')
            {
                negative = true;
            }
            return negative;
        }

        private bool IsValidAfterSeparator(char[] splitString)
        {
            bool validation = true;
            int count = 0;
            for (int i = 0; i < splitString.Length; i++)
            {
                if (splitString[i] == '.' || splitString[i] == ',')
                {
                    count++;
                }
            }
            int temp = splitString.Length - 1;
            if(count > 0)
            {
                while (splitString[temp] != '.' || splitString[temp] != ',')
                {
                    if (splitString[temp] != '0')
                    {
                        return validation = false;
                    }
                    temp--;
                }
            }
            return validation;
        }


        private bool IsSymbolsValid(char[] splitString)
        {
            bool validation = true;
            for(int i = 0; i < splitString.Length; i++)
            {
                if (i == 0 && splitString[i] == '-')
                {
                    continue;
                }
                if(IsValidAfterSeparator(splitString))
                {
                    if (splitString[i] < '0' || splitString[i] > '9')
                    {
                        return validation = false;
                    }
                }
            }
            return validation;
        }

        public int ConvertToInt(char[] splitString)
        {
            int result = 0;
            for (int i = 0; i < splitString.Length; i++)
            {
                if (i == 0 && splitString[i] == '-')
                {
                    continue;
                }
                if (splitString[i] == '.' || splitString[i] == ',')
                {
                    continue;
                }
                result = result * 10 + (splitString[i] - '0');
            }
            return result;
        }

    }
}
