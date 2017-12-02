/**
 * Loads the NoteBook from the file.
 */
public class LoadNoteBookFromFile implements ICommand {
  private NoteBookProvider receiver;

  /**
   * Constructor for this class.
   *
   * @param receiver used by command pattern
   */
  public LoadNoteBookFromFile(NoteBookProvider receiver) {
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
