/**
 * Element of {@link Stack}
 * Contains a link to a previous element.
 */
public class Element {
  private Object item;
  private Element previous;

  public void setItem(Object item) {
    this.item = item;
  }

  public void setPrevious(Element previous) {
    this.previous = previous;
  }

  public Object getItem() {
    return item;
  }

  public Element getPrevious() {
    return previous;
  }
}