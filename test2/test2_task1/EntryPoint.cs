using System;

namespace test2_task1
{
    class EntryPoint
    {
        private const string MESSAGE = "YOUR DATA IS NOT CORRECT. TRY AGAIN:!";
        private const string INPUTDATA = "Input your string:";

        static void Main(string[] args)
        {
            bool continueProgram = true;
            while (continueProgram)
            {
                Console.WriteLine(INPUTDATA);
                string inputString = Console.ReadLine();
                char[] splitString = inputString.ToCharArray();
                StringWorker stringWorker = new StringWorker();
                if(stringWorker.IsValid(splitString))
                {
                   int result =  stringWorker.ConvertToInt(splitString);
                }
            }
        }
    }
}
