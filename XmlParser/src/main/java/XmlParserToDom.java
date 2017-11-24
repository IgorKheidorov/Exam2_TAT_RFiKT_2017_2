/**
 * This class parse Xml document to DOM.
 */
public class XmlParserToDom {
  /**
   * Entry point to parse method.
   * @param input - xml document to string.
   * @return - root element for each step.
   */
  public Node parseXml(String input) {

    return parse(input, 0, input.length());
  }

  /**
   * Parse xml string.
   * TODO while cycle.
   * @param input - xml string
   * @param indexStart - index where parsing starts.
   * @param indexEnd - index where parsing ends.
   * @return - root element for each step.
   */
  private Node parse (String input, int indexStart, int indexEnd) {
    Node nextNode = new Node();
    String nodeName = input.substring(input.indexOf('<'), input.indexOf('>'));
    String nodeValue = input.substring(input.indexOf('>'), input.indexOf('<'));
    nextNode.setName(nodeName);
    nextNode.setValue(nodeValue);
    while() {
      parse(input, input.indexOf('<'), input.indexOf('>'));
    }
  }
  //TODO negative cases.
}