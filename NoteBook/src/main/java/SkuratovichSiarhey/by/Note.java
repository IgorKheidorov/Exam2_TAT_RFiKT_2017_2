package SkuratovichSiarhey.by;

import java.util.Date;

public class Note {
  private String head;
  private String content;
  private String date;

  public Note(String head, String content) {
    this.head = head;
    this.content = content;
    Date date = new Date();
    this.date = date.toString();
  }

  public void setContent(String content) {
    this.content = content;
  }

  public void setHead(String head) {
    this.head = head;
  }

  public void setDate(String date) {
    this.date = date;
  }

  public String getContent() {
    return content;
  }

  public String getHead() {
    return head;
  }

  public String getDate() {
    return date;
  }
}
