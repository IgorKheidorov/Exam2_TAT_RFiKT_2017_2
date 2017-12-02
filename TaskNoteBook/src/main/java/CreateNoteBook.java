/**
 * Creates new NoteBook.
 */
public class CreateNoteBook implements ICommand {
  private Receiver receiver;

  /**
   * Constructor for this class.
   *
   * @param receiver used by command pattern
   */
  public CreateNoteBook(Receiver receiver) {
    this.receiver = receiver;
  }

  /**
   * Creates new NoteBook.
   */
  @Override
  public void execute() {
    receiver.createNoteBook();
  }
}
