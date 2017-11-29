public class Main {

  public static void main(String[] args) {
    try {
      SinglyLinkedList simplyLinkedList = new SinglyLinkedList();
      /*Pen pen1 = new Pen(15, "green");
      Pen pen2 = new Pen(10, "red");
      Pen pen3 = new Pen(155, "black");
      Pen pen4 = new Pen(1, "yellow");*/
      simplyLinkedList.addBack(new Pen(15, "green"));
      simplyLinkedList.addBack(new Pen(10, "red"));
      simplyLinkedList.addBack(new Pen(155, "black"));
      simplyLinkedList.addBack(new Pen(1, "yellow"));
      simplyLinkedList.assignFirstToCurrent();
      simplyLinkedList.getNextElement();
      simplyLinkedList.getNextElement();
      simplyLinkedList.getNextElement();
      System.out.println("Size: " + simplyLinkedList.size());
    } catch (Exception e) {
      System.out.println("Exception" + e.getMessage());
    }
  }
}
