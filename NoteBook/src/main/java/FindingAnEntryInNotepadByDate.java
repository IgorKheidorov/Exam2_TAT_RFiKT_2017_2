/**
 * This class find notes in Notepad by content.
 */
public class FindingAnEntryInNotepadByDate implements Command {
  NoteBook book;
  int date;

  /**
   * This function is constructor
   * @param noteBook is transmitted notebook
   * @param dateOfNote is transmitted date
   */
  public FindingAnEntryInNotepadByDate(NoteBook noteBook,int dateOfNote) {
    this.book = noteBook;
    this.date = dateOfNote;
  }

  /**
   * This function find if there is an equal date in notebook.
   * @throws Exception if there is no such data in notebook.
   */
  public void execute() throws Exception {
    for (int i = 0; i < book.getNote().size(); i++) {
      if(!(date == book.getNote().get(i).getDate())) {
        throw new Exception("There is no such note");
      }
      System.out.println("Note is found " + book.getNote().get(i).toString());
    }
  }
}
