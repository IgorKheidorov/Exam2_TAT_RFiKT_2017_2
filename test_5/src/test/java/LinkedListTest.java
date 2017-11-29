import static org.testng.Assert.*;

/**
 * Test for double Linked List.
 */
public class LinkedListTest {
  @org.testng.annotations.Test
  public void testHasNext() throws Exception {
    Car firstCar = new Car("Mercedes", "red", 50000);
    LinkedList list = new LinkedList();
    list.add(firstCar);
    list.add(firstCar);
    list.previous();
    assertTrue(list.hasNext());
  }

  @org.testng.annotations.Test
  public void testHasNoNext() throws Exception {
    Car firstCar = new Car("Mercedes", "red", 50000);
    LinkedList list = new LinkedList();
    list.add(firstCar);
    assertFalse(list.hasNext());
  }

  @org.testng.annotations.Test
  public void testNext() throws Exception {
    LinkedList list = new LinkedList();
    Car firstCar = new Car("Mercedes", "red", 50000);
    Car secondCar = new Car("Mercedes", "black", 51000);
    Car thirdCar = new Car("Mercedes", "white", 51000);
    list.add(firstCar);
    list.add(secondCar);
    list.add(thirdCar);
    list.previous();
    assertTrue(list.next().equals(thirdCar));
  }

  @org.testng.annotations.Test
  public void testHasPrevious() throws Exception {
    Car firstCar = new Car("Mercedes", "red", 50000);
    LinkedList list = new LinkedList();
    list.add(firstCar);
    list.add(firstCar);
    assertTrue(list.hasPrevious());
  }

  @org.testng.annotations.Test
  public void testHasNoPrevious() throws Exception {
    Car firstCar = new Car("Mercedes", "red", 50000);
    LinkedList list = new LinkedList();
    list.add(firstCar);
    list.add(firstCar);
    list.previous();
    assertFalse(list.hasPrevious());
  }
  @org.testng.annotations.Test
  public void testPrevious() throws Exception {
    LinkedList list = new LinkedList();
    Car firstCar = new Car("Mercedes", "red", 50000);
    Car secondCar = new Car("Mercedes", "black", 51000);
    Car thirdCar = new Car("Mercedes", "white", 51000);
    list.add(firstCar);
    list.add(secondCar);
    list.add(thirdCar);
    assertTrue(list.previous().equals(secondCar));
  }

  @org.testng.annotations.Test
  public void testSet() throws Exception {
    LinkedList list = new LinkedList();
    Car firstCar = new Car("Mercedes", "red", 50000);
    Car secondCar = new Car("Mercedes", "black", 51000);
    Car seconCarNew = new Car("Mercedes", "white", 51000);
    list.add(firstCar);
    list.add(secondCar);
    list.set(seconCarNew);
    list.add(firstCar);
    assertTrue(list.previous().equals(seconCarNew));
  }

  @org.testng.annotations.Test
  public void testSize() throws Exception {
    LinkedList list = new LinkedList();
    Car firstCar = new Car("Mercedes", "red", 50000);
    list.add(firstCar);
    list.add(firstCar);
    assertTrue(list.size() == 2);
  }

  @org.testng.annotations.Test
  public void testAdd() throws Exception {
    LinkedList list = new LinkedList();
    Car firstCar = new Car("Mercedes", "red", 50000);
    Car secondCar = new Car("Mercedes", "black", 51000);
    Car thirdCar = new Car("Mercedes", "white", 51000);
    list.add(firstCar);
    list.add(secondCar);
    list.add(thirdCar);
    assertTrue(list.previous().equals(secondCar));
  }

  @org.testng.annotations.Test
  public void testRemove() throws Exception {
    LinkedList list = new LinkedList();
    Car firstCar = new Car("Mercedes", "red", 50000);
    Car secondCar = new Car("Mercedes", "black", 51000);
    Car thirdCar = new Car("Mercedes", "white", 51000);
    list.add(firstCar);
    list.add(secondCar);
    list.add(thirdCar);
    list.remove();
    assertTrue(list.size() == 2);
  }
}