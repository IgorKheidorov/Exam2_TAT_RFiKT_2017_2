import org.junit.Test;

public class XmlParserToDomTest {
  @Test
  public void parseXmlOneChild() throws Exception {
    XmlParserToDom xmlParserToDom = new XmlParserToDom();
    String input = "<cars><car>Volvo</car></cars>";
    //TODO call method.
  }
  @Test
  public void parseXmlTwoChildren() {
    XmlParserToDom xmlParserToDom = new XmlParserToDom();
    String input = "<cars><car>Volvo<littleCar>Volvochka</littleCar></car></cars>";
    //TODO call method.
  }
  @Test
  public void parseXmlWrongFormat() {
    XmlParserToDom xmlParserToDom = new XmlParserToDom();
    String input = "<cars></>";
    //ToDO call method.
  }
  @Test
  public void parseXmlWithoutChild() {
    XmlParserToDom xmlParserToDom = new XmlParserToDom();
    String input = "<cars></cars>";
    //TODO call method.
  }
  @Test
  public void parseXmlEmptyString() {
    XmlParserToDom xmlParserToDom = new XmlParserToDom();
    String input = "";
    //TODO call method.
  }
}