namespace Test_3.Task_4
{
  public class Node
  {
    private int value;
    private Node next;

    public Node(int value)
    {
      this.value = value;
    }

    public Node()
    {
      value = 0;
    }

    public int Value { get { return value; } set { this.value = value; } }
    public Node Next { get { return next; } set { next = value; } }
  }
}
