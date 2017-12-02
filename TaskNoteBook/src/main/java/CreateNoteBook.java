/**
 * Creates new NoteBook.
 */
public class CreateNoteBook implements ICommand {
  private NoteBookProvider receiver;

  /**
   * Constructor for this class.
   *
   * @param receiver used by command pattern
   */
  public CreateNoteBook(NoteBookProvider receiver) {
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
