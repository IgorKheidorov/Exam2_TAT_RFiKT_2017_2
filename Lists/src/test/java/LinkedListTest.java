import org.junit.Test;

import static org.junit.Assert.assertEquals;

public class LinkedListTest {
  @Test
  public void getSizeAfterAddOneElement() throws Exception {
    LinkedList linkedList = new LinkedList();
    linkedList.add(new Car(346, "ththth", "dshfg"));
    assertEquals(linkedList.getSize(), 1);
  }
  @Test
  public void getSizeEptyLinkedList() {
    LinkedList linkedList = new LinkedList();
    assertEquals(linkedList.getSize(), 0);
  }
  @Test
  public void getSizeAfterAddInLinkedListConsistOneElement() {
    LinkedList linkedList = new LinkedList();
    linkedList.add(new Car(56, "sjfh", "jdksf"));
    linkedList.add(new Car(87, "jhf", "dfs"));
    assertEquals(linkedList.getSize(), 2);
  }
  @Test
  public void getSizeAfterAddInLinkedListConsistsSomeElements() {
    LinkedList linkedList = new LinkedList();
    linkedList.add(new Car(56, "sjfh", "jdksf"));
    linkedList.add(new Car(87, "jhf", "dfs"));
    linkedList.add(new Car(67,"djfh", "sdfg"));
    assertEquals(linkedList.getSize(), 3);
  }
  @Test
  public void addOneElementInEmptyArrayList() {
    Car car = new Car(78, "dfh", "jdhsf");
    LinkedList linkedList = new LinkedList();
    linkedList.add(car);
    assertEquals(linkedList.getHead().getData(), car);
  }
  @Test
  public void addOneElementInLinkedListConsistsOneElement() {
    Car car = new Car(78, "dfh", "jdhsf");
    LinkedList linkedList = new LinkedList();
    linkedList.add(new Car(89, "dhjgf", "skjhf"));
    linkedList.add(car);
    assertEquals(linkedList.getTail().getData(), car);
  }
  @Test
  public void addOneElementInLinkedListConsistsSomeElements() {
    Car car = new Car(78, "dfh", "jdhsf");
    LinkedList linkedList = new LinkedList();
    linkedList.add(new Car(90, "skjdfh", "sjdhf"));
    linkedList.add(new Car(67,"kjsdf", "mzsjdfh"));
    linkedList.add(car);
    assertEquals(linkedList.getTail().getData(), car);
  }
  @Test
  public void remove() throws Exception {
    LinkedList linkedList = new LinkedList();
    linkedList.add(new Car(78, "tyt", "tyt"));
    linkedList.add(new Car(78, "dfh", "jdhsf"));
    linkedList.remove(new Car(78, "tyt", "tyt"));
    assertEquals(linkedList.getSize(), 1);
  }
}