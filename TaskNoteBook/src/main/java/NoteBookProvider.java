import java.io.FileWriter;
import java.io.*;

/**
 * Receiver.
 */
public class NoteBookProvider {
  private NoteBook noteBook;

  /**
   * Creates new NoteBook.
   *
   * @return created NoteBook
   */
  public NoteBook createNoteBook() {
    noteBook = new NoteBook();
    return noteBook;
  }


  /**
   * Adds new note.
   *
   * @param note added note
   */
  public void addNote(Note note) {
    noteBook.getListOfNotes().add(note);
  }

  /**
   * Finds the note by it content.
   *
   * @param content sought content
   * @return note if found, null if not
   */
  public Note findNoteByContext(String content) {
    Note findNote = null;
    for (Note note : noteBook.getListOfNotes()) {
      if (note.getContent().equals(content)) {
        findNote = note;
        break;
      }
    }
    return findNote;
  }

  /**
   * Finds the note by it date of creation.
   *
   * @param date sought date
   * @return note if found, null if not
   */
  public Note findNoteByCreatingData(String date) {
    Note findNote = null;
    for (Note note : noteBook.getListOfNotes()) {
      if (note.getDate().equals(date)) {
        findNote = note;
        break;
      }
    }
    return findNote;
  }

  /**
   * Displays notes.
   */
  public void displayNotes() {
    new NoteBookConsoleView().print(noteBook);
  }

  /**
   * Writes the NoteBook to the file.
   */
  public void writeNoteBookToFile() {
    try {
      FileWriter writer = new FileWriter("Notebook.txt", false);
      writer.write(noteBook.toString());
      writer.flush();
    } catch (IOException e) {
      System.out.println(e.getMessage());
    }
  }

  /**
   * Loads the NoteBook from the file.
   */
  public void loadNoteBookFromFile() {
    //to do
  }
}
