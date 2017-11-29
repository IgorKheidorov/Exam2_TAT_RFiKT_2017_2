/**
 * This class stores information about single car.
 */
public class Car {
  private String model;
  private String colour;
  private int price;

  /**
   * This function is constructor. It transfers information to Car class and assigns values
   *
   * @param carModel  transferred model value
   * @param carColour transferred colour value
   * @param carPrice  transferred price value
   */
  public Car(String carModel, String carColour, int carPrice) {
    this.model = carModel;
    this.colour = carColour;
    this.price = carPrice;
  }
}
