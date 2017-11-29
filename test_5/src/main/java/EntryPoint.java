/**
 * This is entry point class.
 */
public class EntryPoint {
  public static void main(String[] args) {
    Car firstCar = new Car("Mercedes", "red", 50000);
    Car secondCar = new Car("Mercedes", "black", 51000);
    Car thirdCar = new Car("Mercedes", "white", 51000);
    Car fourthCar = new Car("Toyota", "red", 30000);
    Car fivesCar = new Car("Toyota", "black", 35000);
    Car sixCar = new Car("Toyota", "green", 25000);
    LinkedList list = new LinkedList();
    list.add(firstCar);
    list.add(secondCar);
    list.add(thirdCar);
    SinglyLinkedList singlyLinkedList = new SinglyLinkedList();
    singlyLinkedList.add(fourthCar);
    singlyLinkedList.add(fivesCar);
    singlyLinkedList.add(sixCar);
  }
}
