import org.testng.annotations.DataProvider;
import org.testng.annotations.Test;

import static org.testng.Assert.*;
import static org.testng.Assert.assertFalse;

/**
 * This class is a test class.
 */
public class XmlParserToDomTest {
  XmlParserToDom xmlParserToDom = new XmlParserToDom();
  @DataProvider(name="testValidData")
  public static Object[][] testValidData() {
    return new Object[][] {
            { "<Cars></Cars>" },
            { "<Cars> nameOfCars </Cars>"},
            {"<Cars><car></car></Cars>"},
            {"<Cars><cad>bmv</car></Cars>"},
    };
  }

  @Test(dataProvider = "testInvalidData")
  public void testIsInvalidData (String string) {
    assertFalse(path.isPathValid(string));
  }
  @Test(dataProvider = "testValidData")
  public void parseXmlWrongFormat(String string) {
  assertTrue(xmlParserToDom.isFileValid(string));
  }

}