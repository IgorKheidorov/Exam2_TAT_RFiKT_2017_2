/**
 * This class find notes in Notepad by content.
 */
public class FindingAnEntryInNotepadByContent implements Command{
  NoteBook book;
  String contentOfNote;

  /**
   * This is constructor.
   * @param noteBook transmitted notebook
   * @param content transmitted content.
   */
  public FindingAnEntryInNotepadByContent(NoteBook noteBook,String content) {
    this.book = noteBook;
    this.contentOfNote = content;
  }

  /**
   * This function find notes in Notepad by content.
   * @throws Exception if there is no such content print exception message.
   */
  public void execute() throws Exception {
    for (int i = 0; i < book.getNote().size(); i++) {
    if(!contentOfNote.equals(book.getNote().get(i))) {
      throw new Exception("There is no such note");
    }
     System.out.println("Note is found " + book.getNote().get(i).toString());
    }
  }
}
