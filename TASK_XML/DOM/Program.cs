using System.IO;

namespace DOM
{
  class Program
  {
    static void Main(string[] args)
    {
      string path = @"C:\Users\Kate\Desktop\Exs.txt";
      string line;
      using (StreamReader sr = new StreamReader(path))
      {
        line = sr.ReadToEnd();
      }
      Searcher searcher = new Searcher();
      searcher.FindSuccessor(line);    
    }
  }
}
