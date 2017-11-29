package DoublyLinked;

import SinglyLinked.SinglyLinkedList;
import org.junit.Test;

import java.util.Iterator;

import static org.junit.Assert.*;

/**
 * Created by siarhey on 30.11.17.
 */
public class DoublyLinkedListTest {
  @Test
  public void addTestQuantity() throws Exception {
    DoublyLinkedList doublyLinkedList = new DoublyLinkedList();
    doublyLinkedList.add(1);
    doublyLinkedList.add(2);
    doublyLinkedList.add(3);
    assertEquals(3, doublyLinkedList.size());
  }

  @Test
  public void testIteratorHasNext() throws Exception {
    DoublyLinkedList doublyLinkedList = new DoublyLinkedList();
    doublyLinkedList.add(1);
    doublyLinkedList.add(2);
    doublyLinkedList.add(3);
    doublyLinkedList.add(3);
    Iterator iterator = doublyLinkedList.iterator();
    assertEquals(true, iterator.hasNext());
  }

  @Test
  public void testIteratorNextForSecond() throws Exception {
    DoublyLinkedList doublyLinkedList = new DoublyLinkedList();
    doublyLinkedList.add(1);
    doublyLinkedList.add(2);
    doublyLinkedList.add(3);
    doublyLinkedList.add(3);
    Iterator iterator = doublyLinkedList.iterator();
    iterator.next();
    assertEquals(2, iterator.next());
  }

  @Test
  public void testIteratorNextForFirst() throws Exception {
    DoublyLinkedList doublyLinkedList = new DoublyLinkedList();
    doublyLinkedList.add(1);
    doublyLinkedList.add(2);
    doublyLinkedList.add(3);
    doublyLinkedList.add(3);
    Iterator iterator = doublyLinkedList.iterator();
    assertEquals(1, iterator.next());
  }

  @Test
  public void testPoll() throws Exception {
    DoublyLinkedList doublyLinkedList = new DoublyLinkedList();
    doublyLinkedList.add(1);
    doublyLinkedList.add(2);
    doublyLinkedList.add(3);
    doublyLinkedList.poll();
    assertEquals(2, doublyLinkedList.size());
  }

}