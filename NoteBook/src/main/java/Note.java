import java.util.Date;

/**
 * This class is for note, each not include data and value.
 */
public class Note {
  private String value;
  private Date date;

  public Note(String value, Date date) {
    this.value = value;
    this.date = date;
  }
  public String getValue() {
    return this.value;
  }
  public Date getDate() {
    return this.date;
  }
  public void setValue(String value) {
    this.value = value;
  }
  public void setDate(Date date) {
    this.date = date;
  }

  /**
   * This method is override hashCode method for note class.
   * @return - hashCode of note.
   */
  @Override
  public int hashCode() {
    final int prime = 31;
    int result = 1;
    result = prime * result + value.hashCode();
    result = prime * result + date.hashCode();
    return result;
  }

  /**
   * This method override equals method for note class.
   * @param obj - note, that is compared.
   * @return - true, if notes are equals, false - in another case.
   */
  @Override
  public boolean equals(Object obj) {
    if (obj == this) return true;
    if (!(obj instanceof Note)) {
      return false;
    }
    Note note = (Note) obj;
    return note.value.equals(value) &&
        note.date.equals(date);
  }

  /**
   * This method override toString method for note class.
   * @return - one note in string presentation.
   */
  @Override
  public String toString() {
    return " " + this.value.toString() + " " + this.date;
  }
}
