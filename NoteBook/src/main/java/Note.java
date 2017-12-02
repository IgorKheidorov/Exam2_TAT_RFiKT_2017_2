/**
 * This class is note. NoteBook consists of notes
 */
public class Note {
  private int date;
  private String entry;

  public void setDate(int dateOfTheCurrentNote) {
    this.date = dateOfTheCurrentNote;
  }

  public void setEntry(String data) {

    this.entry = data;
  }

  public int getDate() {

    return date;
  }

  public String getEntry() {

    return entry;
  }

  /**
   * This function is override of a hashCode
   * @return overriden hashCode
   */
  @Override
  public int hashCode() {
    final int prime = 31;
    int result = 1;
    result = prime * result + date;
    result = prime * result + ((entry == null) ? 0 : entry.hashCode());
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
    Note other = (Note) obj;
    if (date != other.date)
      return false;
    if (entry == null) {
      if (other.entry != null) {
        return false;
      } else if (!this.entry.equals(other.entry)) {
        return false;
      }
    }
    return true;
  }

  /**
   * This is override of toString method
   * @return Returns the string representation of Note
   */
  @Override
  public String toString() {
    return String.format("Date " + date +"\n" + "Note :" + entry);
  }
}
