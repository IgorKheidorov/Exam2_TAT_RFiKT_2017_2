import java.io.File;
import java.util.Scanner;

public class EntryPoint {
  public static void main(String[] args) throws Exception {
    XmlParserToDom xmlParserToDom = new XmlParserToDom();
    Scanner inputFile = new Scanner(new File("input.xml"));
    String input = inputFile.toString();
    xmlParserToDom.parseXml(input);
  }
}
