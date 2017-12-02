/**
 * Finds the note by it content.
 */
public class FindNoteByContent implements ICommand {
  private NoteBookProvider receiver;
  private String content;

  /**
   * Constructor for this class.
   *
   * @param receiver used by command pattern
   * @param content  sought content
   */
  public FindNoteByContent(NoteBookProvider receiver, String content) {
    this.receiver = receiver;
    this.content = content;
  }

  /**
   * Finds the note by it content.
   */
  @Override
  public void execute() {
    receiver.findNoteByContext(content);
  }
}
