using System;

namespace Exam
{
    /// <summary>
    /// Entry point to the program.
    /// Program that checks if inputed string can present an integer value,
    /// If yes converts it to Iteger value and output.
    /// </summary>
    class EntryPoint
    {
        public const string INPUTPROMPT = "Input value: ";
        /// <summary>
        /// Main class of the program.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(INPUTPROMPT);
                string inputValue = Console.ReadLine();
                Console.WriteLine(new IntegerParser(inputValue).Parse());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
