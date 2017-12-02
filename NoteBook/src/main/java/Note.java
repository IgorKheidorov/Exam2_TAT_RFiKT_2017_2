import java.util.Date;

public class Note {
  private String head;
  private String content;
  private String date;

  public Note() {
    Date date = new Date();
    this.date = date.toString();
  }

  public void setContent(String content) {
    this.content = content;
  }

  public void setHead(String head) {
    this.head = head;
  }

  public String getContent() {
    return content;
  }

  public String getHead() {
    return head;
  }
}
