/**
 * This class processes Xml file to DOM model.
 */
public class XmlParserToDom {
  private static final char end = '/';
  public static final char start = '<';

  /**
   * This function returns node of root
   *
   * @param file processing xml file
   * @return node of root
   */
  private Node parseXmlToDOM(String file) {
    return parse(file, 0, file.length());
  }

  /**
   * This function parse Nodes
   *
   * @param file  processing xml file
   * @param start start of file
   * @param end   end of file
   * @return node
   */
  public Node parse(String file, int start, int end) {
    String nodeName = file.substring(file.indexOf('<'), '>');
    String value = "";
    Node nextNode = new Node();
    nextNode.setNodeName(nodeName);
    nextNode.setValue(value);
    String cutFile = "";
    String[] fileArray = new String[]{file};
    while () {
      for (int i = file.indexOf('>'); i < fileArray.length; i++) {
        if (fileArray[i].charAt(0) == '<') {
          for (int j = file.indexOf(fileArray[i]); j < fileArray.length; j++) {

            if (fileArray[j] == '>') {
            }
            cutFile = file.substring(0, i);
            while ((cutFile.toCharArray())[i] == '/' && cutFile.toCharArray()[i + 1] == '>') {
              for (int j = i + 1; j > 0; j--) {
                cutFile = cutFile.substring(0, i + 1);
              }

            }
          }
          parse(file, file.indexOf(start), file.indexOf(end));
          nextNode.getChildren().add(nextNode);
        }
      }
    }
  }

  /**
   * This function tests if file is valid
   * @param file processing xml file
   * @return true if file is valide, false otherwice
   */
  public boolean isFileValid(String file) {


   return true;
  }
}
