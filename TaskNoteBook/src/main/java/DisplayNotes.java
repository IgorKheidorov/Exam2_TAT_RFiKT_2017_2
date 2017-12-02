/**
 * Displays notes.
 */
public class DisplayNotes implements ICommand {
  private NoteBookProvider receiver;

  /**
   * Constructor for this class.
   *
   * @param receiver used by command pattern
   */
  public DisplayNotes(NoteBookProvider receiver) {
    this.receiver = receiver;
  }

  /**
   * Displays notes.
   */
  @Override
  public void execute() {
    receiver.displayNotes();
  }
}
