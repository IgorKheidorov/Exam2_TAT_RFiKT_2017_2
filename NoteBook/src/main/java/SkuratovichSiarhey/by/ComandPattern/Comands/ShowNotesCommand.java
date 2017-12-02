package SkuratovichSiarhey.by.ComandPattern.Comands;

import SkuratovichSiarhey.by.ComandPattern.Command;
import SkuratovichSiarhey.by.NoteBook;

/**
 * Created by siarhey on 02.12.17.
 */
public class ShowNotesCommand implements Command {
  private NoteBook noteBook;

  public ShowNotesCommand(NoteBook noteBook) {
    this.noteBook = noteBook;
  }

  public void execute() {
/*
    for (int i = 0; i < notes.size(); i++) {

      System.out.println(i + 1).append(")\n");
      fullList.append(notes.get(i).getHead()).append("\n");
      fullList.append(notes.get(i).getContent()).append("\n");
      fullList.append(notes.get(i).getDate());
      if(i != notes.size() - 1) {
        fullList.append("\n");
      }
    }*/
    //fullList.toString();
  }
}
