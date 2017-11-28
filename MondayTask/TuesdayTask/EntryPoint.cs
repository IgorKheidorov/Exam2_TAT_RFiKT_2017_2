using System;

namespace TuesdayTask
{
    /// <summary>
    /// Entry Point to the program.
    /// </summary>
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(new ComplexNumber(2, 3).CompareTo(new ComplexNumber(3, 3)));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
