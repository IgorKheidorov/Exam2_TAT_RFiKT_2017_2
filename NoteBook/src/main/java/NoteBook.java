import java.util.ArrayList;

/**
 * This class stores Notes.
 */
public class NoteBook {
  private ArrayList<Note> note = new ArrayList<Note>();

  /**
   * This function add Note to notebook
   * @param singleNote is transmitted note.
   */
  public void setNote(Note singleNote) {
    this.note.add(singleNote);
  }

  public ArrayList<Note> getNote() {
    return note;
  }

  /**
   * This function is override of hashCode
   * @return hashCode which already override
   */
  @Override
  public int hashCode() {
    final int prime = 31;
    int result = 1;
    result = prime * result + ((note == null) ? 0 : note.hashCode());
    return result;
  }

  /**
   * This function override equal method
   * @param obj is an object for comparing
   * @return true if is equal, false otherwise.
   */
  @Override
  public boolean equals(Object obj) {
    if (obj == this) {
      return true;
    }
    if (obj == null || obj.getClass() != this.getClass()) {
      return false;
    }
    NoteBook other = (NoteBook) obj;
    if (note == null) {
      if (other.note != null) {
        return false;
      } else if (!this.note.equals(other.note)) {
        return false;
      }
    }
    return true;
  }

  /**
   * This function override toString method
   * @return Returns the string representation of notebook.
   */
  @Override
  public String toString() {
    return String.format("NoteBook " + note );
  }
}
