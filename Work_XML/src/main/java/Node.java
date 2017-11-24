import java.util.List;

/**
 * This is class wich store structure of node
 */
public class Node {
  private String nodeName;
  private String value;
  private List<Node> children;

  public String getNodeName() {
    return nodeName;
  }

  public List<Node> getChildren() {
    return children;
  }

  public void setValue(String value) {
    this.value = value;
  }

  public void setChildren(List<Node> children) {
    this.children = children;
  }

  public void setNodeName(String nodeName) {
    this.nodeName = nodeName;
  }
}
