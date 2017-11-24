import java.io.BufferedReader;
import java.io.FileInputStream;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.List;

/**
 * In total this class creates a list of nodes.
 */
public class XmlParser {

  private List<Node> allNodes = new ArrayList<>();

  /*
  to do
  This method creates a list of nodes.
  Calls all methods.
   */
  public void createsListOfNodes() {

  }

  /**
   * Read a lines from the xml file.
   * @return strLine a line from the xml file
   */
  private String readFile() {
    String strLine = null;
    try {
      FileInputStream fileInputStream = new FileInputStream("task.txt");
      BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(fileInputStream));
      if ((strLine = bufferedReader.readLine()) != null) {
        return strLine;
      }
    } catch (IOException e) {
      System.out.println("Exception" + e.getMessage());
    }
    return strLine;
  }

  /*
  to do
  This method search a tag for cut out a part of the file inside this tag later.
  The search is performed with <>, the content between them is cut out.
   */
  private String searchTag(String tag) {

    return tag;
  }

  /*
  to do
  Cuts out a certain part of the xml code between one tag, to simplify further work.
   */
  private void cutPartOfTheFileWithoutTag() {
  }
}
