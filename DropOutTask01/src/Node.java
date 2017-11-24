import java.util.ArrayList;
import java.util.List;

/**
 * This class determines fields
 */
public class Node {

  private String tag;
  private String value;
  private List<Node> childNode = new ArrayList<>();

  public String getTag() {
    return tag;
  }

  public void setTag(String tag) {
    this.tag = tag;
  }

  public String getValue() {
    return value;
  }

  public void setValue(String value) {
    this.value = value;
  }

  public List<Node> getChildNode() {
    return childNode;
  }

  public void setChildNode(List<Node> childNode) {
    this.childNode = childNode;
  }
}
