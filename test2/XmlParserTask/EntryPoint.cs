using System;

namespace XmlParserTask
{
    /// <summary>
    /// Main class of program which parse XMLfile to DOM object
    /// without the use of standart parser.
    /// </summary>
    class EntryPoint
    {
        static void Main(string[] args)
        {
            bool programContinue = true;
            while(programContinue)
            {
                try
                {
                    XmlFile xmlFile = new XmlFile();
                    string file = xmlFile.ReadFile();
                    xmlFile.FindRootNode(file);
                    Console.WriteLine(file);
                    programContinue = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    continue;
                }
            }
        }
    }
}
