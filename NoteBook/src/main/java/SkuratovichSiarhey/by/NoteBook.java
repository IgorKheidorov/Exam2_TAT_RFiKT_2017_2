package SkuratovichSiarhey.by;

import SkuratovichSiarhey.by.Note;

import java.util.ArrayList;

/**
 * Created by siarhey on 02.12.17.
 */
public class NoteBook {
  private String name;
  private ArrayList<Note> notes;


  /**
   * Creates New SkuratovichSiarhey.by.NoteBook.
   */
  public NoteBook(String name) {
    this.name = name;
    this.notes = new ArrayList<Note>();
  }

  public String getName() {
    return name;
  }

  /**
   * Adds new note to SkuratovichSiarhey.by.NoteBook.
   */
  public void addNote(Note note) {
    notes.add(note);
  }

  public ArrayList<Note> getNotes() {
    return notes;
  }

  /**
   * Finds a note by it's content.
   * Returns string-info including: position, head name and date of creation.
   * @param content content by which we are looking for notes in the SkuratovichSiarhey.by.NoteBook.
   */
  public String findByContent(String content) {
    StringBuffer info = new StringBuffer();
    int counter = 0;
    for (int i = 0; i < notes.size(); i++) {
      if (notes.get(i).getContent().equals(content)) {
        counter++;
        info.append("\n").append(i + 1).append(")\n");
        info.append(notes.get(i).getHead()).append("\n");
        info.append(notes.get(i).getDate());
      }
    }
    info.insert(0, "total found: " + counter);
    return info.toString();
  }

  /**
   * Finds a note by it's creation date.
   * Returns string-info including: position, head name and content.
   * @param date date by which we are looking for notes in the SkuratovichSiarhey.by.NoteBook.
   */
  public String findByDate(String date) {
    StringBuffer info = new StringBuffer();
    for (int i = 0; i < notes.size(); i++) {
      if (notes.get(i).getContent().equals(date)) {
        info.append(i + 1).append(")\n");
        info.append(notes.get(i).getHead()).append("\n");
        info.append(notes.get(i).getContent());
      }
    }
    return info.toString();
  }

  /**
   * Returns full list of notes.
   * @return
   */
  public String getFullList() {
    StringBuffer fullList = new StringBuffer();
    for (int i = 0; i < notes.size(); i++) {
        fullList.append(i + 1).append(")\n");
        fullList.append(notes.get(i).getHead()).append("\n");
        fullList.append(notes.get(i).getContent()).append("\n");
        fullList.append(notes.get(i).getDate());
        if(i != notes.size() - 1) {
          fullList.append("\n");
        }
    }
    return fullList.toString();
  }

  /**
   * Writes SkuratovichSiarhey.by.NoteBook object to File
   */
  public void writeToFile() {

  }

  /**
   * Reads File to SkuratovichSiarhey.by.NoteBook object.
   */
  public void download() {

  }


}
