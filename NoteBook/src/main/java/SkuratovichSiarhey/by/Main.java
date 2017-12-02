package SkuratovichSiarhey.by;

/**
 * Created by siarhey on 02.12.17.
 */
public class Main {
  public static void main(String[] args) {
    NoteBook noteBook = new NoteBook("My SkuratovichSiarhey.by.NoteBook");
    Note note1 = new Note("first note", "something good");
    noteBook.addNote(note1);
    Note note2 = new Note("second note", "something bad");
    noteBook.addNote(note2);
    Note note3 = new Note("third note", "something so-so");
    noteBook.addNote(note3);
    NoteBookConsoleView noteBookConsoleView = new NoteBookConsoleView(noteBook);
    noteBookConsoleView.print("full");
  }
}
