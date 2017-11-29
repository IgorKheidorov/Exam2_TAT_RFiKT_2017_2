import SinglyLinked.SinglyLinkedList;

import java.util.Iterator;
import java.util.LinkedList;

/**
 * Created by siarhey on 29.11.17.
 */
public class Main {
  public static void main(String[] args) {
    SinglyLinkedList<Integer> singlyLinkedList = new SinglyLinkedList<>();
    singlyLinkedList.add(1);
    singlyLinkedList.add(2);
    singlyLinkedList.add(3);
    singlyLinkedList.add(4);
    singlyLinkedList.add(5);
    Iterator iterator = singlyLinkedList.iterator();
    while (iterator.hasNext()) {
      System.out.println(iterator.next());
    }




  }
}
