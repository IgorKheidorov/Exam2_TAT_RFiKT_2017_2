/**
 * Finds the note by it date of creation.
 */
public class FindNoteByDate implements ICommand {
  private Receiver receiver;
  private String date;

  /**
   * Constructor for this class.
   *
   * @param receiver used by command pattern
   * @param date     sought date
   */
  public FindNoteByDate(Receiver receiver, String date) {
    this.receiver = receiver;
    this.date = date;
  }

  /**
   * Finds the note by it date of creation.
   */
  @Override
  public void execute() {
    receiver.findNoteByCreatingData(date);
  }
}
