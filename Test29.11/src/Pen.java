/**
 * This class creates a pen.
 */
public class Pen {
  private int price;
  private String color;

  /**
   * This constructor initializes the fields of the pen.
   *
   * @param price the price of the pen
   * @param color the color of the pen
   */
  public Pen(int price, String color) {
    this.price = price;
    this.color = color;
  }

  public int getPrice() {
    return price;
  }

  public void setPrice(int price) {
    this.price = price;
  }

  public String getColor() {
    return color;
  }

  public void setColor(String color) {
    this.color = color;
  }
}
