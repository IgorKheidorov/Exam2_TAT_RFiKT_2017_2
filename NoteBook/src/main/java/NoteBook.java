import java.util.ArrayList;

/**
 * This class is notebook, that contains of notes.
 */

public class NoteBook {
  private ArrayList<Note> notes;
  public NoteBook(ArrayList<Note> notes) {
    this.notes = notes;
  }
  public ArrayList<Note> getNotes() {
    return this.notes;
  }
  public void setNotes(ArrayList<Note> notes) {
    this.notes = notes;
  }
  /**
   * This method is override hashCode method for notebook class.
   * @return - hashCode of notebook.
   */
  @Override
  public int hashCode() {
    final int prime = 31;
    int result = 1;
    result = prime * result + notes.hashCode();
    return result;
  }

  /**
   * This method override equals method for notebook class.
   * @param obj - notebook, that is compared.
   * @return - true, if notebooks are equals, false - in another case.
   */
  @Override
  public boolean equals(Object obj) {
    if (obj == this) return true;
    if (!(obj instanceof Note)) {
      return false;
    }
    Note note = (Note) obj;
    return notes.equals(notes);
  }


  /**
   * This method override toString method for notebook class.
   * @return - one notebook in string presentation.
   */
  @Override
  public String toString() {
    String notesOnTheScreen = "";
    for (int i = 0; i < notes.size(); i++) {
      notesOnTheScreen += notes.get(i).toString();
    }
    return notesOnTheScreen;
  }
}