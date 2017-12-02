/**
 * Loads the NoteBook from the file.
 */
public class LoadNoteBookFromFile implements ICommand {
  private Receiver receiver;

  /**
   * Constructor for this class.
   *
   * @param receiver used by command pattern
   */
  public LoadNoteBookFromFile(Receiver receiver) {
    this.receiver = receiver;
  }

  /**
   * Loads the NoteBook from the file.
   */
  @Override
  public void execute() {
    receiver.loadNoteBookFromFile();
  }
}
