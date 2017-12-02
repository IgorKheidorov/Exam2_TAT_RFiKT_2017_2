/**
 * This class is invoker class.
 */
public class Invoker {
  private Command create;
  private Command add;
  private Command findContent;
  private Command findDate;
  private Command show;
  private Command write;
  private Command read;

  /**
   * This is constructor.
   * @param createNote transmitted command create
   * @param addNote transmitted command add
   * @param findContentNote transmitted command findByContent
   * @param findDateNote transmitted command findByDate
   * @param showNote transmitted command show
   * @param writeNote transmitted command write
   * @param readNote transmitted command read
   */
  public Invoker(Command createNote, Command addNote,Command findContentNote, Command findDateNote,
                 Command showNote, Command writeNote, Command readNote) {
    this.create = createNote;
    this.add = addNote;
    this.findContent =findContentNote;
    this.findDate = findDateNote;
    this.show = showNote;
    this.write = writeNote;
    this.read = readNote;
  }

    public void setCreate() throws Exception {
      this.create.execute();
    }
  public void setAdd() throws Exception {
    this.add.execute();
  }
  public void setFindContent() throws Exception {
    this.findContent.execute();
  }

  public void setFindDate() throws Exception {
    this.findDate.execute();
  }

  public void setShow() throws Exception {
    this.show.execute();
  }
  public void setWrite() throws Exception {
    this.write.execute();
  }
  public void setRead() throws Exception {
    this.read.execute();
  }
}
