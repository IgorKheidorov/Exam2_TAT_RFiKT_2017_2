using System;
using System.Collections.Generic;

namespace XMLToDomTask
{
    /// <summary>
    /// Entry point to the program that parses xml file to DOM object.
    /// </summary>
    class EntryPoint
    {
        /// <summary>
        /// Main class to the program.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            try
            {
                XMLFormat form = new XMLFormat();
                form.Read();
                form.ParseAllString();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
