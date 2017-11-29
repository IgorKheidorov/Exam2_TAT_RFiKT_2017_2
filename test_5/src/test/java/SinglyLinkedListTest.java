import org.testng.annotations.Test;

import static org.testng.Assert.*;

/**
 * This class is a test for Single Linked List
 */
public class SinglyLinkedListTest {
  @Test
  public void testAdd() throws Exception {
    SinglyLinkedList list = new SinglyLinkedList();
    Car firstCar = new Car("Mercedes", "red", 50000);
    Car secondCar = new Car("Mercedes", "black", 51000);
    Car thirdCar = new Car("Mercedes", "white", 51000);
    list.add(firstCar);
    list.add(secondCar);
    list.add(thirdCar);
    assertTrue(list.getSize() == 3);
  }

  @Test
  public void testRemove() throws Exception {
    SinglyLinkedList list = new SinglyLinkedList();
    Car firstCar = new Car("Mercedes", "red", 50000);
    Car secondCar = new Car("Mercedes", "black", 51000);
    Car thirdCar = new Car("Mercedes", "white", 51000);
    list.add(firstCar);
    list.add(secondCar);
    list.add(thirdCar);
    list.remove(thirdCar);
    assertTrue(list.getSize() == 2);
  }

  @Test
  public void testGetSize() throws Exception {
    SinglyLinkedList list = new SinglyLinkedList();
    Car firstCar = new Car("Mercedes", "red", 50000);
    Car secondCar = new Car("Mercedes", "black", 51000);
    Car thirdCar = new Car("Mercedes", "white", 51000);
    list.add(firstCar);
    list.add(secondCar);
    list.add(thirdCar);
    list.remove(thirdCar);
    assertTrue(list.getSize() == 2);
  }

}