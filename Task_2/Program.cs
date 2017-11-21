using System;


namespace Task_2
{
    /// <summary>
    /// Entry point.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            StringAnalyzer analyzer = new StringAnalyzer("dfgr");
            Console.WriteLine(analyzer.StringCanBeCreatingFrom("fgrd"));
        }
    }
}
