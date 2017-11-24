import java.util.List;

/**
 * This class contains nodes for XML to DOM parsing.
 */

public class Node {
  private String name;
  private String value;
  private List<Node> nodes;
  public String getName() {
    return this.name;
  }
  public String getValue() {
    return this.value;
  }
  public List<Node> getNodes() {
    return this.nodes;
  }
  public void setName(String name) {
    this.name = name;
  }
  public void setValue(String value) {
    this.value = value;
  }
  public void setNodes(List<Node> nodes) {
    this.nodes = nodes;
  }
}