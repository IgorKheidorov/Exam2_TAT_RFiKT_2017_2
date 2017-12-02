/**
 * Adds new note.
 */
public class AddNote implements ICommand {
  private Receiver receiver;
  private Note note;

  /**
   * Constructor for this class.
   *
   * @param receiver used by command pattern
   * @param note     added note
   */
  public AddNote(Receiver receiver, Note note) {
    this.receiver = receiver;
    this.note = note;
  }

  /**
   * Adds new note.
   */
  @Override
  public void execute() {
    receiver.addNote(note);
  }
}
