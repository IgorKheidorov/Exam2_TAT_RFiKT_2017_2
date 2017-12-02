import java.util.ArrayList;
import java.util.List;
import java.util.Objects;

/**
 * This class creates a notebook.
 */
public class NoteBook {
  private String date;
  private String name;
  private List<Note> listOfNotes = new ArrayList<>();

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

  public List<Note> getListOfNotes() {
    return listOfNotes;
  }

  public void setListOfNotes(List<Note> listOfNotes) {
    this.listOfNotes = listOfNotes;
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
    NoteBook noteBook = (NoteBook) object;
    return Objects.equals(getDate(), noteBook.getDate()) &&
            Objects.equals(getName(), noteBook.getName()) &&
            Objects.equals(getListOfNotes(), noteBook.getListOfNotes());
  }

  /**
   * Returns a hash code value for the object.
   *
   * @return a hash code value for the object
   */
  @Override
  public int hashCode() {
    return Objects.hash(getDate(), getName(), getListOfNotes());
  }

  /**
   * Returns a string representation of the object.
   *
   * @return a string representation of the object
   */
  @Override
  public String toString() {
    return "NoteBook {" +
            "date = '" + date + '\'' +
            ", name = '" + name + '\'' +
            ", listOfNotes = " + listOfNotes +
            "} ";
  }
}
