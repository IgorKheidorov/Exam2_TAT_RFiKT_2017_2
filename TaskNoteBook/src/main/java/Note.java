import java.util.Objects;

/**
 * This class creates a note.
 */
public class Note {
  private String date;
  private String name;
  private String content;

  public String getDate() {
    return date;
  }

  public void setDate(String date) {
    this.date = date;
  }

  public String getName() {
    return name;
  }

  public void setName(String name) {
    this.name = name;
  }

  public String getContent() {
    return content;
  }

  public void setContent(String content) {
    this.content = content;
  }

  /**
   * Indicates whether some other object is "equal to" another one.
   *
   * @param object the reference object with which to compare
   * @return true if this object is the same as the object argument; false otherwise
   */
  @Override
  public boolean equals(Object object) {
    if (this == object) {
      return true;
    }
    if (object == null || getClass() != object.getClass()) {
      return false;
    }
    Note note = (Note) object;
    return Objects.equals(getDate(), note.getDate()) &&
            Objects.equals(getName(), note.getName()) &&
            Objects.equals(getContent(), note.getContent());
  }

  /**
   * Returns a hash code value for the object.
   *
   * @return a hash code value for the object
   */
  @Override
  public int hashCode() {
    return Objects.hash(getDate(), getName(), getContent());
  }

  /**
   * Returns a string representation of the object.
   *
   * @return a string representation of the object
   */
  @Override
  public String toString() {
    return "Note {" +
            "date = '" + date + '\'' +
            ", name = '" + name + '\'' +
            ", content = '" + content + '\'' +
            "} ";
  }
}
