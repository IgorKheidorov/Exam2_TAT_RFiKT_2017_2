package SinglyLinked;

import org.junit.Test;

import java.util.Iterator;

import static org.junit.Assert.*;

/**
 * Created by siarhey on 30.11.17.
 */
public class SinglyLinkedListTest {

  @Test
  public void addTestQuantity() throws Exception {
    SinglyLinkedList<Integer> singlyLinkedList = new SinglyLinkedList<>();
    singlyLinkedList.add(1);
    singlyLinkedList.add(2);
    singlyLinkedList.add(3);
    assertEquals(3, singlyLinkedList.size());
  }

  @Test
  public void testIteratorHasNext() throws Exception {
    SinglyLinkedList<Integer> singlyLinkedList = new SinglyLinkedList<>();
    singlyLinkedList.add(1);
    singlyLinkedList.add(2);
    singlyLinkedList.add(3);
    Iterator iterator = singlyLinkedList.iterator();
    assertEquals(true, iterator.hasNext());
  }

  @Test
  public void testIteratorNextForSecond() throws Exception {
    SinglyLinkedList<Integer> singlyLinkedList = new SinglyLinkedList<>();
    singlyLinkedList.add(1);
    singlyLinkedList.add(2);
    singlyLinkedList.add(3);
    Iterator iterator = singlyLinkedList.iterator();
    iterator.next();
    assertEquals(2, iterator.next());
  }

  @Test
  public void testIteratorNextForFirst() throws Exception {
    SinglyLinkedList<Integer> singlyLinkedList = new SinglyLinkedList<>();
    singlyLinkedList.add(1);
    singlyLinkedList.add(2);
    singlyLinkedList.add(3);
    Iterator iterator = singlyLinkedList.iterator();
    assertEquals(1, iterator.next());
  }

  @Test
  public void testPoll() throws Exception {
    SinglyLinkedList<Integer> singlyLinkedList = new SinglyLinkedList<>();
    singlyLinkedList.add(1);
    singlyLinkedList.add(2);
    singlyLinkedList.add(3);
    singlyLinkedList.poll();
    assertEquals(2, singlyLinkedList.size());
  }



}