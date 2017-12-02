/**
 * Writes the NoteBook to the file.
 */
public class WriteNoteBookToFile implements ICommand {
  private Receiver receiver;

  /**
   * Constructor for this class.
   *
   * @param receiver used by command pattern
   */
  public WriteNoteBookToFile(Receiver receiver) {
    this.receiver = receiver;
  }

  /**
   * Writes the NoteBook to the file.
   */
  @Override
  public void execute() {
    receiver.writeNoteBookToFile();
  }
}
